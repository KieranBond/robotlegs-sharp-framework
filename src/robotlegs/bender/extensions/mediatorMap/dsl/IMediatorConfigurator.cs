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
namespace robotlegs.bender.extensions.mediatorMap.dsl
{
	public interface IMediatorConfigurator
	{
		/// <summary>
		/// Guards to check before allowing a mediator to be created
		/// </summary>
		/// <returns>Self</returns>
		/// <param name="guards">Guards</param>
		IMediatorConfigurator WithGuards(params object[] guards);

		/// <summary>
		/// Hooks to run before a mediator is created
		/// </summary>
		/// <returns>Self</returns>
		/// <param name="hooks">Hooks</param>
		IMediatorConfigurator WithHooks(params object[] hooks);
		
		/// <summary>
		/// Should the mediator be removed when the mediated item looses scope?
		///
		/// <p>Usually this would be when the mediated item is a Display Object
		/// and it leaves the stage.</p>
		/// </summary>
		/// <returns>Self</returns>
		IMediatorConfigurator AutoRemove(bool value);
	}
}

