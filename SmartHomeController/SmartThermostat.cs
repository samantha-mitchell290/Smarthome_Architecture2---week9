using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartThermostat : SmartDevice
    {
        //private fields
        private double currentTemperture;
        private double targetTemperature;

        //public properties
        public double CurrentTemperature
        {
            get { return currentTemperture; }
            set {  currentTemperture = value;  }
        }

        public double TargetTemperature
        {
            get {  return targetTemperature; }
            set {  targetTemperature = value; }
        }

        //constructor
        public SmartThermostat(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, double currentTemperature, double targetTemperature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            this.CurrentTemperature = currentTemperature;
            this.TargetTemperature = targetTemperature;
        }

        //methods
        public void SetTemperature()
        {

        }

        public void SetCurrentTemperature()
        {

        }

        public override void GetStatus()
        {

        }
    }
}
