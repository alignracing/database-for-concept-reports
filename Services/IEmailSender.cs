using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace database_for_concept_reports.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
