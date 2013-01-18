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
using System.Windows.Forms;
using DotNetApi.Windows;
using DotNetApi.Windows.Controls;

namespace TopoGraph
{
	/// <summary>
	/// The main form of the TopoGraph application.
	/// </summary>
	public partial class FormMain : Form
	{
		private Config config = new Config("HKEY_CURRENT_USER\\Software\\Alex Bikfalvi\\TopoGraph");

		private Formatting formatting = new Formatting();

		private FormAbout formAbout = new FormAbout();

		private SideMenuItem sideMenuItemData;
		private SideMenuItem sideMenuItemTopology;

		private UserControl controlSide = null;
		private UserControl controlPanel = null;

		/// <summary>
		/// Creates a new form instance.
		/// </summary>
		public FormMain()
		{
			InitializeComponent();

			// Set the control tags.
			this.controlDataset.Tag = this.controlData;

			// Create the side menu items.
			this.sideMenuItemData = this.sideMenu.AddItem("Dataset", Resources.ServersDatabase_16, Resources.ServersDatabase_32, new SideMenuEventHandler(this.OnSideMenuClick), this.controlDataset);
			//this.sideMenuItemTopology = this.sideMenu.AddItem("Topology", Resources.Topology_16, Resources.Topology_32, new SideMenuEventHandler(this.OnSideMenuClick), this.controlTopology);

			// Initialize the controls.
			this.controlDataset.Initialize(this.config);
			this.controlData.Initialize(this.config);

			this.controlDataset.SkitterDownloadCompleted += OnSkitterDownloadCompleted;

			// Apply formatting.
			this.formatting.SetFont(this);
		}

		/// <summary>
		/// An event handler called when the user clicks on the close menu item.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnClickClose(object sender, EventArgs e)
		{
			// Close the main window.
			this.Close();
		}

		/// <summary>
		/// An event handler called when the user clicks on the about menu item.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnClickAbout(object sender, EventArgs e)
		{
			// Show the about dialog.
			this.formAbout.ShowDialog(this);
		}

		/// <summary>
		/// An event handler called when the user clicks on a side menu item.
		/// </summary>
		/// <param name="item">The selected side menu item.</param>
		private void OnSideMenuClick(SideMenuItem item)
		{
			if (item == null) return;

			UserControl controlSide = item.Tag as UserControl;

			if (controlSide == this.controlSide) return;
			if (this.controlSide != null) this.controlSide.Visible = false;
			if (controlSide != null) controlSide.Visible = true;

			this.controlSide = controlSide;

			UserControl controlPanel = controlSide.Tag as UserControl;

			if (controlPanel == this.controlPanel) return;
			if (this.controlPanel != null) this.controlPanel.Visible = false;
			if (controlPanel != null) controlPanel.Visible = true;

			this.controlPanel = controlPanel;
		}

		/// <summary>
		/// An event handler called when a skitter file download has completed.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		void OnSkitterDownloadCompleted(object sender, DownloadCompletedEventArgs e)
		{
			// Add the file to the data list.
			this.controlData.AddSkitter(e.File);
		}
	}
}
