namespace GestionInscription
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        //liaisonBD liaison = new liaisonBD();


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_conct = new Guna.UI2.WinForms.Guna2Button();
            nom = new Guna.UI2.WinForms.Guna2TextBox();
            mdp = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            quitt_btn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_conct
            // 
            btn_conct.Animated = true;
            btn_conct.BorderRadius = 20;
            btn_conct.CustomizableEdges = customizableEdges1;
            btn_conct.DisabledState.BorderColor = Color.DarkGray;
            btn_conct.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_conct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_conct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_conct.FillColor = Color.FromArgb(255, 128, 0);
            btn_conct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_conct.ForeColor = Color.White;
            btn_conct.Location = new Point(548, 480);
            btn_conct.Name = "btn_conct";
            btn_conct.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_conct.Size = new Size(180, 45);
            btn_conct.TabIndex = 3;
            btn_conct.Text = "SE CONNECTER";
            btn_conct.Click += btn_conct_Click;
            // 
            // nom
            // 
            nom.BorderRadius = 10;
            nom.CustomizableEdges = customizableEdges3;
            nom.DefaultText = "";
            nom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nom.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nom.Location = new Point(482, 271);
            nom.Name = "nom";
            nom.PlaceholderText = "RakotobeJean";
            nom.SelectedText = "";
            nom.ShadowDecoration.CustomizableEdges = customizableEdges4;
            nom.Size = new Size(298, 43);
            nom.TabIndex = 4;
            // 
            // mdp
            // 
            mdp.BorderRadius = 10;
            mdp.CustomizableEdges = customizableEdges5;
            mdp.DefaultText = "";
            mdp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            mdp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            mdp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            mdp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            mdp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            mdp.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            mdp.ForeColor = Color.Black;
            mdp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            mdp.Location = new Point(482, 388);
            mdp.Name = "mdp";
            mdp.PlaceholderText = "**********";
            mdp.SelectedText = "";
            mdp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            mdp.Size = new Size(298, 42);
            mdp.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(482, 240);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(137, 23);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Nom d'utilisateur :";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(482, 359);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(110, 23);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Mot de passe :";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.BorderRadius = 20;
            guna2CustomGradientPanel1.Controls.Add(quitt_btn);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel4);
            customizableEdges7.BottomLeft = false;
            customizableEdges7.TopLeft = false;
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges7;
            guna2CustomGradientPanel1.Dock = DockStyle.Left;
            guna2CustomGradientPanel1.FillColor = Color.Yellow;
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(255, 128, 0);
            guna2CustomGradientPanel1.FillColor3 = Color.Yellow;
            guna2CustomGradientPanel1.FillColor4 = Color.Red;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CustomGradientPanel1.Size = new Size(407, 563);
            guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // quitt_btn
            // 
            quitt_btn.BackColor = Color.Transparent;
            quitt_btn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitt_btn.ForeColor = Color.White;
            quitt_btn.Location = new Point(169, 286);
            quitt_btn.Name = "quitt_btn";
            quitt_btn.Size = new Size(121, 52);
            quitt_btn.TabIndex = 12;
            quitt_btn.Text = "School";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 81.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.White;
            guna2HtmlLabel4.Location = new Point(129, 166);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(61, 148);
            guna2HtmlLabel4.TabIndex = 11;
            guna2HtmlLabel4.Text = "E";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(566, 24);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(126, 123);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 9;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(523, 166);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(216, 34);
            guna2HtmlLabel3.TabIndex = 10;
            guna2HtmlLabel3.Text = "AUTENTHIFICATION";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(828, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_conct);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(guna2HtmlLabel3);
            panel1.Controls.Add(mdp);
            panel1.Controls.Add(guna2HtmlLabel2);
            panel1.Controls.Add(nom);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 563);
            panel1.TabIndex = 13;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 563);
            Controls.Add(pictureBox1);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "Form1";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_conct;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox mdp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel quitt_btn;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
