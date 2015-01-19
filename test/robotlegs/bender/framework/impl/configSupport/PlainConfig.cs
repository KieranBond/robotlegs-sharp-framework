﻿using System;

namespace robotlegs.bender.framework.impl.configSupport
{
	public class PlainConfig
	{
		/*============================================================================*/
		/* Public Properties                                                          */
		/*============================================================================*/

		[Inject("callback")]
		public Action<PlainConfig> callback;

		/*============================================================================*/
		/* Public Functions                                                           */
		/*============================================================================*/

		[PostConstruct]
		public void init()
		{
			callback(this);
		}
	}
}

