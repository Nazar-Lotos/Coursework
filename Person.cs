using System;
using System.Text;

namespace Coursework
{
    public abstract class Person : Age
    {
        public string fullName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool sex { get; set; }

        public Person()
        { }

        public Person(string fullName, DateTime dateOfBirth, bool sex)
        {
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year -
                (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear ? 1 : 0);
        }
        public virtual string GetDetails()
        {
            string details = $"Full Name: {fullName}\n" +
                             $"Date of Birth: {dateOfBirth.ToShortDateString()}\n" +
                             $"Age: {GetAge()} years\n";

            return details;
        }

        public virtual void ShowDetails(StringBuilder sb)
        {
            sb.Append(GetDetails());
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string value)
        {
            fullName = value;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetDateOfBirth(DateTime value)
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Дата народження не може бути в майбутньому.");
            dateOfBirth = value;
        }

        public bool GetSex()
        {
            return sex;
        }

        public void SetSex(bool value)
        {
            sex = value;
        }
    }
}
