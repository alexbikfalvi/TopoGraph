namespace TopoGraph.Controls
{
	partial class ControlDataset
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.groupBoxSkitter = new System.Windows.Forms.GroupBox();
			this.buttonSkitter = new System.Windows.Forms.Button();
			this.labelSkitterTo = new System.Windows.Forms.Label();
			this.dateTimePickerSkitterTo = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerSkitterFrom = new System.Windows.Forms.DateTimePicker();
			this.labelSkitterFrom = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.groupBoxSkitter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Location = new System.Drawing.Point(59, 4);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(138, 48);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "Download the AS links datasets from the CAIDA project.";
			// 
			// groupBoxSkitter
			// 
			this.groupBoxSkitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSkitter.Controls.Add(this.buttonSkitter);
			this.groupBoxSkitter.Controls.Add(this.labelSkitterTo);
			this.groupBoxSkitter.Controls.Add(this.dateTimePickerSkitterTo);
			this.groupBoxSkitter.Controls.Add(this.dateTimePickerSkitterFrom);
			this.groupBoxSkitter.Controls.Add(this.labelSkitterFrom);
			this.groupBoxSkitter.Location = new System.Drawing.Point(4, 59);
			this.groupBoxSkitter.Name = "groupBoxSkitter";
			this.groupBoxSkitter.Size = new System.Drawing.Size(193, 105);
			this.groupBoxSkitter.TabIndex = 0;
			this.groupBoxSkitter.TabStop = false;
			this.groupBoxSkitter.Text = "Skitter data";
			// 
			// buttonSkitter
			// 
			this.buttonSkitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSkitter.Location = new System.Drawing.Point(6, 76);
			this.buttonSkitter.Name = "buttonSkitter";
			this.buttonSkitter.Size = new System.Drawing.Size(75, 23);
			this.buttonSkitter.TabIndex = 0;
			this.buttonSkitter.Text = "Download";
			this.buttonSkitter.UseVisualStyleBackColor = true;
			this.buttonSkitter.Click += new System.EventHandler(this.OnDownloadSkitter);
			// 
			// labelSkitterTo
			// 
			this.labelSkitterTo.AutoSize = true;
			this.labelSkitterTo.Location = new System.Drawing.Point(6, 51);
			this.labelSkitterTo.Name = "labelSkitterTo";
			this.labelSkitterTo.Size = new System.Drawing.Size(23, 13);
			this.labelSkitterTo.TabIndex = 3;
			this.labelSkitterTo.Text = "To:";
			// 
			// dateTimePickerSkitterTo
			// 
			this.dateTimePickerSkitterTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerSkitterTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerSkitterTo.Location = new System.Drawing.Point(45, 45);
			this.dateTimePickerSkitterTo.MaxDate = new System.DateTime(2008, 2, 7, 0, 0, 0, 0);
			this.dateTimePickerSkitterTo.MinDate = new System.DateTime(2000, 1, 2, 0, 0, 0, 0);
			this.dateTimePickerSkitterTo.Name = "dateTimePickerSkitterTo";
			this.dateTimePickerSkitterTo.Size = new System.Drawing.Size(142, 20);
			this.dateTimePickerSkitterTo.TabIndex = 4;
			this.dateTimePickerSkitterTo.Value = new System.DateTime(2008, 2, 7, 0, 0, 0, 0);
			this.dateTimePickerSkitterTo.ValueChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// dateTimePickerSkitterFrom
			// 
			this.dateTimePickerSkitterFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerSkitterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerSkitterFrom.Location = new System.Drawing.Point(45, 19);
			this.dateTimePickerSkitterFrom.MaxDate = new System.DateTime(2008, 2, 7, 0, 0, 0, 0);
			this.dateTimePickerSkitterFrom.MinDate = new System.DateTime(2000, 1, 2, 0, 0, 0, 0);
			this.dateTimePickerSkitterFrom.Name = "dateTimePickerSkitterFrom";
			this.dateTimePickerSkitterFrom.Size = new System.Drawing.Size(142, 20);
			this.dateTimePickerSkitterFrom.TabIndex = 2;
			this.dateTimePickerSkitterFrom.Value = new System.DateTime(2000, 1, 2, 0, 0, 0, 0);
			this.dateTimePickerSkitterFrom.ValueChanged += new System.EventHandler(this.OnValueChanged);
			// 
			// labelSkitterFrom
			// 
			this.labelSkitterFrom.AutoSize = true;
			this.labelSkitterFrom.Location = new System.Drawing.Point(6, 25);
			this.labelSkitterFrom.Name = "labelSkitterFrom";
			this.labelSkitterFrom.Size = new System.Drawing.Size(33, 13);
			this.labelSkitterFrom.TabIndex = 1;
			this.labelSkitterFrom.Text = "From:";
			// 
			// pictureBox
			// 
			this.pictureBox.Image = global::TopoGraph.Resources.ServersDatabase_48;
			this.pictureBox.Location = new System.Drawing.Point(4, 4);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(48, 48);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// ControlDataset
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxSkitter);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox);
			this.Enabled = false;
			this.Name = "ControlDataset";
			this.Size = new System.Drawing.Size(200, 300);
			this.groupBoxSkitter.ResumeLayout(false);
			this.groupBoxSkitter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.GroupBox groupBoxSkitter;
		private System.Windows.Forms.DateTimePicker dateTimePickerSkitterFrom;
		private System.Windows.Forms.Label labelSkitterFrom;
		private System.Windows.Forms.DateTimePicker dateTimePickerSkitterTo;
		private System.Windows.Forms.Label labelSkitterTo;
		private System.Windows.Forms.Button buttonSkitter;
	}
}
