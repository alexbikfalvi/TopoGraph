using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopoGraph.Controls
{
	/// <summary>
	/// A side control for the dataset.
	/// </summary>
	public partial class ControlDataset : UserControl
	{
		private Config config;

		/// <summary>
		/// Creates a new control instance.
		/// </summary>
		public ControlDataset()
		{
			InitializeComponent();
		}

		public event EventHandler<DownloadCompletedEventArgs> SkitterDownloadCompleted;

		/// <summary>
		/// Initializes the control.
		/// </summary>
		/// <param name="config">The application configuration.</param>
		public void Initialize(Config config)
		{
			this.config = config;

			this.dateTimePickerSkitterFrom.Value = this.config.SkitterDateFrom;
			this.dateTimePickerSkitterTo.Value = this.config.SkitterDateTo;

			this.Enabled = true;
		}

		/// <summary>
		/// An event handler called whenever the input changed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnValueChanged(object sender, EventArgs e)
		{
			this.config.SkitterDateFrom = this.dateTimePickerSkitterFrom.Value;
			this.config.SkitterDateTo = this.dateTimePickerSkitterTo.Value;
		}

		/// <summary>
		/// Download the Skitter data.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The sender arguments.</param>
		private void OnDownloadSkitter(object sender, EventArgs e)
		{
			this.buttonSkitter.Enabled = false;

			FormDownload formDownload = new FormDownload();

			formDownload.FormClosed += OnFormClosed;
			formDownload.Text = "Download Skitter Data";
			formDownload.DownloadCompleted += this.OnSkitterDownloadCompleted;

			formDownload.Download(
				this,
				"Download Skitter Data",
				this.config.SkitterFolder,
				this.config.FileFormat,
				this.config.SkitterUrl,
				this.config.SkitterDateFrom,
				this.config.SkitterDateTo,
				Resources.DownloadTermsSkitter);
		}

		/// <summary>
		/// An event handler called when the form is closed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			this.buttonSkitter.Enabled = true;
		}

		/// <summary>
		/// An event handler called when the download of a new Skitter file has completed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="eventArgs">The download completed event arguments.</param>
		void OnSkitterDownloadCompleted(object sender, DownloadCompletedEventArgs eventArgs)
		{
			if (this.SkitterDownloadCompleted != null) this.SkitterDownloadCompleted(sender, eventArgs);
		}
	}
}
