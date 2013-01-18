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
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DotNetApi.Windows;

namespace TopoGraph
{
	/// <summary>
	/// A form that displays a topology file.
	/// </summary>
	public partial class FormTopology : Form
	{
		private Formatting formatting = new Formatting();

		/// <summary>
		/// Creates a new form instance.
		/// </summary>
		public FormTopology()
		{
			InitializeComponent();

			this.formatting.SetFont(this);
		}

		/// <summary>
		/// Shows the current form with the specified topology.
		/// </summary>
		/// <param name="owner">The window owner.</param>
		/// <param name="topology">The topology.</param>
		public void Show(IWin32Window owner, Topology topology)
		{
			this.Text = string.Format("AS Topology {0}", topology.Date.ToLongDateString());
			this.labelDate.Text = topology.Date.ToLongDateString();
			this.textBox.Text = "Reading the topology from file...";

			// Show the form.
			this.Show();


			// Get the topology contents on a worker thread.
			ThreadPool.QueueUserWorkItem(this.ReadAsync, topology);
		}

		private void ReadAsync(object state)
		{
			Topology topology = state as Topology;

			// Get the content.
			this.Callback(topology.Content);
		}

		private void Callback(object state)
		{
			if (this.InvokeRequired) this.Invoke(new WaitCallback(this.Callback), new object[] { state });
			else
			{
				this.textBox.Text = (state as string).Replace("\n","\r\n");
			}
		}
	}
}
