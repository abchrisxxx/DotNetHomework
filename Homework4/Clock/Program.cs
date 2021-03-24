using System;

namespace Clock
{
    public delegate void TickHandler(object sender, TickEventArgs args);
    public class TickEventArgs
    {
        public string Time;
    }
    public delegate void AlarmHandler(object sender, AlarmEventArgs args);
    public class AlarmEventArgs
    {
        public string Time;
    }
    public class Clock
    {
        
        public event TickHandler Clock_Tick;
        public event AlarmHandler Clock_Alarm;
        public void clock_Tick(string time)
        {
            Console.WriteLine("Tick.");
            TickEventArgs args = new TickEventArgs()
            {
                Time = time
            };
            Clock_Tick(this, args);
        }
        public void clock_Alarm(string time)
        {
            Console.WriteLine("Alarm.");
            AlarmEventArgs args = new AlarmEventArgs()
            {
                Time = time
            };
            Clock_Alarm(this, args);
        }
        
    }
    class Form
    {
        public Clock c=new Clock();
        public Form()
        {
            c.Clock_Alarm += new AlarmHandler(alarm);
            c.Clock_Tick += new TickHandler(tick);
        }
        void alarm(object sender,AlarmEventArgs args)
        {
            Console.WriteLine("Clock alarm at " + args.Time);
        }
        void tick(object seder ,TickEventArgs args)
        {
            Console.WriteLine("Clock tick at " + args.Time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            for(int i = 0; i < 5; i++) {
                System.Threading.Thread.Sleep(1000);
                f.c.clock_Alarm(DateTime.Now.ToString("T"));
                System.Threading.Thread.Sleep(1000);
                f.c.clock_Tick(DateTime.Now.ToString("T"));
            }
            
        }
    }
}
