using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Server.Models;
using api.Server.Servisler;

namespace api.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        // Tüm slider bilgilerini getir
        [HttpGet]
        public async Task<IActionResult> GetSliders()
        {
            try
            {
                var sliders = await _sliderService.GetSlidersAsync();
                return Ok(sliders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Slider bilgileri alınamadı: " + ex.Message });
            }
        }

        // Yeni slider ekle
        [HttpPost]
        public async Task<IActionResult> AddSlider([FromBody] SliderSaveModel model)
        {
            try
            {
                await _sliderService.SaveFilePathAsync(model.FilePath);
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Slider eklenirken hata oluştu: " + ex.Message });
            }
        }



        public class SliderSaveModel
        {
            public string FilePath { get; set; }
        }
    }
}
