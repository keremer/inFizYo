using System.Threading.Tasks;

namespace inFizYo.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
