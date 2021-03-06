//  
//  Ordering.cs
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
	/// An enumeration representing the three possible results of a comparison test: Less Than, Equal or Greather Than.
	/// </summary>
	public enum Ordering : int {
		/// <summary>
		/// A value of the <see cref="T:Ordering"/> saying the first element was less than the second element.
		/// </summary>
		LT	= -0x01,
		/// <summary>
		/// A value of the <see cref="T:Ordering"/> saying the first element was equal to the second element.
		/// </summary>
		EQ	=  0x00,
		/// <summary>
		/// A value of the <see cref="T:Ordering"/> saying the first element was greater than the second element.
		/// </summary>
		GT	=  0x01
	}
	
}