using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class AdministrationOfficeSupport
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<AdministrationOfficeSupport> CreateList()
		{
			return new List<AdministrationOfficeSupport>
			{
				new AdministrationOfficeSupport { Name = "All Administration & Office Support", Uri="&subclassification=6252" },
				new AdministrationOfficeSupport { Name = "Administrative Assistants", Uri="&subclassification=6253" },
				new AdministrationOfficeSupport { Name = "Client & Sales Administration", Uri="&subclassification=6254" },
				new AdministrationOfficeSupport { Name = "Contracts Administration", Uri="&subclassification=6255" },
				new AdministrationOfficeSupport { Name = "Data Entry & Word Processing", Uri="&subclassification=6256" },
				new AdministrationOfficeSupport { Name = "Office Management", Uri="&subclassification=6257" },
				new AdministrationOfficeSupport { Name = "PA, EA & Secretarial", Uri="&subclassification=6258" },
				new AdministrationOfficeSupport { Name = "Receptionists", Uri="&subclassification=6259" },
				new AdministrationOfficeSupport { Name = "Records Management & Document Control", Uri="&subclassification=6260" },
			};
		}
	}
}