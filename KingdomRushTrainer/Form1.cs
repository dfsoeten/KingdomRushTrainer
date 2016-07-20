using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;

namespace KingdomRushTrainer
{
    public partial class Form1 : Form
    {
        public string codeFile = Application.StartupPath + @"\kingdomrush.ini";
        public Mem MemLib = new Mem();
        int gameProcId = 0;
        string windowTitle = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void openGame()
        {   
            gameProcId = MemLib.getProcIDFromName("Kingdom Rush");

            //Prevents error on closing game when the trainer is still open.
            try {
                windowTitle = Process.GetProcessById(gameProcId).MainWindowTitle;
            }
            catch
            {

            }

            if (gameProcId != 0 && windowTitle == "Kingdom Rush HD")
            {
                //Open game's Process
                MemLib.OpenGameProcess(gameProcId);

                //Update Status
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.Text = "Ready!"; }));
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.ForeColor = System.Drawing.Color.Green; }));
                
                //Enable Checkboxes
                cbGold.Invoke(new MethodInvoker(delegate { cbGold.Enabled = true; }));
                cbHealth.Invoke(new MethodInvoker(delegate { cbHealth.Enabled = true; }));

                //Enable Button
                btnSetUpgrades.Invoke(new MethodInvoker(delegate { btnSetUpgrades.Enabled = true; }));
            }
            else
            {
                //Update Status
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.Text = "Waiting..."; }));
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.ForeColor = System.Drawing.Color.Red; }));

                //Disable Checkboxes
                cbGold.Invoke(new MethodInvoker(delegate { cbGold.Enabled = false; }));
                cbHealth.Invoke(new MethodInvoker(delegate { cbHealth.Enabled = false; }));

                //Disable Button
                btnSetUpgrades.Invoke(new MethodInvoker(delegate { btnSetUpgrades.Enabled = false; }));
            }
        }
        
        //Main workloop
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (gameProcId != 0 && windowTitle == "Kingdom Rush HD")
                {

                        if (cbGold.Checked)
                            MemLib.writeMemory("Gold", codeFile, "int", "99999");

                        if (cbHealth.Checked)
                            MemLib.writeMemory("Health", codeFile, "int", "99999");

                        gameProcId = MemLib.getProcIDFromName("Kingdom Rush");
                        windowTitle = Process.GetProcessById(gameProcId).MainWindowTitle;
                }
                else
                    openGame();
            }
        }

        //Set gold back to default
        private void cbGold_CheckedChanged(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            if (!cbGold.Checked)
            {
                MemLib.writeMemory("Gold", codeFile, "int", "265");
            }
        }

        //Set health back to default
        //this will fire the second a value is given.
        private void cbHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            if (!cbHealth.Checked)
            {
                MemLib.writeMemory("Health", codeFile, "int", "20");
            }
        }

        //Set stars to txtUpgrades value
        private void btnSetUpgrades_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("Upgrades", codeFile, "int", txtUpgrades.Text);
        }
        
        //txtUpgrades only numeric values
        private void txtUpgrades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }
    }
}
