namespace Domain.Notifications
{
    public class Notification
    {
        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }

        public string Message { get; set; }
        public string PropertyName { get; set; }
    }
}