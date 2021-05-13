namespace Coursework_Console
{
    class Supermarket // Class "Supermarket"
    {
        public Department First { get; private set; }
        public Department Last { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public Supermarket(string name) // Constructor
        {
            Name = name;
            Quantity = 0;
            First = null;
            Last = null;
        }

        //Methods
        public Department Search(string name)
        {
            Department temp = First;
            while (temp != null)
            {
                if (temp.Name == name)
                    return temp;
                else
                    temp = temp.Next;
            }
            return null;
        }
        public void AddDepartment(string name)
        {
            Department dep = new Department(name);
            if (Quantity == 0) //adding 1-st elt
            {
                Last = dep;
                First = Last;
                Quantity++;
            }
            else//adding 
            {
                Last.SetNext(dep);
                Last = dep;
                Quantity++;
            }
        }
        public bool DelDepartment()
        {
            if (Quantity != 0)
            {
                Department temp = First;
                First = First.Next;

                if (First == null) Last = null;
                temp = null;
                Quantity--;
                return true;
            }
            return false;
        }
        public double Sum()
        {
            double sum = 0;
            Department temp = First;
            while (temp != null)
            {
                sum += temp.Sum();
                temp = temp.Next;
            }
            return sum;
        }
        public string Display()
        {
            Department temp = First;
            string display = $"Supermarket '{Name}' total value: {Sum()} \n\nDepartments: \nName \t Quantity \n";

            while (temp != null)
            {
                display += $"{temp.Name} \t {temp.Quantity} \n";
                temp = temp.Next;
            }
            return display;
        }
    }
}
