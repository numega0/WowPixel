namespace WowPixel
{
    partial class frmWowPixel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWowPixel));
            this.tmrCursor = new System.Windows.Forms.Timer(this.components);
            this.lblCursor = new System.Windows.Forms.Label();
            this.tmrSpam = new System.Windows.Forms.Timer(this.components);
            this.chkTrigger = new System.Windows.Forms.CheckBox();
            this.chkSpam = new System.Windows.Forms.CheckBox();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.txtKey3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fMage = new System.Windows.Forms.TabPage();
            this.txtFireTriggerKey = new System.Windows.Forms.TextBox();
            this.chkFireTriggerKey = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkAoe = new System.Windows.Forms.CheckBox();
            this.chkVanish = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkShadowStep = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRogueTrigger = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkMonk = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelYakala = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tmrFortniteTrigger = new System.Windows.Forms.Timer(this.components);
            this.tmrRogueSpam = new System.Windows.Forms.Timer(this.components);
            this.tmrF = new System.Windows.Forms.Timer(this.components);
            this.tmrGeri = new System.Windows.Forms.Timer(this.components);
            this.tmrYakala = new System.Windows.Forms.Timer(this.components);
            this.tmrFire = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.fMage.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCursor
            // 
            this.tmrCursor.Interval = 15;
            this.tmrCursor.Tick += new System.EventHandler(this.tmrCursor_Tick);
            // 
            // lblCursor
            // 
            this.lblCursor.AutoSize = true;
            this.lblCursor.Location = new System.Drawing.Point(10, 150);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(0, 13);
            this.lblCursor.TabIndex = 1;
            // 
            // tmrSpam
            // 
            this.tmrSpam.Interval = 15;
            this.tmrSpam.Tick += new System.EventHandler(this.tmrSpam_Tick);
            // 
            // chkTrigger
            // 
            this.chkTrigger.AutoSize = true;
            this.chkTrigger.Location = new System.Drawing.Point(6, 8);
            this.chkTrigger.Name = "chkTrigger";
            this.chkTrigger.Size = new System.Drawing.Size(59, 17);
            this.chkTrigger.TabIndex = 2;
            this.chkTrigger.Text = "Trigger";
            this.chkTrigger.UseVisualStyleBackColor = true;
            this.chkTrigger.CheckedChanged += new System.EventHandler(this.chkTrigger_CheckedChanged);
            // 
            // chkSpam
            // 
            this.chkSpam.AutoSize = true;
            this.chkSpam.Location = new System.Drawing.Point(6, 70);
            this.chkSpam.Name = "chkSpam";
            this.chkSpam.Size = new System.Drawing.Size(74, 17);
            this.chkSpam.TabIndex = 3;
            this.chkSpam.Text = "Spam Key";
            this.chkSpam.UseVisualStyleBackColor = true;
            this.chkSpam.CheckedChanged += new System.EventHandler(this.chkSpam_CheckedChanged);
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(117, 6);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(65, 20);
            this.txtKey1.TabIndex = 4;
            this.txtKey1.Text = "9";
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(117, 32);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(65, 20);
            this.txtKey2.TabIndex = 5;
            this.txtKey2.Text = "2";
            // 
            // txtKey3
            // 
            this.txtKey3.Location = new System.Drawing.Point(117, 67);
            this.txtKey3.Name = "txtKey3";
            this.txtKey3.Size = new System.Drawing.Size(65, 20);
            this.txtKey3.TabIndex = 6;
            this.txtKey3.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 198);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.lblCursor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World of Warcraft";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.fMage);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(7, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(296, 141);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtKey1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtKey2);
            this.tabPage3.Controls.Add(this.txtKey3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.chkSpam);
            this.tabPage3.Controls.Add(this.chkTrigger);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(288, 115);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Mage";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fMage
            // 
            this.fMage.Controls.Add(this.txtFireTriggerKey);
            this.fMage.Controls.Add(this.chkFireTriggerKey);
            this.fMage.Location = new System.Drawing.Point(4, 22);
            this.fMage.Name = "fMage";
            this.fMage.Padding = new System.Windows.Forms.Padding(3);
            this.fMage.Size = new System.Drawing.Size(288, 115);
            this.fMage.TabIndex = 4;
            this.fMage.Text = "F Mage";
            this.fMage.UseVisualStyleBackColor = true;
            // 
            // txtFireTriggerKey
            // 
            this.txtFireTriggerKey.Location = new System.Drawing.Point(71, 6);
            this.txtFireTriggerKey.Name = "txtFireTriggerKey";
            this.txtFireTriggerKey.Size = new System.Drawing.Size(100, 20);
            this.txtFireTriggerKey.TabIndex = 11;
            this.txtFireTriggerKey.Text = "3";
            this.txtFireTriggerKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFireTriggerKey_KeyDown);
            // 
            // chkFireTriggerKey
            // 
            this.chkFireTriggerKey.AutoSize = true;
            this.chkFireTriggerKey.Location = new System.Drawing.Point(6, 6);
            this.chkFireTriggerKey.Name = "chkFireTriggerKey";
            this.chkFireTriggerKey.Size = new System.Drawing.Size(59, 17);
            this.chkFireTriggerKey.TabIndex = 0;
            this.chkFireTriggerKey.Text = "Trigger";
            this.chkFireTriggerKey.UseVisualStyleBackColor = true;
            this.chkFireTriggerKey.CheckedChanged += new System.EventHandler(this.chkFireTriggerKey_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkAoe);
            this.tabPage4.Controls.Add(this.chkVanish);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.chkShadowStep);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.chkRogueTrigger);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(288, 115);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Assasination Rogue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkAoe
            // 
            this.chkAoe.AutoSize = true;
            this.chkAoe.Location = new System.Drawing.Point(6, 77);
            this.chkAoe.Name = "chkAoe";
            this.chkAoe.Size = new System.Drawing.Size(114, 17);
            this.chkAoe.TabIndex = 15;
            this.chkAoe.Text = "Fan of Knives AoE";
            this.chkAoe.UseVisualStyleBackColor = true;
            // 
            // chkVanish
            // 
            this.chkVanish.AutoSize = true;
            this.chkVanish.Location = new System.Drawing.Point(6, 54);
            this.chkVanish.Name = "chkVanish";
            this.chkVanish.Size = new System.Drawing.Size(79, 17);
            this.chkVanish.TabIndex = 14;
            this.chkVanish.Text = "Vanish buff";
            this.chkVanish.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Key F10";
            // 
            // chkShadowStep
            // 
            this.chkShadowStep.AutoSize = true;
            this.chkShadowStep.Location = new System.Drawing.Point(6, 31);
            this.chkShadowStep.Name = "chkShadowStep";
            this.chkShadowStep.Size = new System.Drawing.Size(68, 17);
            this.chkShadowStep.TabIndex = 11;
            this.chkShadowStep.Text = "Trigger 2";
            this.chkShadowStep.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(215, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "2 - Envenom\r\n3 - Mutilate\r\n4 - Rupture\r\n5 - Garrote";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = " ";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key";
            // 
            // chkRogueTrigger
            // 
            this.chkRogueTrigger.AutoSize = true;
            this.chkRogueTrigger.Location = new System.Drawing.Point(6, 8);
            this.chkRogueTrigger.Name = "chkRogueTrigger";
            this.chkRogueTrigger.Size = new System.Drawing.Size(59, 17);
            this.chkRogueTrigger.TabIndex = 3;
            this.chkRogueTrigger.Text = "Trigger";
            this.chkRogueTrigger.UseVisualStyleBackColor = true;
            this.chkRogueTrigger.CheckedChanged += new System.EventHandler(this.chkRogueTrigger_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.chkMonk);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(288, 115);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Monk";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = " ";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Key";
            // 
            // chkMonk
            // 
            this.chkMonk.AutoSize = true;
            this.chkMonk.Location = new System.Drawing.Point(6, 8);
            this.chkMonk.Name = "chkMonk";
            this.chkMonk.Size = new System.Drawing.Size(59, 17);
            this.chkMonk.TabIndex = 10;
            this.chkMonk.Text = "Trigger";
            this.chkMonk.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labelYakala);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(288, 115);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "F";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelYakala
            // 
            this.labelYakala.AutoSize = true;
            this.labelYakala.Location = new System.Drawing.Point(6, 39);
            this.labelYakala.Name = "labelYakala";
            this.labelYakala.Size = new System.Drawing.Size(0, 13);
            this.labelYakala.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "22";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Balik";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tmrFortniteTrigger
            // 
            this.tmrFortniteTrigger.Tick += new System.EventHandler(this.tmrFortniteTrigger_Tick);
            // 
            // tmrRogueSpam
            // 
            this.tmrRogueSpam.Enabled = true;
            this.tmrRogueSpam.Interval = 15;
            this.tmrRogueSpam.Tick += new System.EventHandler(this.tmrRogueSpam_Tick);
            // 
            // tmrF
            // 
            this.tmrF.Interval = 22000;
            this.tmrF.Tick += new System.EventHandler(this.tmrF_Tick);
            // 
            // tmrGeri
            // 
            this.tmrGeri.Interval = 1000;
            this.tmrGeri.Tick += new System.EventHandler(this.tmrGeri_Tick);
            // 
            // tmrYakala
            // 
            this.tmrYakala.Interval = 1;
            this.tmrYakala.Tick += new System.EventHandler(this.tmrYakala_Tick);
            // 
            // tmrFire
            // 
            this.tmrFire.Enabled = true;
            this.tmrFire.Tick += new System.EventHandler(this.tmrFire_Tick);
            // 
            // frmWowPixel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 198);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWowPixel";
            this.Text = "Grimnax - Twitch";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.fMage.ResumeLayout(false);
            this.fMage.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrCursor;
        private System.Windows.Forms.Label lblCursor;
        private System.Windows.Forms.Timer tmrSpam;
        private System.Windows.Forms.CheckBox chkTrigger;
        private System.Windows.Forms.CheckBox chkSpam;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.TextBox txtKey3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer tmrFortniteTrigger;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRogueTrigger;
        private System.Windows.Forms.Timer tmrRogueSpam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShadowStep;
        private System.Windows.Forms.CheckBox chkVanish;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer tmrF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmrGeri;
        private System.Windows.Forms.Label labelYakala;
        private System.Windows.Forms.Timer tmrYakala;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkMonk;
        private System.Windows.Forms.CheckBox chkAoe;
        private System.Windows.Forms.TabPage fMage;
        private System.Windows.Forms.CheckBox chkFireTriggerKey;
        private System.Windows.Forms.Timer tmrFire;
        private System.Windows.Forms.TextBox txtFireTriggerKey;
    }
}

