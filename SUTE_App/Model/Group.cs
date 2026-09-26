using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTE_App.Model
{
    internal class Group
    {
        private Guid GroupID;
        private string GroupCode;
        private DateTime CreatedAt;
        private Speciality Speciality;
        private List<Student> Students;
        private Student highStudent;
        private StudentEducationForm EducationForm;
    }
}
