using System;

namespace Coursework
{
    public class Employee : Worker, IComparable<Employee>
    {
        public string department { get; set; }
        public string position { get; set; }
        public double salary { get; set; }
        public DateTime dateOfEmployment { get; set; }
        public DateTime lastPromotionDate { get; set; }

        public Employee()
        {}

        public Employee(string fullName, DateTime dateOfBirth, bool sex, string passportData, string education, string specialty, 
            string department, string position, double salary, DateTime dateOfEmployment, DateTime lastPromotionDate)
            : base(fullName, dateOfBirth, sex, passportData, education, specialty)
        {
            this.department = department;
            this.position = position;
            this.salary = salary;
            this.dateOfEmployment = dateOfEmployment;
            this.lastPromotionDate = lastPromotionDate;
        }

        public override string GetDetails()
        {
            string details = base.GetDetails() +
                             $"Department: {GetDepartment()}\n" +
                             $"Position: {position}\n" +
                             $"Salary: {salary}\n" +
                             $"Date of Employment: {dateOfEmployment.ToString("dd.MM.yyyy")}\n" +
                             $"Last Promotion Date: {lastPromotionDate.ToString("dd.MM.yyyy")}\n" +
                             $"Years of Service : {CalculateYearsOfService()}\n";
            return details;
        }

        public int CalculateYearsOfService()
        {
            int yearsOfService = DateTime.Now.Year - dateOfEmployment.Year;
            if (DateTime.Now.DayOfYear < dateOfEmployment.DayOfYear)
            {
                yearsOfService--;
            }
            return yearsOfService;
        }

        public bool IsEligibleForPromotion()
        {
            int yearsOfService = CalculateYearsOfService();
            return yearsOfService >= 3; 
        }

        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string value)
        {
            department = value;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string value)
        {
            position = value;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double value)
        {
            if (value < 0)
                throw new ArgumentException("Оклад не може бути від'ємним.");
            salary = value;
        }

        public DateTime GetDateOfEmployment()
        {
            return dateOfEmployment;
        }

        public void SetDateOfEmployment(DateTime value)
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Дата прийняття на роботу не може бути в майбутньому.");
            dateOfEmployment = value;
        }

        public DateTime GetLastPromotionDate()
        {
            return lastPromotionDate;
        }

        public void SetLastPromotionDate(DateTime value)
        {
            if (value < dateOfEmployment)
                throw new ArgumentException("Дата останнього призначення не може бути раніше дати прийняття на роботу.");
            lastPromotionDate = value;
        }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1; 
            return this.fullName.CompareTo(other.fullName);
        }
    }
}
