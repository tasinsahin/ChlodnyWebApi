using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class AlbumMap : EntityTypeConfiguration<Album>
	{
		public AlbumMap()
		{
			// Primary Key
			this.HasKey(t => t.AlbumId);

			// Properties
			this.Property(t => t.Title)
				.IsRequired()
				.HasMaxLength(160);
				
			// Table & Column Mappings
			this.ToTable("Album");
			this.Property(t => t.AlbumId).HasColumnName("AlbumId");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.ArtistId).HasColumnName("ArtistId");
		}
	}
}

