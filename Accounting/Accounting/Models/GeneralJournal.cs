using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Models
{
    public class GeneralJournal
    {
		
			public int ID { get; set; }
			public DateTime Date { get; set; }
			public string Description { get; set; }
			public string PostRef { get; set; }
			public decimal Debit { get; set; }
			public decimal Credit { get; set; }
		public class Transaction
		{
			public int ID { get; set; }
			public DateTime Date { get; set; }
			public string Description { get; set; }
			public string PostRef { get; set; }
			public decimal Debit { get; set; }
			public decimal Credit { get; set; }

		}
	}
}
