using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoBenhNhan
{
    public partial class UCQuanlyhethong : UserControl
    {
        public UCQuanlyhethong()
        {
            InitializeComponent();
        }

        private void pnlTongbenhnhan_Click(object sender, EventArgs e)
        {
            fMain mainForm = this.FindForm() as fMain;
            if (mainForm != null)
            {
                mainForm.MoDanhSachBenhNhan();
            }
        }

        private void pnlCadangcho_Click(object sender, EventArgs e)
        {
            fMain mainForm = this.FindForm() as fMain;
            if (mainForm != null)
            {
                mainForm.MoDanhSachCaKham();
            }
        }

        private void pnlHosokham_Click(object sender, EventArgs e)
        {
            fMain mainForm = this.FindForm() as fMain;
            if (mainForm != null)
            {
                mainForm.MoDanhSachHoSo();
            }
        }

        private void pnlTaikhoan_Click(object sender, EventArgs e)
        {
            fMain mainForm = this.FindForm() as fMain;
            if (mainForm != null)
            {
                mainForm.MoThongTinTaiKhoan();
            }
        }
    }
}
