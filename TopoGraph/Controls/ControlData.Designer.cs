namespace TopoGraph.Controls
{
	partial class ControlData
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlData));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonDataset = new System.Windows.Forms.ToolStripDropDownButton();
			this.menuItemSkitter = new System.Windows.Forms.ToolStripMenuItem();
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDataset});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(600, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			// 
			// buttonDataset
			// 
			this.buttonDataset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSkitter});
			this.buttonDataset.Image = global::TopoGraph.Resources.Database_16;
			this.buttonDataset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonDataset.Name = "buttonDataset";
			this.buttonDataset.Size = new System.Drawing.Size(110, 22);
			this.buttonDataset.Text = "Skitter dataset";
			// 
			// menuItemSkitter
			// 
			this.menuItemSkitter.Checked = true;
			this.menuItemSkitter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuItemSkitter.Name = "menuItemSkitter";
			this.menuItemSkitter.Size = new System.Drawing.Size(148, 22);
			this.menuItemSkitter.Text = "Skitter dataset";
			// 
			// listView
			// 
			this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderFile});
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.FullRowSelect = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(0, 25);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(600, 375);
			this.listView.SmallImageList = this.imageList;
			this.listView.TabIndex = 1;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.ItemActivate += new System.EventHandler(this.OnItemActivate);
			// 
			// columnHeaderDate
			// 
			this.columnHeaderDate.Text = "Date";
			this.columnHeaderDate.Width = 120;
			// 
			// columnHeaderFile
			// 
			this.columnHeaderFile.Text = "File";
			this.columnHeaderFile.Width = 320;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Topology_16.png");
			// 
			// ControlData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listView);
			this.Controls.Add(this.toolStrip);
			this.Enabled = false;
			this.Name = "ControlData";
			this.Size = new System.Drawing.Size(600, 400);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeaderDate;
		private System.Windows.Forms.ToolStripDropDownButton buttonDataset;
		private System.Windows.Forms.ToolStripMenuItem menuItemSkitter;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ColumnHeader columnHeaderFile;
	}
}
