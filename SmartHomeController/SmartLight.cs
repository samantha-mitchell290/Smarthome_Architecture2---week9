using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartLight : SmartDevice
    {
        // private fields
        private double brightness;
        private string colour;


        // public properties
        public double Brightness
        {
            get { return brightness; }
            set { brightness = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        // Parameterised constructor & base class information
        public SmartLight(
            double smartLightBrightness, 
            string smartLightColour, 
            int smartDeviceID, 
            string smartDeviceName, 
            bool smartDeviceStatus) 
            : base(
                  smartDeviceID, 
                  smartDeviceName, 
                  smartDeviceStatus
                  )
        {
            Brightness = smartLightBrightness;
            Colour = smartLightColour;
        }

        // Methods
        public void SetBrightness(double brightness)
        {
            this.Brightness = brightness;
            Console.WriteLine($"Brightness now set to {Brightness}");
        }

        public void SetColour(string colour)
        {
            this.Colour= colour;
            Console.WriteLine($"Colour now set to {Colour}");
        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($"Brightness: {Brightness}%, Colour: {Colour}");
        }

    }
}
