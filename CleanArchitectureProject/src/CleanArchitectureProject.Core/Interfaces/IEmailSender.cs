using System.Threading.Tasks;

namespace CleanArchitectureProject.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
