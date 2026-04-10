namespace QuanLyHoSoBenhNhan
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlMain = new Panel();
            pnlFill = new Panel();
            pnlUCDashboard = new Panel();
            pnlMenu = new Panel();
            btnQLhoso = new Guna.UI2.WinForms.Guna2Button();
            btnQLcakham = new Guna.UI2.WinForms.Guna2Button();
            btnQLtaikhoan = new Guna.UI2.WinForms.Guna2Button();
            btnQLbenhnhan = new Guna.UI2.WinForms.Guna2Button();
            btnQLhethong = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            pnlMain.SuspendLayout();
            pnlFill.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlHeader.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlFill);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1121, 534);
            pnlMain.TabIndex = 1;
            // 
            // pnlFill
            // 
            pnlFill.Controls.Add(pnlUCDashboard);
            pnlFill.Controls.Add(pnlMenu);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.Location = new Point(0, 51);
            pnlFill.Name = "pnlFill";
            pnlFill.Size = new Size(1121, 483);
            pnlFill.TabIndex = 1;
            // 
            // pnlUCDashboard
            // 
            pnlUCDashboard.AutoSize = true;
            pnlUCDashboard.Dock = DockStyle.Fill;
            pnlUCDashboard.Location = new Point(194, 0);
            pnlUCDashboard.Margin = new Padding(3, 2, 3, 2);
            pnlUCDashboard.Name = "pnlUCDashboard";
            pnlUCDashboard.Size = new Size(927, 483);
            pnlUCDashboard.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnQLhoso);
            pnlMenu.Controls.Add(btnQLcakham);
            pnlMenu.Controls.Add(btnQLtaikhoan);
            pnlMenu.Controls.Add(btnQLbenhnhan);
            pnlMenu.Controls.Add(btnQLhethong);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 2, 3, 2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(194, 483);
            pnlMenu.TabIndex = 0;
            // 
            // btnQLhoso
            // 
            btnQLhoso.CheckedState.FillColor = Color.RoyalBlue;
            btnQLhoso.CustomizableEdges = customizableEdges1;
            btnQLhoso.DisabledState.BorderColor = Color.DarkGray;
            btnQLhoso.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQLhoso.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQLhoso.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQLhoso.FillColor = Color.White;
            btnQLhoso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLhoso.ForeColor = SystemColors.ActiveCaptionText;
            btnQLhoso.HoverState.FillColor = Color.LightSkyBlue;
            btnQLhoso.Location = new Point(3, 154);
            btnQLhoso.Margin = new Padding(3, 2, 3, 2);
            btnQLhoso.Name = "btnQLhoso";
            btnQLhoso.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnQLhoso.Size = new Size(189, 42);
            btnQLhoso.TabIndex = 4;
            btnQLhoso.Text = "Quản lý hồ sơ";
            btnQLhoso.Click += btnQLhoso_Click;
            // 
            // btnQLcakham
            // 
            btnQLcakham.CheckedState.FillColor = Color.RoyalBlue;
            btnQLcakham.CustomizableEdges = customizableEdges3;
            btnQLcakham.DisabledState.BorderColor = Color.DarkGray;
            btnQLcakham.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQLcakham.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQLcakham.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQLcakham.FillColor = Color.White;
            btnQLcakham.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLcakham.ForeColor = SystemColors.ActiveCaptionText;
            btnQLcakham.HoverState.FillColor = Color.LightSkyBlue;
            btnQLcakham.Location = new Point(3, 108);
            btnQLcakham.Margin = new Padding(3, 2, 3, 2);
            btnQLcakham.Name = "btnQLcakham";
            btnQLcakham.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnQLcakham.Size = new Size(189, 42);
            btnQLcakham.TabIndex = 3;
            btnQLcakham.Text = "Quản lý ca khám";
            btnQLcakham.Click += btnQLcakham_Click;
            // 
            // btnQLtaikhoan
            // 
            btnQLtaikhoan.CheckedState.FillColor = Color.RoyalBlue;
            btnQLtaikhoan.CustomizableEdges = customizableEdges5;
            btnQLtaikhoan.DisabledState.BorderColor = Color.DarkGray;
            btnQLtaikhoan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQLtaikhoan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQLtaikhoan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQLtaikhoan.FillColor = Color.White;
            btnQLtaikhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLtaikhoan.ForeColor = SystemColors.ActiveCaptionText;
            btnQLtaikhoan.HoverState.FillColor = Color.LightSkyBlue;
            btnQLtaikhoan.Location = new Point(3, 200);
            btnQLtaikhoan.Margin = new Padding(3, 2, 3, 2);
            btnQLtaikhoan.Name = "btnQLtaikhoan";
            btnQLtaikhoan.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnQLtaikhoan.Size = new Size(189, 42);
            btnQLtaikhoan.TabIndex = 2;
            btnQLtaikhoan.Text = "Quản lý tài khoản";
            btnQLtaikhoan.Click += btnThongtinTK_Click;
            // 
            // btnQLbenhnhan
            // 
            btnQLbenhnhan.CheckedState.FillColor = Color.RoyalBlue;
            btnQLbenhnhan.CustomizableEdges = customizableEdges7;
            btnQLbenhnhan.DisabledState.BorderColor = Color.DarkGray;
            btnQLbenhnhan.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQLbenhnhan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQLbenhnhan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQLbenhnhan.FillColor = Color.White;
            btnQLbenhnhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLbenhnhan.ForeColor = SystemColors.ActiveCaptionText;
            btnQLbenhnhan.HoverState.FillColor = Color.LightSkyBlue;
            btnQLbenhnhan.Location = new Point(3, 62);
            btnQLbenhnhan.Margin = new Padding(3, 2, 3, 2);
            btnQLbenhnhan.Name = "btnQLbenhnhan";
            btnQLbenhnhan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnQLbenhnhan.Size = new Size(189, 42);
            btnQLbenhnhan.TabIndex = 1;
            btnQLbenhnhan.Text = "Quản lý bệnh nhân";
            btnQLbenhnhan.Click += btnQLbenhnhan_Click;
            // 
            // btnQLhethong
            // 
            btnQLhethong.CheckedState.FillColor = Color.RoyalBlue;
            btnQLhethong.CustomizableEdges = customizableEdges9;
            btnQLhethong.DisabledState.BorderColor = Color.DarkGray;
            btnQLhethong.DisabledState.CustomBorderColor = Color.DarkGray;
            btnQLhethong.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnQLhethong.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnQLhethong.FillColor = Color.White;
            btnQLhethong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLhethong.ForeColor = SystemColors.ActiveCaptionText;
            btnQLhethong.HoverState.FillColor = Color.LightSkyBlue;
            btnQLhethong.Location = new Point(3, 14);
            btnQLhethong.Margin = new Padding(3, 2, 3, 2);
            btnQLhethong.Name = "btnQLhethong";
            btnQLhethong.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnQLhethong.Size = new Size(189, 42);
            btnQLhethong.TabIndex = 0;
            btnQLhethong.Text = "Quản lý hệ thống";
            btnQLhethong.Click += btnQLHethong_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.RoyalBlue;
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(panel4);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1121, 51);
            pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 16);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 1;
            label2.Text = "Hệ thống quản lý phòng khám ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumBlue;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 51);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = " MTV Clinic";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 534);
            Controls.Add(pnlMain);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Hồ Sơ Bệnh Nhân";
            WindowState = FormWindowState.Maximized;
            Shown += fMain_Shown;
            pnlMain.ResumeLayout(false);
            pnlFill.ResumeLayout(false);
            pnlFill.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMain;
        private Panel pnlFill;
        private Panel pnlHeader;
        private Panel pnlMenu;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnQLhethong;
        private Guna.UI2.WinForms.Guna2Button btnQLtaikhoan;
        private Guna.UI2.WinForms.Guna2Button btnQLbenhnhan;
        private Panel pnlUCDashboard;
        private Guna.UI2.WinForms.Guna2Button btnQLcakham;
        private Guna.UI2.WinForms.Guna2Button btnQLhoso;
    }
}