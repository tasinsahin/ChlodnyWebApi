using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class ArtistMap : EntityTypeConfiguration<Artist>
	{
		public ArtistMap()
		{
			// Primary Key
			this.HasKey(t => t.ArtistId);

			// Properties
			this.Property(t => t.Name)
				.HasMaxLength(120);
				
			// Table & Column Mappings
			this.ToTable("Artist");
			this.Property(t => t.ArtistId).HasColumnName("ArtistId");
			this.Property(t => t.Name).HasColumnName("Name");
		}
	}
}

