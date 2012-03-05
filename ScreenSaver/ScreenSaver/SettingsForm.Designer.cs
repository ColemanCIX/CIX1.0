namespace ScreenSaver
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.cmbColeman = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbOtherChannel = new System.Windows.Forms.ComboBox();
            this.lblChannel1 = new System.Windows.Forms.Label();
            this.lblChannel2 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(85, 258);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(186, 258);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // colorDlg
            // 
            this.colorDlg.AnyColor = true;
            // 
            // cmbInterval
            // 
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "30 seconds",
            "60 seconds",
            "90 seconds",
            "120 seconds"});
            this.cmbInterval.Location = new System.Drawing.Point(47, 214);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(265, 21);
            this.cmbInterval.TabIndex = 7;
            // 
            // cmbColeman
            // 
            this.cmbColeman.FormattingEnabled = true;
            this.cmbColeman.Items.AddRange(new object[] {
            "Student Feed",
            "Faculty Feed",
            "Generic Feed"});
            this.cmbColeman.Location = new System.Drawing.Point(47, 71);
            this.cmbColeman.Name = "cmbColeman";
            this.cmbColeman.Size = new System.Drawing.Size(265, 21);
            this.cmbColeman.TabIndex = 8;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(333, 35);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Which news feeds would you like to subscribe to?";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbOtherChannel
            // 
            this.cmbOtherChannel.FormattingEnabled = true;
            this.cmbOtherChannel.Items.AddRange(new object[] {
            "Student Feed",
            "Faculty Feed",
            "Union Tribune Local News",
            "CNET News",
            "Microsoft News"});
            this.cmbOtherChannel.Location = new System.Drawing.Point(47, 125);
            this.cmbOtherChannel.Name = "cmbOtherChannel";
            this.cmbOtherChannel.Size = new System.Drawing.Size(265, 21);
            this.cmbOtherChannel.TabIndex = 10;
            // 
            // lblChannel1
            // 
            this.lblChannel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel1.Location = new System.Drawing.Point(47, 47);
            this.lblChannel1.Name = "lblChannel1";
            this.lblChannel1.Size = new System.Drawing.Size(265, 23);
            this.lblChannel1.TabIndex = 11;
            this.lblChannel1.Text = "Coleman Channel";
            this.lblChannel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChannel2
            // 
            this.lblChannel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannel2.Location = new System.Drawing.Point(47, 101);
            this.lblChannel2.Name = "lblChannel2";
            this.lblChannel2.Size = new System.Drawing.Size(265, 23);
            this.lblChannel2.TabIndex = 12;
            this.lblChannel2.Text = "Other Channel";
            this.lblChannel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInterval
            // 
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(46, 190);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(265, 23);
            this.lblInterval.TabIndex = 13;
            this.lblInterval.Text = "Select Article Rotation Speed";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 298);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblChannel2);
            this.Controls.Add(this.lblChannel1);
            this.Controls.Add(this.cmbOtherChannel);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbColeman);
            this.Controls.Add(this.cmbInterval);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "SettingsForm";
            this.Text = "CIX Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.ComboBox cmbInterval;
        private System.Windows.Forms.ComboBox cmbColeman;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbOtherChannel;
        private System.Windows.Forms.Label lblChannel1;
        private System.Windows.Forms.Label lblChannel2;
        private System.Windows.Forms.Label lblInterval;
    }
}