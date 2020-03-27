using DemoProjectDi.Data;
using DemoProjectDi.Models;
using DemoProjectDi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectDi.Service
{
    public class SmsService : IMessageService<Sms>
    {
        private readonly DataContext _context;
        public SmsService(DataContext context)
        {
            _context = context;
        }
        public async Task<Sms> SendMessage(MessageViewModel messageViewModel)
        {
            var sms = new Sms
            {
                Id = messageViewModel.Id,
                phone = messageViewModel.phone,
                content = messageViewModel.content
            };
            _context.Sms.Add(sms);
            await _context.SaveChangesAsync();
            return sms;
        }

        
    }
}
