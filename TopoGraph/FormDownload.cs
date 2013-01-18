/* 
 * Copyright (C) 2013 Alex Bikfalvi
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at
 * your option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DotNetApi.Windows;

namespace TopoGraph
{
	/// <summary>
	/// A download form.
	/// </summary>
	public partial class FormDownload : Form
	{
		private WebClient client = new WebClient();

		private string folder;
		private string fileFormat;
		private string file;
		private string url;

		private DateTime begin;
		private DateTime end;
		private DateTime currentDate;

		private DownloadProgressChangedEventHandler delegateProgressChanged;
		private AsyncCompletedEventHandler delegateDownloadCompleted;
		private WaitCallback delegateDownloadError;

		private FormTerms formTerms = new FormTerms();

		private Formatting formatting = new Formatting();

		/// <summary>
		/// Create a new form instance.
		/// </summary>
		public FormDownload()
		{
			InitializeComponent();

			this.client.DownloadFileCompleted += this.OnDownloadCompleted;
			this.client.DownloadProgressChanged += this.OnDownloadProgressChanged;

			this.delegateProgressChanged = new DownloadProgressChangedEventHandler(this.OnDownloadProgressChanged);
			this.delegateDownloadCompleted = new AsyncCompletedEventHandler(this.OnDownloadCompleted);
			this.delegateDownloadError = new WaitCallback(this.DownloadError);

			this.formatting.SetFont(this);
		}

		/// <summary>
		/// An event called when the download of a file has completed.
		/// </summary>
		public event EventHandler<DownloadCompletedEventArgs> DownloadCompleted;

		/// <summary>
		/// Displays the download dialog and begins the download of speciefied files.
		/// </summary>
		/// <param name="owner">The window owner.</param>
		/// <param name="title">The window title.</param>
		/// <param name="folder">The folder where the files will be saved.</param>
		/// <param name="url">The download URL pattern.</param>
		/// <param name="begin">The begin date.</param>
		/// <param name="end">The end date.</param>
		/// <param name="terms">The download terms in RTF format.</param>
		public void Download(
			IWin32Window owner,
			string title,
			string folder,
			string fileFormat,
			string url,
			DateTime begin,
			DateTime end,
			string terms)
		{
			// Save the operation parameters.
			this.folder = folder;
			this.fileFormat = fileFormat;
			this.url = url;
			this.begin = begin;
			this.end = end;
			this.currentDate = this.begin;

			// Set the title.
			this.labelTitle.Text = title;
			// Set the image.
			this.pictureBox.Image = Resources.GlobeDownload_48;
			// Set the button.
			this.buttonCancel.Text = "Cancel";
			// Set the progress.
			this.progressBar.Value = 0;

			// Show the dialog.
			base.Show(owner);

			// Check whether the user agrees to the download terms.
			if (this.formTerms.ShowDialog(this, terms) == DialogResult.OK)
			{
				// Skip the files already downloaded.
				while (this.currentDate <= this.end)
				{
					// Begin the download.
					if (this.DownloadBegin()) break;
					else this.currentDate = this.currentDate.AddDays(1.0);
				}
			}
			else
			{
				this.pictureBox.Image = Resources.GlobeWarning_48;
				this.labelProgress.Text = "Download terms not agreed.";
				this.buttonCancel.Text = "Close";
				this.progressBar.Value = 100;
			}
		}

		/// <summary>
		/// Begins an asynchronous download for the current date.
		/// </summary>
		private bool DownloadBegin()
		{
			// Set the download file name.
			string file = this.folder + "\\" + string.Format(this.fileFormat, this.currentDate.Year, this.currentDate.Month, this.currentDate.Day);

			// Check if the file exists.
			if (File.Exists(file))
			{
				// Skip the download.
				this.progressBar.Value = 100;
				this.labelProgress.Text = string.Format("The file for date {0} already exists.", this.currentDate.ToLongDateString());
				return false;
			}

			// Set the file.
			this.file = file;

			// Set the download URI.
			Uri uri = new Uri(string.Format(this.url, this.currentDate.Year, this.currentDate.Month, this.currentDate.Day));

			this.progressBar.Value = 0;
			this.labelProgress.Text = string.Format("Downloading date {0}...", this.currentDate.ToLongDateString());

			// Begin download on the thread pool.
			ThreadPool.QueueUserWorkItem(this.DownloadBeginAsync, uri);

			return true;
		}

		/// <summary>
		/// Begins an asynchronous download for the current date on the thread pool.
		/// </summary>
		/// <param name="state">The state.</param>
		private void DownloadBeginAsync(object state)
		{
			try
			{
				// Begin an asynchronous download.
				this.client.DownloadFileAsync(state as Uri, this.file);
			}
			catch (Exception exception)
			{
				this.DownloadError(exception);
			}
		}

		/// <summary>
		/// Displays a download error on the UI thread.
		/// </summary>
		/// <param name="info">The exception object.</param>
		private void DownloadError(object info)
		{
			if (this.InvokeRequired) this.Invoke(this.delegateDownloadError, new object[] { info });
			else
			{
				Exception exception = info as Exception;
				this.pictureBox.Image = Resources.GlobeError_48;
				this.progressBar.Value = 100;
				this.labelProgress.Text = "Download error. " + exception.Message;
				this.buttonCancel.Text = "Close";
			}
		}

		/// <summary>
		/// An event handler called when the current download progress has changed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			if (this.InvokeRequired) this.Invoke(this.delegateProgressChanged, new object[] { sender, e });
			else
			{
				this.progressBar.Value = e.ProgressPercentage;
				this.labelProgress.Text = string.Format("Downloading date {0} ({1} of {2} bytes received)...", this.currentDate.ToLongDateString(), e.BytesReceived, e.TotalBytesToReceive);
			}
		}

		/// <summary>
		/// An event handler called when the current download has completed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (this.InvokeRequired) this.Invoke(this.delegateDownloadCompleted, new object[] { sender, e });
			else
			{
				// Check if the operation was canceled.
				if (e.Cancelled)
				{
					if (File.Exists(this.file))
						File.Delete(this.file);

					this.pictureBox.Image = Resources.GlobeWarning_48;
					this.progressBar.Value = 100;
					this.labelProgress.Text = "Download canceled.";
					this.buttonCancel.Text = "Close";
					this.buttonCancel.Enabled = true;

					return;
				}

				// Check if an error occurred.
				if (e.Error != null)
				{
					// Delete the file if any was written to the disk.
					if (File.Exists(this.file))
						File.Delete(this.file);

					// Indicates whether the error stops the download.
					bool errorStop = true;

					// Check if this was a web exception.
					if(e.Error.GetType() == typeof(WebException))
					{
						WebException exception = e.Error as WebException;
						// Check if the error was protocol error.
						if(exception.Status == WebExceptionStatus.ProtocolError)
							errorStop = false;
					}

					if (errorStop)
					{
						this.pictureBox.Image = Resources.GlobeError_48;
						this.progressBar.Value = 100;
						this.labelProgress.Text = "Download error. " + e.Error.Message;
						this.buttonCancel.Text = "Close";
						this.buttonCancel.Enabled = true;
						return;
					}
				}

				// If a file has been downloaded.
				if (File.Exists(this.file))
				{
					// Raise a download completed event.
					if (this.DownloadCompleted != null)
						this.DownloadCompleted(this, new DownloadCompletedEventArgs(this.currentDate, this.file));
				}

				// Skip the files already downloaded
				do
				{
					// Increment the current date.
					this.currentDate = this.currentDate.AddDays(1);

					if (this.currentDate <= this.end)
					{
						// Begin a new download.
						if (this.DownloadBegin()) return;
					}
				}
				while (this.currentDate <= this.end);

				// Complete the download.
				this.pictureBox.Image = Resources.GlobeSuccess_48;
				this.labelProgress.Text = "Download complete.";
				this.buttonCancel.Text = "Close";
				this.buttonCancel.Enabled = true;
			}
		}

		/// <summary>
		/// Cancels the current download.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void CancelDownload(object sender, EventArgs e)
		{
			// If a download is in progress.
			if (this.client.IsBusy)
			{
				// Cancel the request.
				this.client.CancelAsync();
				// Disable the button.
				this.buttonCancel.Enabled = false;
			}
			else
			{
				// Close the dialog.
				this.Close();
			}
		}
	}

	/// <summary>
	/// A class that represents the arguments of a successfull download.
	/// </summary>
	public class DownloadCompletedEventArgs : EventArgs
	{
		private DateTime date;
		private string file;

		/// <summary>
		/// Creates a new event argument instance.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="file">The file.</param>
		public DownloadCompletedEventArgs(DateTime date, string file)
		{
			this.date = date;
			this.file = file;
		}

		/// <summary>
		/// Gets the downloaded date.
		/// </summary>
		public DateTime Date { get { return this.date; } }

		/// <summary>
		/// Gets the downloaded file.
		/// </summary>
		public string File { get { return this.file; } }
	}
}
