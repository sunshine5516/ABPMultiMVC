using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPMultiMVC.EntityFramework;

namespace ABPMultiMVC.Migrator
{
    [DependsOn(typeof(ABPMultiMVCDataModule))]
    public class ABPMultiMVCMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPMultiMVCDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}