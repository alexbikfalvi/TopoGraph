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
using System.Linq;
using System.Text;

namespace TopoGraph
{
	/// <summary>
	/// A list of AS topologies.
	/// </summary>
	public class TopologyList
	{
		private Dictionary<DateTime, Topology> list = new Dictionary<DateTime, Topology>();

		/// <summary>
		/// Creates an empty list instance.
		/// </summary>
		public TopologyList()
		{
		}

		public event EventHandler<TopologyEventArgs> TopologyAdded;

		/// <summary>
		/// Reads a list of Skitter topologies from the specified folder, and with the given file name pattern.
		/// </summary>
		/// <param name="folder">The folder.</param>
		/// <param name="filePattern">The file name pattern.</param>
		/// <param name="fileDelimiter">The file name delimiter.</param>
		public void ReadSkitterFromFolder(string folder, string filePattern, char[] fileDelimiter)
		{
			// Enumerate all files that match the specified pattern.
			IEnumerable<string> files = Directory.EnumerateFiles(folder, filePattern, SearchOption.TopDirectoryOnly);

			// Read the date from each file.
			foreach (string file in files)
			{
				this.ReadSkitterFromFile(file, fileDelimiter);
			}
		}

		/// <summary>
		/// Reads a Skitter topology from file.
		/// </summary>
		/// <param name="file">The file name.</param>
		/// <param name="fileDelimiter">The file name delimiter.</param>
		public void ReadSkitterFromFile(string file, char[] fileDelimiter)
		{
			// Split the file into tokens.
			string[] tokens = Path.GetFileNameWithoutExtension(file).Split(fileDelimiter);

			int year = int.Parse(tokens[1]);
			int month = int.Parse(tokens[2]);
			int day = int.Parse(tokens[3]);

			// Create the date.
			DateTime date = new DateTime(year, month, day);

			// If the date already exists, do nothing.
			if (this.list.ContainsKey(date)) return;

			// Else, create a new topology and add it to the list.
			TopologySkitter topology = new TopologySkitter(date, file);
			// Add the topology to the list.
			this.list.Add(date, topology);
			
			// Call an event handler.
			if (this.TopologyAdded != null) this.TopologyAdded(this, new TopologyEventArgs(date, topology));
		}
	}

	/// <summary>
	/// A class representing a topology event argument.
	/// </summary>
	public class TopologyEventArgs : EventArgs
	{
		private DateTime date;
		private Topology topology;

		/// <summary>
		/// Creates a new topology arguments instance.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="topology">The topology.</param>
		public TopologyEventArgs(DateTime date, Topology topology)
		{
			this.date = date;
			this.topology = topology;
		}

		/// <summary>
		/// Gets the date.
		/// </summary>
		public DateTime Date { get { return this.date; } }

		/// <summary>
		/// Gets the topology.
		/// </summary>
		public Topology Topology { get { return this.topology; } }
	}
}
