using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Utilities
{
    public class MainClass
    {
        public static readonly string connect = "Data Source=.;Initial Catalog=ShoeShop;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connect);
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (conn.State != ConnectionState.Closed) { conn.Open(); }
                res = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
             
            }
            return res;
        }
        public static  DataTable GetData(string qry)
        {
            SqlCommand cmd=new SqlCommand(qry, conn);
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static void LoadData(string qry,DataGridView gv, ListBox ls)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gvCellFormating);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv.DataSource = dt;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private static void gvCellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv=(Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        public static void ClearAll(Form form)
        {
            foreach(Control control in form.Controls)
            {
                Type type = control.GetType();
                if (type == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    Guna.UI2.WinForms.Guna2TextBox txt=(Guna.UI2.WinForms.Guna2TextBox)control;
                    txt.Text = "";
                }
                else if (type == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                {
                    Guna.UI2.WinForms.Guna2ComboBox cb = (Guna.UI2.WinForms.Guna2ComboBox)control;
                    cb.SelectedIndex = 0;
                    cb.SelectedIndex = -1;
                }
                else if (type == typeof(TextBox)) { 
                     ((CheckBox)control).Checked = false;
                }
            }
        }
        public static void BlurBackground(Form Model)
        {
            Form Background=new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity  = 0.5d;
        
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }
        public static void CbFill(string qry,ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            da.Fill(dt);
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
