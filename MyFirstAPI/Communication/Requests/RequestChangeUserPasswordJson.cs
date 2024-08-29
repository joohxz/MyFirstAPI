namespace MyFirstAPI.Communication.Requests
{
    public class RequestChangeUserPasswordJson
    {
        public string CurrentPassword { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
    }
}
