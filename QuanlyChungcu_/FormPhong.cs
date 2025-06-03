using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyChungcu
{
    public partial class FormPhong : Form
    {
        FormNoiThatPhong formNTP = null;
        public FormPhong()
        {
            InitializeComponent();
        }

        void loadDataPhong()
        {
            datagridViewPhong.AutoGenerateColumns = false;
            datagridViewPhong.DataSource = DataConnect.GetData("SELECT * FROM Phong", null);
            thietlapLoadPhong();
        }
        void thietlapLoadPhong()
        {
            datagridViewPhong.Columns["nameMaPhong"].DataPropertyName = "MaPhong";
            datagridViewPhong.Columns["nameLoaiPhong"].DataPropertyName = "LoaiPhong";
            datagridViewPhong.Columns["nameDonGia"].DataPropertyName = "DonGia";
            datagridViewPhong.Columns["nameTinhTrang"].DataPropertyName = "TinhTrang";
            datagridViewPhong.Columns["nameDanhGia"].DataPropertyName = "DanhGia";

            datagridViewPhong.AllowUserToAddRows = false;    //ẩn dòng trắng cuối
            datagridViewPhong.RowHeadersVisible = false;
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            loadDataPhong();
        }

        private void datagridViewPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datagridViewPhong.CurrentRow.Index;
            String maPhong = datagridViewPhong.Rows[i].Cells[0].Value.ToString();
            String maTB = datagridViewPhong.Rows[i].Cells[1].Value.ToString();

            if (datagridViewPhong.Columns[e.ColumnIndex].Name == "nameView")
            {
                if (formNTP == null)
                {
                    formNTP = new FormNoiThatPhong(maPhong);
                    formNTP.FormClosed += FormNTP_FormClosed;
                    formNTP.MdiParent = this.MdiParent;
                    formNTP.Dock = DockStyle.Fill;
                    formNTP.Show();
                }
                else
                {
                    formNTP.Activate();
                }
            }
        }
        private void FormNTP_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formNTP = null;
        }
    }
}
