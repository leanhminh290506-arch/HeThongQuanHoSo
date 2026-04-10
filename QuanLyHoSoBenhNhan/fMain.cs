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

        private void ResetChecked(object sender, EventArgs e)
        {
            btnQLhethong.Checked = false;
            btnQLbenhnhan.Checked = false;
            btnQLtaikhoan.Checked = false;
            btnQLcakham.Checked = false;
            btnQLhoso.Checked = false;
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

        public void MoDanhSachCaKham()
        {
            ResetChecked(null, null);
            btnQLcakham.Checked = true;
            UCQuanlycakham uCQuanlycakham = new UCQuanlycakham();
            uCQuanlycakham.Dock = DockStyle.Fill;
            pnlUCDashboard.Controls.Clear();
            pnlUCDashboard.Controls.Add(uCQuanlycakham);
        }

        public void MoDanhSachHoSo()
        {
            ResetChecked(null, null);
            btnQLhoso.Checked = true;
            UCQuanlyhoso uCQuanlyhoso = new UCQuanlyhoso();
            uCQuanlyhoso.Dock = DockStyle.Fill;
            pnlUCDashboard.Controls.Clear();
            pnlUCDashboard.Controls.Add(uCQuanlyhoso);
        }

        public void MoThongTinTaiKhoan()
        {
            ResetChecked(null, null);
            btnQLtaikhoan.Checked = true;
            UCQuanlytaikhoan uCQuanlytaikhoan = new UCQuanlytaikhoan();
            uCQuanlytaikhoan.Dock = DockStyle.Fill;
            pnlUCDashboard.Controls.Clear();
            pnlUCDashboard.Controls.Add(uCQuanlytaikhoan);
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
            MoThongTinTaiKhoan();
        }

        private void btnQLcakham_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLcakham.Checked = true;
            MoDanhSachCaKham();
        }

        private void btnQLhoso_Click(object sender, EventArgs e)
        {
            ResetChecked(sender, e);
            btnQLhoso.Checked = true;
            MoDanhSachHoSo();
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            btnQLHethong_Click(sender, e);
        }

    }
}
