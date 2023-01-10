using Serilog;

namespace UserAddress.API.Services
{
    public class LoggingService : ILoggingService
    { 
        public void LogError(string error)
        {
            try
            {
                Log.Error(error);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public void LogWarning(string message)
        {
            try
            {
                Log.Information(message);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
