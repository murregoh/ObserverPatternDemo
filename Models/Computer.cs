namespace Models
{
    public class Computer : Subject
    {

        private int code;

        private int price;

        private string status;

        private string color;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    Notify(price, value);
                    price = value;
                }
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    Notify(status, value);
                    status = value;
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    Notify(color, value);
                    color = value;
                }
            }
        }

        public Computer(int code, int price, string status, string color)
        {
            this.Code = code;
            this.Price = price;
            this.Status = status;
            this.Color = color;
        }
    }
}