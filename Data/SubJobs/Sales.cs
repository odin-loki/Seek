using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class Sales
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<Sales> CreateList()
		{
			return new List<Sales>
			{
				new Sales { Name = "All Sales", Uri="&subclassification=6363" },
				new Sales { Name = "Account & Relationship Management", Uri="&subclassification=6364" },
				new Sales { Name = "Analysis & Reporting", Uri="&subclassification=6366" },
				new Sales { Name = "Management", Uri="&subclassification=6365" },
				new Sales { Name = "New Business Development", Uri="&subclassification=6367" },
				new Sales { Name = "Sales Coordinators", Uri="&subclassification=6368" },
				new Sales { Name = "Sales Representatives/Consultants", Uri="&subclassification=6369" },
			};
		}
	}
}