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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);
