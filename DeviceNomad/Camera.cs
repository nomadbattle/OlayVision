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

        public delegate EventHandler OnImageGrabbedHandler(Bitmap bitmap);
        public delegate EventHandler OnDeviceErrorHandler(EventHandler e, DeviceError errorType);

        public event OnImageGrabbedHandler OnImageGrabbed;
        public event OnDeviceErrorHandler OnDeviceError;

        public List<string> ListCameraKeys()
        {
            return null;
        }

        public void InitCamera()
        {
        }

        public void Snap()
        {
        }

        public void RunContie()
        { }

        public void StopRun()
        { }
    }
}
