namespace GestionInscription
{
    partial class Form1
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
            button1 = new Button();
            nom = new TextBox();
            mdp = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nom
            // 
            nom.Location = new Point(276, 112);
            nom.Name = "nom";
            nom.Size = new Size(100, 23);
            nom.TabIndex = 1;
            // 
            // mdp
            // 
            mdp.Location = new Point(276, 211);
            mdp.Name = "mdp";
            mdp.Size = new Size(100, 23);
            mdp.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mdp);
            Controls.Add(nom);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nom;
        private TextBox mdp;
    }
}
