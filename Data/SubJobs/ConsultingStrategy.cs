using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class ConsultingStrategy
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<ConsultingStrategy> CreateList()
		{
			return new List<ConsultingStrategy>
			{
				new ConsultingStrategy { Name = "All Consulting & Strategy", Uri="&subclassification=6077" },
				new ConsultingStrategy { Name = "Analysts", Uri="&subclassification=6078" },
				new ConsultingStrategy { Name = "Corporate Development", Uri="&subclassification=6079" },
				new ConsultingStrategy { Name = "Environment & Sustainability Consulting", Uri="&subclassification=6080" },
				new ConsultingStrategy { Name = "Management & Change Consulting", Uri="&subclassification=6081" },
				new ConsultingStrategy { Name = "Policy", Uri="&subclassification=6082" },
				new ConsultingStrategy { Name = "Strategy & Planning", Uri="&subclassification=6083" },
			};
		}
	}
}