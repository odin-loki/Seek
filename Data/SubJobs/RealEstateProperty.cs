using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class RealEstateProperty
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<RealEstateProperty> CreateList()
		{
			return new List<RealEstateProperty>
			{
				new RealEstateProperty { Name = "All Real Estate & Property", Uri="&subclassification=6371" },
				new RealEstateProperty { Name = "Administration", Uri="&subclassification=6001" },
				new RealEstateProperty { Name = "Analysts", Uri="&subclassification=6002" },
				new RealEstateProperty { Name = "Body Corporate & Facilities Management", Uri="&subclassification=6003" },
				new RealEstateProperty { Name = "Commercial Sales, Leasing & Property Mgmt", Uri="&subclassification=6004" },
				new RealEstateProperty { Name = "Residential Leasing & Property Management", Uri="&subclassification=6005" },
				new RealEstateProperty { Name = "Residential Sales", Uri="&subclassification=6006" },
				new RealEstateProperty { Name = "Retail & Property Development", Uri="&subclassification=1546" },
				new RealEstateProperty { Name = "Valuation", Uri="&subclassification=6007" },
				new RealEstateProperty { Name = "", Uri="" },
			};
		}
	}
}