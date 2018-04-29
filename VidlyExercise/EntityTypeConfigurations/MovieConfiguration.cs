using System.Data.Entity.ModelConfiguration;
using VidlyExercise.Models;

namespace VidlyExercise.EntityTypeConfigurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(m => m.GenreId)
                .IsRequired();
        }
    }
}