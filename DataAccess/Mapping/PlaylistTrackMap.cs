using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class PlaylistTrackMap : EntityTypeConfiguration<PlaylistTrack>
	{
		public PlaylistTrackMap()
		{
			// Primary Key
			HasKey(t => new { t.PlaylistId, t.TrackId });

			// Properties
			Property(t => t.PlaylistId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			Property(t => t.TrackId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			ToTable("PlaylistTrack");
			Property(t => t.PlaylistId).HasColumnName("PlaylistId");
			Property(t => t.TrackId).HasColumnName("TrackId");
		}
	}
}

