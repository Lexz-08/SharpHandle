using System;
using System.Runtime.InteropServices;

namespace SharpHandle
{
	public class HandleGetter
	{
		#region PInvoke
		[DllImport("user32")]
		private static extern IntPtr FindWindow(string sClassName, string sWindowName);

		[DllImport("user32")]
		private static extern IntPtr GetForegroundWindow();
		#endregion
		#region Functions
		public static IntPtr GetWindowHandle(string WindowTitle) => FindWindow(null, WindowTitle);
		public static IntPtr GetFocusedWindowHandle() => GetForegroundWindow();
		#endregion
	}
}
