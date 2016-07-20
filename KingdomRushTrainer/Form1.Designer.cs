namespace KingdomRushTrainer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbStatusofgame = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbGold = new System.Windows.Forms.CheckBox();
            this.cbHealth = new System.Windows.Forms.CheckBox();
            this.lbCredits = new System.Windows.Forms.Label();
            this.lbUpgrades = new System.Windows.Forms.Label();
            this.txtUpgrades = new System.Windows.Forms.TextBox();
            this.btnSetUpgrades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.gbUpgrades = new System.Windows.Forms.GroupBox();
            this.gbValues.SuspendLayout();
            this.gbUpgrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(13, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(71, 13);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Game Status:";
            // 
            // lbStatusofgame
            // 
            this.lbStatusofgame.AutoSize = true;
            this.lbStatusofgame.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusofgame.ForeColor = System.Drawing.Color.Red;
            this.lbStatusofgame.Location = new System.Drawing.Point(91, 13);
            this.lbStatusofgame.Name = "lbStatusofgame";
            this.lbStatusofgame.Size = new System.Drawing.Size(52, 13);
            this.lbStatusofgame.TabIndex = 1;
            this.lbStatusofgame.Text = "Waiting...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // cbGold
            // 
            this.cbGold.AutoSize = true;
            this.cbGold.BackColor = System.Drawing.Color.Transparent;
            this.cbGold.Enabled = false;
            this.cbGold.ForeColor = System.Drawing.Color.White;
            this.cbGold.Location = new System.Drawing.Point(6, 26);
            this.cbGold.Name = "cbGold";
            this.cbGold.Size = new System.Drawing.Size(48, 17);
            this.cbGold.TabIndex = 5;
            this.cbGold.Text = "Gold";
            this.cbGold.UseVisualStyleBackColor = false;
            this.cbGold.CheckedChanged += new System.EventHandler(this.cbGold_CheckedChanged);
            // 
            // cbHealth
            // 
            this.cbHealth.AutoSize = true;
            this.cbHealth.BackColor = System.Drawing.Color.Transparent;
            this.cbHealth.Enabled = false;
            this.cbHealth.ForeColor = System.Drawing.Color.White;
            this.cbHealth.Location = new System.Drawing.Point(6, 59);
            this.cbHealth.Name = "cbHealth";
            this.cbHealth.Size = new System.Drawing.Size(57, 17);
            this.cbHealth.TabIndex = 6;
            this.cbHealth.Text = "Health";
            this.cbHealth.UseVisualStyleBackColor = false;
            this.cbHealth.CheckedChanged += new System.EventHandler(this.cbHealth_CheckedChanged);
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.BackColor = System.Drawing.Color.Transparent;
            this.lbCredits.ForeColor = System.Drawing.Color.Transparent;
            this.lbCredits.Location = new System.Drawing.Point(324, 239);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(148, 13);
            this.lbCredits.TabIndex = 7;
            this.lbCredits.Text = "By: Dan and  NewAge Soldier";
            // 
            // lbUpgrades
            // 
            this.lbUpgrades.AutoSize = true;
            this.lbUpgrades.BackColor = System.Drawing.Color.Transparent;
            this.lbUpgrades.ForeColor = System.Drawing.Color.Transparent;
            this.lbUpgrades.Location = new System.Drawing.Point(6, 27);
            this.lbUpgrades.Name = "lbUpgrades";
            this.lbUpgrades.Size = new System.Drawing.Size(53, 13);
            this.lbUpgrades.TabIndex = 8;
            this.lbUpgrades.Text = "Upgrades";
            // 
            // txtUpgrades
            // 
            this.txtUpgrades.Location = new System.Drawing.Point(65, 25);
            this.txtUpgrades.Name = "txtUpgrades";
            this.txtUpgrades.Size = new System.Drawing.Size(67, 20);
            this.txtUpgrades.TabIndex = 9;
            this.txtUpgrades.Text = "65";
            this.txtUpgrades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgrades_KeyPress);
            // 
            // btnSetUpgrades
            // 
            this.btnSetUpgrades.Enabled = false;
            this.btnSetUpgrades.ForeColor = System.Drawing.Color.Black;
            this.btnSetUpgrades.Location = new System.Drawing.Point(138, 23);
            this.btnSetUpgrades.Name = "btnSetUpgrades";
            this.btnSetUpgrades.Size = new System.Drawing.Size(67, 23);
            this.btnSetUpgrades.TabIndex = 10;
            this.btnSetUpgrades.Text = "Set";
            this.btnSetUpgrades.UseVisualStyleBackColor = true;
            this.btnSetUpgrades.Click += new System.EventHandler(this.btnSetUpgrades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Note: Buy upgrade to update upgrades.";
            // 
            // gbValues
            // 
            this.gbValues.BackColor = System.Drawing.Color.Transparent;
            this.gbValues.Controls.Add(this.cbHealth);
            this.gbValues.Controls.Add(this.cbGold);
            this.gbValues.ForeColor = System.Drawing.Color.White;
            this.gbValues.Location = new System.Drawing.Point(16, 46);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(98, 87);
            this.gbValues.TabIndex = 12;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Values";
            // 
            // gbUpgrades
            // 
            this.gbUpgrades.BackColor = System.Drawing.Color.Transparent;
            this.gbUpgrades.Controls.Add(this.lbUpgrades);
            this.gbUpgrades.Controls.Add(this.txtUpgrades);
            this.gbUpgrades.Controls.Add(this.label1);
            this.gbUpgrades.Controls.Add(this.btnSetUpgrades);
            this.gbUpgrades.ForeColor = System.Drawing.Color.White;
            this.gbUpgrades.Location = new System.Drawing.Point(132, 46);
            this.gbUpgrades.Name = "gbUpgrades";
            this.gbUpgrades.Size = new System.Drawing.Size(234, 87);
            this.gbUpgrades.TabIndex = 13;
            this.gbUpgrades.TabStop = false;
            this.gbUpgrades.Text = "Upgrades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingdomRushTrainer.Properties.Resources.kingdomrush;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.gbUpgrades);
            this.Controls.Add(this.gbValues);
            this.Controls.Add(this.lbCredits);
            this.Controls.Add(this.lbStatusofgame);
            this.Controls.Add(this.lbStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Kingdom Rush HD Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            this.gbUpgrades.ResumeLayout(false);
            this.gbUpgrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbStatusofgame;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbGold;
        private System.Windows.Forms.CheckBox cbHealth;
        private System.Windows.Forms.Label lbCredits;
        private System.Windows.Forms.Label lbUpgrades;
        private System.Windows.Forms.TextBox txtUpgrades;
        private System.Windows.Forms.Button btnSetUpgrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.GroupBox gbUpgrades;
    }
}

