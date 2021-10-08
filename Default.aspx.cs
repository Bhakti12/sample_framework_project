using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection cmd = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Lab14110\Documents\Visual Studio 2010\WebSites\WebSite1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        cmd.Open();
        SqlCommand c = new SqlCommand("insert into user(name,city,username,password) values(@n,@c,@u,@p)",cmd);
        c.Parameters.AddWithValue("@n",TextBox5.Text);
        c.Parameters.AddWithValue("@c",TextBox2.Text);
        c.Parameters.AddWithValue("@u",TextBox3.Text);
        c.Parameters.AddWithValue("@p",TextBox6.Text);
        c.ExecuteNonQuery();
        lblmsg.Text = "Data inserted successfully";
        cmd.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection cmd = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=Integrated Security=True;User Instance=True");
        cmd.Open();
        SqlCommand c = new SqlCommand("update user set name=@n,city=@c,username=@u,password=@p where name=@n", cmd);
        c.Parameters.AddWithValue("@n", TextBox5.Text);
        c.Parameters.AddWithValue("@c", TextBox2.Text);
        c.Parameters.AddWithValue("@u", TextBox3.Text);
        c.Parameters.AddWithValue("@p", TextBox6.Text);
        c.ExecuteNonQuery();
        lblmsg.Text = "Data updated successfully";
        cmd.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection cmd = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Lab14110\Documents\Visual Studio 2010\WebSites\WebSite1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        cmd.Open();
        SqlCommand c = new SqlCommand("Delete from user where name=@n", cmd);
        c.ExecuteNonQuery();
        lblmsg.Text = "Data deleted successfully";
        cmd.Close();
    }
}