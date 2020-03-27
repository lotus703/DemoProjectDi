using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProjectDi.Models;
using DemoProjectDi.Service;
using DemoProjectDi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjectDi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly IMessageService<Sms> _messageServices;
        public SmsController(IMessageService<Sms> service)
        {
            _messageServices = service;

        }
        
        [HttpPost]
        public async Task<IActionResult> SendMessage(MessageViewModel mesage)
        {
            try
            {
                var abc = await _messageServices.SendMessage(mesage);
                return StatusCode(201, new
                {
                    message = "Success",
      
                }); ;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Fail"
                });
            }
        }
    }
}