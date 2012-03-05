namespace ScreenSaver
{
    partial class AnalogClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogClock));
            this.tmrAnalogClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrAnalogClock
            // 
            this.tmrAnalogClock.Interval = 1000;
            this.tmrAnalogClock.Tick += new System.EventHandler(this.tmrAnalogClock_Tick);
            // 
            // AnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "AnalogClock";
            this.Resize += new System.EventHandler(this.AnalogClock_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnalogClock;
    }
}