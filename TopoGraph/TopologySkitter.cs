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
	public class TopologySkitter : Topology
	{
		/// <summary>
		/// Creates a new topology instance.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="file">The file.</param>
		public TopologySkitter(DateTime date, string file)
			: base(date, file)
		{
		}

		/// <summary>
		/// Gets the contents of the topology file.
		/// </summary>
		public override string Content
		{
			get
			{
				// Create a new file info.
				FileInfo fileInfo = new FileInfo(this.File);

				using (FileStream stream = fileInfo.OpenRead())
				{
					using (GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress))
					{
						using (StreamReader reader = new StreamReader(gzip))
						{
							return reader.ReadToEnd();
						}
					}
				}
			}
		}
	}
}
