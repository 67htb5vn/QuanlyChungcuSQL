using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyChungcu
{
    public partial class FormHoaDonDV : Form
    {
        String oldMa = "";
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
            datagridViewHoaDonDV.DataSource = DataConnect.GetData("SELECT * FROM HoaDonDV", null);
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

            textBoxHoaDon.Text = datagridViewHoaDonDV.Rows[i].Cells[0].Value.ToString();
            if (datagridViewHoaDonDV.Rows[i].Cells[7].Value.ToString() == "True")
                comboBoxTrangThaiTT.Text = "Đã thanh toán";
            else
                comboBoxTrangThaiTT.Text = "Chưa thanh toán";

            textBoxNgayTT.Text = datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString();
            if (datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString() != "")
            {
                ngayTT = DateTime.Parse(datagridViewHoaDonDV.Rows[i].Cells[8].Value.ToString());
                textBoxNgayTT.Text = ngayTT.ToString("dd/MM/yyyy");
            }

            textBoxHopDong.Text = datagridViewHoaDonDV.Rows[i].Cells[10].Value.ToString();
            oldMa = datagridViewHoaDonDV.Rows[i].Cells[0].Value.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                themHoaDonDV_TT();
            else
                themHoaDonDV_CTT();
            loadHoaDonDV();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                suaHoaDonDV_TT();
            else
                suaHoaDonDV_CTT();
            loadHoaDonDV();

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xoaHoaDonDV();
            khoitaoHoaDonDV();
            loadHoaDonDV();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            timkiemHoaDonDV();
        }
        private void buttonKhoiTao_Click(object sender, EventArgs e)
        {
            khoitaoHoaDonDV();
            loadHoaDonDV();
        }

        private void khoitaoHoaDonDV()
        {
            textBoxHoaDon.Text = "";
            textBoxHopDong.Text = "";
            comboBoxTrangThaiTT.Text = "";
            textBoxNgayTT.Text = "";
            textBoxThangSD.Text = "";
            comboBoxTrangThaiTT.SelectedIndex = -1;
        }

        private void themHoaDonDV_TT()
        {
            if (textBoxThangSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                new SqlParameter("@ThangSD", SqlDbType.Date),
                new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                new SqlParameter("@ngayTT", SqlDbType.Date),
                new SqlParameter("@maHopDong", SqlDbType.NChar)
                };

                    checkThang(textBoxThangSD.Text);
                    String ThangSDstring = textBoxThangSD.Text.Substring(3, 4) + "-" + textBoxThangSD.Text.Substring(0, 2) + "-01";
                    DateTime ThangSD = DateTime.Parse(ThangSDstring.Trim());

                    DateTime ngayTT = new DateTime();
                    ngayTT = DateTime.ParseExact(textBoxNgayTT.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);   //{   //cho phép chuỗi nhập vào là 1/1/2024 hoặc 01/01/2024
                    para[3].Value = ngayTT;

                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = ThangSD;
                    para[2].Value = "True";
                    para[4].Value = textBoxHopDong.Text;

                    DataConnect.Proc("them_HDDV_form_TT", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void themHoaDonDV_CTT()
        {
            if (textBoxThangSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                new SqlParameter("@ThangSD", SqlDbType.Date),
                new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                new SqlParameter("@maHopDong", SqlDbType.NChar)
                };

                    checkThang(textBoxThangSD.Text);

                    String ThangSDstring = textBoxThangSD.Text.Substring(3, 4) + "-" + textBoxThangSD.Text.Substring(0, 2) + "-01";
                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = ThangSDstring;
                    para[2].Value = "False";
                    para[3].Value = textBoxHopDong.Text;

                    DataConnect.Proc("them_HDDV_form_CTT", para);
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void suaHoaDonDV_TT()
        {
            if (textBoxThangSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                new SqlParameter("@ThangSD", SqlDbType.Date),
                new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                new SqlParameter("@ngayTT", SqlDbType.Date),
                new SqlParameter("@maHopDong", SqlDbType.NChar),
                new SqlParameter("@oldMa", SqlDbType.NChar)
                };

                    checkThang(textBoxThangSD.Text);
                    String ThangSDString = textBoxThangSD.Text.Substring(3, 4) + "-" + textBoxThangSD.Text.Substring(0, 2) + "-01";
                    DateTime ThangSD = DateTime.Parse(ThangSDString);

                    DateTime ngayTT = new DateTime();
                    ngayTT = DateTime.ParseExact(textBoxNgayTT.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);

                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = ThangSD;
                    para[2].Value = "True";
                    para[3].Value = ngayTT;
                    para[4].Value = textBoxHopDong.Text;
                    para[5].Value = oldMa;

                    DataConnect.Proc("sua_HDDV_TT", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void suaHoaDonDV_CTT()
        {
            if (textBoxThangSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                new SqlParameter("@ThangSD", SqlDbType.Date),
                new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                new SqlParameter("@maHopDong", SqlDbType.NChar),
                new SqlParameter("@oldma", SqlDbType.NChar)
            };

                    checkThang(textBoxThangSD.Text);

                    String ThangSDstring = textBoxThangSD.Text.Substring(3, 4) + "-" + textBoxThangSD.Text.Substring(0, 2) + "-01";
                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = ThangSDstring;
                    para[2].Value = "False";
                    para[3].Value = textBoxHopDong.Text;
                    para[4].Value = oldMa;

                    DataConnect.Proc("sua_HDDV_CTT", para);
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void xoaHoaDonDV()
        {
            if (textBoxThangSD.Text == "" && textBoxNgayTT.Text == "" && textBoxHoaDon.Text == "" && textBoxHopDong.Text == "" && comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonDV", SqlDbType.NChar),
                    new SqlParameter("@ThangSD", SqlDbType.NVarChar, 50),
                    new SqlParameter("@TrangThaiTT", SqlDbType.NVarChar,50),
                    new SqlParameter("@ngayTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@maHopDong", SqlDbType.NVarChar, 50)
                };

                    para[0].Value = textBoxHoaDon.Text.Trim();
                    para[1].Value = textBoxThangSD.Text.Trim();
                    if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                        para[2].Value = "True";
                    else if (comboBoxTrangThaiTT.Text == "Chưa thanh toán")
                        para[2].Value = "False";
                    else
                        para[2].Value = "";
                    para[3].Value = textBoxNgayTT.Text.Trim();
                    para[4].Value = textBoxHopDong.Text.Trim();

                    DataConnect.Proc("xoa_HDDV", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                        MessageBox.Show("Lỗi: Xóa gây mất dữ liệu");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void timkiemHoaDonDV()
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@maHoaDonDV", SqlDbType.NVarChar, 10),
                    new SqlParameter("@ThangSD", SqlDbType.NVarChar, 50),
                    new SqlParameter("@TrangThaiTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@ngayTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@maHopDong", SqlDbType.NVarChar, 10)
                };

                para[0].Value = textBoxHoaDon.Text;
                para[1].Value = textBoxThangSD.Text;
                if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                    para[2].Value = "True";
                else if (comboBoxTrangThaiTT.Text == "Chưa thanh toán")
                    para[2].Value = "False";
                else
                    para[2].Value = "";
                para[3].Value = textBoxNgayTT.Text;
                para[4].Value = textBoxHopDong.Text;

                datagridViewHoaDonDV.DataSource = DataConnect.ProcSelec("timkiem_HDDV", para);
                datagridViewHoaDonDV.AllowUserToAddRows = false;
                datagridViewHoaDonDV.RowHeadersVisible = false;
                datagridViewHoaDonDV.Columns["ThangSD"].DefaultCellStyle.Format = "MM/yyyy";
                datagridViewHoaDonDV.Columns["NgayThanhToan"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Contains("was not recognized as a valid DateTime."))
                    MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                    MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                MessageBox.Show("Lỗi");
            }
            catch (NhapsaiThang ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                    MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                    MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                    MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                MessageBox.Show("Lỗi");
            }
        }
        private void datagridViewHoaDonDV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "NULL";
                e.FormattingApplied = true;
            }
        }

        private void comboBoxTrangThaiTT_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
            {
                textBoxNgayTT.ReadOnly = false;
            }
            else
            {
                textBoxNgayTT.Text = "";
                textBoxNgayTT.ReadOnly = true;
            }
        }
        public class NhapsaiThang : Exception
        {
            public NhapsaiThang()
            : base("Tháng sử dụng không đúng MM/yyyy.") { } //throw() thì gọi cái này, throw(mess) thì gọi cái nhapsaithang(mess)

            public NhapsaiThang(string ex)
            : base(ex) { }
        }

        public void checkThang(string thangSD)
        {
            if (!Regex.IsMatch(thangSD, @"^\d{2}/\d{4}$"))  //@ là chuỗi nguyên văn
                throw new NhapsaiThang("Lỗi: Nhập theo định dạng MM/yyyy");
            int thang = int.Parse(thangSD.Substring(0, 2));
            if (thang > 12 | thang < 1)
                throw new NhapsaiThang("Lỗi: Nhập đúng giá trị tháng 01-12");
        }

        private void check(String funcName, SqlParameter[] para)
        {
            String paraName = String.Join(" , ", para.Select(p => p.ParameterName));  //hàm lambda xử lý từng phần tử


            String a = "SELECT * FROM " + funcName + " ( " + paraName + " )";

            textBoxHoaDon.Text = a;
        }
    }
}
