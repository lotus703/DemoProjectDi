using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectDi.ViewModels
{
    public class MessageViewModel 
    {
        public int Id { get; set; }
        public string content { get; set; }

        public string phone { get; set; }
        public string email { get; set; }
    }
}
