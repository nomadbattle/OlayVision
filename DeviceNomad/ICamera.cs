using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceNomad
{
    public interface ICamera
    {
        string CameraKey { get; set; }

        event Camera.OnImageGrabbedHandler OnImageGrabbed;
        event Camera.OnDeviceErrorHandler OnDeviceError;

        List<string> ListCameraKeys();

        void InitCamera();

        void Snap();

        void RunContie();

        void StopRun();
    }
}
