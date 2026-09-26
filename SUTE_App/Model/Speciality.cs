using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTE_App.Model
{
    internal class Speciality
    {
        private Guid SpcialityID;
        private string SpecialityName;
        private string SpecialityCode;
        private string SpecialityDescription;
        private string SpecialityStatus;
        private DateTime SpecialityCreatedDate;
        private string EducationLevel;
        private string ScienceArea;
        private List<Subject> Subjects;

        private List<Group> Groups;
    }
}
