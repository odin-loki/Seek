using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class GovernmentDefence
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<GovernmentDefence> CreateList()
		{
			return new List<GovernmentDefence>
			{
				new GovernmentDefence { Name = "All Government & Defence", Uri="&subclassification=1314" },
				new GovernmentDefence { Name = "Air Force", Uri="&subclassification=1322" },
				new GovernmentDefence { Name = "Army", Uri="&subclassification=1378" },
				new GovernmentDefence { Name = "Emergency Services", Uri="&subclassification=1450" },
				new GovernmentDefence { Name = "Navy", Uri="&subclassification=6359" },
				new GovernmentDefence { Name = "Police & Corrections", Uri="&subclassification=6360" },
				new GovernmentDefence { Name = "Policy, Planning & Regulation", Uri="&subclassification=1409" },
				new GovernmentDefence { Name = "Government - Federal", Uri="&subclassification=1410" },
				new GovernmentDefence { Name = "Government - Local", Uri="&subclassification=1411" },
				new GovernmentDefence { Name = "Government - State", Uri="&subclassification=6361" },
			};
		}
	}
}