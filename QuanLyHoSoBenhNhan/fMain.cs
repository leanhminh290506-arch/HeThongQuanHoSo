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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        public void MoDanhSachBenhNhan()
        {
            ResetChecked(null, null);
            btnQLbenhnhan.Checked = true;

            UCQuanlybenhnhan uCQLbenhnhan = new UCQuanlybenhnhan();
            uCQLbenhnhan.Dock = DockStyle.Fill;
            pnlUCDashboard.Controls.Clear();
            pnlUCDashboard.Controls.Add(uCQLbenhnhan);
        }

        private void ResetChecked(object sender, EventArgs e)
        {
            btnQLhethong.Checked = false;
            btnQLbenhnhan.Checked = false;
            btnQLtaikhoan.Checked = false;
            btnQLcakham.Checked = false;
        }

        private void btnQLHethong_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLhethong.Checked = true;
            UCQuanlyhethong uCQuanlyhethong = new UCQuanlyhethong();
            uCQuanlyhethong.Dock = DockStyle.Fill;
            pnlUCDashboard.Controls.Clear();
            pnlUCDashboard.Controls.Add(uCQuanlyhethong);
        }

        private void btnQLbenhnhan_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLbenhnhan.Checked = true;
            MoDanhSachBenhNhan();
        }

        private void btnThongtinTK_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLtaikhoan.Checked = true;
        }

        private void btnQLcakham_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLcakham.Checked = true;
        }
    }
}
