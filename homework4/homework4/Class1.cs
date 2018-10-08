using System;
using System.Collections.Generic;
using System.Text;


namespace homework4
{
    //声明委托类型
    public delegate void AlarmEventHandler();
    //定义事件源
    public class Alarm
    {
        //声明事件
        public event AlarmEventHandler ringing;
        private int hour, mins, secs;
        string settime = "";
        public void SetClock(int hour, int mins, int secs)
        {
            this.hour = hour;
            this.mins = mins;
            this.secs = secs;
            settime = hour.ToString() + ":" + mins.ToString() + ":" + secs.ToString();
        }
        public void Check()
        {
            string localtime = DateTime.Now.ToLongTimeString().ToString();
            if(settime == localtime)
            {
                ringing();
            }
        }
    }

}
