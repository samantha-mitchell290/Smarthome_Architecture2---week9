using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartSpeaker : SmartDevice
    {
        // private fields
        private int volume;
        private bool isPlaying;


        // public properties

        public int Volume
        {  
            get { return volume; } 
            set { volume = value; }   
        }

        public bool IsPlaying
        {
            get {return isPlaying;  }
            set {  isPlaying = value; }
        }

        // Constructor
        public SmartSpeaker(
            int smartSpeakerVolume, 
            bool smartSpeakerIsPlaying, 
            int smartDeviceID, 
            string deviceName, 
            bool DeviceStatus) 
            : base(smartDeviceID, deviceName, DeviceStatus)
        {
            Volume = smartSpeakerVolume;
            IsPlaying = smartSpeakerIsPlaying;
        }


        // Methods

        public void PlayMusic()
        {

        }

        public void StopMusic()
        {

        }

        public void SetVolume()
        {

        }

        public override void GetStatus()
        {
            
        }

    }
}
