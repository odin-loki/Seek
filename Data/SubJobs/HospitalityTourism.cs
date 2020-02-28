using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class HospitalityTourism
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<HospitalityTourism> CreateList()
		{
			return new List<HospitalityTourism>
			{
				new HospitalityTourism { Name = "All Hospitality & Tourism", Uri="&subclassification=1315" },
				new HospitalityTourism { Name = "Airlines", Uri="&subclassification=1332" },
				new HospitalityTourism { Name = "Bar & Beverage Staff", Uri="&subclassification=6052" },
				new HospitalityTourism { Name = "Chefs/Cooks", Uri="&subclassification=6053" },
				new HospitalityTourism { Name = "Front Office & Guest Services", Uri="&subclassification=1405" },
				new HospitalityTourism { Name = "Gaming", Uri="&subclassification=1415" },
				new HospitalityTourism { Name = "Housekeeping", Uri="&subclassification=6054" },
				new HospitalityTourism { Name = "Kitchen & Sandwich Hands", Uri="&subclassification=6055" },
				new HospitalityTourism { Name = "Management", Uri="&subclassification=6056" },
				new HospitalityTourism { Name = "Reservations", Uri="&subclassification=1537" },
				new HospitalityTourism { Name = "Tour Guides", Uri="&subclassification=1542" },
				new HospitalityTourism { Name = "Travel Agents/Consultants", Uri="&subclassification=1549" },
				new HospitalityTourism { Name = "Waiting Staff", Uri="&subclassification=6057" },
			};
		}
	}
}