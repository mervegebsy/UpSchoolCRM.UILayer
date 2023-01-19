using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concrete;
using CRMUpSchool.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolCRM.UILayer.Areas.Employee.Models;

namespace UpSchoolCRM.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        [HttpGet]
        public  IActionResult SendMessage()
        {
          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message m)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.SenderEmail = user.Email;
            m.SenderName = user.Name + "" + user.Surname; 
            using(var context = new Context())
            {
                context.Users.Where(x => x.Email == m.RecieverEmail).Select(x => x.Name + "" + x.Surname).FirstOrDefault();
            }
            _messageService.TInsert(m);
            return RedirectToAction("SendMessage");
            //wyqwxddtjdwreldo
        }
        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("admin","mervegebesoy@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.RecieverEmail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = p.EmailContent;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = p.EmailSubject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mervegebesoy@gmail.com", "wyqwxddtjdwreldo");
            client.Send(mimeMessage);
            client.Disconnect(true);


            return View();
        }
    }
}
