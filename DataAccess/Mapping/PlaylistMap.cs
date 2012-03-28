using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class PlaylistMap : EntityTypeConfiguration<Playlist>
	{
		public PlaylistMap()
		{
			// Primary Key
			this.HasKey(t => t.PlaylistId);

			// Properties
			this.Property(t => t.Name)
				.HasMaxLength(120);
				
			// Table & Column Mappings
			this.ToTable("Playlist");
			this.Property(t => t.PlaylistId).HasColumnName("PlaylistId");
			this.Property(t => t.Name).HasColumnName("Name");
		}
	}
}

