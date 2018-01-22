using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABPMultiMVC.EntityFramework;

namespace ABPMultiMVC
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPMultiMVCCoreModule))]
    public class ABPMultiMVCDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPMultiMVCDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
