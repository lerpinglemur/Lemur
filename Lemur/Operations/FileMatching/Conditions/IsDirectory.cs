﻿using Lemur.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lemur.Operations.FileMatching {

	/// <summary>
	/// Matches only files which are directories.
	/// </summary>
	[NameDesc( "Only Directories", "Only directories are included in search results." )]
	[Serializable]
	public class IsDirectory : BaseCondition {

		override public bool IsMatch( FileSystemInfo info ) {

			if( info is DirectoryInfo ) {
				return base.IsMatch( true );
			}

			return base.IsMatch( false );
	
		}

	} // class

} // namespace