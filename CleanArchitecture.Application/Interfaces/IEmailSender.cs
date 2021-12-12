using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IEmailSender
    {
        Task<Response> SendEmailAsync(string email, string subject, string message);
        Task<Response> Execute(string apiKey, string subject, string message, string email);
    }
}
