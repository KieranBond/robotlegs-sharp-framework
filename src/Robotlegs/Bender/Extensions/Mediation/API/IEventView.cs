//------------------------------------------------------------------------------
//  Copyright (c) 2014-2016 the original author or authors. All Rights Reserved. 
// 
//  NOTICE: You are permitted to use, modify, and distribute this file 
//  in accordance with the terms of the license agreement accompanying it. 
//------------------------------------------------------------------------------

using Robotlegs.Bender.Extensions.EventManagement.API;
using Robotlegs.Bender.Extensions.Mediation.API;


namespace Robotlegs.Bender.Extensions.Mediation.API
{
	public interface IEventView : IView
	{
		IEventDispatcher dispatcher{ get; set;}
	}
}
