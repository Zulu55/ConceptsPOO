using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    BirthDate = new Date(1974, 9, 23),
    Salary = 2000000,
    FirstName = "Juan",
    LastName = "Zuluaga",
    HiringDate = new Date(2022, 2, 1),
    IsActive = true
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    BirthDate = new Date(1981, 1, 11),
    FirstName = "Ledys",
    LastName = "Bedoya",
    HiringDate = new Date(2021, 2, 1),
    IsActive = true,
    Sales = 280000000M,
    CommissionPercentaje = 0.03F
};

Employee employee3 = new BaseCommissionEmployee()
{
    Id = 3040,
    BirthDate = new Date(1971, 1, 11),
    FirstName = "Mario",
    LastName = "Cortez",
    HiringDate = new Date(2021, 2, 1),
    IsActive = true,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F,
    Salary = 899567.89M
};

Employee employee4 = new HourlyEmployee()
{
    Id = 3040,
    BirthDate = new Date(1971, 1, 11),
    FirstName = "Mario",
    LastName = "Cortez",
    HiringDate = new Date(2021, 2, 1),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 18566.67M,
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3,
    employee4,
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                     ================");
Console.WriteLine($"TOTAL                 {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1234,
    Price = 5200000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Papa Capira",
    Id = 198798,
    Price = 15200000M,
    Quantity = 0.543F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

