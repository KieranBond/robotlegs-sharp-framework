//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace robotlegs.bender.extensions.matching
{
	public class TypeMatchException : Exception
	{
		public const string EMPTY_MATCHER = "An empty matcher will create a filter which matches nothing. You should specify at least one condition for the filter.";

		public const string SEALED_MATCHER = "This matcher has been sealed and can no longer be configured.";

		public TypeMatchException (string message) : base(message)
		{

		}
	}
}

