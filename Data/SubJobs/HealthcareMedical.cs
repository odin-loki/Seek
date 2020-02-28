using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class HealthcareMedical
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<HealthcareMedical> CreateList()
		{
			return new List<HealthcareMedical>
			{
				new HealthcareMedical { Name = "All Healthcare & Medical", Uri="&subclassification=6329" },
				new HealthcareMedical { Name = "Ambulance/Paramedics", Uri="&subclassification=6330" },
				new HealthcareMedical { Name = "Chiropractic & Osteopathic", Uri="&subclassification=1353" },
				new HealthcareMedical { Name = "Clinical/Medical Research", Uri="&subclassification=1372" },
				new HealthcareMedical { Name = "Dental", Uri="&subclassification=6331" },
				new HealthcareMedical { Name = "Dieticians", Uri="&subclassification=1386" },
				new HealthcareMedical { Name = "Environmental Services", Uri="&subclassification=6332" },
				new HealthcareMedical { Name = "General Practitioners", Uri="&subclassification=6333" },
				new HealthcareMedical { Name = "Management", Uri="&subclassification=6334" },
				new HealthcareMedical { Name = "Medical Administration", Uri="&subclassification=6335" },
				new HealthcareMedical { Name = "Medical Imaging", Uri="&subclassification=6336" },
				new HealthcareMedical { Name = "Medical Specialists", Uri="&subclassification=6337" },
				new HealthcareMedical { Name = "Natural Therapies & Alternative Medicine", Uri="&subclassification=6338" },
				new HealthcareMedical { Name = "Nursing - A&E, Critical Care & ICU", Uri="&subclassification=6339" },
				new HealthcareMedical { Name = "Nursing - Aged Care", Uri="&subclassification=6340" },
				new HealthcareMedical { Name = "Nursing - Community, Maternal & Child Health", Uri="&subclassification=6341" },
				new HealthcareMedical { Name = "Nursing - Educators & Facilitators", Uri="&subclassification=6342" },
				new HealthcareMedical { Name = "Nursing - General Medical & Surgical", Uri="&subclassification=6343" },
				new HealthcareMedical { Name = "Nursing - High Acuity", Uri="&subclassification=6344" },
				new HealthcareMedical { Name = "Nursing - Management", Uri="&subclassification=6345" },
				new HealthcareMedical { Name = "Nursing - Midwifery, Neo-Natal, SCN & NICU", Uri="&subclassification=6346" },
				new HealthcareMedical { Name = "Nursing - Paediatric & PICU", Uri="&subclassification=6347" },
				new HealthcareMedical { Name = "Nursing - Psych, Forensic & Correctional Health", Uri="&subclassification=6348" },
				new HealthcareMedical { Name = "Nursing - Theatre & Recovery", Uri="&subclassification=6349" },
				new HealthcareMedical { Name = "Optical", Uri="&subclassification=1467" },
				new HealthcareMedical { Name = "Pathology", Uri="&subclassification=6350" },
				new HealthcareMedical { Name = "Pharmaceuticals & Medical Devices", Uri="&subclassification=1470" },
				new HealthcareMedical { Name = "Pharmacy", Uri="&subclassification=6352" },
				new HealthcareMedical { Name = "Physiotherapy, OT & Rehabilitation", Uri="&subclassification=6351" },
				new HealthcareMedical { Name = "Psychology, Counselling & Social Work", Uri="&subclassification=6370" },
				new HealthcareMedical { Name = "Residents & Registrars", Uri="&subclassification=6353" },
				new HealthcareMedical { Name = "Sales", Uri="&subclassification=6354" },
				new HealthcareMedical { Name = "Speech Therapy", Uri="&subclassification=6355" },
			};
		}
	}
}