using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class FarmingAnimalsConservation
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<FarmingAnimalsConservation> CreateList()
		{
			return new List<FarmingAnimalsConservation>
			{
				new FarmingAnimalsConservation { Name = "All Farming, Animals & Conservation", Uri="&subclassification=6206" },
				new FarmingAnimalsConservation { Name = "Agronomy & Farm Services", Uri="&subclassification=6207" },
				new FarmingAnimalsConservation { Name = "Conservation, Parks & Wildlife", Uri="&subclassification=6208" },
				new FarmingAnimalsConservation { Name = "Farm Labour", Uri="&subclassification=6209" },
				new FarmingAnimalsConservation { Name = "Farm Management", Uri="&subclassification=6210" },
				new FarmingAnimalsConservation { Name = "Fishing & Aquaculture", Uri="&subclassification=6211" },
				new FarmingAnimalsConservation { Name = "Horticulture", Uri="&subclassification=6212" },
				new FarmingAnimalsConservation { Name = "Veterinary Services & Animal Welfare", Uri="&subclassification=6213" },
				new FarmingAnimalsConservation { Name = "Winery & Viticulture", Uri="&subclassification=6214" },
				new FarmingAnimalsConservation { Name = "Other", Uri="" },
			};
		}
	}
}