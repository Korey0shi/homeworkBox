using System;
using System.Threading;

namespace Project2
{
    class Clock
    {
        public event AlarmEventHandle AlarmEvent;
        public event TickEventHandle TickEvent;
        private int alarmHour;
        private int alarmMinute;
        private int alarmSecond;

        public void SetAlarm(int alarmHour,int alarmMinute,int alarmSecond)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
            this.alarmSecond = alarmSecond;
        }
        public void StartWork()
        {
            while (true)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                this.TickEvent(hour, minute, second);
                if(hour==this.alarmHour&&minute==this.alarmMinute&&second==this.alarmSecond)
                {
                    AlarmEvent(hour, minute, second);
                }
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Clock myClock = new Alarm.Clock();
            myClock.AlarmEvent += ClockAlarm;
            myClock.TickEvent += ClockTick;
            myClock.SetAlarm(10, 12, 50);
            myClock.StartWork();
        }
    }
 
}
