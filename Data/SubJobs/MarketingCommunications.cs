using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class MarketingCommunications
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<MarketingCommunications> CreateList()
		{
			return new List<MarketingCommunications>
			{
				new MarketingCommunications { Name = "All Marketing & Communications", Uri="&subclassification=6009" },
				new MarketingCommunications { Name = "Brand Management", Uri="&subclassification=6010" },
				new MarketingCommunications { Name = "Digital & Search Marketing", Uri="&subclassification=6011" },
				new MarketingCommunications { Name = "Direct Marketing & CRM", Uri="&subclassification=6012" },
				new MarketingCommunications { Name = "Event Management", Uri="&subclassification=6013" },
				new MarketingCommunications { Name = "Internal Communications", Uri="&subclassification=6017" },
				new MarketingCommunications { Name = "Management", Uri="&subclassification=6014" },
				new MarketingCommunications { Name = "Market Research & Analysis", Uri="&subclassification=6015" },
				new MarketingCommunications { Name = "Marketing Assistants/Coordinators", Uri="&subclassification=6016" },
				new MarketingCommunications { Name = "Marketing Communications", Uri="&subclassification=6018" },
				new MarketingCommunications { Name = "Product Management & Development", Uri="&subclassification=6019" },
				new MarketingCommunications { Name = "Public Relations & Corporate Affairs", Uri="&subclassification=6020" },
				new MarketingCommunications { Name = "Trade Marketing", Uri="&subclassification=6021" },
			};
		}
	}
}