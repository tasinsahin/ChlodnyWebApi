using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
	public class InvoiceLine
	{
		public int InvoiceLineId { get; set; }
		public int InvoiceId { get; set; }
		public int TrackId { get; set; }
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }
	}
}

