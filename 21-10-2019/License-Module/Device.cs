﻿using System.Collections;

namespace License_Module
{
    public class Device
    {
        public Device()
        {
            Component.GetComponent();
        }
        public string GetMACID()
        {
            return Component.MAC_Address;
        }

        public string GetHDSerial()
        {
            return Component.HDSerial;
        }
    }
}
