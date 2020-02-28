using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class Legal
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<Legal> CreateList()
		{
			return new List<Legal>
			{
				new Legal { Name = "All Legal", Uri="&subclassification=6188" },
				new Legal { Name = "Banking & Finance Law", Uri="&subclassification=6190" },
				new Legal { Name = "Construction Law", Uri="&subclassification=6191" },
				new Legal { Name = "Corporate & Commercial Law", Uri="&subclassification=6189" },
				new Legal { Name = "Criminal & Civil Law", Uri="&subclassification=6192" },
				new Legal { Name = "Environment & Planning Law", Uri="&subclassification=6193" },
				new Legal { Name = "Family Law", Uri="&subclassification=6194" },
				new Legal { Name = "Generalists - In-house", Uri="&subclassification=6195" },
				new Legal { Name = "Generalists - Law Firm", Uri="&subclassification=6196" },
				new Legal { Name = "Industrial Relations & Employment Law", Uri="&subclassification=6197" },
				new Legal { Name = "Insurance & Superannuation Law", Uri="&subclassification=6198" },
				new Legal { Name = "Intellectual Property Law", Uri="&subclassification=1429" },
				new Legal { Name = "Law Clerks & Paralegals", Uri="&subclassification=6199" },
				new Legal { Name = "Legal Practice Management", Uri="&subclassification=1431" },
				new Legal { Name = "Legal Secretaries", Uri="&subclassification=6200" },
				new Legal { Name = "Litigation & Dispute Resolution", Uri="&subclassification=6201" },
				new Legal { Name = "Personal Injury Law", Uri="&subclassification=6202" },
				new Legal { Name = "Property Law", Uri="&subclassification=6203" },
				new Legal { Name = "Tax Law", Uri="&subclassification=6204" },
			};
		}
	}
}