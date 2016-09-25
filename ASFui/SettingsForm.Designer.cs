﻿using System.IO;
using System.Windows.Forms;

namespace ASFui
{
    partial class SettingsForm
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
            this.ofdBinarySearch = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbBinaryPath = new System.Windows.Forms.GroupBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.gbLocalRemote = new System.Windows.Forms.GroupBox();
            this.tbRemoteURL = new System.Windows.Forms.TextBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbSaved = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCooldown = new System.Windows.Forms.CheckBox();
            this.cbOwned = new System.Windows.Forms.CheckBox();
            this.cbInvalid = new System.Windows.Forms.CheckBox();
            this.cbDuplicated = new System.Windows.Forms.CheckBox();
            this.cbOK = new System.Windows.Forms.CheckBox();
            this.gbBinaryPath.SuspendLayout();
            this.gbLocalRemote.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdBinarySearch
            // 
            this.ofdBinarySearch.DefaultExt = "exe";
            this.ofdBinarySearch.Filter = "Executable|*.exe";
            this.ofdBinarySearch.Title = "Search for ASF binary";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbBinaryPath
            // 
            this.gbBinaryPath.Controls.Add(this.lbPath);
            this.gbBinaryPath.Controls.Add(this.btnSearch);
            this.gbBinaryPath.Location = new System.Drawing.Point(12, 12);
            this.gbBinaryPath.Name = "gbBinaryPath";
            this.gbBinaryPath.Size = new System.Drawing.Size(431, 48);
            this.gbBinaryPath.TabIndex = 2;
            this.gbBinaryPath.TabStop = false;
            this.gbBinaryPath.Text = "ASF binary";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(6, 24);
            this.lbPath.MaximumSize = new System.Drawing.Size(335, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(114, 13);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Setting not configured.";
            // 
            // gbLocalRemote
            // 
            this.gbLocalRemote.Controls.Add(this.tbRemoteURL);
            this.gbLocalRemote.Controls.Add(this.rbRemote);
            this.gbLocalRemote.Controls.Add(this.rbLocal);
            this.gbLocalRemote.Location = new System.Drawing.Point(12, 66);
            this.gbLocalRemote.Name = "gbLocalRemote";
            this.gbLocalRemote.Size = new System.Drawing.Size(431, 48);
            this.gbLocalRemote.TabIndex = 3;
            this.gbLocalRemote.TabStop = false;
            this.gbLocalRemote.Text = "Local or Remote";
            // 
            // tbRemoteURL
            // 
            this.tbRemoteURL.Enabled = false;
            this.tbRemoteURL.Location = new System.Drawing.Point(135, 19);
            this.tbRemoteURL.Name = "tbRemoteURL";
            this.tbRemoteURL.Size = new System.Drawing.Size(290, 20);
            this.tbRemoteURL.TabIndex = 2;
            // 
            // rbRemote
            // 
            this.rbRemote.AutoSize = true;
            this.rbRemote.Location = new System.Drawing.Point(66, 20);
            this.rbRemote.Name = "rbRemote";
            this.rbRemote.Size = new System.Drawing.Size(62, 17);
            this.rbRemote.TabIndex = 1;
            this.rbRemote.Text = "Remote";
            this.rbRemote.UseVisualStyleBackColor = true;
            this.rbRemote.CheckedChanged += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(9, 20);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbSaved
            // 
            this.lbSaved.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSaved.Location = new System.Drawing.Point(262, 216);
            this.lbSaved.Name = "lbSaved";
            this.lbSaved.Size = new System.Drawing.Size(100, 23);
            this.lbSaved.TabIndex = 5;
            this.lbSaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCooldown);
            this.groupBox1.Controls.Add(this.cbOwned);
            this.groupBox1.Controls.Add(this.cbInvalid);
            this.groupBox1.Controls.Add(this.cbDuplicated);
            this.groupBox1.Controls.Add(this.cbOK);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clear Keys Input";
            // 
            // cbCooldown
            // 
            this.cbCooldown.AutoSize = true;
            this.cbCooldown.Location = new System.Drawing.Point(182, 44);
            this.cbCooldown.Name = "cbCooldown";
            this.cbCooldown.Size = new System.Drawing.Size(89, 17);
            this.cbCooldown.TabIndex = 4;
            this.cbCooldown.Text = "On cooldown";
            this.cbCooldown.UseVisualStyleBackColor = true;
            // 
            // cbOwned
            // 
            this.cbOwned.AutoSize = true;
            this.cbOwned.Location = new System.Drawing.Point(182, 20);
            this.cbOwned.Name = "cbOwned";
            this.cbOwned.Size = new System.Drawing.Size(184, 17);
            this.cbOwned.TabIndex = 3;
            this.cbOwned.Text = "When the game is already owned";
            this.cbOwned.UseVisualStyleBackColor = true;
            // 
            // cbInvalid
            // 
            this.cbInvalid.AutoSize = true;
            this.cbInvalid.Location = new System.Drawing.Point(6, 67);
            this.cbInvalid.Name = "cbInvalid";
            this.cbInvalid.Size = new System.Drawing.Size(136, 17);
            this.cbInvalid.TabIndex = 2;
            this.cbInvalid.Text = "When the key is invalid";
            this.cbInvalid.UseVisualStyleBackColor = true;
            // 
            // cbDuplicated
            // 
            this.cbDuplicated.AutoSize = true;
            this.cbDuplicated.Checked = true;
            this.cbDuplicated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDuplicated.Location = new System.Drawing.Point(7, 44);
            this.cbDuplicated.Name = "cbDuplicated";
            this.cbDuplicated.Size = new System.Drawing.Size(155, 17);
            this.cbDuplicated.TabIndex = 1;
            this.cbDuplicated.Text = "When the key is duplicated";
            this.cbDuplicated.UseVisualStyleBackColor = true;
            // 
            // cbOK
            // 
            this.cbOK.AutoSize = true;
            this.cbOK.Checked = true;
            this.cbOK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOK.Location = new System.Drawing.Point(7, 20);
            this.cbOK.Name = "cbOK";
            this.cbOK.Size = new System.Drawing.Size(153, 17);
            this.cbOK.TabIndex = 0;
            this.cbOK.Text = "When the key is redeemed";
            this.cbOK.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 248);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSaved);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbLocalRemote);
            this.Controls.Add(this.gbBinaryPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ASFui.Properties.Resources.ASFui;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "ASFui - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.gbBinaryPath.ResumeLayout(false);
            this.gbBinaryPath.PerformLayout();
            this.gbLocalRemote.ResumeLayout(false);
            this.gbLocalRemote.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdBinarySearch;
        private System.Windows.Forms.Button btnSearch;
        private GroupBox gbBinaryPath;
        private Label lbPath;
        private GroupBox gbLocalRemote;
        private RadioButton rbRemote;
        private RadioButton rbLocal;
        private Button btnSave;
        private TextBox tbRemoteURL;
        private Label lbSaved;
        private GroupBox groupBox1;
        private CheckBox cbCooldown;
        private CheckBox cbOwned;
        private CheckBox cbInvalid;
        private CheckBox cbDuplicated;
        private CheckBox cbOK;
    }
}