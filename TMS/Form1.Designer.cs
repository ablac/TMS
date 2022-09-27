namespace TMS
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rButtons1 = new Tool_Inventory_System.RButtons();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox2 = new TMS.Contols.TBox();
            this.tBox1 = new TMS.Contols.TBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.rButtons1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBox2);
            this.panel1.Controls.Add(this.tBox1);
            this.panel1.Location = new System.Drawing.Point(224, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 447);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TMS.Properties.Resources.High_Resolution_Logo___Transparent_Background;
            this.pictureBox1.Location = new System.Drawing.Point(122, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clear";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(240, 399);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Pin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rButtons1
            // 
            this.rButtons1.BackColor = System.Drawing.Color.Green;
            this.rButtons1.BackgroundColor = System.Drawing.Color.Green;
            this.rButtons1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rButtons1.BorderRadius = 40;
            this.rButtons1.BorderSize = 2;
            this.rButtons1.FlatAppearance.BorderSize = 0;
            this.rButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButtons1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rButtons1.ForeColor = System.Drawing.Color.White;
            this.rButtons1.Location = new System.Drawing.Point(33, 339);
            this.rButtons1.Name = "rButtons1";
            this.rButtons1.Size = new System.Drawing.Size(323, 54);
            this.rButtons1.TabIndex = 6;
            this.rButtons1.Text = "Login";
            this.rButtons1.TextColor = System.Drawing.Color.White;
            this.rButtons1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID";
            // 
            // tBox2
            // 
            this.tBox2.BackColor = System.Drawing.SystemColors.Window;
            this.tBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBox2.BorderSize = 5;
            this.tBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox2.ForeColor = System.Drawing.Color.DimGray;
            this.tBox2.Location = new System.Drawing.Point(33, 232);
            this.tBox2.Margin = new System.Windows.Forms.Padding(4);
            this.tBox2.Multiline = false;
            this.tBox2.Name = "tBox2";
            this.tBox2.Padding = new System.Windows.Forms.Padding(7);
            this.tBox2.PasswordChar = false;
            this.tBox2.Size = new System.Drawing.Size(323, 40);
            this.tBox2.TabIndex = 3;
            this.tBox2.UnderlinedStyle = true;
            // 
            // tBox1
            // 
            this.tBox1.BackColor = System.Drawing.SystemColors.Window;
            this.tBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBox1.BorderSize = 5;
            this.tBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox1.ForeColor = System.Drawing.Color.DimGray;
            this.tBox1.Location = new System.Drawing.Point(33, 144);
            this.tBox1.Margin = new System.Windows.Forms.Padding(4);
            this.tBox1.Multiline = false;
            this.tBox1.Name = "tBox1";
            this.tBox1.Padding = new System.Windows.Forms.Padding(7);
            this.tBox1.PasswordChar = false;
            this.tBox1.Size = new System.Drawing.Size(323, 40);
            this.tBox1.TabIndex = 2;
            this.tBox1.UnderlinedStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 787);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Tool_Inventory_System.RButtons rButtons1;
        private Label label3;
        private Label label2;
        private Contols.TBox tBox2;
        private Contols.TBox tBox1;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox checkBox1;
    }
}