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

namespace QuanlyChungcu
{
    public partial class FormNoiThatPhong : Form
    {
        String maPhong = "";
        public FormNoiThatPhong(String maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void FormNoiThatPhong_Load(object sender, EventArgs e)
        {
            loadDataNoiThatPhong();
        }

        private void loadDataNoiThatPhong()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@maPhong", SqlDbType.NChar)
            };
            para[0].Value = maPhong;

            datagridViewNoiThatPhong.DataSource = DataConnect.GetData("SELECT * FROM NoiThatPhong where maPhong=@maPhong", para);

            datagridViewNoiThatPhong.AllowUserToAddRows = false;
            datagridViewNoiThatPhong.RowHeadersVisible = false;
        }
    }
}
