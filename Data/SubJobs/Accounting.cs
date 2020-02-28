using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class Accounting
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<Accounting> CreateList()
		{
			return new List<Accounting>
			{
				new Accounting { Name = "Accounts Receivable/Credit Control", Uri="&subclassification=6143" },
				new Accounting { Name = "Analysis & Reporting", Uri="&subclassification=6142" },
				new Accounting { Name = "Assistant Accountants", Uri="&subclassification=6144" },
				new Accounting { Name = "Audit - External", Uri="&subclassification=6145" },
				new Accounting { Name = "Audit - Internal", Uri="&subclassification=6146" },
				new Accounting { Name = "Bookkeeping & Small Practice Accounting", Uri="&subclassification=6147" },
				new Accounting { Name = "Business Services & Corporate Advisory", Uri="&subclassification=6148" },
				new Accounting { Name = "Company Secretaries", Uri="&subclassification=6149" },
				new Accounting { Name = "Compliance & Risk", Uri="&subclassification=6150" },
				new Accounting { Name = "Cost Accounting", Uri="&subclassification=6151" },
				new Accounting { Name = "Financial Accounting & Reporting", Uri="&subclassification=6152" },
				new Accounting { Name = "Financial Managers & Controllers", Uri="&subclassification=6153" },
				new Accounting { Name = "Forensic Accounting & Investigation", Uri="&subclassification=6154" },
				new Accounting { Name = "Insolvency & Corporate Recovery", Uri="&subclassification=6155" },
				new Accounting { Name = "Inventory & Fixed Assets", Uri="&subclassification=6156" },
				new Accounting { Name = "Management", Uri="&subclassification=6157" },
				new Accounting { Name = "Management Accounting & Budgeting", Uri="&subclassification=1468" },
				new Accounting { Name = "Payroll", Uri="&subclassification=6158" },
				new Accounting { Name = "Strategy & Planning", Uri="&subclassification=6159" },
				new Accounting { Name = "Systems Accounting & IT Audit", Uri="&subclassification=6160" },
				new Accounting { Name = "Taxation", Uri="&subclassification=6161" },
				new Accounting { Name = "Treasury", Uri="&subclassification=6162" },
			};
		}
	}
}