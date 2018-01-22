using System.Linq;
using ABPMultiMVC.EntityFramework;
using ABPMultiMVC.MultiTenancy;

namespace ABPMultiMVC.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPMultiMVCDbContext _context;

        public DefaultTenantCreator(ABPMultiMVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
