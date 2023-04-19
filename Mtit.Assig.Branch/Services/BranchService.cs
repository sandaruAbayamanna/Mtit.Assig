using Mtit.Assig.Branch.Data;

namespace Mtit.Assig.Branch.Services
{
    public class BranchService : IBranchService
    {
        public List<Models.Branch> GetBranches()
        {
            return BranchMockDataService.branches;
        }

        public Models.Branch? GetBranch(int id)
        {
            return BranchMockDataService.branches.FirstOrDefault(x => x.Id == id);
        }

        public Models.Branch? AddBranch(Models.Branch branch)
        {
            BranchMockDataService.branches.Add(branch);
            return branch;
        }

        public Models.Branch? UpdateBranch(Models.Branch branch)
        {
            Models.Branch selectedBranch = BranchMockDataService.branches.FirstOrDefault(x => x.Id == branch.Id);
            if (selectedBranch != null)
            {
                selectedBranch.Province = branch.Province;
                selectedBranch.LocatedAt = branch.LocatedAt;
                selectedBranch.DistanceToMotherBank = branch.DistanceToMotherBank;
               
                return selectedBranch;
            }
            return selectedBranch;
        }

        public bool? DeleteBranch(int id)
        {
            Models.Branch selectedBranch = BranchMockDataService.branches.FirstOrDefault(x => x.Id == id);
            if (selectedBranch != null)
            {
                BranchMockDataService.branches.Remove(selectedBranch);
                return true;
            }
            return false;
        }
    }
}
