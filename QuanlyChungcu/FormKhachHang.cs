using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
//using DataConnect;   //kết nối đến cơ sở dữ liệu

namespace QuanlyChungcu
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        //DataConnect này là static class trong project QuanlyChungCu, ko liên quan đến project DataConnect
        //ko xóa project DataConnect
        public void loadDataKH()
        {
            datagridViewKhachHang.DataSource = DataConnect.GetData("SELECT * FROM KhachHang", null);
            datagridViewKhachHang.AllowUserToAddRows = false;    //ẩn dòng trắng cuối
            datagridViewKhachHang.RowHeadersVisible = false;     //ẩn cột trắng đầu
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadDataKH();
        }
        private void insert()
        {
            SqlCommand cmd = new SqlCommand();
            cmd = DataConnect.createCommand();
            cmd.CommandText = "insert KhachHang(maKH, tenKH, CCCD, QueQuan, NgaySinh, GioiTinh) values (@maKH, @TenKH, @CCCD, @QueQuan, @NgaySinh, @GioiTinh)";
            cmd.Parameters.Add(new SqlParameter("@maKH", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@tenKH", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@CCCD", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@QueQuan", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", textBox6.Text));

            DataConnect.Open();
            cmd.ExecuteNonQuery();
            DataConnect.Close();
            textBox1.Text = "ok";
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            insert();
            loadDataKH();
        }
    }
}
