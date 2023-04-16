
namespace Mtit.Assig.Employee.Data
{
    public class EmployeeMockDataService
    {
        public static List<Models.Employee> employees = new List<Models.Employee>(){

            new Models.Employee{Id = 1,Name="john",Address="123 Main st",Email="john@gmail.com",Type="Trainee", Age=20 },
            new Models.Employee{Id = 2,Name="Mary",Address="235 Bakers st",Email="Mary@gmail.com",Type="Manager",Age=23 },
            new Models.Employee{Id = 3,Name="Sandaru",Address="126 kotta st",Email="Sandaru@gmail.com",Type="Trainee",Age=26},
            new Models.Employee{Id = 4, Name = "pulini", Address = "942 nawala st", Email = "pulini@gmail.com", Type = "Executiv ", Age = 21},
            new Models.Employee{Id = 5, Name = "devindi", Address = "627 rajagiriya st", Email = "devindi@gmail.com", Type = "Director", Age = 27}
        };
    }
}
