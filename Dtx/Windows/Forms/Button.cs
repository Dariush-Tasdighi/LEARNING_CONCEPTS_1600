﻿namespace Dtx.Windows.Forms
{
	public class Button : System.Windows.Forms.Button
	{
		public Button() : base()
		{
			Cursor = System.Windows.Forms.Cursors.Hand;
		}

		//protected override void OnMouseEnter(System.EventArgs e)
		//{
		//	base.OnMouseEnter(e);
		//}

		//protected override void OnMouseLeave(System.EventArgs e)
		//{
		//	base.OnMouseLeave(e);
		//}

		protected override void OnMouseEnter(System.EventArgs e)
		{
			base.OnMouseEnter(e);

			BackColor = System.Drawing.Color.Khaki;
		}

		protected override void OnMouseLeave(System.EventArgs e)
		{
			base.OnMouseLeave(e);

			BackColor = System.Drawing.Color.Silver;
		}
	}
}
