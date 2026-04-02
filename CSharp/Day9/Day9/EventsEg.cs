using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class EventsEg
    {
        int value = 0;

        public delegate void numberManipulator(int x);

        public event numberManipulator changeNum;

        public virtual void onNumChange(int x)
        {
            Console.WriteLine($"Event Raised and the Value from {value} is Changed to {x}..");
        }

        public EventsEg(int n)
        {
            this.changeNum += new numberManipulator(this.onNumChange);            
            setValue(n);           
        }

        public void setValue(int x)
        {
            if (value != x)
            {
                value = x;
                onNumChange(x);

            }
            else
            {
                Console.WriteLine("No changes in the value and hence no event");
            }
        }
    }

    class TestEvents
    {
        static void Main()
        {
            EventsEg eventsEg = new EventsEg(5);
            eventsEg.setValue(15);
            eventsEg.setValue(20);
            eventsEg.setValue(20);
            Console.Read();
        }
    }
}
