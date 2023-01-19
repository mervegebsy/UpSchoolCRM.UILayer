using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolCRM.UILayer.Areas.Employee.Models
{
    public class MailRequest
    {
        public string SenderName{ get; set; }
        public string SenderEmail { get; set; }
        public string RecieverEmail { get; set; }
        public string EmailSubject { get; set; }
        public string EmailContent { get; set; }
    }
}
