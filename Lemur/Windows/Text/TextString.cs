﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemur.Windows.Text {

	public struct TextString {

		public const string Error = "error";
		public const string Message = "message";

		public string Text {
			get;
			set;
		}


		/// <summary>
		/// Indicates the type of text being displayed ( message, error, etc. )
		/// This can be bound to a DataTemplateSelector to change the display
		/// of the text.
		/// </summary>
		public string Type {
			get;
			set;
		}

		public TextString( string text, string type=null ) {

			this.Text = text;
			this.Type = type;

		}

		public static implicit operator string( TextString s ) {
			return s.Text;
		}

		public static implicit operator TextString( string s ) {
			return new TextString( s );
		}

    } // class

} // namespace
