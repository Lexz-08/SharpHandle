using SharpHandle;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private IntPtr selectedWindow;

		[DllImport("user32")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifier, uint key);

		[DllImport("user32")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			RegisterHotKey(Handle, 0, 0x0004, (uint)Keys.W);
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			UnregisterHotKey(Handle, 1);
		}
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0312)
			{
				if (m.WParam.ToInt32() == 0)
				{
					selectedWindow = HandleGetter.GetFocusedWindowHandle();
				}
			}

			try
			{
				selectedHandle.Text = selectedWindow.ToString();
			}
			catch
			{
			}

			base.WndProc(ref m);
		}

		private void thisWindow_Click(object sender, System.EventArgs e)
		{
			selectedWindow = Handle;
		}

		private void selectWindow_Click(object sender, EventArgs e)
		{
			selectedWindow = HandleGetter.GetWindowHandle(windowTitle.Text);
		}
	}
}
