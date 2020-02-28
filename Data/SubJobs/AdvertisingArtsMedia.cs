using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class AdvertisingArtsMedia
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<AdvertisingArtsMedia> CreateList()
		{
			return new List<AdvertisingArtsMedia>
			{
				new AdvertisingArtsMedia { Name = "All Advertising, Arts & Media", Uri="&subclassification=6305" },
				new AdvertisingArtsMedia { Name = "Agency Account Management", Uri="&subclassification=6306" },
				new AdvertisingArtsMedia { Name = "Art Direction", Uri="&subclassification=6307" },
				new AdvertisingArtsMedia { Name = "Editing & Publishing", Uri="&subclassification=6308" },
				new AdvertisingArtsMedia { Name = "Event Management", Uri="&subclassification=6309" },
				new AdvertisingArtsMedia { Name = "Journalism & Writing", Uri="&subclassification=6310" },
				new AdvertisingArtsMedia { Name = "Management", Uri="&subclassification=6311" },
				new AdvertisingArtsMedia { Name = "Media Strategy, Planning & Buying", Uri="&subclassification=6312" },
				new AdvertisingArtsMedia { Name = "Performing Arts", Uri="&subclassification=6313" },
				new AdvertisingArtsMedia { Name = "Photography", Uri="&subclassification=6314" },
				new AdvertisingArtsMedia { Name = "Programming & Production", Uri="&subclassification=6315" },
				new AdvertisingArtsMedia { Name = "Promotions", Uri="&subclassification=6316" },
			};
		}
	}
}