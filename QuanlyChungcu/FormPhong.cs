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
        public FormPhong()
        {
            InitializeComponent();
        }

        void loadDataPhong()
        {
            datagridViewPhong.DataSource = DataConnect.GetData("SELECT * FROM Phong");
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            loadDataPhong();
        }
    }
}
