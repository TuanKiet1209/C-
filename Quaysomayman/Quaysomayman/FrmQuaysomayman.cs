using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaysomayman
{
    public partial class FrmQuaysomayman : Form
    {
        List<Employee> employees;
        EmployeeDao employeeDao;
        public FrmQuaysomayman()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "data files (*.ini)|*.ini|All files (*.*)|*.*";
            openfile.Title = "Chon file danh sach";
            openfile.InitialDirectory = Application.StartupPath;
            if(openfile.ShowDialog()==DialogResult.OK);
            {
                string path = openfile.FileName;
                employeeDao.Docfileds(path);
                employees = employeeDao.employees;
                HienThiNV();
            }
        }

        private void HienThiNV()
        {
            int i = 1;
            foreach(Employee item in employees)
            {
                item.STT = i++;
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = employees;
            dgvDSQuay.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuaysomayman_Load(object sender, EventArgs e)
        {
            employees=new List<Employee>();
            employeeDao = new EmployeeDao();
            LoadComboGiaiThuong();
        }

        private void LoadComboGiaiThuong()
        {
            GiaiThuongDao giaiThuong=new GiaiThuongDao();
            giaiThuong.Docfiledsgiai(Application.StartupPath +@"\GiaiThuong.ini");
            cboGiaiThuong.DataSource = giaiThuong.giaiThuong;
            cboGiaiThuong.DisplayMember = "TenGiai";
            cboGiaiThuong.ValueMember = "ID";
        }
        bool isOpen = true;
         private void btnQuay_Click_1(object sender, EventArgs e)
         {
             if (isOpen)
             {
                 timer1.Enabled = true;
                 btnQuay.Text = "Dung";
                 isOpen = false;
             }
             else
             {
                 timer1.Enabled = false;
                 btnQuay.Text = "Quay";
                 isOpen = true;
             }
         }

         private void TachID(int iD)
         {
             int number = iD;
             if (number > 0)
             {
                 label6.Text = (number % 10).ToString();
                 number = number / 10;
             }
             if (number > 0)
             {
                 label2.Text = (number % 10).ToString();
                 number = number / 10;
             }
             if (number > 0)
             {
                 label3.Text = (number % 10).ToString();
                 number = number / 10;
             }
             if (number > 0)
             {
                 label4.Text = (number % 10).ToString();
                 number = number / 10;
             }
             if (number > 0)
             {
                 label5.Text = (number % 10).ToString();
                 number = number / 10;
             }
         }

         private void timer1_Tick(object sender, EventArgs e)
         {
             Random rd = new Random();
             int a = rd.Next(1, employees.Count);
             TachID(employees[a].ID);
         }
    }
}
