using DemoProjectDi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectDi.Service
{
    public interface IMessageService <T>
       
    {
        Task<T> SendMessage(MessageViewModel  messageViewModel);
    }
}
