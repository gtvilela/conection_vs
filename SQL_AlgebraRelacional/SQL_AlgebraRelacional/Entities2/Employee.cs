namespace SQL_AlgebraRelacional.Entities2
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }

        public Employee(string name, double price, string email)
        {
            Name = name;
            Salary = price;
            Email = email;
        }
    }
}
