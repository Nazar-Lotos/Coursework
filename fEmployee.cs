using System;
using System.Windows.Forms;

namespace Coursework
{
    public partial class fEmployee : Form
    {
        public Employee TheEmployee;
        public fEmployee(Employee employee)
        {
            InitializeComponent();
            TheEmployee = employee;
        }
        public fEmployee(ref Employee employee)
        {
            InitializeComponent();
            TheEmployee = employee;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheEmployee.SetFullName(tbFullName.Text.Trim());
            TheEmployee.SetDateOfBirth(DateTime.ParseExact(tbDateOfBirth.Text.Trim(), "dd.MM.yyyy", null));
            TheEmployee.SetSex(rbFemale.Checked);
            TheEmployee.SetPassportData(tbPassportData.Text.Trim());
            TheEmployee.SetEducation(cbEducation.SelectedItem == null ? null : cbEducation.SelectedItem.ToString());
            TheEmployee.SetSpecialty(tbSpecialty.Text.Trim());
            TheEmployee.SetDepartment(tbDepartment.Text.Trim());
            TheEmployee.SetPosition(tbPosition.Text.Trim());
            TheEmployee.SetSalary(double.Parse(tbSalary.Text.Trim()));
            TheEmployee.SetDateOfEmployment(DateTime.ParseExact(tbDateOfEmployment.Text.Trim(), "dd.MM.yyyy", null));
            TheEmployee.SetLastPromotionDate(DateTime.ParseExact(tbLastPromotionDate.Text.Trim(), "dd.MM.yyyy", null));

            DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e){DialogResult = DialogResult.Cancel;}

        private void fEmployee_Load(object sender, EventArgs e)
        {
            if(TheEmployee != null)
            {
                tbFullName.Text = TheEmployee.GetFullName();
                tbDateOfBirth.Text = TheEmployee.GetDateOfBirth().ToString("dd.MM.yyyy");
                rbMale.Checked = !TheEmployee.GetSex();
                rbFemale.Checked = TheEmployee.GetSex();
                tbPassportData.Text = TheEmployee.GetPassportData();
                cbEducation.SelectedItem = TheEmployee.GetEducation();
                tbSpecialty.Text = TheEmployee.GetSpecialty();
                tbDepartment.Text = TheEmployee.GetDepartment();
                tbPosition.Text = TheEmployee.GetPosition();
                tbSalary.Text = TheEmployee.GetSalary().ToString();
                tbDateOfEmployment.Text = TheEmployee.GetDateOfEmployment().ToString("dd.MM.yyyy");
                tbLastPromotionDate.Text = TheEmployee.GetLastPromotionDate().ToString("dd.MM.yyyy");
            }
        }
    }
}
