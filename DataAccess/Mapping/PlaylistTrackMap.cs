using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class PlaylistTrackMap : EntityTypeConfiguration<PlaylistTrack>
	{
		public PlaylistTrackMap()
		{
			// Primary Key
			this.HasKey(t => new { t.PlaylistId, t.TrackId });

			// Properties
			this.Property(t => t.PlaylistId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.TrackId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("PlaylistTrack");
			this.Property(t => t.PlaylistId).HasColumnName("PlaylistId");
			this.Property(t => t.TrackId).HasColumnName("TrackId");
		}
	}
}

