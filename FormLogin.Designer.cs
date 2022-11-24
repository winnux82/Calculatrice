namespace Calculatrice
{
    partial class FormLogin
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
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Pas = new System.Windows.Forms.Label();
            this.TxtB_Id = new System.Windows.Forms.TextBox();
            this.TxtB_Pass = new System.Windows.Forms.TextBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(38, 48);
            this.Lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(61, 15);
            this.Lbl_Id.TabIndex = 0;
            this.Lbl_Id.Text = "Identifiant";
            // 
            // Lbl_Pas
            // 
            this.Lbl_Pas.AutoSize = true;
            this.Lbl_Pas.Location = new System.Drawing.Point(38, 93);
            this.Lbl_Pas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Pas.Name = "Lbl_Pas";
            this.Lbl_Pas.Size = new System.Drawing.Size(57, 15);
            this.Lbl_Pas.TabIndex = 1;
            this.Lbl_Pas.Text = "Password";
            // 
            // TxtB_Id
            // 
            this.TxtB_Id.Location = new System.Drawing.Point(150, 48);
            this.TxtB_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Id.Name = "TxtB_Id";
            this.TxtB_Id.Size = new System.Drawing.Size(116, 23);
            this.TxtB_Id.TabIndex = 2;
            this.TxtB_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Id_KeyPress);
            // 
            // TxtB_Pass
            // 
            this.TxtB_Pass.Location = new System.Drawing.Point(150, 90);
            this.TxtB_Pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtB_Pass.Name = "TxtB_Pass";
            this.TxtB_Pass.PasswordChar = '*';
            this.TxtB_Pass.Size = new System.Drawing.Size(116, 23);
            this.TxtB_Pass.TabIndex = 3;
            this.TxtB_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Pass_KeyPress);
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Location = new System.Drawing.Point(111, 163);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Valider.Size = new System.Drawing.Size(88, 27);
            this.Btn_Valider.TabIndex = 4;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Voir le mot de passe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 202);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.TxtB_Pass);
            this.Controls.Add(this.TxtB_Id);
            this.Controls.Add(this.Lbl_Pas);
            this.Controls.Add(this.Lbl_Id);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_Pas;
        private System.Windows.Forms.TextBox TxtB_Id;
        private System.Windows.Forms.TextBox TxtB_Pass;
        private System.Windows.Forms.Button Btn_Valider;
        private CheckBox checkBox1;
    }
}