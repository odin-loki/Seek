using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class SportRecreation
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<SportRecreation> CreateList()
		{
			return new List<SportRecreation>
			{
				new SportRecreation { Name = "All Sport & Recreation", Uri="&subclassification=6247" },
				new SportRecreation { Name = "Coaching & Instruction", Uri="&subclassification=6248" },
				new SportRecreation { Name = "Fitness & Personal Training", Uri="&subclassification=6249" },
				new SportRecreation { Name = "Management", Uri="&subclassification=6250" },
			};
		}
	}
}