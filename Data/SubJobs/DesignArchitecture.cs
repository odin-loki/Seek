using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class DesignArchitecture
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<DesignArchitecture> CreateList()
		{
			return new List<DesignArchitecture>
			{
				new DesignArchitecture { Name = "All Design & Architecture", Uri="&subclassification=6265" },
				new DesignArchitecture { Name = "Architectural Drafting", Uri="&subclassification=6264" },
				new DesignArchitecture { Name = "Architecture", Uri="&subclassification=6267" },
				new DesignArchitecture { Name = "Fashion & Textile Design", Uri="&subclassification=6268" },
				new DesignArchitecture { Name = "Graphic Design", Uri="&subclassification=6266" },
				new DesignArchitecture { Name = "Illustration & Animation", Uri="&subclassification=6269" },
				new DesignArchitecture { Name = "Industrial Design", Uri="&subclassification=6270" },
				new DesignArchitecture { Name = "Interior Design", Uri="&subclassification=6271" },
				new DesignArchitecture { Name = "Landscape Architecture", Uri="&subclassification=6272" },
				new DesignArchitecture { Name = "Urban Design & Planning", Uri="&subclassification=6273" },
				new DesignArchitecture { Name = "Web & Interaction Design", Uri="&subclassification=6274" },
			};
		}
	}
}