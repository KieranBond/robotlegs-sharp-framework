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
using System.Collections.Generic;
using robotlegs.bender.extensions.viewManager.api;


namespace robotlegs.bender.extensions.viewManager.impl
{
	/// <summary>
	/// View manager, will be made by each context.
	/// It can add containers which will be passed into the Container Registry.
	/// But if you add a second container view with it, it will clone all it's view handlers added to itself for you
	/// </summary>

	public class ViewManager : IViewManager
	{
		private List<IViewHandler> _handlers = new List<IViewHandler>();
		private List<object> _containers = new List<object>();

		public ViewManager()
		{
		}

		public void AddContainer(object container)
		{
			//TODO: Check for nested containers and already existing containers with this ViewManager
//			if (!ValidContainer(container))
//				return;

			_containers.Add(container);

			ContainerBinding containerBinding = ContainerRegistry.AddContainer(container);
			foreach (IViewHandler handler in _handlers)
			{
				containerBinding.AddHandler(handler);
			}

			//TODO: Dispatch new ViewManagerEvent(ViewManagerEvent.CONTAINER_ADD, container);
		}

		public void AddViewHandler(IViewHandler handler)
		{
			if (_handlers.Contains(handler))
				return;

			_handlers.Add(handler);

			// Add new handler to our containers
			foreach (object container in _containers)
			{
				ContainerRegistry.AddContainer(container).AddHandler(handler);
			}

			//TODO: Dispatch ViewManagerEvent.HANDLER_ADD
		}

		public void RemoveViewHandler(IViewHandler handler)
		{
			_handlers.Remove(handler);

			foreach(object container in _containers)
			{
				ContainerRegistry.GetBinding(container).RemoveHandler(handler);
			}

			//TODO: new ViewManagerEvent(ViewManagerEvent.HANDLER_REMOVE, null, handler);
		}
	}
}

