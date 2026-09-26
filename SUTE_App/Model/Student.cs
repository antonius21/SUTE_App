using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace SUTE_App.Model
{
    internal class Student
    {
        private Guid StudentID;
        private string StudentName;
        private string StudentSurname;
        private string StudentMiddleName;

        private DateTime StudentBirthDate;
        private DateTime StudentLastActivity;
        private StudentStatus StudentStatus;
        private StudentGender StudentGender;
        private StudentEducationForm StudentEducationForm;
        private StudentEducationLevel StudentEducationLevel;
        private StudentEducationType StudentEducationType;
        private StudentEducationLanguage StudentEducationLanguage;

        private Group StudentGroup;
        private Speciality Speciality;

        private string StudentEmail;
        private string StudentPhone;

        private string StudentPassportSeries;
        private string StudentPassportNumber;

        private string StudentTaxpayerIdentificationNumber;

        private List<Semestr> StudentSemestrs;
        private List<Shedule> StudentShedules;
        private List<Grade> StudentGrades;

    }
    public enum StudentStatus
    {
        Active,
        Inactive,
        Graduated,
        Expelled
    }
    public enum StudentGender
    {
        Male,
        Female,
    }
    public enum StudentEducationForm
    {
        FullTime,
        PartTime,
        DistanceLearning
    }
    public enum StudentEducationLevel
    {
        Bachelor,
        Master,
        Specialist,
        PhD
    }
    public enum StudentEducationType
    {
        Budget,
        Contract
    }
    public enum StudentEducationLanguage
    {
        Ukrainian,
        English,
        Other
    }
}
