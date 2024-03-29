﻿using System.Data.Entity.ModelConfiguration;
using ClinicManagement.Core.Models;

namespace Clinicapp.Persistence.EntityConfigurations
{
    public class SpecializationConfiguration : EntityTypeConfiguration<Specialization>
    {
        public SpecializationConfiguration()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}