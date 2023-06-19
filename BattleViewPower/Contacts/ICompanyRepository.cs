using BattleViewPower.Models;

namespace BattleViewPower.Contacts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();

        
    }
}
