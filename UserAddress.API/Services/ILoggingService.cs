namespace UserAddress.API.Services
{
    public interface ILoggingService
    { 
        public void LogError(string error); 

        public void LogWarning(string message);  
    }
}
