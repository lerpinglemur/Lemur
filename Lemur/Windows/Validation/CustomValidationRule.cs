﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Lemur.Windows.Validation {

	/// <summary>
	/// Validation rule with a customizable validation message.
	/// </summary>
	public abstract class CustomValidationRule : ValidationRule {

		//private RuleProperties properties;
		//public RuleProperties Properties { get => properties; set => properties = value; }

		/// <summary>
		/// Returns the default error message if it is not not and not empty, or the alternative string
		/// if it does not.
		/// </summary>
		/// <returns></returns>
		protected string ErrorMessage( string altMessage=null ) {
			return string.IsNullOrEmpty(this._defaultMessage) ? altMessage : this._defaultMessage;
		}

		/// <summary>
		/// Returns the result with the given error message on failure, or the default error message if message is null or empty.
		/// </summary>
		/// <param name="result"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		protected ValidationResult Result( bool result, string message = null ) {

			if( result ) {
				return new ValidationResult( true, null );
			} else {
				return new ValidationResult( false, string.IsNullOrEmpty( this._defaultMessage ) ? message : this._defaultMessage );
			}

		}

		private string _defaultMessage;
		public string DefaultErrorMessage {
			get {
				return this._defaultMessage;
			}
			set {
				this._defaultMessage = value;
			}
		}

    } // class

} // namespace