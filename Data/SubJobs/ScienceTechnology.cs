using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class ScienceTechnology
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<ScienceTechnology> CreateList()
		{
			return new List<ScienceTechnology>
			{
				new ScienceTechnology { Name = "All Science & Technology", Uri="&subclassification=6215" },
				new ScienceTechnology { Name = "Biological & Biomedical Sciences", Uri="&subclassification=6216" },
				new ScienceTechnology { Name = "Biotechnology & Genetics", Uri="&subclassification=6217" },
				new ScienceTechnology { Name = "Chemistry & Physics", Uri="&subclassification=6218" },
				new ScienceTechnology { Name = "Environmental, Earth & Geosciences", Uri="&subclassification=6219" },
				new ScienceTechnology { Name = "Food Technology & Safety", Uri="&subclassification=6220" },
				new ScienceTechnology { Name = "Laboratory & Technical Services", Uri="&subclassification=6221" },
				new ScienceTechnology { Name = "Materials Sciences", Uri="&subclassification=6222" },
				new ScienceTechnology { Name = "Mathematics, Statistics & Information Sciences", Uri="&subclassification=6223" },
				new ScienceTechnology { Name = "Modelling & Simulation", Uri="&subclassification=6224" },
				new ScienceTechnology { Name = "Quality Assurance & Control", Uri="&subclassification=6225" },
			};
		}
	}
}