using System;

namespace EventsAndDelegates
{
    
    // Delegate Definition   , delegate is kind of class 
    public delegate string MyDel(string str);

    class EventProgram
    {
        event MyDel MyEvent;  // defining the Event 

        public EventProgram() // Constructor
                              // Event is capable of saving or overloading delegates in it 
        {
            this.MyEvent += new MyDel(this.WelcomeUser);  // assigning delegate to event ,
                                                          // saving pointer of function in event  
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram(); // Creating an object , calling the constructor of event 
            string result = obj1.MyEvent("Tutorials Point"); // passing parameter to the event which will invoke the delegate 
            Console.WriteLine(result);
        }
    }

    
}

