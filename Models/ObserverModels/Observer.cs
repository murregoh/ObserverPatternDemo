namespace Models
{
    public abstract class Observer
    {
        public abstract void Update(int oldValue, int newValue);

        public abstract void Update(string oldValue, string newValue);
    }
}

