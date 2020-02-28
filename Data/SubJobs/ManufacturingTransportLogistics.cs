using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class ManufacturingTransportLogistics
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<ManufacturingTransportLogistics> CreateList()
		{
			return new List<ManufacturingTransportLogistics>
			{
				new ManufacturingTransportLogistics { Name = "All Manufacturing, Transport & Logistics", Uri="&subclassification=6095" },
				new ManufacturingTransportLogistics { Name = "Analysis & Reporting", Uri="&subclassification=6093" },
				new ManufacturingTransportLogistics { Name = "Assembly & Process Work", Uri="&subclassification=6094" },
				new ManufacturingTransportLogistics { Name = "Aviation Services", Uri="&subclassification=6096" },
				new ManufacturingTransportLogistics { Name = "Couriers, Drivers & Postal Services", Uri="&subclassification=6097" },
				new ManufacturingTransportLogistics { Name = "Fleet Management", Uri="&subclassification=6098" },
				new ManufacturingTransportLogistics { Name = "Freight/Cargo Forwarding", Uri="&subclassification=6099" },
				new ManufacturingTransportLogistics { Name = "Import/Export & Customs", Uri="&subclassification=6101" },
				new ManufacturingTransportLogistics { Name = "Machine Operators", Uri="&subclassification=6102" },
				new ManufacturingTransportLogistics { Name = "Management", Uri="&subclassification=6104" },
				new ManufacturingTransportLogistics { Name = "Pattern Makers & Garment Technicians", Uri="&subclassification=6105" },
				new ManufacturingTransportLogistics { Name = "Pickers & Packers", Uri="&subclassification=6103" },
				new ManufacturingTransportLogistics { Name = "Production, Planning & Scheduling", Uri="&subclassification=6100" },
				new ManufacturingTransportLogistics { Name = "Public Transport & Taxi Services", Uri="&subclassification=6109" },
				new ManufacturingTransportLogistics { Name = "Purchasing, Procurement & Inventory", Uri="&subclassification=6106" },
				new ManufacturingTransportLogistics { Name = "Quality Assurance & Control", Uri="&subclassification=6110" },
				new ManufacturingTransportLogistics { Name = "Rail & Maritime Transport", Uri="&subclassification=6111" },
				new ManufacturingTransportLogistics { Name = "Road Transport", Uri="&subclassification=6107" },
				new ManufacturingTransportLogistics { Name = "Team Leaders/Supervisors", Uri="&subclassification=6108" },
				new ManufacturingTransportLogistics { Name = "Warehousing, Storage & Distribution", Uri="&subclassification=6112" },
			};
		}
	}
}