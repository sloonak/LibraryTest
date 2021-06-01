using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class Device
    {
        public void PowerOn() { }
        public void PowerOff() { }
        public void VolumeOn() { }
        public void VolumeOff() { }
        public void Mute() { }
    }
    public class Radio : Device
    {
        public void ChangeWave() { }
    }
    public class TV : Device
    {
        public void ChangeChannel() { }
        public void ChangeInput() { }
    }
    public class Mobile : Device
    {
        public void Call() { }
        public void ShowCharge() { }
        public void ShowInfo() { }
        public void Photo() { }
        public void FlashOn() { }
        public void FlashOff() { }
    }
}
