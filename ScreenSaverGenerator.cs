using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScreenSaver
{
	public partial class ScreenSaverGenerator : Form
    {
		private Point MouseXY;
		protected ScrParameters parameters;
		public List<ScreenSaverForm> Ls = new List<ScreenSaverForm>();

		public ScreenSaverGenerator(ScrParameters p)
        {
            InitializeComponent();
			parameters = p;
			
        }

		private void ScreenSaverGenerator_Load(object sender, System.EventArgs e)
		{
			for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++)
			{
				ScreenSaverForm sf = new ScreenSaverForm(i, parameters); //sf.Owner = this;
				sf.Show();
				Ls.Add(sf);
			}

			TopMost = true;
			Size = new Size(1, 1);
			Location = new Point(0, 0);
			Cursor.Hide();
		}

		private void OnMouseEvent(object sender, MouseEventArgs e)
		{
			if (!MouseXY.IsEmpty)			
			{
				if (MouseXY != new Point(e.X, e.Y))
					EndScreenSaver();
				if (e.Clicks > 0)
					EndScreenSaver();
			}
			MouseXY = new Point(e.X, e.Y);
		}

		private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
		{
			EndScreenSaver();
		}

		public void EndScreenSaver()
        {
			foreach(ScreenSaverForm f in Ls) { f.Close();  }
			Close();
		}
	}
}
