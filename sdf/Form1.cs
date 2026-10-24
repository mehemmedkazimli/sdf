using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sdf
{
    public partial class Form1 : Form
    {
        // Sənəd tələbi: EmployeeServiceBase service = new EmployeeService();[cite: 4]
        private EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
            YenileSiyahini();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Xahiş olunur bütün xanaları doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yash;
            bool yashDuzgundur = int.TryParse(txtAge.Text, out yash);

            if (yashDuzgundur == false || yash <= 0)
            {
                MessageBox.Show("Düzgün yaş daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee emp = new Employee();
            emp.Code = txtCode.Text.Trim();
            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtLastName.Text.Trim();
            emp.Age = yash;

            bool elaveOlundu = service.AddEmployee(emp);

            if (elaveOlundu == true)
            {
                MessageBox.Show("İşçi uğurla əlavə olundu!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCode.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();

                YenileSiyahini();
            }
            else
            {
                MessageBox.Show("Bu koda malik işçi artıq var!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem == null)
            {
                MessageBox.Show("Xahiş olunur bir işçi seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPayTitle.Text == "" || txtPayAmount.Text == "")
            {
                MessageBox.Show("Ödəniş adını və məbləğini daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double meblegh;
            bool mebleghDuzgundur = double.TryParse(txtPayAmount.Text, out meblegh);

            if (mebleghDuzgundur == false || meblegh <= 0)
            {
                MessageBox.Show("Düzgün məbləğ daxil edin (0-dan böyük olmalıdır)!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string secilmisKod = cmbEmployees.SelectedItem.ToString().Split('-')[0].Trim();

            bool odenisElaveEdildi = service.AddPayment(secilmisKod, txtPayTitle.Text.Trim(), meblegh);

            if (odenisElaveEdildi)
            {
                MessageBox.Show("Ödəniş uğurla qeydə alındı!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayTitle.Clear();
                txtPayAmount.Clear();
                YenileOdenisCedvelini(secilmisKod);
            }
            else
            {
                MessageBox.Show("Ödəniş əlavə edilə bilmədi!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchStat_Click(object sender, EventArgs e)
        {
            string kod = txtSearchCode.Text.Trim();

            if (kod == "")
            {
                MessageBox.Show("Axtarmaq üçün işçi kodunu yazın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee emp = service.FindEmployee(kod);

            if (emp != null)
            {
                lblStatInfo.Text = "Kod: " + emp.Code + " | Ad: " + emp.FirstName + " | Soyad: " + emp.LastName + " | Yaş: " + emp.Age;

                dgvStatPayments.DataSource = null;
                dgvStatPayments.DataSource = service.GetEmployeePayments(kod);
            }
            else
            {
                lblStatInfo.Text = "İşçi Məlumatı: ---";
                dgvStatPayments.DataSource = null;
                MessageBox.Show("Belə koda malik işçi tapılmadı!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Sistemdən çıxmaq istəyirsiniz?", "Çıxış Təsdiqi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem != null)
            {
                string secilmisKod = cmbEmployees.SelectedItem.ToString().Split('-')[0].Trim();
                YenileOdenisCedvelini(secilmisKod);
            }
        }

        private void YenileSiyahini()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = service.GetAllEmployees();

            cmbEmployees.Items.Clear();
            foreach (Employee emp in service.GetAllEmployees())
            {
                cmbEmployees.Items.Add(emp.Code + " - " + emp.FirstName + " " + emp.LastName);
            }
        }

        private void YenileOdenisCedvelini(string kod)
        {
            dgvPaymentHistory.DataSource = null;
            List<Payment> odenisler = service.GetEmployeePayments(kod);
            if (odenisler != null)
            {
                dgvPaymentHistory.DataSource = odenisler;
            }
        }
    }
}