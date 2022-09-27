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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox1 = new TMS.Contols.TBox();
            this.tBox2 = new TMS.Contols.TBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rButtons1 = new Tool_Inventory_System.RButtons();
            this.rButtons2 = new Tool_Inventory_System.RButtons();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rButtons2);
            this.panel1.Controls.Add(this.rButtons1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBox2);
            this.panel1.Controls.Add(this.tBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(224, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 444);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TMS";
            // 
            // tBox1
            // 
            this.tBox1.BackColor = System.Drawing.SystemColors.Window;
            this.tBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBox1.BorderSize = 5;
            this.tBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox1.ForeColor = System.Drawing.Color.DimGray;
            this.tBox1.Location = new System.Drawing.Point(33, 154);
            this.tBox1.Margin = new System.Windows.Forms.Padding(4);
            this.tBox1.Multiline = false;
            this.tBox1.Name = "tBox1";
            this.tBox1.Padding = new System.Windows.Forms.Padding(7);
            this.tBox1.PasswordChar = false;
            this.tBox1.Size = new System.Drawing.Size(323, 40);
            this.tBox1.TabIndex = 2;
            this.tBox1.UnderlinedStyle = true;
            // 
            // tBox2
            // 
            this.tBox2.BackColor = System.Drawing.SystemColors.Window;
            this.tBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBox2.BorderSize = 5;
            this.tBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox2.ForeColor = System.Drawing.Color.DimGray;
            this.tBox2.Location = new System.Drawing.Point(33, 227);
            this.tBox2.Margin = new System.Windows.Forms.Padding(4);
            this.tBox2.Multiline = false;
            this.tBox2.Name = "tBox2";
            this.tBox2.Padding = new System.Windows.Forms.Padding(7);
            this.tBox2.PasswordChar = false;
            this.tBox2.Size = new System.Drawing.Size(323, 40);
            this.tBox2.TabIndex = 3;
            this.tBox2.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Pin";
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
            this.rButtons1.ForeColor = System.Drawing.Color.White;
            this.rButtons1.Location = new System.Drawing.Point(33, 341);
            this.rButtons1.Name = "rButtons1";
            this.rButtons1.Size = new System.Drawing.Size(133, 54);
            this.rButtons1.TabIndex = 6;
            this.rButtons1.Text = "Login";
            this.rButtons1.TextColor = System.Drawing.Color.White;
            this.rButtons1.UseVisualStyleBackColor = false;
            // 
            // rButtons2
            // 
            this.rButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rButtons2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rButtons2.BorderColor = System.Drawing.Color.Maroon;
            this.rButtons2.BorderRadius = 40;
            this.rButtons2.BorderSize = 2;
            this.rButtons2.FlatAppearance.BorderSize = 0;
            this.rButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButtons2.ForeColor = System.Drawing.Color.White;
            this.rButtons2.Location = new System.Drawing.Point(223, 341);
            this.rButtons2.Name = "rButtons2";
            this.rButtons2.Size = new System.Drawing.Size(133, 54);
            this.rButtons2.TabIndex = 7;
            this.rButtons2.Text = "Cancel";
            this.rButtons2.TextColor = System.Drawing.Color.White;
            this.rButtons2.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Tool_Inventory_System.RButtons rButtons2;
        private Tool_Inventory_System.RButtons rButtons1;
        private Label label3;
        private Label label2;
        private Contols.TBox tBox2;
        private Contols.TBox tBox1;
        private Label label1;
    }
}