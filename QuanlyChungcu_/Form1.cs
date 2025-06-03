using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace QuanlyChungcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DataConnect.Open();
            InitializeComponent();

        }

        //Button Button_dangKichHoat = null;

        bool menuTPhong_morong = false;
        bool menuThietBi_morong = false;
        bool menuDichVu_morong = false;
        bool menuHoaDon_morong = false;
        bool menuBaoCao_morong = false;

        FormKhachHang formKH = null;
        FormHopDong formHopDong = null;
        FormPhong formPhong = null;
        FormHoaDonDV formHoaDonDV = null;
        FormHoaDonTPhong formHoaDonTPhong = null;


        private void timer1_Tick(object sender, EventArgs e)  //hàm lặp lại hành động mỗi 1 giây
        {

            if (menuTPhong_morong == false)      //nếu chưa nhấn 
            {
                menuTPhong.Height += 10;
                if (menuTPhong.Height >= 276)
                {
                    timer1.Stop();
                    menuTPhong_morong = true;
                }
            }
            else                                //nếu đã nhấn
            {
                menuTPhong.Height -= 10;
                if (menuTPhong.Height <= 69)
                {
                    timer1.Stop();
                    menuTPhong_morong = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)  //qlTPhong
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (menuThietBi_morong == false)
            {
                menuThietBi.Height += 10;
                if (menuThietBi.Height >= 207)
                {
                    timer2.Stop();
                    menuThietBi_morong = true;
                }
            }
            else
            {
                menuThietBi.Height -= 10;
                if (menuThietBi.Height <= 69)
                {
                    timer2.Stop();
                    menuThietBi_morong = false;
                }
            }
        }

        private void QlThietBi_Click(object sender, EventArgs e)
        {

            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (menuDichVu_morong == false)
            {
                menuDichVu.Height += 10;
                if (menuDichVu.Height >= 345)
                {
                    timer3.Stop();
                    menuDichVu_morong = true;
                }
            }
            else
            {
                menuDichVu.Height -= 10;
                if (menuDichVu.Height <= 69)
                {
                    timer3.Stop();
                    menuDichVu_morong = false;
                }
            }
        }

        private void qlDichVu_Click(object sender, EventArgs e)
        {

            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (menuHoaDon_morong == false)
            {
                menuHoaDon.Height += 10;
                if (menuHoaDon.Height >= 207)
                {
                    timer4.Stop();
                    menuHoaDon_morong = true;
                }
            }
            else
            {
                menuHoaDon.Height -= 10;
                if (menuHoaDon.Height <= 69)
                {
                    timer4.Stop();
                    menuHoaDon_morong = false;
                }
            }
        }

        private void qlHoaDon_Click(object sender, EventArgs e)
        {

            timer4.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (menuBaoCao_morong == false)
            {
                menuBaoCao.Height += 10;
                if (menuBaoCao.Height >= 276)
                {
                    timer5.Stop();
                    menuBaoCao_morong = true;
                }
            }
            else
            {
                menuBaoCao.Height -= 10;
                if (menuBaoCao.Height <= 69)
                {
                    timer5.Stop();
                    menuBaoCao_morong = false;
                }
            }
        }

        private void BaoCao_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            if (formKH == null)                     //nếu chưa mở form thì mở form
            {
                formKH = new FormKhachHang();
                formKH.FormClosed += formKH_Closed;
                formKH.MdiParent = this;            //formKH có form cha là this (form1)
                formKH.Dock = DockStyle.Fill;
                formKH.Show();
            }
            else                                  //nếu form đã mở thì kích hoạt, đưa nó lên đầu
            {
                formKH.Activate();                //nếu form đã show, thì gọi active mới đưa lên trước nếu form bị ẩn
            }                                     //gọi .show() thì ko đưa lên trước
        }

        private void formKH_Closed(object sender, EventArgs e)
        {                                        //close khác với =null, close chỉ tắt đi còn =null là xóa liên kết với form, form ko ẩn, ko tắt
            formKH = null;                        //close tuy tắt đi nhưng ko gây ra =null, do nó vẫn tham chiếu đến đối tượng nào đó
            //formKH.Close();  
        }

        private void Phòng_Click(object sender, EventArgs e)
        {
            if (formPhong == null)
            {
                formPhong = new FormPhong();
                formPhong.MdiParent = this;
                formPhong.FormClosed += FormPhong_FormClosed;
                formPhong.Dock = DockStyle.Fill;
                formPhong.Show();
            }
            else
            {
                formPhong.Activate();
            }
        }

        private void FormPhong_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPhong = null;
        }

        private void HopDong_Click(object sender, EventArgs e)
        {
            if (formHopDong == null)
            {
                formHopDong = new FormHopDong();
                formHopDong.MdiParent = this;
                formHopDong.Dock = DockStyle.Fill;
                formHopDong.FormClosed += FormHopDong_FormClosed;
                formHopDong.Show();
            }
        }

        private void FormHopDong_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formHopDong = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HoaDonTPhong_Click(object sender, EventArgs e)
        {
            if (formHoaDonTPhong == null)
            {
                formHoaDonTPhong = new FormHoaDonTPhong();
                formHoaDonTPhong.MdiParent = this;
                formHoaDonTPhong.Dock = DockStyle.Fill;
                formHoaDonTPhong.FormClosed += FormHoaDonTPhong_FormClosed;
                formHoaDonTPhong.Show();
            }
            else
            {
                formHoaDonTPhong.Activate();
            }
        }

        private void FormHoaDonTPhong_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formHoaDonTPhong = null;
        }

        private void HoaDonDV_Click(object sender, EventArgs e)
        {
            if (formHoaDonDV == null)
            {
                formHoaDonDV = new FormHoaDonDV();
                formHoaDonDV.MdiParent = this;
                formHoaDonDV.Dock = DockStyle.Fill;
                formHoaDonDV.FormClosed += FormHoaDonDV_FormClosed;
                formHoaDonDV.Show();
            }
            else
            {
                formHoaDonDV.Activate();
            }
        }

        private void FormHoaDonDV_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formHoaDonDV = null;
        }
    }
}
