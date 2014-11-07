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
using robotlegs.bender.framework.api;


namespace robotlegs.bender.extensions.enhancedLogging.impl
{
	public class ConsoleLogTarget : ILogTarget
	{
		/*============================================================================*/
		/* Private Properties                                                         */
		/*============================================================================*/
		
		private IContext _context;
		
		/*============================================================================*/
		/* Constructor                                                                */
		/*============================================================================*/
		
		/**
		 * Creates a Console Log Target
		 * @param context Context
		 */
		
		public ConsoleLogTarget (IContext context)
		{
			_context = context;
		}
		
		/*============================================================================*/
		/* Public Functions                                                           */
		/*============================================================================*/

		public void Log (object source, robotlegs.bender.framework.impl.LogLevel level, DateTime timestamp, object message, params object[] messageParameters)
		{
			Console.WriteLine(timestamp.ToLongTimeString()
			      + " " + level.ToString()
			      + " " + _context
			      + " " + source
			      + " " + message, messageParameters);
		}
	}
}

