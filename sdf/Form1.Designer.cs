namespace sdf
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();

            this.lblCode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();

            this.lblSelectEmp = new System.Windows.Forms.Label();
            this.lblPayTitle = new System.Windows.Forms.Label();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtPayTitle = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();

            this.lblSearchCode = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.btnSearchStat = new System.Windows.Forms.Button();
            this.lblStatInfo = new System.Windows.Forms.Label();
            this.dgvStatPayments = new System.Windows.Forms.DataGridView();

            this.btnExit = new System.Windows.Forms.Button();

            this.tabControlMain.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatPayments)).BeginInit();
            this.SuspendLayout();

            // --- TabControl ---
            this.tabControlMain.Controls.Add(this.tab1);
            this.tabControlMain.Controls.Add(this.tab2);
            this.tabControlMain.Controls.Add(this.tab3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 460);

            // --- TAB 1: İşçi Əlavə Et ---
            this.tab1.Controls.Add(this.lblCode);
            this.tab1.Controls.Add(this.txtCode);
            this.tab1.Controls.Add(this.lblFirstName);
            this.tab1.Controls.Add(this.txtFirstName);
            this.tab1.Controls.Add(this.lblLastName);
            this.tab1.Controls.Add(this.txtLastName);
            this.tab1.Controls.Add(this.lblAge);
            this.tab1.Controls.Add(this.txtAge);
            this.tab1.Controls.Add(this.btnAddEmployee);
            this.tab1.Controls.Add(this.dgvEmployees);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(776, 434);
            this.tab1.Text = "İşçi Əlavə Et";
            this.tab1.UseVisualStyleBackColor = true;

            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 25);
            this.lblCode.Text = "İşçi Kodu:";

            this.txtCode.Location = new System.Drawing.Point(90, 22);
            this.txtCode.Size = new System.Drawing.Size(130, 20);

            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 65);
            this.lblFirstName.Text = "Ad:";

            this.txtFirstName.Location = new System.Drawing.Point(90, 62);
            this.txtFirstName.Size = new System.Drawing.Size(130, 20);

            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 105);
            this.lblLastName.Text = "Soyad:";

            this.txtLastName.Location = new System.Drawing.Point(90, 102);
            this.txtLastName.Size = new System.Drawing.Size(130, 20);

            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 145);
            this.lblAge.Text = "Yaş:";

            this.txtAge.Location = new System.Drawing.Point(90, 142);
            this.txtAge.Size = new System.Drawing.Size(130, 20);

            this.btnAddEmployee.Location = new System.Drawing.Point(90, 180);
            this.btnAddEmployee.Size = new System.Drawing.Size(130, 30);
            this.btnAddEmployee.Text = "Əlavə Et";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);

            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(240, 20);
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(515, 390);

            // --- TAB 2: Ödəniş Yaz ---
            this.tab2.Controls.Add(this.lblSelectEmp);
            this.tab2.Controls.Add(this.cmbEmployees);
            this.tab2.Controls.Add(this.lblPayTitle);
            this.tab2.Controls.Add(this.txtPayTitle);
            this.tab2.Controls.Add(this.lblPayAmount);
            this.tab2.Controls.Add(this.txtPayAmount);
            this.tab2.Controls.Add(this.btnAddPayment);
            this.tab2.Controls.Add(this.dgvPaymentHistory);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(776, 434);
            this.tab2.Text = "Ödəniş Yaz";
            this.tab2.UseVisualStyleBackColor = true;

            this.lblSelectEmp.AutoSize = true;
            this.lblSelectEmp.Location = new System.Drawing.Point(20, 25);
            this.lblSelectEmp.Text = "İşçi Seç:";

            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(95, 22);
            this.cmbEmployees.Size = new System.Drawing.Size(160, 21);
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);

            this.lblPayTitle.AutoSize = true;
            this.lblPayTitle.Location = new System.Drawing.Point(20, 65);
            this.lblPayTitle.Text = "Ödəniş Adı:";

            this.txtPayTitle.Location = new System.Drawing.Point(95, 62);
            this.txtPayTitle.Size = new System.Drawing.Size(160, 20);

            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(20, 105);
            this.lblPayAmount.Text = "Məbləğ:";

            this.txtPayAmount.Location = new System.Drawing.Point(95, 102);
            this.txtPayAmount.Size = new System.Drawing.Size(160, 20);

            this.btnAddPayment.Location = new System.Drawing.Point(95, 140);
            this.btnAddPayment.Size = new System.Drawing.Size(160, 30);
            this.btnAddPayment.Text = "Ödəniş Yaz";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);

            this.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(275, 20);
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(480, 390);

            // --- TAB 3: Statistika ---
            this.tab3.Controls.Add(this.lblSearchCode);
            this.tab3.Controls.Add(this.txtSearchCode);
            this.tab3.Controls.Add(this.btnSearchStat);
            this.tab3.Controls.Add(this.lblStatInfo);
            this.tab3.Controls.Add(this.dgvStatPayments);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(776, 434);
            this.tab3.Text = "Statistika";
            this.tab3.UseVisualStyleBackColor = true;

            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.Location = new System.Drawing.Point(20, 25);
            this.lblSearchCode.Text = "İşçi Kodu:";

            this.txtSearchCode.Location = new System.Drawing.Point(90, 22);
            this.txtSearchCode.Size = new System.Drawing.Size(130, 20);

            this.btnSearchStat.Location = new System.Drawing.Point(230, 20);
            this.btnSearchStat.Size = new System.Drawing.Size(85, 24);
            this.btnSearchStat.Text = "Axtar";
            this.btnSearchStat.UseVisualStyleBackColor = true;
            this.btnSearchStat.Click += new System.EventHandler(this.BtnSearchStat_Click);

            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatInfo.Location = new System.Drawing.Point(20, 60);
            this.lblStatInfo.Text = "İşçi Məlumatı: ---";

            this.dgvStatPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatPayments.Location = new System.Drawing.Point(20, 90);
            this.dgvStatPayments.ReadOnly = true;
            this.dgvStatPayments.Size = new System.Drawing.Size(735, 320);

            // --- Çıxış Düyməsi ---
            this.btnExit.Location = new System.Drawing.Point(670, 470);
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // --- Form1 ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 510);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Ödəniş Sistemi";

            this.tabControlMain.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatPayments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tab1, tab2, tab3;

        private System.Windows.Forms.Label lblCode, lblFirstName, lblLastName, lblAge;
        private System.Windows.Forms.TextBox txtCode, txtFirstName, txtLastName, txtAge;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;

        private System.Windows.Forms.Label lblSelectEmp, lblPayTitle, lblPayAmount;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.TextBox txtPayTitle, txtPayAmount;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;

        private System.Windows.Forms.Label lblSearchCode, lblStatInfo;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Button btnSearchStat;
        private System.Windows.Forms.DataGridView dgvStatPayments;

        private System.Windows.Forms.Button btnExit;
    }
}