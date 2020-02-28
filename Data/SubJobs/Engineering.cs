using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class Engineering
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<Engineering> CreateList()
		{
			return new List<Engineering>
			{
				new Engineering { Name = "All Engineering", Uri="&subclassification=6022" },
				new Engineering { Name = "Aerospace Engineering", Uri="&subclassification=6023" },
				new Engineering { Name = "Automotive Engineering", Uri="&subclassification=6024" },
				new Engineering { Name = "Building Services Engineering", Uri="&subclassification=6026" },
				new Engineering { Name = "Chemical Engineering", Uri="&subclassification=6027" },
				new Engineering { Name = "Civil/Structural Engineering", Uri="&subclassification=6028" },
				new Engineering { Name = "Electrical/Electronic Engineering", Uri="&subclassification=6025" },
				new Engineering { Name = "Engineering Drafting", Uri="&subclassification=6029" },
				new Engineering { Name = "Environmental Engineering", Uri="&subclassification=6030" },
				new Engineering { Name = "Field Engineering", Uri="&subclassification=6031" },
				new Engineering { Name = "Industrial Engineering", Uri="&subclassification=6032" },
				new Engineering { Name = "Maintenance", Uri="&subclassification=6033" },
				new Engineering { Name = "Management", Uri="&subclassification=6034" },
				new Engineering { Name = "Materials Handling Engineering", Uri="&subclassification=6035" },
				new Engineering { Name = "Mechanical Engineering", Uri="&subclassification=6036" },
				new Engineering { Name = "Process Engineering", Uri="&subclassification=6038" },
				new Engineering { Name = "Project Engineering", Uri="&subclassification=6037" },
				new Engineering { Name = "Project Management", Uri="&subclassification=6039" },
				new Engineering { Name = "Supervisors", Uri="&subclassification=6040" },
				new Engineering { Name = "Systems Engineering", Uri="&subclassification=6041" },
				new Engineering { Name = "Water & Waste Engineering", Uri="&subclassification=6042" },
			};
		}
	}
}