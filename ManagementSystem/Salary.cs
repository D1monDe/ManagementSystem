using System.ComponentModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ManagementSystem
{
    [ToolboxItem(true)]
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Евгений\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();

            displayEmployees();
            disableFields();
        }
        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List <SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }
        public void disableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }
        public void clearFields()
        {
            salary_name.Text = "";
            salary_position.Text = "";
            salary_employeeID.Text = "";
            salary_salary.Text = "";
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            disableFields();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (salary_name.Text == ""
                || salary_employeeID.Text == ""
                || salary_position.Text == ""
                || salary_salary.Text == "")
            {
                MessageBox.Show("Заповніть поля", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Ви впевнені що хочете оновити ID працівника: "
                    + salary_employeeID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employees SET salary = @salary" +
                                ", update_date = @updateData WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees();

                                MessageBox.Show("Оновлено успішно!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Відмінено", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_name.Text = row.Cells[0].Value.ToString();
                salary_position.Text = row.Cells[2].Value.ToString();
                salary_employeeID.Text = row.Cells[4].Value.ToString();
                salary_salary.Text = row.Cells[5].Value.ToString();
            }   
        }
    }
}
