namespace Coursework_Console
{
    class Department // Class "Department"
    {
        static readonly int ArrSize = 10;
        public Department Next { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public readonly Product[] Arr = new Product[ArrSize];

        public Department(string name) // Constructor
        {
            Name = name;
            Quantity = 0;
            Next = null;
        }

        //Methods
        public void SetNext(Department next) => Next = next;
        public int Search(string name)
        {
            for (int i = 0; i < Quantity; i++)
            {
                if (name == Arr[i].Name)
                    return i;
            }
            return -1;
        }

        public bool Add(string name, double price) // adding first or int the end 
        {
            if (Quantity < ArrSize)
            {
                Product prod = new Product(name, price);

                if (Quantity == 0) Arr[0] = prod;
                else Arr[Quantity] = prod;

                Quantity++;
                return true;
            }
            return false;
        }
        public bool AddByIndex(int index, string name, double price)
        {
            if (Quantity < ArrSize && Quantity != 0)
            {
                if (index < Quantity)
                {
                    Product prod = new Product(name, price);

                    for (int i = Quantity; i > index; i--)//shift 
                        Arr[i] = Arr[i - 1];

                    Arr[index] = prod;
                    Quantity++;
                    return true;
                }
            }
            return false;
        }
        public bool DelProduct(string name)
        {
            if (Quantity != 0)
            {
                int i = Search(name);

                if (i != -1)
                {
                    Arr[i] = null;
                    for (i = i + 1; i < Quantity; i++)
                        Arr[i - 1] = Arr[i];

                    Quantity--;
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public double Sum()
        {
            double sum = 0;
            for (int i = 0; i < Quantity; i++)
                sum += Arr[i].Price;
            return sum;
        }
        public string Display()
        {
            string display = $"Departement '{Name}' total value: {Sum()}\n\nProducts:\nName\tPrice\n";

            for (int i = 0; i < Quantity; i++)
                display += $"{Arr[i].Name}\t{Arr[i].Price}\n";

            return display;
        }
    }
}
