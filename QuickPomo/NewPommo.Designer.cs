namespace QuickPomo {
	partial class NewPommo {
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
			this.newPomoText = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.endCurrentButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newPomoText
			// 
			this.newPomoText.AcceptsTab = true;
			this.newPomoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newPomoText.Location = new System.Drawing.Point(12, 29);
			this.newPomoText.Multiline = true;
			this.newPomoText.Name = "newPomoText";
			this.newPomoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.newPomoText.Size = new System.Drawing.Size(343, 167);
			this.newPomoText.TabIndex = 0;
			this.newPomoText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.newPomoText_PreviewKeyDown);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(280, 202);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "Start";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(12, 202);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// endCurrentButton
			// 
			this.endCurrentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.endCurrentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.endCurrentButton.Location = new System.Drawing.Point(199, 202);
			this.endCurrentButton.Name = "endCurrentButton";
			this.endCurrentButton.Size = new System.Drawing.Size(75, 23);
			this.endCurrentButton.TabIndex = 3;
			this.endCurrentButton.Text = "End Current";
			this.endCurrentButton.UseVisualStyleBackColor = true;
			this.endCurrentButton.Click += new System.EventHandler(this.endCurrentButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Goal or End reason:";
			// 
			// NewPommo
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(367, 237);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.endCurrentButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.newPomoText);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(277, 155);
			this.Name = "NewPommo";
			this.Text = "Change Pommo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox newPomoText;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button endCurrentButton;
		private System.Windows.Forms.Label label1;
	}
}