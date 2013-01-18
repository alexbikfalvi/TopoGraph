namespace TopoGraph
{
	partial class FormTerms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerms));
			this.buttonDecline = new System.Windows.Forms.Button();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// buttonDecline
			// 
			this.buttonDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonDecline.Location = new System.Drawing.Point(397, 277);
			this.buttonDecline.Name = "buttonDecline";
			this.buttonDecline.Size = new System.Drawing.Size(75, 23);
			this.buttonDecline.TabIndex = 0;
			this.buttonDecline.Text = "Decline";
			this.buttonDecline.UseVisualStyleBackColor = true;
			// 
			// buttonAccept
			// 
			this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAccept.Location = new System.Drawing.Point(316, 277);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(75, 23);
			this.buttonAccept.TabIndex = 1;
			this.buttonAccept.Text = "Accept";
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.OnAccept);
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.Location = new System.Drawing.Point(12, 12);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.ReadOnly = true;
			this.richTextBox.Size = new System.Drawing.Size(460, 259);
			this.richTextBox.TabIndex = 2;
			this.richTextBox.Text = "";
			// 
			// FormTerms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonDecline;
			this.ClientSize = new System.Drawing.Size(484, 312);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.buttonDecline);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FormTerms";
			this.ShowInTaskbar = false;
			this.Text = "Download Terms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDecline;
		private System.Windows.Forms.Button buttonAccept;
		private System.Windows.Forms.RichTextBox richTextBox;
	}
}