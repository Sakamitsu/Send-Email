using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMail.Models;

namespace TestMail.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
