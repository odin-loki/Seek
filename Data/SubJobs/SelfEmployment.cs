using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class SelfEmployment
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<SelfEmployment> CreateList()
		{
			return new List<SelfEmployment>
			{
				new SelfEmployment { Name = "All Self Employment", Uri="&subclassification=6262" },
			};
		}
	}
}