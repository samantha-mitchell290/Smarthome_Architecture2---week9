using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartDevice
    {
        // private fields
        private int deviceID;
        private string deviceName;
        private bool status;

        // public properties
        public int DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set {  status = value; }
        }

        // Parameterised constructor
        public SmartDevice(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus)
        {
            this.DeviceID = smartDeviceID;
            this.DeviceName = smartDeviceName;
            this.Status = smartDeviceStatus;
        }

        // Methods
        public void TurnOn()
        {
            Status = true;
            Console.WriteLine($"{deviceName} with device ID {DeviceID} is now ON");
        }

        public void TurnOff()
        {
            Status = false;
            Console.WriteLine($"{deviceName} with device ID {DeviceID} is now OFF");
        }

        public virtual void GetStatus()
        {
            Console.WriteLine($"Device ID: {DeviceID}, Name: {DeviceName}, Status (on or off): {(Status ? "ON" : "OFF")}");
        }
    }
}
