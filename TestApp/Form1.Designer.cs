
namespace TestApp
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.thisWindow = new System.Windows.Forms.Button();
			this.selectedHandle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.windowTitle = new System.Windows.Forms.TextBox();
			this.selectWindow = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selected Handle:";
			// 
			// thisWindow
			// 
			this.thisWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.thisWindow.Location = new System.Drawing.Point(568, 10);
			this.thisWindow.Name = "thisWindow";
			this.thisWindow.Size = new System.Drawing.Size(113, 29);
			this.thisWindow.TabIndex = 2;
			this.thisWindow.Text = "This Window";
			this.toolTip1.SetToolTip(this.thisWindow, "Get the handle of this window.");
			this.thisWindow.UseVisualStyleBackColor = true;
			this.thisWindow.Click += new System.EventHandler(this.thisWindow_Click);
			// 
			// selectedHandle
			// 
			this.selectedHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectedHandle.BackColor = System.Drawing.SystemColors.ControlLight;
			this.selectedHandle.Location = new System.Drawing.Point(127, 15);
			this.selectedHandle.Name = "selectedHandle";
			this.selectedHandle.Size = new System.Drawing.Size(435, 19);
			this.selectedHandle.TabIndex = 3;
			this.selectedHandle.Text = "-none-";
			this.toolTip1.SetToolTip(this.selectedHandle, "The handle of the currently selected window.");
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(667, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Get Focused Window: Shift + W";
			// 
			// windowTitle
			// 
			this.windowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.windowTitle.Location = new System.Drawing.Point(109, 66);
			this.windowTitle.Name = "windowTitle";
			this.windowTitle.Size = new System.Drawing.Size(451, 25);
			this.windowTitle.TabIndex = 5;
			this.toolTip1.SetToolTip(this.windowTitle, "The title of the window to get the handle from.");
			// 
			// selectWindow
			// 
			this.selectWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectWindow.Location = new System.Drawing.Point(566, 64);
			this.selectWindow.Name = "selectWindow";
			this.selectWindow.Size = new System.Drawing.Size(113, 29);
			this.selectWindow.TabIndex = 6;
			this.selectWindow.Text = "Select Window";
			this.toolTip1.SetToolTip(this.selectWindow, "Get the handle of the window with the specified title.");
			this.selectWindow.UseVisualStyleBackColor = true;
			this.selectWindow.Click += new System.EventHandler(this.selectWindow_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Window Title:";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(691, 106);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.selectWindow);
			this.Controls.Add(this.windowTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.selectedHandle);
			this.Controls.Add(this.thisWindow);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button thisWindow;
		private System.Windows.Forms.Label selectedHandle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox windowTitle;
		private System.Windows.Forms.Button selectWindow;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

