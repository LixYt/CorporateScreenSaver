using System;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class ScreenSaverForm : Form
	{
		private readonly System.ComponentModel.IContainer components;
		private Point MouseXY;
		private int ScreenNumber;
		protected ScrParameters parameters;
		public bool Stop = false;

		public ScreenSaverForm(int scrn, ScrParameters p)
		{
			InitializeComponent();

			ScreenNumber = scrn;
						
			Name = $"Screen{scrn}";

			BackgroundImage = Image.FromFile(p.imgPath);
			BackgroundImageLayout = ImageLayout.Zoom;

			parameters = p;
		}

		private void ScreenSaverForm_Load(object sender, System.EventArgs e)
		{
			Bounds = Screen.AllScreens[ScreenNumber].Bounds;
			TopMost = true;
		}

		private void OnMouseEvent(object sender, MouseEventArgs e)
		{
			if (!MouseXY.IsEmpty)
			{
				if (MouseXY != new Point(e.X, e.Y))
					CallClosing();
				if (e.Clicks > 0)
					CallClosing();
			}
			MouseXY = new Point(e.X, e.Y);
		}

		public void CallClosing()
        {
			Application.Exit();
        }

		private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
		{
			CallClosing();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.ShowInTaskbar = false;
            this.Text = "ScreenSaver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenSaverForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.ResumeLayout(false);

		}
        #endregion

        private void ScreenSaverForm_Paint(object sender, PaintEventArgs e)
        {
			// Create font and brush.
			Font drawFontGrand = new Font("Arial", 32);
			Font drawFont = new Font("Arial", 16);
			Font drawFontGrandBold = new Font("Arial", 32, FontStyle.Bold);

			SolidBrush drawBrushClassif = new SolidBrush(Color.FromArgb(parameters.CouleurClassif));
			SolidBrush drawBrushNormal = new SolidBrush(Color.Black);
			SolidBrush drawBrushWhite = new SolidBrush(Color.White);

			Size sizeClassif = TextRenderer.MeasureText(e.Graphics, parameters.classification, drawFontGrand);
			Size sizeMentions = TextRenderer.MeasureText(e.Graphics, parameters.mentions, drawFont);
			Size sizeSysteme = TextRenderer.MeasureText(e.Graphics, parameters.systeme, drawFontGrandBold);
			Size sizeEntite = TextRenderer.MeasureText(e.Graphics, parameters.entite, drawFontGrand);

			// Set format of string.
			StringFormat drawFormat = new StringFormat();

			//BackClassif
			Rectangle rec = new Rectangle((Size.Width / 2 - sizeClassif.Width / 2) - 10, 90, sizeClassif.Width + 20, sizeClassif.Height+20);
			e.Graphics.FillRectangle(drawBrushWhite, rec);
			Pen pen = new Pen(drawBrushClassif, 3);
			e.Graphics.DrawRectangle(pen, rec);

			//Back mentions
			Rectangle rec2 = new Rectangle((Size.Width / 2 - sizeMentions.Width / 2) - 10, Height - 110, sizeMentions.Width + 20, sizeMentions.Height + 20);
			e.Graphics.FillRectangle(drawBrushWhite, rec2);
			Pen pen2 = new Pen(drawBrushNormal, 3);
			e.Graphics.DrawRectangle(pen2, rec2);

			//Back Mentions
			e.Graphics.DrawString(parameters.classification, drawFontGrand, drawBrushClassif, (Size.Width / 2 - sizeClassif.Width / 2), 100, drawFormat);
			e.Graphics.DrawString(parameters.mentions, drawFont, drawBrushNormal, (Size.Width / 2 - sizeMentions.Width / 2), Height-100, drawFormat);
			e.Graphics.DrawString(parameters.systeme, drawFontGrandBold, drawBrushNormal, (Size.Width / 2 - sizeSysteme.Width / 2), Height/2, drawFormat);
			e.Graphics.DrawString(parameters.entite, drawFontGrand, drawBrushNormal, (Size.Width / 2 - sizeEntite.Width / 2), Height/2-100, drawFormat);
		}

        private void ScreenSaverForm_Click(object sender, EventArgs e)
        {
			CallClosing();
        }
    }
}
