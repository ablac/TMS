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
            this.empPinTB = new TMS.Contols.TBox();
            this.empIdTB = new TMS.Contols.TBox();
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
            this.panel1.Controls.Add(this.empPinTB);
            this.panel1.Controls.Add(this.empIdTB);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // empPinTB
            // 
            this.empPinTB.BackColor = System.Drawing.SystemColors.Window;
            this.empPinTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.empPinTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empPinTB.BorderSize = 5;
            this.empPinTB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empPinTB.ForeColor = System.Drawing.Color.DimGray;
            this.empPinTB.Location = new System.Drawing.Point(33, 232);
            this.empPinTB.Margin = new System.Windows.Forms.Padding(4);
            this.empPinTB.Multiline = false;
            this.empPinTB.Name = "empPinTB";
            this.empPinTB.Padding = new System.Windows.Forms.Padding(7);
            this.empPinTB.PasswordChar = true;
            this.empPinTB.Size = new System.Drawing.Size(323, 40);
            this.empPinTB.TabIndex = 3;
            this.empPinTB.UnderlinedStyle = true;
            // 
            // empIdTB
            // 
            this.empIdTB.BackColor = System.Drawing.SystemColors.Window;
            this.empIdTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.empIdTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empIdTB.BorderSize = 5;
            this.empIdTB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empIdTB.ForeColor = System.Drawing.Color.DimGray;
            this.empIdTB.Location = new System.Drawing.Point(33, 144);
            this.empIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.empIdTB.Multiline = false;
            this.empIdTB.Name = "empIdTB";
            this.empIdTB.Padding = new System.Windows.Forms.Padding(7);
            this.empIdTB.PasswordChar = false;
            this.empIdTB.Size = new System.Drawing.Size(323, 40);
            this.empIdTB.TabIndex = 2;
            this.empIdTB.UnderlinedStyle = true;
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
        private Contols.TBox empPinTB;
        private Contols.TBox empIdTB;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox checkBox1;
    }
}