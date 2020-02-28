using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class Construction
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<Construction> CreateList()
		{
			return new List<Construction>
			{
				new Construction { Name = "All Construction", Uri="&subclassification=6113" },
				new Construction { Name = "Contracts Management", Uri="&subclassification=1387" },
				new Construction { Name = "Estimating", Uri="&subclassification=6114" },
				new Construction { Name = "Foreperson/Supervisors", Uri="&subclassification=6115" },
				new Construction { Name = "Health, Safety & Environment", Uri="&subclassification=6116" },
				new Construction { Name = "Management", Uri="&subclassification=6117" },
				new Construction { Name = "Planning & Scheduling", Uri="&subclassification=6118" },
				new Construction { Name = "Plant & Machinery Operators", Uri="&subclassification=6119" },
				new Construction { Name = "Project Management", Uri="&subclassification=6120" },
				new Construction { Name = "Quality Assurance & Control", Uri="&subclassification=6121" },
				new Construction { Name = "Surveying", Uri="&subclassification=6122" },
			};
		}
	}
}