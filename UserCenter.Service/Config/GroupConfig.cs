using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserCenter.Service.Entity;

namespace UserCenter.Service.Config
{
    class GroupConfig : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.ToTable("T_Groups");
        }
    }
}
