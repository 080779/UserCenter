using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserCenter.Service.Entity;

namespace UserCenter.Service.Config
{
    class UserGroupConfig : IEntityTypeConfiguration<UserGroupEntity>
    {
        public void Configure(EntityTypeBuilder<UserGroupEntity> builder)
        {
            builder.ToTable("T_UserGroups");
            builder.HasOne(u => u.Group).WithMany().HasForeignKey(u => u.GroupId).IsRequired();
            builder.HasOne(u => u.User).WithMany().HasForeignKey(u => u.UserId).IsRequired();
        }
    }
}
