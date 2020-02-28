using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class RetailConsumerProducts
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<RetailConsumerProducts> CreateList()
		{
			return new List<RetailConsumerProducts>
			{
				new RetailConsumerProducts { Name = "All Retail & Consumer Products", Uri="&subclassification=6044" },
				new RetailConsumerProducts { Name = "Buying", Uri="&subclassification=6045" },
				new RetailConsumerProducts { Name = "Management - Area/Multi-site", Uri="&subclassification=6046" },
				new RetailConsumerProducts { Name = "Management - Department/Assistant", Uri="&subclassification=6047" },
				new RetailConsumerProducts { Name = "Management - Store", Uri="&subclassification=6048" },
				new RetailConsumerProducts { Name = "Merchandisers", Uri="&subclassification=6049" },
				new RetailConsumerProducts { Name = "Planning", Uri="&subclassification=6050" },
				new RetailConsumerProducts { Name = "Retail Assistants", Uri="&subclassification=6051" },
			};
		}
	}
}