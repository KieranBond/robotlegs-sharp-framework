//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace robotlegs.bender.extensions.commandCenter.dsl
{
	public interface ICommandUnmapper
	{
		/// <summary>
		/// Unmaps a Command
		/// </summary>
		/// <param name="commandType">Command to unmap</param>
		void FromCommand(Type commandType);

		/// <summary>
		/// Unmaps all commands from this trigger
		/// </summary>
		void FromAll();
	}
}
