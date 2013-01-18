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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopoGraph.Controls
{
	/// <summary>
	///  A control that displays the data.
	/// </summary>
	public partial class ControlData : UserControl
	{
		private Config config;

		private TopologyList dataSkitter = new TopologyList();

		private Dictionary<DateTime, ListViewItem> itemsSkitter = new Dictionary<DateTime,ListViewItem>();
		private ControlDataSorter sorter = new ControlDataSorter();

		/// <summary>
		/// Creates a new control instance.
		/// </summary>
		public ControlData()
		{
			InitializeComponent();

			// Set the item sorter.
			this.listView.ListViewItemSorter = this.sorter;

			this.dataSkitter.TopologyAdded += OnSkitterTopologyAdded;
		}

		/// <summary>
		/// Initializes the control.
		/// </summary>
		/// <param name="config">The configuration.</param>
		public void Initialize(Config config)
		{
			this.config = config;
			this.Enabled = true;

			// Read the Skitter data.
			this.dataSkitter.ReadSkitterFromFolder(this.config.SkitterFolder, this.config.FilePattern, this.config.FileDelimiter);
		}

		/// <summary>
		/// Adds a new Skitter topology file.
		/// </summary>
		/// <param name="file">The file.</param>
		public void AddSkitter(string file)
		{
			// Read the Skitter data.
			this.dataSkitter.ReadSkitterFromFile(file, this.config.FileDelimiter);
		}

		/// <summary>
		/// An event handler called when a topology was added.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		void OnSkitterTopologyAdded(object sender, TopologyEventArgs e)
		{
			// If an item already exists, do nothing.
			if (this.itemsSkitter.ContainsKey(e.Date)) return;

			// Else, create a new item.
			ListViewItem item = new ListViewItem(new string[] { string.Format("{0:D4}/{1:D2}/{2:D2}", e.Date.Year, e.Date.Month, e.Date.Day), Path.GetFileName(e.Topology.File) }, 0);
			item.Tag = e.Topology;

			// Add the item to the dictionary.
			this.itemsSkitter.Add(e.Date, item);

			// If the skitter data is not selected, return.
			if (!this.menuItemSkitter.Checked) return;

			// Add the item to the list.
			this.listView.Items.Add(item);
		}

		private void OnItemActivate(object sender, EventArgs e)
		{
			if (this.listView.SelectedItems.Count == 0) return;

			Topology topology = this.listView.SelectedItems[0].Tag as Topology;

			FormTopology formTopology = new FormTopology();

			formTopology.Show(this, topology);
		}
	}

	/// <summary>
	/// A class to compare the data.
	/// </summary>
	internal class ControlDataSorter : IComparer
	{
		public int Compare(object x, object y)
		{
			ListViewItem itemX = x as ListViewItem;
			ListViewItem itemY = y as ListViewItem;

			Topology topologyX = itemX.Tag as Topology;
			Topology topologyY = itemY.Tag as Topology;

			if (topologyX.Date < topologyY.Date) return -1;
			else if (topologyX.Date == topologyY.Date) return 0;
			else return 1;
		}
	}
}
