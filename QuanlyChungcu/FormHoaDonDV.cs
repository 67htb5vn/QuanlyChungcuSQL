using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanlyChungcu
{
    public partial class FormHoaDonDV : Form
    {
        public FormHoaDonDV()
        {
            InitializeComponent();
        }

        private void FormHoaDonDV_Load(object sender, EventArgs e)
        {
            loadHoaDonDV();
        }

        void loadHoaDonDV()
        {
            datagridViewHoaDonDV.DataSource = DataConnect.GetData("SELECT * FROM HoaDonDV");
            datagridViewHoaDonDV.AllowUserToAddRows = false;
            datagridViewHoaDonDV.RowHeadersVisible = false;
            datagridViewHoaDonDV.Columns["ThangSD"].DefaultCellStyle.Format = "MM/yyyy";
            datagridViewHoaDonDV.Columns["NgayThanhToan"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void datagridViewHoaDonDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datagridViewHoaDonDV.CurrentRow.Index;
            DateTime ngayTT = new DateTime();
            DateTime ThangSD = new DateTime();

            textBoxThangSD.Text = datagridViewHoaDonDV.Rows[i].Cells[1].Value.ToString();
            if (datagridViewHoaDonDV.Rows[i].Cells[1].Value.ToString() != "")
            {
                ThangSD = DateTime.Parse(datagridViewHoaDonDV.Rows[i].Cells[1].Value.ToString());
                textBoxThangSD.Text = ThangSD.ToString("MM/yyyy");
            }

            textBoxNgayTT.Text = datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString();
            if (datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString() != "")
            {
                ngayTT = DateTime.Parse(datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString());
                textBoxNgayTT.Text = ngayTT.ToString("dd/MM/yyyy");
            }
            
            textBoxHoaDon.Text = datagridViewHoaDonDV.Rows[i].Cells[0].Value.ToString();
            comboBoxTrangThaiTT.Text = datagridViewHoaDonDV.Rows[i].Cells[7].Value.ToString();          
            textBoxHopDong.Text = datagridViewHoaDonDV.Rows[i].Cells[10].Value.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            themHoaDonDV();
            loadHoaDonDV();
        }

        private void themHoaDonDV()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                new SqlParameter("@ThangSD", SqlDbType.Date),
                new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                new SqlParameter("@ngayTT", SqlDbType.Date), 
                new SqlParameter("maHopDong", SqlDbType.NChar) 
            };

            String ThangSDstring=textBoxThangSD.Text.Substring(3,4)+"-"+ textBoxThangSD.Text.Substring(0, 2)+"-01";
            DateTime ThangSD=DateTime.Parse(ThangSDstring.Trim());
            DateTime ngayTT=DateTime.ParseExact(textBoxNgayTT.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);
            String TrangThai = "";
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                TrangThai = "True";
            else
                TrangThai = "False";

            para[0].Value = textBoxHoaDon.Text;
            para[1].Value = ThangSD;
            para[2].Value = TrangThai;
            para[3].Value = ngayTT;
            para[4].Value = textBoxHopDong.Text;

        DataConnect.Proc("them_HDDV_form_TT", para);
        }
    }
}
