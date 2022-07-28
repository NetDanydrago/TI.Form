

namespace TI.FormEFCore.Repositories.Configurations
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.HasKey(d => new { d.Id });
        }
    }
}
