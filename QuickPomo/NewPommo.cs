using System;
using System.Windows.Forms;

namespace QuickPomo {
	public partial class NewPommo : Form {
		private bool cancelOk;

		public NewPommo () {
			cancelOk = false;
			InitializeComponent();
		}

		public event EventHandler<TextEventArgs> NewPomo;
		public event EventHandler<TextEventArgs> EndCurrentPomo;

		public void InvokeNewPomo(string text) {
			var handler = NewPomo;
			if (handler != null) handler(this, new TextEventArgs{Text = text});
		}

		private void InvokeEndCurrentPomo (string reason) {
			var handler = EndCurrentPomo;
			if (handler != null) handler(this, new TextEventArgs { Text = reason });
		}

		private void cancelButton_Click (object sender, EventArgs e) {
			Close();
		}

		private void okButton_Click (object sender, EventArgs e) {
			if (cancelOk) {
				cancelOk = false;
				return;
			}
			InvokeNewPomo(newPomoText.Text);
			Close();
		}

		private void endCurrentButton_Click (object sender, EventArgs e) {
			InvokeEndCurrentPomo(newPomoText.Text);
			Close();
		}

		private void newPomoText_PreviewKeyDown (object sender, PreviewKeyDownEventArgs e) {
			if (e.Shift && (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)) {
				newPomoText.Text += "\r\n";
				newPomoText.SelectionStart = newPomoText.Text.Length;
				cancelOk = true;
			}
		}

	}
}
