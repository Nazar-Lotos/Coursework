using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coursework
{
    public partial class fMain : Form
    {
        private List<Employee> employees = new List<Employee> ();
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvEmployees.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "fullName";
            column.Name = "Full name";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "dateOfBirth";
            column.Name = "Date of birth";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "sex",
                HeaderText = "Sex",
                DataSource = new[]
                {
                    new { Value = false, Display = "Male" },
                    new { Value = true, Display = "Female" }
                },
                ValueMember = "Value",
                DisplayMember = "Display",
            };
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "passportData";
            column.Name = "Passport data";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "education";
            column.Name = "Education";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "specialty";
            column.Name = "Specialty";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "department";
            column.Name = "Department";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "position";
            column.Name = "Position";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "salary";
            column.Name = "Salary";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "dateOfEmployment";
            column.Name = "Date of employment";
            gvEmployees.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "lastPromotionDate";
            column.Name = "Last promotion date";
            gvEmployees.Columns.Add(column);

            employees.Add(new Employee("John Fitzgerald Kennedy", new DateTime(1917, 5, 29), false, "039868734", 
                "High School Diploma", "IT", "IT", "Leader", 3000, new DateTime(2011, 10, 13), new DateTime(2022, 11, 15)));
            employees.Add(new Employee("Alice Johnson", new DateTime(1985, 8, 12), true, "125679384", "Bachelor’s Degree", 
                "Marketing", "Sales", "Manager", 4500, new DateTime(2015, 4, 10), new DateTime(2019, 5, 18)));
            employees.Add(new Employee("Michael Brown", new DateTime(1990, 3, 22), false, "768943012", "Master’s Degree", 
                "Finance", "Finance", "Director", 7200, new DateTime(2012, 6, 1), new DateTime(2018, 3, 12)));
            employees.Add(new Employee("Emily White", new DateTime(1995, 12, 5), true, "328907645", "PhD or Doctorate", 
                "IT", "IT", "Chief Officer", 9500, new DateTime(2016, 9, 15), new DateTime(2021, 7, 20)));
            employees.Add(new Employee("Robert Davis", new DateTime(1988, 11, 3), false, "980123457", "High School Diploma", 
                "Engineering", "Operations", "Senior", 3200, new DateTime(2010, 5, 11), new DateTime(2020, 2, 19)));
            employees.Add(new Employee("Sophia Martinez", new DateTime(1992, 7, 16), true, "657839024", "Associate Degree", 
                "Design", "Marketing", "Specialist", 2800, new DateTime(2014, 8, 23), new DateTime(2019, 3, 8)));
            employees.Add(new Employee("James Wilson", new DateTime(1983, 4, 29), false, "758903246", "Bachelor’s Degree", 
                "Human Resources", "HR", "Manager", 4100, new DateTime(2009, 1, 20), new DateTime(2016, 11, 25)));
            employees.Add(new Employee("Isabella Anderson", new DateTime(1998, 9, 11), true, "283764509", "Master’s Degree", 
                "Sales", "Sales", "Senior", 3300, new DateTime(2020, 2, 12), new DateTime(2022, 6, 15)));
            employees.Add(new Employee("Ethan Thomas", new DateTime(1979, 2, 14), false, "984763210", "High School Diploma", 
                "Operations", "Operations", "Junior", 2500, new DateTime(2008, 10, 8), new DateTime(2015, 4, 6)));
            employees.Add(new Employee("Mia Lee", new DateTime(1991, 6, 7), true, "123984756", "PhD or Doctorate", "IT", "IT", 
                "Lead", 8600, new DateTime(2017, 3, 14), new DateTime(2021, 10, 20)));
            employees.Add(new Employee("Lucas Clark", new DateTime(1987, 5, 18), false, "347890124", "Bachelor’s Degree", 
                "Finance", "Finance", "Specialist", 3900, new DateTime(2011, 7, 21), new DateTime(2019, 9, 17)));
            employees.Add(new Employee("Emma Harris", new DateTime(1982, 10, 27), true, "786092143", "Master’s Degree", 
                "Marketing", "Marketing", "Director", 6700, new DateTime(2007, 12, 3), new DateTime(2016, 1, 15)));
            employees.Add(new Employee("Ivan Petrov", new DateTime(1958, 3, 12), false, "876543210", "Bachelor’s Degree", 
                "Finance", "Accounting", "Accountant", 2500, new DateTime(2001, 5, 20), new DateTime(2018, 7, 15)));
            employees.Add(new Employee("Olga Shevchenko", new DateTime(1960, 7, 4), true, "123456789", "High School Diploma", 
                "Logistics", "Warehouse", "Manager", 2000, new DateTime(1995, 9, 10), new DateTime(2017, 2, 1)));
            employees.Add(new Employee("Mykola Kravchuk", new DateTime(1961, 11, 22), false, "987654321", "Master’s Degree", 
                "IT", "Development", "Software Engineer", 3200, new DateTime(1998, 4, 5), new DateTime(2020, 11, 18)));
            employees.Add(new Employee("Larysa Moroz", new DateTime(1957, 2, 1), true, "192837465", "Associate Degree", "HR", 
                "Recruitment", "HR Specialist", 1800, new DateTime(1990, 12, 20), new DateTime(2015, 6, 30)));
            employees.Add(new Employee("Viktor Bondarenko", new DateTime(1963, 8, 15), false, "567890123", "PhD or Doctorate", 
                "Research", "R&D", "Researcher", 4000, new DateTime(1989, 3, 10), new DateTime(2021, 8, 25)));
            employees.Add(new Employee("Alexander Walker", new DateTime(1976, 8, 31), false, "348761092", "Associate Degree", 
                "Engineering", "Engineering", "Intern", 1800, new DateTime(2005, 6, 10), new DateTime(2009, 9, 12)));
            employees.Add(new Employee("Olivia Hall", new DateTime(1993, 11, 20), true, "239847560", "High School Diploma", "IT", 
                "IT", "Junior", 3100, new DateTime(2019, 5, 19), new DateTime(2022, 11, 10)));
            employees.Add(new Employee("Benjamin Young", new DateTime(1986, 3, 4), false, "897634502", "Bachelor’s Degree", "HR", 
                "HR", "Leader", 4400, new DateTime(2012, 9, 22), new DateTime(2020, 6, 30)));
            employees.Add(new Employee("Charlotte Adams", new DateTime(1989, 12, 14), true, "409876341", "Master’s Degree", "Sales", 
                "Sales", "Chief Officer", 9100, new DateTime(2013, 11, 1), new DateTime(2020, 4, 12)));
            employees.Add(new Employee("Henry Baker", new DateTime(1980, 7, 25), false, "129348765", "High School Diploma", 
                "Operations", "Operations", "Specialist", 2600, new DateTime(2006, 8, 19), new DateTime(2014, 3, 5)));
            employees.Add(new Employee("Ava Turner", new DateTime(1996, 1, 6), true, "673829045", "PhD or Doctorate", "Finance", 
                "Finance", "Director", 7900, new DateTime(2018, 6, 9), new DateTime(2022, 12, 22)));
            employees.Add(new Employee("Daniel Hill", new DateTime(1984, 9, 13), false, "476589302", "Associate Degree", 
                "Marketing", "Marketing", "Manager", 4200, new DateTime(2010, 11, 25), new DateTime(2017, 8, 30)));
            employees.Add(new Employee("Andriy Melnyk", new DateTime(1965, 4, 10), false, "345678901", "Master’s Degree", 
                "Engineering", "Design", "Mechanical Engineer", 2800, new DateTime(1992, 6, 15), new DateTime(2019, 12, 5)));
            employees.Add(new Employee("Amelia Scott", new DateTime(1994, 2, 28), true, "837490125", "Bachelor’s Degree", 
                "Engineering", "Engineering", "Leader", 5000, new DateTime(2020, 10, 10), new DateTime(2023, 1, 18)));
            employees.Add(new Employee("Sebastian Green", new DateTime(1981, 4, 21), false, "234987650", "Master’s Degree", "IT", 
                "IT", "Senior", 3500, new DateTime(2009, 7, 12), new DateTime(2016, 5, 8)));
            employees.Add(new Employee("Grace Phillips", new DateTime(1988, 6, 30), true, "890123476", "High School Diploma", 
                "Design", "Marketing", "Specialist", 2700, new DateTime(2014, 4, 17), new DateTime(2020, 2, 25)));
            employees.Add(new Employee("Matthew Carter", new DateTime(1978, 11, 10), false, "123908745", "PhD or Doctorate", 
                "Finance", "Finance", "Chief Officer", 9400, new DateTime(2003, 5, 6), new DateTime(2018, 3, 14)));
            employees.Add(new Employee("Sofia Perez", new DateTime(1997, 10, 15), true, "908347562", "Bachelor’s Degree", "HR", 
                "HR", "Manager", 4600, new DateTime(2018, 12, 24), new DateTime(2022, 7, 9)));
            employees.Add(new Employee("William Lopez", new DateTime(1985, 5, 9), false, "567839024", "Master’s Degree", "IT", 
                "IT", "Director", 8200, new DateTime(2015, 9, 10), new DateTime(2021, 6, 30)));

            bindSrcEmployees.DataSource = employees;
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            fEmployee fe = new fEmployee(employee);
            if(fe.ShowDialog() == DialogResult.OK) 
            {
                bindSrcEmployees.Add(employee);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)bindSrcEmployees.List[bindSrcEmployees.Position];

            fEmployee fe = new fEmployee(ref employee);
            if(fe.ShowDialog() == DialogResult.OK)
            {
                bindSrcEmployees.List[bindSrcEmployees.Position] = employee;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Видалити поточний запис?", "Видалення запису", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcEmployees.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            {
                bindSrcEmployees.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Закрити застосунок?", "Вихід з програми", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK ) 
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Employee employee in bindSrcEmployees.List)
                    {
                        sw.Write(employee.fullName + "\t" + employee.dateOfBirth.ToString("dd.MM.yyyy") + "\t" +
                            (!employee.sex ? "Male" : "Female") + "\t" + employee.passportData + "\t" +
                                 employee.education + "\t" + employee.specialty + "\t" + employee.department + "\t" +
                                 employee.position + "\t" + employee.salary + "\t" + employee.dateOfEmployment.ToString("dd.MM.yyyy") + "\t" + 
                                 employee.lastPromotionDate.ToString("dd.MM.yyyy") + "\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка: \n{ex.Message}",
                                    "Помилка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            if (cbSotring.SelectedItem == null)
                return;

            bool isAsc = ((cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "ASC") ? true : false);
            switch(cbSotring.SelectedItem.ToString())
            {
                case "Full name":
                    if(isAsc)
                        employees.Sort((x,y) => string.Compare(x.fullName, y.fullName));
                    else
                        employees.Sort((x, y) => string.Compare(y.fullName, x.fullName));
                    break;
                case "Date of birth":
                    if(isAsc)
                        employees.Sort((x,y) => x.dateOfBirth.CompareTo(y.dateOfBirth));
                    else
                        employees.Sort((x, y) => y.dateOfBirth.CompareTo(x.dateOfBirth));
                    break;
                case "Salary":
                    if(isAsc)
                        employees.Sort((x,y) => x.salary.CompareTo(y.salary));
                    else
                        employees.Sort((x, y) => y.salary.CompareTo(x.salary));
                    break;
                case "Date of employment":
                    if(isAsc)
                        employees.Sort((x,y) => x.dateOfEmployment.CompareTo(y.dateOfEmployment));
                    else
                        employees.Sort((x, y) => y.dateOfEmployment.CompareTo(x.dateOfEmployment));
                    break;
                case "Last promotion date":
                    if(isAsc)
                        employees.Sort((x,y) => x.lastPromotionDate.CompareTo(y.lastPromotionDate));
                    else
                        employees.Sort((x, y) => y.lastPromotionDate.CompareTo(x.lastPromotionDate));
                    break;
            }

            bindSrcEmployees.DataSource = employees;
            bindSrcEmployees.ResetBindings(false);
        }

        private void btnFiltering_Click(object sender, EventArgs e)
        {
            if ((cbFiltering1.SelectedItem == null || tbValue1.Text == "") && (cbFiltering2.SelectedItem == null || tbValue2.Text == ""))
                return;

            IEnumerable<Employee> filteredList = employees; 
            if(cbFiltering1.SelectedItem != null && tbValue1.Text != "")
            {
                switch(cbFiltering1.SelectedItem.ToString())
                {
                    case "Sex":
                        filteredList = filteredList.Where(emp => emp.sex == (tbValue1.Text == "Male" ? false : true));
                        break;
                    case "Education":
                        filteredList = filteredList.Where(emp => emp.education == tbValue1.Text);
                        break;
                    case "Specialty":
                        filteredList = filteredList.Where(emp => emp.specialty == tbValue1.Text);
                        break;
                    case "Department":
                        filteredList = filteredList.Where(emp => emp.department == tbValue1.Text);
                        break;
                    case "Position":
                        filteredList = filteredList.Where(emp => emp.position == tbValue1.Text);
                        break;
                }
            }

            if (cbFiltering2.SelectedItem != null && tbValue2.Text != "")
            {
                switch (cbFiltering2.SelectedItem.ToString())
                {
                    case "Sex":
                        filteredList = filteredList.Where(emp => emp.sex == (tbValue2.Text == "Male" ? false : true));
                        break;
                    case "Education":
                        filteredList = filteredList.Where(emp => emp.education == tbValue2.Text);
                        break;
                    case "Specialty":
                        filteredList = filteredList.Where(emp => emp.specialty == tbValue2.Text);
                        break;
                    case "Department":
                        filteredList = filteredList.Where(emp => emp.department == tbValue2.Text);
                        break;
                    case "Position":
                        filteredList = filteredList.Where(emp => emp.position == tbValue2.Text);
                        break;
                }
            }

            bindSrcEmployees.DataSource = filteredList;
            bindSrcEmployees.ResetBindings(false);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bindSrcEmployees.DataSource = employees;
            bindSrcEmployees.ResetBindings(false);
        }

        private void btnFinding_Click(object sender, EventArgs e)
        {
            if (tbFindingName.Text == "" && tbFindingPassport.Text == "")
                return;

            Employee employee = new Employee();
            if(tbFindingName.Text != "" && tbFindingPassport.Text != "")
                employee = employees.Find(emp => emp.fullName == tbFindingName.Text && emp.passportData == tbFindingPassport.Text);
            else if (tbFindingName.Text != "")
                employee = employees.Find(emp => emp.fullName == tbFindingName.Text);
            else
                employee = employees.Find(emp => emp.passportData == tbFindingPassport.Text);

            bindSrcEmployees.DataSource = employee;
            bindSrcEmployees.ResetBindings(false);
        }

        private void btnResetFind_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private List<Person> GetRetirementCandidates()
        {
            int retirementAge = int.Parse(tbRetirementAge.Text == "" ? "60" : tbRetirementAge.Text); 
            int preRetirementThreshold = 5;

            List<Person> candidates = employees.Where(emp => emp.GetAge() >= retirementAge || 
            emp.GetAge() >= (retirementAge - preRetirementThreshold)).Cast<Person>().ToList();

            return candidates;
        }

        private string GenerateOrder(List<Person> candidates)
        {
            StringBuilder order = new StringBuilder();
            order.AppendLine("Наказ про скорочення штатів");
            order.AppendLine($"Дата: {DateTime.Now.ToShortDateString()}");
            order.AppendLine(new string('-', 40));
            order.AppendLine("До звільнення підлягають:");

            foreach (var emp in candidates)
            {
                emp.ShowDetails(order);
                order.AppendLine();
            }

            order.AppendLine(new string('-', 40));
            order.AppendLine("Наказ підписано директором.");
            return order.ToString();
        }

        private void btnGenerateOrder_Click(object sender, EventArgs e)
        {
            var candidates = GetRetirementCandidates();
            string order = GenerateOrder(candidates);

            fOrder orderForm = new fOrder();
            orderForm.SetOrderText(order);
            orderForm.ShowDialog();
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*) | *.* ";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcEmployees.Clear();
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;

                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Employee employee = new Employee(split[0], DateTime.ParseExact(split[1].Trim(), "dd.MM.yyyy", null), 
                            (split[2] == "Male" ? false : true), split[3], split[4], split[5], split[6], split[7], double.Parse(split[8]), 
                            DateTime.ParseExact(split[9].Trim(), "dd.MM.yyyy", null), DateTime.ParseExact(split[10].Trim(), "dd.MM.yyyy", null));
                        bindSrcEmployees.Add(employee);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }
    }
}
