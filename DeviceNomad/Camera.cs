using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DeviceNomad
{
    public class Camera : ICamera
    {
        public string CameraKey { get; set; }
        public DeviceType CameraType { get; set; }
        public bool IsOpen { get; set; }
        
        public delegate void OnCameraOpenedHandler();
        public delegate void OnCameraClosedHandler();
        public delegate void OnImageGrabbedHandler(Bitmap bitmap);
        public delegate void OnDeviceErrorHandler(DeviceError errorType);

        public event OnCameraOpenedHandler OnCameraOpened;
        public event OnCameraClosedHandler OnCameraClosed;
        public event OnImageGrabbedHandler OnImageGrabbed;
        public event OnDeviceErrorHandler OnDeviceError;

        public List<string> ListCameraKeys()
        {
            return null;
        }

        public void InitCamera()
        {
        }

        public void Open()
        {
            
        }

        public void Close()
        {
        }

        public void Snap()
        {
        }

        public void RunContie()
        { }

        public void StopRun()
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
