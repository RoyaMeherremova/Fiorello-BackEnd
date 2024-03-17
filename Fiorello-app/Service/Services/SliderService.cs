using AutoMapper;
using Repository.Repositories.Interfaces;
using Service.DTOs;
using Service.Services.Interfaces;


namespace Service.Services
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepo;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository sliderRepo, IMapper mapper)
        {
            _sliderRepo = sliderRepo;
            _mapper = mapper;


        }

        public async Task DeleteAsync(int? id) => await _sliderRepo.DeleteAsync(await _sliderRepo.GetByIdAsync(id));


        public async Task<IEnumerable<SliderDto>> GetAllAsync() => _mapper.Map<IEnumerable<SliderDto>>(await _sliderRepo.FindAllAsync());

        public async Task<SliderDto> GetByIdAsync(int? id) => _mapper.Map<SliderDto>(await _sliderRepo.GetByIdAsync(id));

        public async Task<IEnumerable<SliderDto>> SearchAsync(string? searchText)
        {
            if (string.IsNullOrEmpty(searchText))
                return _mapper.Map<IEnumerable<SliderDto>>(await _sliderRepo.FindAllAsync());
            return _mapper.Map<IEnumerable<SliderDto>>(await _sliderRepo.FindAllAsync(m => m.Title.Contains(searchText)));
        }
    }
}
