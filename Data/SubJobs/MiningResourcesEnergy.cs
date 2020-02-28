using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class MiningResourcesEnergy
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<MiningResourcesEnergy> CreateList()
		{
			return new List<MiningResourcesEnergy>
			{
				new MiningResourcesEnergy { Name = "All Mining, Resources & Energy", Uri="&subclassification=6059" },
				new MiningResourcesEnergy { Name = "Analysis & Reporting", Uri="&subclassification=6060" },
				new MiningResourcesEnergy { Name = "Health, Safety & Environment", Uri="&subclassification=6061" },
				new MiningResourcesEnergy { Name = "Management", Uri="&subclassification=6062" },
				new MiningResourcesEnergy { Name = "Mining - Drill & Blast", Uri="&subclassification=6063" },
				new MiningResourcesEnergy { Name = "Mining - Engineering & Maintenance", Uri="&subclassification=6064" },
				new MiningResourcesEnergy { Name = "Mining - Exploration & Geoscience", Uri="&subclassification=6066" },
				new MiningResourcesEnergy { Name = "Mining - Operations", Uri="&subclassification=6065" },
				new MiningResourcesEnergy { Name = "Mining - Processing", Uri="&subclassification=6073" },
				new MiningResourcesEnergy { Name = "Natural Resources & Water", Uri="&subclassification=6067" },
				new MiningResourcesEnergy { Name = "Oil & Gas - Drilling", Uri="&subclassification=6068" },
				new MiningResourcesEnergy { Name = "Oil & Gas - Engineering & Maintenance", Uri="&subclassification=6069" },
				new MiningResourcesEnergy { Name = "Oil & Gas - Exploration & Geoscience", Uri="&subclassification=6071" },
				new MiningResourcesEnergy { Name = "Oil & Gas - Operations", Uri="&subclassification=6070" },
				new MiningResourcesEnergy { Name = "Oil & Gas - Production & Refinement", Uri="&subclassification=6072" },
				new MiningResourcesEnergy { Name = "Power Generation & Distribution", Uri="&subclassification=6074" },
				new MiningResourcesEnergy { Name = "Surveying", Uri="&subclassification=6075" },
			};
		}
	}
}