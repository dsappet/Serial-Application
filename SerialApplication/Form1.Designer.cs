﻿namespace SerialApplication
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
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxXonXoff = new System.Windows.Forms.CheckBox();
            this.checkBoxHardwareHandshaking = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.startListening_Btn = new System.Windows.Forms.Button();
            this.stopListening_Btn = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.writeText = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.sendReplyCheckBox = new System.Windows.Forms.CheckBox();
            this.clearTextBtn = new System.Windows.Forms.Button();
            this.loopWrite_btn = new System.Windows.Forms.Button();
            this.stopLoop_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portComboBox
            // 
            this.portComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.portComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(99, 39);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(140, 23);
            this.portComboBox.TabIndex = 0;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxXonXoff);
            this.groupBox1.Controls.Add(this.checkBoxHardwareHandshaking);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudComboBox);
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            // 
            // checkBoxXonXoff
            // 
            this.checkBoxXonXoff.AutoSize = true;
            this.checkBoxXonXoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxXonXoff.ForeColor = System.Drawing.SystemColors.InfoText;
            this.checkBoxXonXoff.Location = new System.Drawing.Point(156, 120);
            this.checkBoxXonXoff.Name = "checkBoxXonXoff";
            this.checkBoxXonXoff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxXonXoff.Size = new System.Drawing.Size(78, 19);
            this.checkBoxXonXoff.TabIndex = 5;
            this.checkBoxXonXoff.Text = "Xon / Xoff";
            this.checkBoxXonXoff.UseVisualStyleBackColor = true;
            // 
            // checkBoxHardwareHandshaking
            // 
            this.checkBoxHardwareHandshaking.AutoSize = true;
            this.checkBoxHardwareHandshaking.Checked = true;
            this.checkBoxHardwareHandshaking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHardwareHandshaking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHardwareHandshaking.ForeColor = System.Drawing.SystemColors.InfoText;
            this.checkBoxHardwareHandshaking.Location = new System.Drawing.Point(83, 147);
            this.checkBoxHardwareHandshaking.Name = "checkBoxHardwareHandshaking";
            this.checkBoxHardwareHandshaking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHardwareHandshaking.Size = new System.Drawing.Size(148, 19);
            this.checkBoxHardwareHandshaking.TabIndex = 4;
            this.checkBoxHardwareHandshaking.Text = "Hardware Handshaking";
            this.checkBoxHardwareHandshaking.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // baudComboBox
            // 
            this.baudComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.baudComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Location = new System.Drawing.Point(99, 81);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(140, 23);
            this.baudComboBox.TabIndex = 1;
            // 
            // startListening_Btn
            // 
            this.startListening_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.startListening_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startListening_Btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startListening_Btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startListening_Btn.Location = new System.Drawing.Point(268, 14);
            this.startListening_Btn.Name = "startListening_Btn";
            this.startListening_Btn.Size = new System.Drawing.Size(127, 27);
            this.startListening_Btn.TabIndex = 2;
            this.startListening_Btn.Text = "Start Listening";
            this.startListening_Btn.UseVisualStyleBackColor = false;
            this.startListening_Btn.Click += new System.EventHandler(this.startListening_Btn_Click);
            // 
            // stopListening_Btn
            // 
            this.stopListening_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.stopListening_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopListening_Btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopListening_Btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.stopListening_Btn.Location = new System.Drawing.Point(268, 55);
            this.stopListening_Btn.Name = "stopListening_Btn";
            this.stopListening_Btn.Size = new System.Drawing.Size(127, 27);
            this.stopListening_Btn.TabIndex = 3;
            this.stopListening_Btn.Text = "Stop Listening";
            this.stopListening_Btn.UseVisualStyleBackColor = false;
            this.stopListening_Btn.Click += new System.EventHandler(this.stopListening_Btn_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoTextBox.Location = new System.Drawing.Point(15, 256);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(383, 197);
            this.infoTextBox.TabIndex = 4;
            this.infoTextBox.TextChanged += new System.EventHandler(this.infoTextBox_TextChanged);
            // 
            // writeText
            // 
            this.writeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.writeText.Location = new System.Drawing.Point(15, 194);
            this.writeText.Name = "writeText";
            this.writeText.Size = new System.Drawing.Size(246, 23);
            this.writeText.TabIndex = 5;
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.writeButton.Location = new System.Drawing.Point(268, 192);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(127, 27);
            this.writeButton.TabIndex = 6;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // sendReplyCheckBox
            // 
            this.sendReplyCheckBox.AutoSize = true;
            this.sendReplyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendReplyCheckBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sendReplyCheckBox.Location = new System.Drawing.Point(282, 89);
            this.sendReplyCheckBox.Name = "sendReplyCheckBox";
            this.sendReplyCheckBox.Size = new System.Drawing.Size(83, 19);
            this.sendReplyCheckBox.TabIndex = 7;
            this.sendReplyCheckBox.Text = "Send Reply";
            this.sendReplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearTextBtn
            // 
            this.clearTextBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.clearTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTextBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearTextBtn.Location = new System.Drawing.Point(15, 223);
            this.clearTextBtn.Name = "clearTextBtn";
            this.clearTextBtn.Size = new System.Drawing.Size(87, 27);
            this.clearTextBtn.TabIndex = 8;
            this.clearTextBtn.Text = "Clear";
            this.clearTextBtn.UseVisualStyleBackColor = false;
            this.clearTextBtn.Click += new System.EventHandler(this.clearTextBtn_Click);
            // 
            // loopWrite_btn
            // 
            this.loopWrite_btn.BackColor = System.Drawing.SystemColors.Menu;
            this.loopWrite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopWrite_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopWrite_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loopWrite_btn.Location = new System.Drawing.Point(269, 117);
            this.loopWrite_btn.Name = "loopWrite_btn";
            this.loopWrite_btn.Size = new System.Drawing.Size(126, 27);
            this.loopWrite_btn.TabIndex = 9;
            this.loopWrite_btn.Text = "Loop Write";
            this.loopWrite_btn.UseVisualStyleBackColor = false;
            this.loopWrite_btn.Click += new System.EventHandler(this.loopWrite_btn_Click);
            // 
            // stopLoop_Btn
            // 
            this.stopLoop_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.stopLoop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopLoop_Btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoop_Btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.stopLoop_Btn.Location = new System.Drawing.Point(269, 151);
            this.stopLoop_Btn.Name = "stopLoop_Btn";
            this.stopLoop_Btn.Size = new System.Drawing.Size(126, 27);
            this.stopLoop_Btn.TabIndex = 10;
            this.stopLoop_Btn.Text = "Stop Loop";
            this.stopLoop_Btn.UseVisualStyleBackColor = false;
            this.stopLoop_Btn.Click += new System.EventHandler(this.stopLoop_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(412, 482);
            this.Controls.Add(this.stopLoop_Btn);
            this.Controls.Add(this.loopWrite_btn);
            this.Controls.Add(this.clearTextBtn);
            this.Controls.Add(this.sendReplyCheckBox);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.writeText);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.stopListening_Btn);
            this.Controls.Add(this.startListening_Btn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Serial Listener";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.Button startListening_Btn;
        private System.Windows.Forms.Button stopListening_Btn;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.TextBox writeText;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.CheckBox sendReplyCheckBox;
        private System.Windows.Forms.Button clearTextBtn;
        private System.Windows.Forms.CheckBox checkBoxHardwareHandshaking;
        private System.Windows.Forms.CheckBox checkBoxXonXoff;
        private System.Windows.Forms.Button loopWrite_btn;
        private System.Windows.Forms.Button stopLoop_Btn;
    }
}

