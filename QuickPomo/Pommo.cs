using System;
using System.IO;
using System.Windows.Forms;

namespace QuickPomo {
	public partial class Pommo : Form {
		private DateTime pomoStarted;
		private NewPommo lastNewScreen;

		public Pommo () {
			InitializeComponent();
			pomoStarted = DateTime.MinValue;
		}

		void SetNewPomo (object sender, TextEventArgs e) {
			pomoStarted = DateTime.Now;
			LogPommoStart(pomoStarted,e.Text);
			Text = e.Text;
		}

		private void pomoTimerTick (object sender, EventArgs e) {
			var minutes = (DateTime.Now - pomoStarted).TotalMinutes;
			var prop = Math.Max(Math.Min(25.0, minutes), 0) / 25.0;

			pomoProgress.Value = (int)((prop * pomoProgress.Maximum) - pomoProgress.Minimum);
		}

		private void pomoProgress_Click (object sender, EventArgs e) {
			if (lastNewScreen != null) lastNewScreen.Close();
			var newPomo = new NewPommo();
			newPomo.NewPomo += SetNewPomo;
			newPomo.EndCurrentPomo += EndCurrentCurrentPomo;
			lastNewScreen = newPomo;
			FitFormNearSelf(newPomo);
		}

		void FitFormNearSelf(Form newPomo) {
			var p = Location;
			var screen = Screen.GetBounds(this);

			var offset_bottom = (p.Y + Height + newPomo.Height + 20);

			if (offset_bottom < screen.Bottom) {
				p.Offset(0, Height + 8);
			} else {
				p.Offset(0, -newPomo.Height - 8);
			}

			newPomo.Show();
			newPomo.Location = p;
		}

		private void EndCurrentCurrentPomo (object sender, TextEventArgs e) {
			pomoStarted = DateTime.MinValue;
			LogPommoEnded(e.Text);
		}

		private void Pommo_FormClosing (object sender, FormClosingEventArgs e) {
			LogPommoClosed();
		}

		private void LogPommoEnded (string reason) {
			try {
				File.AppendAllText(@"C:\PomoSessions.txt",
								   "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " -- [Ended]   " + reason);
			} catch {
				ignore();
			}
		}

		private void LogPommoStart(DateTime started, string target) {
			try {
				File.AppendAllText(@"C:\PomoSessions.txt",
								   "\r\n" + started.ToString("yyyy-MM-dd HH:mm:ss") +      " -- [Started] " + target);
			} catch {
				ignore();
			}
		}

		private void LogPommoClosed() {
			try {
				File.AppendAllText(@"C:\PomoSessions.txt",
								   "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " -- [Closed]  ");
			} catch {
				ignore();
			}
		}

		private void ignore() {}
	}
}
