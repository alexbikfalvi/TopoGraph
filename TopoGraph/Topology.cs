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
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace TopoGraph
{
	public abstract class Topology
	{
		private DateTime date;
		private string file;

		/// <summary>
		/// Creates a new topology instance.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="file">The file.</param>
		public Topology(DateTime date, string file)
		{
			this.date = date;
			this.file = file;
		}

		/// <summary>
		/// Gets the topology date.
		/// </summary>
		public DateTime Date { get { return this.date; } }

		/// <summary>
		/// Gets the topology file.
		/// </summary>
		public string File { get { return this.file; } }

		/// <summary>
		/// Gets the content of the topology file.
		/// </summary>
		public virtual string Content { get { return null; } }
	}
}
