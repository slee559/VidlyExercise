using System.Data.Entity.ModelConfiguration;
using VidlyExercise.Models;

namespace VidlyExercise.EntityTypeConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {

        public CustomerConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Birthdate)
                .IsOptional();
        }
    }
}