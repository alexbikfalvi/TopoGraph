namespace TopoGraph
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.sideMenu = new DotNetApi.Windows.Controls.SideMenu();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.controlDataset = new TopoGraph.Controls.ControlDataset();
			this.controlTopology = new TopoGraph.Controls.ControlTopology();
			this.controlData = new TopoGraph.Controls.ControlData();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.sideMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(784, 516);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(784, 562);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(784, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.sideMenu);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.controlData);
			this.splitContainer.Size = new System.Drawing.Size(784, 516);
			this.splitContainer.SplitterDistance = 250;
			this.splitContainer.TabIndex = 0;
			// 
			// sideMenu
			// 
			this.sideMenu.Controls.Add(this.controlDataset);
			this.sideMenu.Controls.Add(this.controlTopology);
			this.sideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sideMenu.HiddenItems = 0;
			this.sideMenu.ItemHeight = 48;
			this.sideMenu.Location = new System.Drawing.Point(0, 0);
			this.sideMenu.MinimizedItems = 0;
			this.sideMenu.MinimizedItemWidth = 25;
			this.sideMenu.MinimumPanelHeight = 50;
			this.sideMenu.Name = "sideMenu";
			this.sideMenu.Padding = new System.Windows.Forms.Padding(0, 28, 0, 56);
			this.sideMenu.SelectedItem = null;
			this.sideMenu.Size = new System.Drawing.Size(248, 514);
			this.sideMenu.TabIndex = 0;
			this.sideMenu.VisibleItems = 0;
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(784, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuItemFile
			// 
			this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClose});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Size = new System.Drawing.Size(37, 20);
			this.menuItemFile.Text = "&File";
			// 
			// menuItemClose
			// 
			this.menuItemClose.Name = "menuItemClose";
			this.menuItemClose.Size = new System.Drawing.Size(103, 22);
			this.menuItemClose.Text = "&Close";
			this.menuItemClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
			this.menuItemHelp.Name = "menuItemHelp";
			this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
			this.menuItemHelp.Text = "&Help";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Name = "menuItemAbout";
			this.menuItemAbout.Size = new System.Drawing.Size(116, 22);
			this.menuItemAbout.Text = "&About...";
			this.menuItemAbout.Click += new System.EventHandler(this.OnClickAbout);
			// 
			// controlDataset
			// 
			this.controlDataset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlDataset.Enabled = false;
			this.controlDataset.Location = new System.Drawing.Point(0, 28);
			this.controlDataset.Name = "controlDataset";
			this.controlDataset.Size = new System.Drawing.Size(248, 430);
			this.controlDataset.TabIndex = 1;
			this.controlDataset.Visible = false;
			// 
			// controlTopology
			// 
			this.controlTopology.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlTopology.Enabled = false;
			this.controlTopology.Location = new System.Drawing.Point(0, 28);
			this.controlTopology.Name = "controlTopology";
			this.controlTopology.Size = new System.Drawing.Size(248, 430);
			this.controlTopology.TabIndex = 0;
			this.controlTopology.Visible = false;
			// 
			// controlData
			// 
			this.controlData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlData.Enabled = false;
			this.controlData.Location = new System.Drawing.Point(0, 0);
			this.controlData.Name = "controlData";
			this.controlData.Size = new System.Drawing.Size(528, 514);
			this.controlData.TabIndex = 0;
			this.controlData.Visible = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.Text = "TopoGraph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.sideMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuItemFile;
		private System.Windows.Forms.ToolStripMenuItem menuItemClose;
		private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
		private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private DotNetApi.Windows.Controls.SideMenu sideMenu;
		private Controls.ControlDataset controlDataset;
		private Controls.ControlTopology controlTopology;
		private Controls.ControlData controlData;
	}
}

