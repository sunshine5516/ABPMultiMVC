using ABPMultiMVC.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPMultiMVC.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPMultiMVCDbContext _context;

        public InitialHostDbBuilder(ABPMultiMVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
