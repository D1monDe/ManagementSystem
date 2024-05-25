using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ManagementSystem
{
    internal class SalaryData
    {
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Position { set; get; }
        public string Contact { set; get; }
        public string EmployeeID { set; get; }
        public int Salary { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Евгений\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.Name = reader["full_name"].ToString();
                            sd.Gender = reader["gender"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Contact = reader["contact_number"].ToString();
                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Salary = (int)reader["salary"];

                            listdata.Add(sd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
