//  
//  Utils.cs
//  
//  Author:
//       Willem Van Onsem <vanonsem.willem@gmail.com>
// 
//  Copyright (c) 2012 Willem Van Onsem
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace KommuSoft.HaskellLibraries {
	
	/// <summary>
	/// A utility class used by the methods in <see cref="T:DataList"/> to process some tasks easier.
	/// </summary>
	public static class Utils {
		
		/// <summary>
		/// Compares the two given items and returns the minimum of the two.
		/// </summary>
		/// <param name="x1">
		/// The first element to compare.
		/// </param>
		/// <param name="x2">
		/// The second element to compare.
		/// </param>
		/// <returns>
		/// The minimum of the two given elements (<paramref name="x1"/> and <paramref name="x2"/>) according to their built-in comparison function.
		/// </returns>
		public static X Minimum<X> (X x1, X x2) where X : IComparable<X> {
			if(x1.CompareTo(x2) <= 0x00) {
				return x1;
			}
			else {
				return x2;
			}
		}
		/// <summary>
		/// Compares the two given items and returns the maximum of the two.
		/// </summary>
		/// <param name="x1">
		/// The first element to compare.
		/// </param>
		/// <param name="x2">
		/// The second element to compare.
		/// </param>
		/// <returns>
		/// The maximum of the two given elements (<paramref name="x1"/> and <paramref name="x2"/>) according to their built-in comparison function.
		/// </returns>
		public static X Maximum<X> (X x1, X x2) where X : IComparable<X> {
			if(x1.CompareTo(x2) >= 0x00) {
				return x1;
			}
			else {
				return x2;
			}
		}
		
	}
}