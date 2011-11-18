namespace QuickPomo {
	partial class Pommo {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.components = new System.ComponentModel.Container();
			this.pomoProgress = new System.Windows.Forms.ProgressBar();
			this.pomoTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// pomoProgress
			// 
			this.pomoProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pomoProgress.Location = new System.Drawing.Point(0, 0);
			this.pomoProgress.Maximum = 10000;
			this.pomoProgress.Name = "pomoProgress";
			this.pomoProgress.Size = new System.Drawing.Size(852, 14);
			this.pomoProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pomoProgress.TabIndex = 0;
			this.pomoProgress.Click += new System.EventHandler(this.pomoProgress_Click);
			// 
			// pomoTimer
			// 
			this.pomoTimer.Enabled = true;
			this.pomoTimer.Interval = 1000;
			this.pomoTimer.Tick += new System.EventHandler(this.pomoTimerTick);
			// 
			// Pommo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 14);
			this.Controls.Add(this.pomoProgress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Pommo";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Click progress bar to start a pomodoro session (25 minutes)";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pommo_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar pomoProgress;
		private System.Windows.Forms.Timer pomoTimer;
	}
}

