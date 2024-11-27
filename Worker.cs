using System;

namespace Coursework
{
    public abstract class Worker : Person
    {
        public string passportData { get; set; }
        public string education { get; set; }
        public string specialty { get; set; }

        public Worker() 
        { }

        public Worker(string fullName, DateTime dateOfBirth, bool sex, string passportData, string education, string specialty)
            : base(fullName, dateOfBirth, sex)
        {
            this.passportData = passportData;
            this.education = education;
            this.specialty = specialty;
        }

        public override string GetDetails()
        {
            string details = base.GetDetails() + $"Passport Data: {passportData}\n" +
                             $"Education: {education}\n" +
                             $"Specialty: {specialty}\n";
                             
            return details;
        }

        public string GetPassportData()
        {
            return passportData;
        }

        public void SetPassportData(string value)
        {
            passportData = value;
        }

        public string GetEducation()
        {
            return education;
        }

        public void SetEducation(string value)
        {
            education = value;
        }

        public string GetSpecialty()
        {
            return specialty;
        }

        public void SetSpecialty(string value)
        {
            specialty = value;
        }
    }
}
