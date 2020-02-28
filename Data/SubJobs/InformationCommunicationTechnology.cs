using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class InformationCommunicationTechnology
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<InformationCommunicationTechnology> CreateList()
		{
			return new List<InformationCommunicationTechnology>
			{
				new InformationCommunicationTechnology { Name = "All Information & Communication Technology", Uri="&subclassification=6282" },
				new InformationCommunicationTechnology { Name = "Architects", Uri="&subclassification=6283" },
				new InformationCommunicationTechnology { Name = "Business/Systems Analysts", Uri="&subclassification=6284" },
				new InformationCommunicationTechnology { Name = "Computer Operators", Uri="&subclassification=6285" },
				new InformationCommunicationTechnology { Name = "Consultants", Uri="&subclassification=6286" },
				new InformationCommunicationTechnology { Name = "Database Development & Administration", Uri="&subclassification=6287" },
				new InformationCommunicationTechnology { Name = "Developers/Programmers", Uri="&subclassification=6288" },
				new InformationCommunicationTechnology { Name = "Engineering - Hardware", Uri="&subclassification=6289" },
				new InformationCommunicationTechnology { Name = "Engineering - Network", Uri="&subclassification=6290" },
				new InformationCommunicationTechnology { Name = "Engineering - Software", Uri="&subclassification=6291" },
				new InformationCommunicationTechnology { Name = "Help Desk & IT Support", Uri="&subclassification=6292" },
				new InformationCommunicationTechnology { Name = "Management", Uri="&subclassification=6293" },
				new InformationCommunicationTechnology { Name = "Networks & Systems Administration", Uri="&subclassification=6294" },
				new InformationCommunicationTechnology { Name = "Product Management & Development", Uri="&subclassification=6295" },
				new InformationCommunicationTechnology { Name = "Programme & Project Management", Uri="&subclassification=6296" },
				new InformationCommunicationTechnology { Name = "Sales - Pre & Post", Uri="&subclassification=6297" },
				new InformationCommunicationTechnology { Name = "Security", Uri="&subclassification=6298" },
				new InformationCommunicationTechnology { Name = "Team Leaders", Uri="&subclassification=6299" },
				new InformationCommunicationTechnology { Name = "Technical Writing", Uri="&subclassification=6300" },
				new InformationCommunicationTechnology { Name = "Telecommunications", Uri="&subclassification=6301" },
				new InformationCommunicationTechnology { Name = "Testing & Quality Assurance", Uri="&subclassification=6302" },
				new InformationCommunicationTechnology { Name = "Web Development & Production", Uri="&subclassification=6303" },
			};
		}
	}
}