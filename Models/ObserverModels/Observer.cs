namespace Models
{
    public abstract class Observer
    {
        public abstract void SendEmail(int oldValue, int newValue);

        public abstract void SendEmail(string oldValue, string newValue);
    }
}

