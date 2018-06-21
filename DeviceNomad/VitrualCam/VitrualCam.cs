using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceNomad.VitrualCam
{
    public class VitrualCam : ICamera
    {
        public string CameraKey { get; set; }
        public DeviceType CameraType { get; set; }
        public bool IsOpen { get; set; }
        public CameraRunMode RunMode { get; set; }
        public event Camera.OnCameraOpenedHandler OnCameraOpened;
        public event Camera.OnCameraClosedHandler OnCameraClosed;
        public event Camera.OnImageGrabbedHandler OnImageGrabbed;
        public event Camera.OnDeviceErrorHandler OnDeviceError;
        public List<string> ListCameraKeys()
        {
            throw new NotImplementedException();
        }

        public void InitCamera()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Snap()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
