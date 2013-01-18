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

namespace TopoGraph
{
	/// <summary>
	/// A form that displays terms and conditions.
	/// </summary>
	public partial class FormTerms : Form
	{
		private Formatting formatting = new Formatting();

		/// <summary>
		/// Creates a new form instance.
		/// </summary>
		public FormTerms()
		{
			InitializeComponent();

			this.formatting.SetFont(this);
		}

		/// <summary>
		/// Displays the dialog with the specified terms text.
		/// </summary>
		/// <param name="owner">The dialog owner.</param>
		/// <param name="text">The terms text in RTF format.</param>
		/// <returns>The dialog result.</returns>
		public DialogResult ShowDialog(IWin32Window owner, string text)
		{
			this.richTextBox.Rtf = text;
			return base.ShowDialog(owner);
		}

		/// <summary>
		/// An event handler called when the user accepts the terms.
		/// </summary>
		/// <param name="sender">The sender object.</param>
		/// <param name="e">The event arguments.</param>
		private void OnAccept(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
