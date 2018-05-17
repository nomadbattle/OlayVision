using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThridLibray;

namespace DeviceNomad.DahuaCam
{
    public class DahuaCamera : ICamera
    {
        public string CameraKey { get; set; }

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
    }
}
