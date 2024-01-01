using System.Data.Entity.ModelConfiguration;
using ClinicManagement.Core.Models;

namespace Clinicapp.Persistence.EntityConfigurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}