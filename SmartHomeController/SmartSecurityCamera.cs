using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartSecurityCamera : SmartDevice
    {
        //private fields
        private string resolutionStatus;
        private bool recordingStatus;

        //public properties
        public string ResolutionStatus
        {
            get { return resolutionStatus; }
            set {  resolutionStatus = value; }
        }

        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set {  recordingStatus = value; }
        }
        
        //constructor
        public SmartSecurityCamera(string resolutionStatus,  bool recordingStatus, int smartDeviceID, string smartDeviceName, bool smartDeviceStatus) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            this.ResolutionStatus = resolutionStatus;
            this.RecordingStatus = recordingStatus;
        }

        //methods
        public void StartRecording()
        {

        }
        public void StopRecording()
        {

        }
        public void TurnOff()
        {

        }
        public override void GetStatus()
        {
            
        }
    }
}
