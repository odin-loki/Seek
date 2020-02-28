using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class CEOGeneralManagement
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<CEOGeneralManagement> CreateList()
		{
			return new List<CEOGeneralManagement>
			{
				new CEOGeneralManagement { Name = "All CEO & General Management", Uri="&subclassification=7020" },
				new CEOGeneralManagement { Name = "Board Appointments", Uri="&subclassification=7021" },
				new CEOGeneralManagement { Name = "CEO", Uri="&subclassification=7022" },
				new CEOGeneralManagement { Name = "COO & MD", Uri="&subclassification=7023" },
				new CEOGeneralManagement { Name = "General/Business Unit Manager", Uri="&subclassification=7024" },
			};
		}
	}
}