using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDummyGridrow();
        }
    }

    public void BindDummyGridrow()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("FirstName");
        dt.Columns.Add("LastName");
        dt.Columns.Add("City");
        dt.Columns.Add("Country");
        gvData.DataSource = dt;
        gvData.DataBind();
    }

    [WebMethod]
    public static Employee[] BindEmployees()
    {
        string connectionString = @"Data Source=CIPL-PC72;Initial Catalog=NORTHWND;Integrated Security=True";
        DataTable dt = new DataTable();
        List<Employee> employeeList = new List<Employee>();
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("select FirstName, LastName, City, Country from Employees", con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                foreach (DataRow dtrow in dt.Rows)
                {
                    Employee employee = new Employee();
                    employee.FirstName = dtrow["FirstName"].ToString();
                    employee.LastName = dtrow["LastName"].ToString();
                    employee.City = dtrow["City"].ToString();
                    employee.Country = dtrow["Country"].ToString();
                    employeeList.Add(employee);
                }
            }
        }

        return employeeList.ToArray();
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

