using System;
using System.Threading.Tasks;
using api.Server.Models; // AuthResult sınıfını ekleyin
using Npgsql; // Npgsql kütüphanesini ekleyin

namespace api.Server.Servisler
{
    public class AuthService : IAuthService
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=gazi;Username=root;Password=root;";

        public async Task<AuthResult> LoginAsync(string email, string password)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    // PostgreSQL sorgusu: Kullanıcıyı email ve password ile ara
                    var query = "SELECT COUNT(*) FROM public.admin WHERE email = @email AND password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);

                        var count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                        if (count > 0)
                        {
                            return new AuthResult { Success = true };
                        }
                        else
                        {
                            return new AuthResult { Success = false, Message = "Email veya parola hatalı" };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Veritabanı hatası: " + ex.Message);
                return new AuthResult { Success = false, Message = "Veritabanı hatası" };
            }
        }
    }
}
