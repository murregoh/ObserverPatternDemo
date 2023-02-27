using System.Collections.Generic;

namespace Models
{
    public abstract class Subject
    {
        private List<Observer> buyers = new List<Observer>();

        public void Attach(Observer observer)
        {
            buyers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            buyers.Remove(observer);
        }

        public void Notify(int oldValue, int newValue)
        {
            foreach (Observer o in buyers)
            {
                o.SendEmail(oldValue, newValue);
            }
        }

        public void Notify(string oldValue, string newValue)
        {
            foreach (Observer o in buyers)
            {
                o.SendEmail(oldValue, newValue);
            }
        }
    }
}
