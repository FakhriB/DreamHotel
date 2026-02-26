using DREAMHOTEL.Services.Interfaces;
using DREAMHOTEL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DREAMHOTEL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IServiceService _serviceService;

        public HomeController(ISliderService sliderService,IServiceService serviceService)
        {
            _sliderService = sliderService;
            _serviceService = serviceService;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _sliderService.GetAllAsync();

            var vm = sliders.Select(s => new SliderVM
            {
                Id = s.Id,
                Title = s.Title,
                SubTitle = s.SubTitle,
                Order = s.Order,
                IsMain = s.IsMain,
                ImageUrl = s.ImageUrl
            }).ToList();

            return View(vm);
        }

        public async Task<IActionResult> Services()
        {
            var services = await _serviceService.GetAllAsync();

            var data = services.Select(sv => new ServiceVM
            {
                Title = sv.Title,
                Description = sv.Description,
                IsMain = sv.IsMain,
                Icon = sv.Icon,
                 
            }).ToList();

            return View(data);
        }
    }
}

