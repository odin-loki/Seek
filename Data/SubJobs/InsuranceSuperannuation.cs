using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class InsuranceSuperannuation
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<InsuranceSuperannuation> CreateList()
		{
			return new List<InsuranceSuperannuation>
			{
				new InsuranceSuperannuation { Name = "All Insurance & Superannuation", Uri="&subclassification=6275" },
				new InsuranceSuperannuation { Name = "Actuarial", Uri="&subclassification=6276" },
				new InsuranceSuperannuation { Name = "Assessment", Uri="&subclassification=6277" },
				new InsuranceSuperannuation { Name = "Brokerage", Uri="&subclassification=1350" },
				new InsuranceSuperannuation { Name = "Claims", Uri="&subclassification=6278" },
				new InsuranceSuperannuation { Name = "Fund Administration", Uri="&subclassification=6279" },
				new InsuranceSuperannuation { Name = "Management", Uri="&subclassification=1499" },
				new InsuranceSuperannuation { Name = "Risk Consulting", Uri="&subclassification=1524" },
				new InsuranceSuperannuation { Name = "Superannuation", Uri="&subclassification=1544" },
				new InsuranceSuperannuation { Name = "Underwriting", Uri="&subclassification=1553" },
				new InsuranceSuperannuation { Name = "Workers & Compensation", Uri="&subclassification=6280" },
			};
		}
	}
}