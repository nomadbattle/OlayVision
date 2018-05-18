using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceNomad
{
    public interface ICamera
    {
        string CameraKey { get; set; }
        DeviceType CameraType { get; set; }

        bool IsOpen { get; set; }

        event Camera.OnCameraOpenedHandler OnCameraOpened;
        event Camera.OnCameraClosedHandler OnCameraClosed;
        event Camera.OnImageGrabbedHandler OnImageGrabbed;
        event Camera.OnDeviceErrorHandler OnDeviceError;

        List<string> ListCameraKeys();

        void InitCamera();

        void Open();

        void Close();

        void Snap();

        void RunContie();

        void StopRun();

        void Dispose();
    }
}
