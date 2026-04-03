using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    //1. let us create a custom event Arguments
   public class ButtonClickedEvent : EventArgs
    {
        public string ClickedBy { get; } // read only property

       public ButtonClickedEvent(string clickedBy)
       {
            this.ClickedBy = clickedBy;
       }
    }

    //2. create a publisher class
    public class Button
    {
        //create an event
        public event EventHandler<ButtonClickedEvent> ButtonClicked;

        //3. Method to stimulate button click
        public void Click(string user)
        {
            Console.WriteLine("Event Raised");
            OnButtonClicked(new ButtonClickedEvent(user));
        }
        //4. Raise an Event
        protected virtual void OnButtonClicked(ButtonClickedEvent e)
        {
            ButtonClicked.Invoke(this, e);
        }
    }

    class Subscriber1
    {
        //5. event handler
        public static void Button_ButtonClicked(object sender, ButtonClickedEvent e)
        {
            Console.WriteLine($"Button was Clicked by : {e.ClickedBy}");
        }

        //6. test the event
        static void Main()
        {
            Button button = new Button();

            //7. to subscribe to the event
            button.ButtonClicked += Button_ButtonClicked;

            button.Click("Infinite");
            button.Click("Banurekha");
            Console.Read();
        }
    }
}
