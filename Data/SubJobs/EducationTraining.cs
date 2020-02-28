using System.Collections.Generic;

namespace Seek.Data.SubJobs
{
	public class EducationTraining
	{
		public string Name { get; set; }
		public string Uri { get; set; }

		public static List<EducationTraining> CreateList()
		{
			return new List<EducationTraining>
			{
				new EducationTraining { Name = "All Education & Training", Uri="&subclassification=6124" },
				new EducationTraining { Name = "Childcare & Outside School Hours Care", Uri="&subclassification=6125" },
				new EducationTraining { Name = "Library Services & Information Management", Uri="&subclassification=6126" },
				new EducationTraining { Name = "Management - Schools", Uri="&subclassification=6127" },
				new EducationTraining { Name = "Management - Universities", Uri="&subclassification=6128" },
				new EducationTraining { Name = "Management - Vocational", Uri="&subclassification=6129" },
				new EducationTraining { Name = "Research & Fellowships", Uri="&subclassification=6130" },
				new EducationTraining { Name = "Student Services", Uri="&subclassification=6132" },
				new EducationTraining { Name = "Teaching - Early Childhood", Uri="&subclassification=6133" },
				new EducationTraining { Name = "Teaching - Primary", Uri="&subclassification=6134" },
				new EducationTraining { Name = "Teaching - Secondary", Uri="&subclassification=6135" },
				new EducationTraining { Name = "Teaching - Tertiary", Uri="&subclassification=6136" },
				new EducationTraining { Name = "Teaching - Vocational", Uri="&subclassification=6131" },
				new EducationTraining { Name = "Teaching Aides & Special Needs", Uri="&subclassification=6137" },
				new EducationTraining { Name = "Tutoring", Uri="&subclassification=6138" },
				new EducationTraining { Name = "Workplace Training & Assessment", Uri="&subclassification=6139" },
			};
		}
	}
}