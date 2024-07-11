using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Npgsql;
using api.Server.Models;

namespace api.Server.Servisler
{
    public class SliderService : ISliderService
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=gazi;Username=root;Password=root;";


        public SliderService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> GetSliderCountAsync()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    var query = "SELECT COUNT(*) FROM sliders";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Veritabanı hatası: " + ex.Message);
                throw; // Hata yönetimi için istisna fırlatılır
            }
        }

        public async Task<List<SliderInfo>> GetSlidersAsync()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    var sliders = new List<SliderInfo>();
                    var query = "SELECT id, resim_yolu FROM sliders";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                sliders.Add(new SliderInfo
                                {
                                    id = reader.GetInt32(0),
                                    resim_yolu = reader.GetString(1)
                                });
                            }
                        }
                    }
                    return sliders;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Veritabanı hatası: " + ex.Message);
                throw; // Hata yönetimi için istisna fırlatılır
            }
        }

        public async Task SaveFilePathAsync(string filePath)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    var query = "INSERT INTO sliders (resim_yolu) VALUES (@filePath)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filePath", filePath);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                Console.WriteLine($"Dosya yolu kaydedildi: {filePath}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Veritabanı hatası: " + ex.Message);
                throw; // Hata yönetimi için istisna 
            }
        }
    }
}
