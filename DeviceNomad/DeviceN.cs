using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviceNomad.DahuaCam;

namespace DeviceNomad
{
    public static class DeviceN
    {
        public static List<string> GetDeviceTypes()
        {
            List<string> devices = new List<string>();
            devices.Add(DeviceType.Basler.ToString());
            devices.Add(DeviceType.Dahua.ToString());
            return devices;
        }

        public static List<string> GetCameraKeys(DeviceType deviceType)
        {
            if (deviceType == DeviceType.Dahua)
            {
                DahuaCamera dahua = new DahuaCamera();
                return dahua.ListCameraKeys();
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
