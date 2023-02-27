using System;

namespace Models
{
    public class Buyer : Observer
    {

        private string subject;

        public Buyer(
            string subject)
        {
            this.subject = subject;
        }

        public override void SendEmail(int oldValue, int newValue)
        {
            Console.WriteLine("Dear {0}, the value has change from {1} to {2}", subject, oldValue, newValue);
        }

        public override void SendEmail(string oldValue, string newValue)
        {
            Console.WriteLine("Dear {0}, the value has change from {1} to {2}", subject, oldValue, newValue);
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}