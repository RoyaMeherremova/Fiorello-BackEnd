using Microsoft.AspNetCore.Http;


namespace Service.DTOs
{
    public class SliderUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
