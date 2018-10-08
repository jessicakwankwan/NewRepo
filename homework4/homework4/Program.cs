using System;

namespace homework4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("输入时：分：秒");
            int hour = Convert.ToInt32(System.Console.ReadLine());
            int mins = Convert.ToInt32(System.Console.ReadLine());
            int secs = Convert.ToInt32(System.Console.ReadLine());
            Alarm alarm = new Alarm();
            alarm.SetClock(hour, mins, secs);
            alarm.ringing += AlarmRing;
            alarm.Check();
        }
        //事件处理方法
        static void AlarmRing()
        {
            Console.Write("时间到啦！！！！");
        }
    }
}
