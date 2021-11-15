using System.Threading.Tasks;

namespace SBSender.Data.Services
{
    public interface IQueueService
    {
        Task SendMessageAsync<T>(T serviceBusMessage, string queueName);
    }
}