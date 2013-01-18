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
using Microsoft.Win32;

namespace TopoGraph
{
	/// <summary>
	/// A class that stores the application configuration.
	/// </summary>
	public class Config
	{
		private string root = null;
		private static string fileFormat = "aslinks-{0:D4}-{1:D2}-{2:D2}.gz";
		private static string filePattern = "aslinks-????-??-??.gz";
		private static char[] fileDelimiter = { '-' };

		/// <summary>
		/// Creates a new crawler configuration based on the specified root registry key.
		/// </summary>
		/// <param name="root">The root key. </param>
		public Config(string root)
		{
			this.root = root;
		}

		/// <summary>
		/// Gets or sets the Skitter begin date.
		/// </summary>
		public DateTime SkitterDateFrom
		{
			get
			{
				try { return DateTime.Parse(Registry.GetValue(this.root, "SkitterDateFrom", "2000/01/02") as string); }
				catch (Exception) { return new DateTime(2000, 1, 2); }
			}
			set { Registry.SetValue(this.root, "SkitterDateFrom", value.ToShortDateString(), RegistryValueKind.String); }
		}

		/// <summary>
		/// Gets or sets the Skitter end date.
		/// </summary>
		public DateTime SkitterDateTo
		{
			get
			{
				try { return DateTime.Parse(Registry.GetValue(this.root, "SkitterDateTo", "2008/02/07") as string); }
				catch (Exception) { return new DateTime(2000, 1, 2); }
			}
			set { Registry.SetValue(this.root, "SkitterDateTo", value.ToShortDateString(), RegistryValueKind.String); }
		}

		/// <summary>
		/// Gets or sets the Skitter URL.
		/// </summary>
		public string SkitterUrl
		{
			get
			{
				try { return Registry.GetValue(this.root, "SkitterUrl", "http://data.caida.org/datasets/topology/skitter-aslinks/{0:D4}/{1:D2}/skitter_as_links.{0:D4}{1:D2}{2:D2}.gz") as string; }
				catch (Exception) { return "http://data.caida.org/datasets/topology/skitter-aslinks/{0:D4}/{1:D2}/skitter_as_links.{0:D4}{1:D2}{2:D2}.gz"; }
			}
			set { Registry.SetValue(this.root, "SkitterUrl", value, RegistryValueKind.String); }
		}

		/// <summary>
		/// Gets or sets the Skitter folder.
		/// </summary>
		public string SkitterFolder
		{
			get
			{
				try { return Registry.GetValue(this.root, "SkitterFolder",
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Alex Bikfalvi\\TopoGraph\\Caida\\Skitter") as string; }
				catch (Exception) { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Alex Bikfalvi\\TopoGraph\\Caida\\Skitter"; }
			}
			set { Registry.SetValue(this.root, "SkitterFolder", value, RegistryValueKind.String); }
		}

		/// <summary>
		/// Gets the data file format.
		/// </summary>
		public string FileFormat { get { return Config.fileFormat; } }

		/// <summary>
		/// Gets the data file pattern.
		/// </summary>
		public string FilePattern { get { return Config.filePattern; } }

		/// <summary>
		/// Gets the data file delimiter.
		/// </summary>
		public char[] FileDelimiter { get { return Config.fileDelimiter; } }
	}
}
