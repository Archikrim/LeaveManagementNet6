using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                    UserId = "54e6a58c-2284-4f33-a8ef-389333f44d2b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                    UserId = "77e4cc68-a1b5-4761-bb55-15c1206ec8a6"
                }
            );
        }
    }
}