using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class TradesServices
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<TradesServices> CreateList()
		{
			return new List<TradesServices>
			{
				new TradesServices { Name = "All Trades & Services", Uri="&subclassification=1313" },
				new TradesServices { Name = "Air Conditioning & Refrigeration", Uri="&subclassification=1328" },
				new TradesServices { Name = "Automotive Trades", Uri="&subclassification=6226" },
				new TradesServices { Name = "Bakers & Pastry Chefs", Uri="&subclassification=6227" },
				new TradesServices { Name = "Building Trades", Uri="&subclassification=6228" },
				new TradesServices { Name = "Butchers", Uri="&subclassification=1345" },
				new TradesServices { Name = "Carpentry & Cabinet Making", Uri="&subclassification=6229" },
				new TradesServices { Name = "Cleaning Services", Uri="&subclassification=6230" },
				new TradesServices { Name = "Electricians", Uri="&subclassification=6231" },
				new TradesServices { Name = "Fitters, Turners & Machinists", Uri="&subclassification=6232" },
				new TradesServices { Name = "Floristry", Uri="&subclassification=1406" },
				new TradesServices { Name = "Gardening & Landscaping", Uri="&subclassification=6233" },
				new TradesServices { Name = "Hair & Beauty Services", Uri="&subclassification=6234" },
				new TradesServices { Name = "Labourers", Uri="&subclassification=6235" },
				new TradesServices { Name = "Locksmiths", Uri="&subclassification=6236" },
				new TradesServices { Name = "Maintenance & Handyperson Services", Uri="&subclassification=6237" },
				new TradesServices { Name = "Nannies & Babysitters", Uri="&subclassification=6238" },
				new TradesServices { Name = "Painters & Sign Writers", Uri="&subclassification=6240" },
				new TradesServices { Name = "Plumbers", Uri="&subclassification=6239" },
				new TradesServices { Name = "Printing & Publishing Services", Uri="&subclassification=6241" },
				new TradesServices { Name = "Security Services", Uri="&subclassification=6242" },
				new TradesServices { Name = "Tailors & Dressmakers", Uri="&subclassification=6243" },
				new TradesServices { Name = "Technicians", Uri="&subclassification=6244" },
				new TradesServices { Name = "Welders & Boilermakers", Uri="&subclassification=6245" },
			};
		}
	}
}