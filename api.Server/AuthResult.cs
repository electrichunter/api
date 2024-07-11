 

namespace api.Server.Models
{
    public class AuthResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public AuthResult()
        {
            Success = false;
            Message = string.Empty;
        }
    }
}
