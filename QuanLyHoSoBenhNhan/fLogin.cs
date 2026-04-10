using System.Runtime.InteropServices;

namespace QuanLyHoSoBenhNhan
{
    public partial class fLogin : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(
    IntPtr hWnd,
    int msg,
    int wParam,
    string lParam);
        public fLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            SendMessage(txtUsername.Handle, 0x1501, 0, "Tên đăng nhập");
            SendMessage(txtPassword.Handle, 0x1501, 0, "Mật khẩu");
            lblSlogan1.Parent = pictureBox4;
            lblSlogan1.BackColor = Color.Transparent;
            lblSlogan2.Parent = pictureBox4;
            lblSlogan2.BackColor = Color.Transparent;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
                fMain formMain = new fMain();
                formMain.Show();
                this.Hide();
        }
    }
}
