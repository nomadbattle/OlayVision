using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceNomad
{
    public enum DeviceType
    {
        Basler,
        Dahua,
    }

    public enum DeviceError
    {
        OpenError,
        SnapError,
        Disconnected,
    }

    public enum CameraRunMode
    {
        Single,
        Continue,
    }
}
