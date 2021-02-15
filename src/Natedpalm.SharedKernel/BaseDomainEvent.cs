using System;
using MediatR;

namespace Natedpalm.SharedKernel
{
    public class BaseDomainEvent : INotification
    {
        public DateTime DateOcurred { get; protected set; }
    }
}