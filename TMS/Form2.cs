﻿using System.Windows.Forms;

namespace TMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rButtons7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rButtons2_Click(object sender, EventArgs e)
        {
            empIDAddTB.Text = "";
            empNameAddTB.Text = "";
            empPnumAddTB.Text = "";
            EmpPinAddTB.Text = "";
            foreach (int i in empPermissions1.CheckedIndices)
            {
                empPermissions1.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in empPermissions2.CheckedIndices)
            {
                empPermissions2.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void rButtons3_Click(object sender, EventArgs e)
        {
            toolIDAddTB.Text = "";
            toolTypeAddTB.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
