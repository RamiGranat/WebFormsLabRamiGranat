using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inlamningsuppgift2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;User ID=RamiGranat1; Password=hajtech1; Integrated security=true;");

            string sqlQuery = "SELECT * FROM Production.ProductCategory";

            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);

            SqlDataReader oreader;

            try
            {
                ListItem newItem = new ListItem();
                newItem.Text = "Select";
                newItem.Value = "0";
                DropDownList1.Items.Add(newItem);
                sqlConnection.Open();
                oreader = cmd.ExecuteReader();
                while (oreader.Read())
                {
                    ListItem listItem1 = new ListItem();
                    listItem1.Text = oreader["Name"].ToString();
                    listItem1.Value = oreader["ProductCategoryID"].ToString();
                    DropDownList1.Items.Add(listItem1);
                }
                oreader.Close();
                oreader.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
            }
            /*
            datawriter

            

            SqlInsertInto(columns);
            values('value1', value2)

            */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
if (!String.IsNullOrWhiteSpace(AddToDatabase.Text))
            {
            
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;User ID=RamiGranat1; Password=hajtech1; Integrated security=true;");

                DateTime newModifiedDate = DateTime.Now;
                String myGuid = Guid.NewGuid().ToString();

                con.Open();

            String sqlQuery = "INSERT INTO Production.ProductCategory (NAME, rowguid, ModifiedDate) VALUES ('" + AddToDatabase.Text + "','" + myGuid + "','" + newModifiedDate + "')";

                SqlCommand cmd = new SqlCommand(sqlQuery, con);

            if(cmd.ExecuteNonQuery() < 1)
            {
                    ErrorLabel.Text = "Kategorien kunde tyvärr inte göras pga av databas fel";

            ErrorLabel.Visible = true;
            }
            con.Close();
            con.Dispose();
            cmd.Dispose();
            }
            else
            {

            }
        }
    }
}