using Repository.Repositories.Interfaces;
using Service.DTOs;
using Service.Services.Interfaces;


namespace Service.Services
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepo;
        public SliderService(ISliderRepository sliderRepo)
        {
            _sliderRepo= sliderRepo;
        }
      

        public async Task<IEnumerable<SliderDto>> GetAllAsync()
        { 
            var data = await _sliderRepo.GetAllAsync(); 
            throw new NotImplementedException();
        }
    }
}
