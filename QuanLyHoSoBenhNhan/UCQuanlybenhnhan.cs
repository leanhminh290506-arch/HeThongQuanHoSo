using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoBenhNhan
{
    public partial class UCQuanlybenhnhan : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(
        IntPtr hWnd,
        int msg,
        int wParam,
        string lParam);
        public UCQuanlybenhnhan()
        {
            InitializeComponent();
        }

        private void UCQuanlybenhnhan_Load(object sender, EventArgs e)
        {
            SendMessage(txtTimkiem.Handle, 0x1501, 0, "🔍Tìm kiếm bệnh nhân theo thông tin cá nhân");
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
