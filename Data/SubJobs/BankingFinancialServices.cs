using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class BankingFinancialServices
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<BankingFinancialServices> CreateList()
		{
			return new List<BankingFinancialServices>
			{
				new BankingFinancialServices { Name = "All Banking & Financial Services", Uri="&subclassification=6174" },
				new BankingFinancialServices { Name = "Account & Relationship Management", Uri="&subclassification=6175" },
				new BankingFinancialServices { Name = "Analysis & Reporting", Uri="&subclassification=6177" },
				new BankingFinancialServices { Name = "Banking - Business", Uri="&subclassification=6178" },
				new BankingFinancialServices { Name = "Banking - Corporate & Institutional", Uri="&subclassification=6176" },
				new BankingFinancialServices { Name = "Banking - Retail/Branch", Uri="&subclassification=1352" },
				new BankingFinancialServices { Name = "Client Services", Uri="&subclassification=6179" },
				new BankingFinancialServices { Name = "Compliance & Risk", Uri="&subclassification=6180" },
				new BankingFinancialServices { Name = "Corporate Finance & Investment Banking", Uri="&subclassification=6181" },
				new BankingFinancialServices { Name = "Credit", Uri="&subclassification=1392" },
				new BankingFinancialServices { Name = "Financial Planning", Uri="&subclassification=1404" },
				new BankingFinancialServices { Name = "Funds Management", Uri="&subclassification=6182" },
				new BankingFinancialServices { Name = "Management", Uri="&subclassification=6183" },
				new BankingFinancialServices { Name = "Mortgages", Uri="&subclassification=6184" },
				new BankingFinancialServices { Name = "Settlements", Uri="&subclassification=6185" },
				new BankingFinancialServices { Name = "Stockbroking & Trading", Uri="&subclassification=6186" },
				new BankingFinancialServices { Name = "Treasury", Uri="&subclassification=6187" },
			};
		}
	}
}