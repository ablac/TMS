﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public partial class Form2
    {
        private void rButtons2_Click(object sender, EventArgs e)
        {
            empIDAddTB.Text = "";
            empNameAddTB.Text = "";
            empPnumAddTB.Text = "";
            EmpPinAddTB.Text = "";
            empRemove.Text = "";
            toolRemove.Text = "";
            RT_Tools_CB.Checked = false;
            RU_Tools_CB.Checked = false;
            AT_Tools_CB.Checked = false;
            AU_Tools_CB.Checked = false;
            UH_Tools_CB.Checked = false;
            TH_Tools_CB.Checked = false;
            UHS_Tools_CB.Checked = false;
            THS_Tools_CB.Checked = false;
            CIT_Tools_CB.Checked = false;
            COT_Tools_CB.Checked = false;
        }

        private void rButtons3_Click(object sender, EventArgs e)
        {
            toolIDAddTB.Text = "";
            toolTypeAddTB.Text = "";
            empRemove.Text = "";
            toolRemove.Text = "";
        }

        //Close Application Buttons
        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
