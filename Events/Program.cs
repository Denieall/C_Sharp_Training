using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // To create an event:
    // Define a delegate
    // Define an event based on that delegate
    // Create method to publish the event
    // Raise that event
    // Create method to handle the events
    // Subscribe the methods to the event

    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            Reporting r = new Reporting();
            Verifier v = new Verifier();

            // Subscribing to the AreaCalculated Event
            c.AreaCalculated += r.report;
            c.AreaCalculated += v.verify;

            c.calcArea();
            
        }
    }
    
    // Publisher Class
    class Calc
    {
        // 1. Define a delegate
        public delegate void AreaCalculatedEventHandler(Object sender, Video e);

        // 2. Define an event based on that delegate
        public event AreaCalculatedEventHandler AreaCalculated;

        public void calcArea()
        {
            Console.WriteLine("The area is");
            Thread.Sleep(5000);
            Console.WriteLine("31");

            // 3. Raise an event
            OnAreaCalculated();
        }

        protected virtual void OnAreaCalculated()
        {
            // Checking for subscriber method
            if (AreaCalculated != null)
            {
                AreaCalculated(this, new Video("This is a video file"));
            }
        }
    }

    //Subscriber class 1
    class Reporting
    {
        public void report(Object sender, Video e)
        {
            Console.WriteLine("Reporting..." + "-------" + e.Desc);
        }
    }

    //Subscriber class 2
    class Verifier
    {
        public void verify(Object sender, Video e)
        {
            Console.WriteLine("Verifying process completed" + "-------" + e.Desc);
        }
    }

    // Custom class
    class Video : EventArgs
    {
        private string desc;

        public Video(String s)
        {
            desc = s;
        }

        public string Desc
        {
            get { return desc; }
        }

    }
}
