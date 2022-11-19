namespace Calculatrice
{
    partial class Calculatrice
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculatrice));
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.Txt_A = new System.Windows.Forms.TextBox();
            this.Txt_B = new System.Windows.Forms.TextBox();
            this.Lbl_Info = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Diff = new System.Windows.Forms.Button();
            this.Btn_Prod = new System.Windows.Forms.Button();
            this.Btn_Div = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Eraser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(35, 97);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(66, 15);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "Valeur de A";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(35, 137);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(65, 15);
            this.lbl_B.TabIndex = 1;
            this.lbl_B.Text = "Valeur de B";
            // 
            // Txt_A
            // 
            this.Txt_A.Location = new System.Drawing.Point(127, 94);
            this.Txt_A.Name = "Txt_A";
            this.Txt_A.Size = new System.Drawing.Size(148, 23);
            this.Txt_A.TabIndex = 2;
            this.Txt_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_A_KeyPress);
            // 
            // Txt_B
            // 
            this.Txt_B.Location = new System.Drawing.Point(127, 134);
            this.Txt_B.Name = "Txt_B";
            this.Txt_B.Size = new System.Drawing.Size(148, 23);
            this.Txt_B.TabIndex = 3;
            this.Txt_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_B_KeyPress);
            // 
            // Lbl_Info
            // 
            this.Lbl_Info.BackColor = System.Drawing.Color.RosyBrown;
            this.Lbl_Info.Location = new System.Drawing.Point(0, 352);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new System.Drawing.Size(326, 66);
            this.Lbl_Info.TabIndex = 11;
            this.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Add.Location = new System.Drawing.Point(35, 170);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 75);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseMnemonic = false;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Diff
            // 
            this.Btn_Diff.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Diff.Location = new System.Drawing.Point(127, 170);
            this.Btn_Diff.Name = "Btn_Diff";
            this.Btn_Diff.Size = new System.Drawing.Size(75, 75);
            this.Btn_Diff.TabIndex = 6;
            this.Btn_Diff.Text = "-";
            this.Btn_Diff.UseVisualStyleBackColor = true;
            this.Btn_Diff.Click += new System.EventHandler(this.Btn_Diff_Click);
            // 
            // Btn_Prod
            // 
            this.Btn_Prod.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Prod.Location = new System.Drawing.Point(35, 261);
            this.Btn_Prod.Name = "Btn_Prod";
            this.Btn_Prod.Size = new System.Drawing.Size(75, 75);
            this.Btn_Prod.TabIndex = 7;
            this.Btn_Prod.Text = "x";
            this.Btn_Prod.UseVisualStyleBackColor = true;
            this.Btn_Prod.Click += new System.EventHandler(this.Btn_Prod_Click);
            // 
            // Btn_Div
            // 
            this.Btn_Div.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Div.Location = new System.Drawing.Point(127, 261);
            this.Btn_Div.Name = "Btn_Div";
            this.Btn_Div.Size = new System.Drawing.Size(75, 75);
            this.Btn_Div.TabIndex = 8;
            this.Btn_Div.Text = "÷";
            this.Btn_Div.UseVisualStyleBackColor = true;
            this.Btn_Div.Click += new System.EventHandler(this.Btn_Div_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.BackgroundImage")));
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Exit.Location = new System.Drawing.Point(219, 261);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 75);
            this.Btn_Exit.TabIndex = 9;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Eraser
            // 
            this.Btn_Eraser.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Eraser.BackgroundImage")));
            this.Btn_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eraser.Location = new System.Drawing.Point(219, 170);
            this.Btn_Eraser.Name = "Btn_Eraser";
            this.Btn_Eraser.Size = new System.Drawing.Size(75, 75);
            this.Btn_Eraser.TabIndex = 10;
            this.Btn_Eraser.UseVisualStyleBackColor = false;
            this.Btn_Eraser.Click += new System.EventHandler(this.Btn_Eraser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lbl_Title);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 76);
            this.panel1.TabIndex = 12;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(152, 8);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(160, 50);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Calculatrice \r\nnon scientifique";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Eraser);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Div);
            this.Controls.Add(this.Btn_Prod);
            this.Controls.Add(this.Btn_Diff);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lbl_Info);
            this.Controls.Add(this.Txt_B);
            this.Controls.Add(this.Txt_A);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculatrice";
            this.Text = "Calculatrice non scientifique";
            this.Load += new System.EventHandler(this.Calculatrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_A;
        private Label lbl_B;
        private TextBox Txt_A;
        private TextBox Txt_B;
        private Label Lbl_Info;
        private Button Btn_Add;
        private Button Btn_Diff;
        private Button Btn_Prod;
        private Button Btn_Div;
        private Button Btn_Exit;
        private Button Btn_Eraser;
        private Panel panel1;
        private Label Lbl_Title;
        private PictureBox pictureBox1;
    }
}