using Models;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(12, 34, "Available", "Black");

            computer.Attach(new Buyer("Mateo"));
            computer.Attach(new Buyer("Michael"));

            computer.Price = 55;
        }
    }
}
