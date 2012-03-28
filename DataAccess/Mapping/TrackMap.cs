using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class TrackMap : EntityTypeConfiguration<Track>
	{
		public TrackMap()
		{
			// Primary Key
			this.HasKey(t => t.TrackId);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.Composer)
				.HasMaxLength(220);
				
			// Table & Column Mappings
			this.ToTable("Track");
			this.Property(t => t.TrackId).HasColumnName("TrackId");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.AlbumId).HasColumnName("AlbumId");
			this.Property(t => t.MediaTypeId).HasColumnName("MediaTypeId");
			this.Property(t => t.GenreId).HasColumnName("GenreId");
			this.Property(t => t.Composer).HasColumnName("Composer");
			this.Property(t => t.Milliseconds).HasColumnName("Milliseconds");
			this.Property(t => t.Bytes).HasColumnName("Bytes");
			this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
		}
	}
}

