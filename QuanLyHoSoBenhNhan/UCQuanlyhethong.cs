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

        private void pnlLichkham_Click(object sender, EventArgs e)
        {
            UCQuanlycakham lichkham = new UCQuanlycakham();
            lichkham.Dock = DockStyle.Fill;
            pnlDanhsach.Controls.Clear();
            pnlDanhsach.Controls.Add(lichkham);
        }

        private void pnlCadangcho_Click(object sender, EventArgs e)
        {
            UCQuanlycakham cadangcho = new UCQuanlycakham();
            cadangcho.Dock = DockStyle.Fill;
            pnlDanhsach.Controls.Clear();
            pnlDanhsach.Controls.Add(cadangcho);
        }
    }
}
