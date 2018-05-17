using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
