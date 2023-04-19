namespace Mtit.Assig.Customer.Data
{
    public class CustomerMockDataService
    {
        public static List<Models.Customer> customers = new List<Models.Customer>()
        {
            new Models.Customer{Id = 1, Name="john", Age=20, AccBalance=20000, AccType="saving account", CribStatus=false},
            new Models.Customer{Id = 2, Name="Mary", Age=23, AccBalance=20000, AccType="saving account", CribStatus=true},
            new Models.Customer{Id = 3, Name = "Sandaru", Age = 26, AccBalance = 20000, AccType = "fixed account", CribStatus = true},
            new Models.Customer{Id = 4, Name = "pulini", Age = 21, AccBalance = 20000, AccType = "saving account", CribStatus = false},
            new Models.Customer{Id = 5, Name = "devindi", Age = 27, AccBalance = 20000, AccType = "fixed account", CribStatus = false}
        };
    }
}
