using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace khuong18i1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = null;

        SqlCommand cmd = null;
        SqlDataAdapter da;
        DataSet ds;


        public void ConnectDB()
        {try
            {
                conn = new SqlConnection("Data Source =DESKTOP-48ME44I;Initial Catalog=btC;Integrated Security =SSPI");
                conn.Open();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            FilldgrKQ();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectDB();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into ThongTin values(@ID,@cpname,@ctname,@cttitle,@address,@city,@region,@code,@country,@phone,@fax)";
                cmd.Parameters.Add("@Id", SqlDbType.NChar).Value = txtID.Text;
                cmd.Parameters.Add("@cpname", SqlDbType.NVarChar).Value = txtCPName.Text;
                cmd.Parameters.Add("@ctname", SqlDbType.NVarChar).Value =txtCTName.Text;
                cmd.Parameters.Add("@cttitle", SqlDbType.NVarChar).Value = txtTitle.Text;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                cmd.Parameters.Add("@region", SqlDbType.NVarChar).Value = txtRegion.Text;
                cmd.Parameters.Add("@code", SqlDbType.NChar).Value = txtcode.Text;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = txtCountry.Text;
                cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = txtPhone.Text;
                cmd.Parameters.Add("@fax", SqlDbType.NChar).Value = txtFax.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0) MessageBox.Show("success");
                else MessageBox.Show("Fail");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectDB();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from ThongTin where CustomerId= '" +txtID.Text+"'";
                int n = cmd.ExecuteNonQuery();
                if (n > 0) MessageBox.Show("success");
                else MessageBox.Show("Fail");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FilldgrKQ()
        {
            try
            {
                ConnectDB();
                da = new SqlDataAdapter("select * from KetQua", conn);
                ds = new DataSet();
                da.Fill(ds);
                dgrKQ.ItemsSource = ds.Tables[0].DefaultView;
                dgrKQ.DisplayMemberPath = "CustomerID";
                dgrKQ.SelectedValuePath = "OrderID";
                conn.Close();
                da.Dispose();
                ds.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            var load = new MainWindow();
            load.Show();
            this.Hide();
        }
    

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            String OrderID = dgrKQ.SelectedValuePath.ToString();
            cmd.CommandText = "Update ThongTin Set region = '" + txtRegion.Text + "' Where CustomerId = '" + txtID.Text + "' ";
            int n = cmd.ExecuteNonQuery();
            if (n > 0) MessageBox.Show("Success");
            else MessageBox.Show("Fail");
            conn.Close();
            cmd.Dispose();
        }
    }
    
}
