using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
	public class Track
	{
		public int TrackId { get; set; }
		public string Name { get; set; }
		public Nullable<int> AlbumId { get; set; }
		public int MediaTypeId { get; set; }
		public Nullable<int> GenreId { get; set; }
		public string Composer { get; set; }
		public int Milliseconds { get; set; }
		public Nullable<int> Bytes { get; set; }
		public decimal UnitPrice { get; set; }
	}
}

