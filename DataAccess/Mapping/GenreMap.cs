using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class GenreMap : EntityTypeConfiguration<Genre>
	{
		public GenreMap()
		{
			// Primary Key
			this.HasKey(t => t.GenreId);

			// Properties
			this.Property(t => t.Name)
				.HasMaxLength(120);
				
			// Table & Column Mappings
			this.ToTable("Genre");
			this.Property(t => t.GenreId).HasColumnName("GenreId");
			this.Property(t => t.Name).HasColumnName("Name");
		}
	}
}

