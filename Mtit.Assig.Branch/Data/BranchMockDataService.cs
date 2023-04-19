namespace Mtit.Assig.Branch.Data
{
    public class BranchMockDataService
    {
        public static List<Models.Branch> branches = new List<Models.Branch>(){

            new Models.Branch{Id = 1, Province="Western", LocatedAt="Kotalawala", DistanceToMotherBank=32},
            new Models.Branch{ Id = 2, Province = "Western", LocatedAt = "Kotte", DistanceToMotherBank = 3},
            new Models.Branch{ Id = 3, Province = "Southern", LocatedAt = "Malabe", DistanceToMotherBank = 3},
            new Models.Branch{ Id = 4, Province = "Eastern ", LocatedAt = "Mirigama", DistanceToMotherBank = 5 },
            new Models.Branch{ Id = 5, Province = "North", LocatedAt = "aluthnuwara", DistanceToMotherBank = 2 }
        };
    }
}
