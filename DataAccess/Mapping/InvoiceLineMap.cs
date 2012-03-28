using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class InvoiceLineMap : EntityTypeConfiguration<InvoiceLine>
	{
		public InvoiceLineMap()
		{
			// Primary Key
			this.HasKey(t => t.InvoiceLineId);

			// Properties
			// Table & Column Mappings
			this.ToTable("InvoiceLine");
			this.Property(t => t.InvoiceLineId).HasColumnName("InvoiceLineId");
			this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
			this.Property(t => t.TrackId).HasColumnName("TrackId");
			this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
			this.Property(t => t.Quantity).HasColumnName("Quantity");
		}
	}
}

