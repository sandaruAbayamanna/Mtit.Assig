namespace Mtit.Assig.Branch.Services
{
    public interface IBranchService
    {
        List<Models.Branch> GetBranches();
        Models.Branch? GetBranch(int id);
        Models.Branch? AddBranch(Models.Branch employee);
        Models.Branch? UpdateBranch(Models.Branch employee);
        bool? DeleteBranch(int id);
    }
}
