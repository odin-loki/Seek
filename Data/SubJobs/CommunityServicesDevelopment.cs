using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class CommunityServicesDevelopment
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<CommunityServicesDevelopment> CreateList()
		{
			return new List<CommunityServicesDevelopment>
			{
				new CommunityServicesDevelopment { Name = "All Community Services & Development", Uri="&subclassification=6164" },
				new CommunityServicesDevelopment { Name = "Aged & Disability Support", Uri="&subclassification=6165" },
				new CommunityServicesDevelopment { Name = "Child Welfare, Youth & Family Services", Uri="&subclassification=6166" },
				new CommunityServicesDevelopment { Name = "Community Development", Uri="&subclassification=6167" },
				new CommunityServicesDevelopment { Name = "Employment Services", Uri="&subclassification=6168" },
				new CommunityServicesDevelopment { Name = "Fundraising", Uri="&subclassification=6169" },
				new CommunityServicesDevelopment { Name = "Housing & Homelessness Services", Uri="&subclassification=6170" },
				new CommunityServicesDevelopment { Name = "Indigenous & Multicultural Services", Uri="&subclassification=6171" },
				new CommunityServicesDevelopment { Name = "Management", Uri="&subclassification=6172" },
				new CommunityServicesDevelopment { Name = "Volunteer Coordination & Support", Uri="&subclassification=6173" },
			};
		}
	}
}