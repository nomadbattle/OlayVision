using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ThridLibray;

namespace DeviceNomad.DahuaCam
{
    public class DahuaCamera : ICamera
    {
        private IDevice _mDev;
        private Mutex _mutex = new Mutex();        /* 锁，保证多线程安全 */
        private List<IGrabbedRawData> _frameList = new List<IGrabbedRawData>();        /* 图像缓存列表 */
        private const int DefaultInterval = 40;
        private Stopwatch _stopWatch = new Stopwatch();    /* 时间统计器 */
        private bool _bShowLoop = true;            /* 线程控制变量 */
        private Thread renderThread = null;         /* 显示线程  */

        public string CameraKey { get; set; }
        public DeviceType CameraType { get; set; } = DeviceType.Dahua;
        public bool IsOpen { get; set; } = false;

        public event Camera.OnCameraOpenedHandler OnCameraOpened;
        public event Camera.OnCameraClosedHandler OnCameraClosed;
        public event Camera.OnImageGrabbedHandler OnImageGrabbed;
        public event Camera.OnDeviceErrorHandler OnDeviceError;

        public List<string> ListCameraKeys()
        {
            List<IDeviceInfo> devices = Enumerator.EnumerateDevices();

            List<string> devKeys = devices.Select(di => di.Key).ToList();

            return devKeys;
        }

        public void InitCamera()
        {
            if (_mDev != null)
            {
                Dispose();
            }
            _mDev = Enumerator.GetDeviceByKey(CameraKey);
            _mDev.CameraOpened += OnCameraOpen;
            _mDev.ConnectionLost += OnConnectLoss;
            _mDev.CameraClosed += OnCameraClose;

            if (null == renderThread)
            {
                renderThread = new Thread(new ThreadStart(ShowThread));
                renderThread.Start();
            }
            _stopWatch.Start();
        }

        public void Open()
        {
            /* 打开设备 */
            if (!_mDev.Open())
            {
                OnDeviceError?.Invoke(DeviceError.OpenError);
            }

        }

        public void Close()
        {
            try
            {
                if (_mDev == null)
                {
                    throw new InvalidOperationException("Device is invalid");
                }

                _mDev.StreamGrabber.ImageGrabbed -= OnImageGrabbedN;         /* 反注册回调 */
                _mDev.ShutdownGrab();                                       /* 停止码流 */
                _mDev.Close();                                              /* 关闭相机 */
            }
            catch (Exception exception)
            {
                Catcher.Show(exception);
            }
        }

        public void Snap()
        {
            /* 设置缓存个数为8（默认值为16） */
            _mDev.StreamGrabber.SetBufferCount(8);

            /* 注册码流回调事件 */
            _mDev.StreamGrabber.ImageGrabbed += OnImageGrabbedN;

            /* 开启码流 */
            if (!_mDev.GrabUsingGrabLoopThread())
            {
                OnDeviceError?.Invoke(DeviceError.SnapError);
                return;
            }
        }

        public void RunContie()
        {
            throw new NotImplementedException();
        }

        public void StopRun()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_mDev != null)
            {
                _mDev.ShutdownGrab();
                _mDev.Dispose();
                _mDev = null;
            }
        }

        /* 相机打开回调 */
        private void OnCameraOpen(object sender, EventArgs e)
        {
            OnCameraOpened?.Invoke();
        }

        /* 相机关闭回调 */
        private void OnCameraClose(object sender, EventArgs e)
        {
            OnCameraClosed?.Invoke();
        }

        /* 相机丢失回调 */
        private void OnConnectLoss(object sender, EventArgs e)
        {
            Dispose();
            OnDeviceError?.Invoke(DeviceError.Disconnected);
        }


        /* 码流数据回调 */
        private void OnImageGrabbedN(Object sender, GrabbedEventArgs e)
        {
            _mutex.WaitOne();
            _frameList.Add(e.GrabResult.Clone());
            _mutex.ReleaseMutex();
        }

        private void ShowThread()
        {
            while (_bShowLoop)
            {
                if (_frameList.Count == 0)
                {
                    Thread.Sleep(10);
                    continue;
                }

                /* 图像队列取最新帧 */
                _mutex.WaitOne();
                IGrabbedRawData frame = _frameList.ElementAt(_frameList.Count - 1);
                _frameList.Clear();
                _mutex.ReleaseMutex();

                /* 主动调用回收垃圾 */
                GC.Collect();

                /* 控制显示最高帧率为25FPS */
                if (false == IsTimeToDisplay())
                {
                    continue;
                }

                try
                {
                    /* 图像转码成bitmap图像 */
                    var bitmap = frame.ToBitmap(false);
                    OnImageGrabbed?.Invoke(bitmap);
                    bitmap.Dispose();
                }
                catch (Exception exception)
                {
                    Catcher.Show(exception);
                }
            }
        }

        /* 判断是否应该做显示操作 */
        private bool IsTimeToDisplay()
        {
            _stopWatch.Stop();
            long lDisplayInterval = _stopWatch.ElapsedMilliseconds;
            if (lDisplayInterval <= DefaultInterval)
            {
                _stopWatch.Start();
                return false;
            }
            else
            {
                _stopWatch.Reset();
                _stopWatch.Start();
                return true;
            }
        }
    }
}
