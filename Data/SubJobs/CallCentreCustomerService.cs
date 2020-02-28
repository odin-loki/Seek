using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class CallCentreCustomerService
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<CallCentreCustomerService> CreateList()
		{
			return new List<CallCentreCustomerService>
			{
				new CallCentreCustomerService { Name = "All Call Centre & Customer Service", Uri="&subclassification=6084" },
				new CallCentreCustomerService { Name = "Collections", Uri="&subclassification=6085" },
				new CallCentreCustomerService { Name = "Customer Service - Call Centre", Uri="&subclassification=6086" },
				new CallCentreCustomerService { Name = "Customer Service - Customer Facing", Uri="&subclassification=6087" },
				new CallCentreCustomerService { Name = "Management & Support", Uri="&subclassification=6088" },
				new CallCentreCustomerService { Name = "Sales - Inbound", Uri="&subclassification=6089" },
				new CallCentreCustomerService { Name = "Sales - Outbound", Uri="&subclassification=6090" },
				new CallCentreCustomerService { Name = "Supervisors/Team Leaders", Uri="&subclassification=6091" },
			};
		}
	}
}