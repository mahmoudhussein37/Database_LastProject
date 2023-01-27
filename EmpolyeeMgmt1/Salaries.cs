using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpolyeeMgmt1
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployee();
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTB1";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        private void GetEmployee()
        {
            string Query = "Select * from Employee";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "Select EmpSal from Employee where EmpName = {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
           // MessageBox.Show("" + DSal);
           
        }



        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }
    }
}
