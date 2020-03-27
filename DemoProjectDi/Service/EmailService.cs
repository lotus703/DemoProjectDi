using DemoProjectDi.Data;
using DemoProjectDi.Models;
using DemoProjectDi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectDi.Service
{
    public class EmailService : IMessageService<Email>
    {
        private readonly DataContext _context;
        public EmailService(DataContext context)
        {
            _context = context;
        }
        public async Task<Email> SendMessage(MessageViewModel  messageViewModel)
        {
            var email = new Email
            {
                Id = messageViewModel.Id,
                email = messageViewModel.email,
                content = messageViewModel.content
            };
            _context.Email.Add(email);
            await _context.SaveChangesAsync();
            return email;
        }

         
    }
}
