namespace ScreenSaver
{
    partial class ScreenSaverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaverForm));
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.rotateTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.lblLow = new System.Windows.Forms.Label();
            this.grpTomorrow = new System.Windows.Forms.GroupBox();
            this.lblTomorrowTemps = new System.Windows.Forms.Label();
            this.lblTomorrowStatus = new System.Windows.Forms.Label();
            this.lblCurrentWeather = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblWeatherStatus = new System.Windows.Forms.Label();
            this.lblWeatherHeader = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.pnlArticle2 = new System.Windows.Forms.Panel();
            this.pnlArticle1 = new System.Windows.Forms.Panel();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.lblEvents3 = new System.Windows.Forms.Label();
            this.lblEvents2 = new System.Windows.Forms.Label();
            this.lblEvents1 = new System.Windows.Forms.Label();
            this.lblEventsHeader = new System.Windows.Forms.Label();
            this.picCixLogo = new System.Windows.Forms.PictureBox();
            this.analogClock = new ScreenSaver.AnalogClock();
            this.pnlWeather.SuspendLayout();
            this.grpTomorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.pnlArticle2.SuspendLayout();
            this.pnlArticle1.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCixLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rotateTimer
            // 
            this.rotateTimer.Interval = 5000;
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWeather.BackgroundImage")));
            this.pnlWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeather.Controls.Add(this.lblLow);
            this.pnlWeather.Controls.Add(this.grpTomorrow);
            this.pnlWeather.Controls.Add(this.lblCurrentWeather);
            this.pnlWeather.Controls.Add(this.lblHigh);
            this.pnlWeather.Controls.Add(this.lblWeatherStatus);
            this.pnlWeather.Controls.Add(this.lblWeatherHeader);
            this.pnlWeather.Controls.Add(this.picWeatherIcon);
            this.pnlWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWeather.Location = new System.Drawing.Point(973, 30);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(276, 493);
            this.pnlWeather.TabIndex = 3;
            // 
            // lblLow
            // 
            this.lblLow.BackColor = System.Drawing.Color.Transparent;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.White;
            this.lblLow.Location = new System.Drawing.Point(-2, 304);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(276, 23);
            this.lblLow.TabIndex = 7;
            this.lblLow.Text = "Low: 52";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpTomorrow
            // 
            this.grpTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.grpTomorrow.Controls.Add(this.lblTomorrowTemps);
            this.grpTomorrow.Controls.Add(this.lblTomorrowStatus);
            this.grpTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTomorrow.ForeColor = System.Drawing.Color.White;
            this.grpTomorrow.Location = new System.Drawing.Point(24, 349);
            this.grpTomorrow.Name = "grpTomorrow";
            this.grpTomorrow.Size = new System.Drawing.Size(225, 118);
            this.grpTomorrow.TabIndex = 10;
            this.grpTomorrow.TabStop = false;
            this.grpTomorrow.Text = "Tomorrow";
            // 
            // lblTomorrowTemps
            // 
            this.lblTomorrowTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowTemps.ForeColor = System.Drawing.Color.White;
            this.lblTomorrowTemps.Location = new System.Drawing.Point(6, 70);
            this.lblTomorrowTemps.Name = "lblTomorrowTemps";
            this.lblTomorrowTemps.Size = new System.Drawing.Size(213, 33);
            this.lblTomorrowTemps.TabIndex = 9;
            this.lblTomorrowTemps.Text = "High: 70 / Low: 54 ";
            this.lblTomorrowTemps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTomorrowStatus
            // 
            this.lblTomorrowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowStatus.ForeColor = System.Drawing.Color.White;
            this.lblTomorrowStatus.Location = new System.Drawing.Point(6, 34);
            this.lblTomorrowStatus.Name = "lblTomorrowStatus";
            this.lblTomorrowStatus.Size = new System.Drawing.Size(213, 23);
            this.lblTomorrowStatus.TabIndex = 8;
            this.lblTomorrowStatus.Text = "Sunny";
            this.lblTomorrowStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentWeather
            // 
            this.lblCurrentWeather.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeather.ForeColor = System.Drawing.Color.White;
            this.lblCurrentWeather.Location = new System.Drawing.Point(-2, 241);
            this.lblCurrentWeather.Name = "lblCurrentWeather";
            this.lblCurrentWeather.Size = new System.Drawing.Size(276, 36);
            this.lblCurrentWeather.TabIndex = 6;
            this.lblCurrentWeather.Text = "Currently: 57";
            this.lblCurrentWeather.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHigh
            // 
            this.lblHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.White;
            this.lblHigh.Location = new System.Drawing.Point(-2, 274);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(276, 41);
            this.lblHigh.TabIndex = 5;
            this.lblHigh.Text = "High: 68";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeatherStatus
            // 
            this.lblWeatherStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherStatus.ForeColor = System.Drawing.Color.White;
            this.lblWeatherStatus.Location = new System.Drawing.Point(-2, 59);
            this.lblWeatherStatus.Name = "lblWeatherStatus";
            this.lblWeatherStatus.Size = new System.Drawing.Size(276, 35);
            this.lblWeatherStatus.TabIndex = 4;
            this.lblWeatherStatus.Text = "Sunny";
            this.lblWeatherStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeatherHeader
            // 
            this.lblWeatherHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(8)))));
            this.lblWeatherHeader.Location = new System.Drawing.Point(-2, 14);
            this.lblWeatherHeader.Name = "lblWeatherHeader";
            this.lblWeatherHeader.Size = new System.Drawing.Size(276, 44);
            this.lblWeatherHeader.TabIndex = 3;
            this.lblWeatherHeader.Text = "Today\'s Forecast";
            this.lblWeatherHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.picWeatherIcon.Image = global::ScreenSaver.Properties.Resources.Sunny;
            this.picWeatherIcon.Location = new System.Drawing.Point(61, 97);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(155, 130);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 2;
            this.picWeatherIcon.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.Transparent;
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(350, 42);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(584, 77);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 1;
            this.picHeader.TabStop = false;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Black;
            this.lblTitle2.Location = new System.Drawing.Point(2, -2);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(590, 74);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "Title 2";
            // 
            // lblDescription2
            // 
            this.lblDescription2.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.ForeColor = System.Drawing.Color.Black;
            this.lblDescription2.Location = new System.Drawing.Point(3, 85);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(595, 106);
            this.lblDescription2.TabIndex = 6;
            this.lblDescription2.Text = "Description 2";
            // 
            // pnlArticle2
            // 
            this.pnlArticle2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlArticle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlArticle2.BackgroundImage")));
            this.pnlArticle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlArticle2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArticle2.Controls.Add(this.lblTitle2);
            this.pnlArticle2.Controls.Add(this.lblDescription2);
            this.pnlArticle2.Location = new System.Drawing.Point(343, 496);
            this.pnlArticle2.Name = "pnlArticle2";
            this.pnlArticle2.Size = new System.Drawing.Size(600, 195);
            this.pnlArticle2.TabIndex = 7;
            // 
            // pnlArticle1
            // 
            this.pnlArticle1.BackColor = System.Drawing.Color.Transparent;
            this.pnlArticle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlArticle1.BackgroundImage")));
            this.pnlArticle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlArticle1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArticle1.Controls.Add(this.lblDescription1);
            this.pnlArticle1.Controls.Add(this.lblTitle1);
            this.pnlArticle1.Location = new System.Drawing.Point(343, 150);
            this.pnlArticle1.Name = "pnlArticle1";
            this.pnlArticle1.Size = new System.Drawing.Size(600, 319);
            this.pnlArticle1.TabIndex = 8;
            // 
            // lblDescription1
            // 
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.ForeColor = System.Drawing.Color.Black;
            this.lblDescription1.Location = new System.Drawing.Point(3, 88);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(590, 211);
            this.lblDescription1.TabIndex = 1;
            this.lblDescription1.Text = "Description 1";
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Black;
            this.lblTitle1.Location = new System.Drawing.Point(3, 3);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(595, 76);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Title 1";
            // 
            // pnlEvents
            // 
            this.pnlEvents.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEvents.BackgroundImage")));
            this.pnlEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEvents.Controls.Add(this.picCixLogo);
            this.pnlEvents.Controls.Add(this.lblEvents3);
            this.pnlEvents.Controls.Add(this.lblEvents2);
            this.pnlEvents.Controls.Add(this.lblEvents1);
            this.pnlEvents.Controls.Add(this.lblEventsHeader);
            this.pnlEvents.ForeColor = System.Drawing.Color.White;
            this.pnlEvents.Location = new System.Drawing.Point(29, 30);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(285, 661);
            this.pnlEvents.TabIndex = 10;
            // 
            // lblEvents3
            // 
            this.lblEvents3.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents3.ForeColor = System.Drawing.Color.White;
            this.lblEvents3.Location = new System.Drawing.Point(3, 504);
            this.lblEvents3.Name = "lblEvents3";
            this.lblEvents3.Size = new System.Drawing.Size(275, 150);
            this.lblEvents3.TabIndex = 3;
            this.lblEvents3.Text = "Article 3";
            // 
            // lblEvents2
            // 
            this.lblEvents2.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents2.ForeColor = System.Drawing.Color.White;
            this.lblEvents2.Location = new System.Drawing.Point(3, 297);
            this.lblEvents2.Name = "lblEvents2";
            this.lblEvents2.Size = new System.Drawing.Size(275, 150);
            this.lblEvents2.TabIndex = 2;
            this.lblEvents2.Text = "Article 2";
            // 
            // lblEvents1
            // 
            this.lblEvents1.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents1.ForeColor = System.Drawing.Color.White;
            this.lblEvents1.Location = new System.Drawing.Point(3, 77);
            this.lblEvents1.Name = "lblEvents1";
            this.lblEvents1.Size = new System.Drawing.Size(275, 150);
            this.lblEvents1.TabIndex = 1;
            this.lblEvents1.Text = "Article 1";
            // 
            // lblEventsHeader
            // 
            this.lblEventsHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblEventsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(8)))));
            this.lblEventsHeader.Location = new System.Drawing.Point(3, 10);
            this.lblEventsHeader.Name = "lblEventsHeader";
            this.lblEventsHeader.Size = new System.Drawing.Size(275, 31);
            this.lblEventsHeader.TabIndex = 0;
            this.lblEventsHeader.Text = "Reminders";
            this.lblEventsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picCixLogo
            // 
            this.picCixLogo.BackColor = System.Drawing.Color.Transparent;
            this.picCixLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCixLogo.BackgroundImage")));
            this.picCixLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCixLogo.Location = new System.Drawing.Point(-14, -8);
            this.picCixLogo.Name = "picCixLogo";
            this.picCixLogo.Size = new System.Drawing.Size(176, 114);
            this.picCixLogo.TabIndex = 11;
            this.picCixLogo.TabStop = false;
            this.picCixLogo.Visible = false;
            // 
            // analogClock
            // 
            this.analogClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.analogClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(120)))));
            this.analogClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("analogClock.BackgroundImage")));
            this.analogClock.CalendarType = ScreenSaver.AnalogClock.CalendarTypes.Gregorian;
            this.analogClock.Caption = "CIX";
            this.analogClock.ClockStyle = ScreenSaver.AnalogClock.ClockStyles.Standard;
            this.analogClock.DateStyle = ScreenSaver.AnalogClock.DateStyles.Full;
            this.analogClock.Enabled = false;
            this.analogClock.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogClock.HandColor = System.Drawing.Color.Black;
            this.analogClock.HandStyle = ScreenSaver.AnalogClock.HandStyles.Uniform;
            this.analogClock.InnerColor = System.Drawing.Color.SkyBlue;
            this.analogClock.Location = new System.Drawing.Point(992, 518);
            this.analogClock.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.analogClock.MinimumSize = new System.Drawing.Size(50, 50);
            this.analogClock.Name = "analogClock";
            this.analogClock.NumberStyle = ScreenSaver.AnalogClock.NumberStyles.All;
            this.analogClock.OuterColor = System.Drawing.Color.SteelBlue;
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(244, 202);
            this.analogClock.TabIndex = 4;
            this.analogClock.TextColor = System.Drawing.Color.Black;
            this.analogClock.TickColor = System.Drawing.Color.Black;
            this.analogClock.TickStyle = ScreenSaver.AnalogClock.TickStyles.All;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(183)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.pnlEvents);
            this.Controls.Add(this.pnlArticle1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.pnlArticle2);
            this.Controls.Add(this.analogClock);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.pnlWeather.ResumeLayout(false);
            this.grpTomorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.pnlArticle2.ResumeLayout(false);
            this.pnlArticle1.ResumeLayout(false);
            this.pnlEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCixLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenSaver.AnalogClock analogClock;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer rotateTimer;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblCurrentWeather;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblWeatherStatus;
        private System.Windows.Forms.Label lblWeatherHeader;
        private System.Windows.Forms.GroupBox grpTomorrow;
        private System.Windows.Forms.Label lblTomorrowTemps;
        private System.Windows.Forms.Label lblTomorrowStatus;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Panel pnlArticle2;
        private System.Windows.Forms.Panel pnlArticle1;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label lblEventsHeader;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblEvents2;
        private System.Windows.Forms.Label lblEvents1;
        private System.Windows.Forms.Label lblEvents3;
        private System.Windows.Forms.PictureBox picCixLogo;
    }
}

