﻿using System.Threading.Tasks;

namespace OpenCqrs.Abstractions.Events
{
    public interface IEventHandlerAsync<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}
