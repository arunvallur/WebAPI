namespace WebAPI_Domain_Contract
{
    public interface INotificationManager
    {
        Task<bool> pushNotification(string message);
    }
}
