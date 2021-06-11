using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EducationalBackgrounds
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public string FieldOfStudy { get; set; }
        public string LevelOfEducation { get; set; }
        public string EducationPlace { get; set; }
        public string TypeOfUniversity { get; set; }
        public string YearOfGraduation { get; set; }
        public double Average { get; set; }
        public int PersonId { get; set; }

        public People Person { get; set; }
    }
}
