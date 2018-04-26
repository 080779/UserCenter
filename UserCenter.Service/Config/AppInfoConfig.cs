using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserCenter.Service.Entity;

namespace UserCenter.Service.Config
{
    class AppInfoConfig : IEntityTypeConfiguration<AppInfoEntity>
    {
        public void Configure(EntityTypeBuilder<AppInfoEntity> builder)
        {
            builder.ToTable("T_AppInfos");
        }
    }
}
