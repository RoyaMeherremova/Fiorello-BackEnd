

using Service.DTOs;

namespace Service.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<SliderDto>> GetAllAsync();
        //Task<SliderDto> GetByIdAsync(int? id);
        //Task CreateAsync(SliderCreateDto sliderCreateDto);
        //Task DeleteAsync(int? id);
        //Task UpdateAsync(int? id, SliderUpdateDto sliderUpdateDto);
        //Task<IEnumerable<SliderDto>> SearchAsync(string? searchText);
    }
}
