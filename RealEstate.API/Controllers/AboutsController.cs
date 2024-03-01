using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.BusinessLayer.Abstract;
using RealEstate.DtoLayer.AboutDtos;

namespace RealEstateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AboutDto>>> AboutList()
        {
            var abouts = await _aboutService.GetAllAsync();
            return Ok(abouts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AboutDto>> GetAbout(int id)
        {
            var about = await _aboutService.GetByIdAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return Ok(about);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAbout(AboutDto aboutDto)
        {
            await _aboutService.CreateAsync(aboutDto);
            return CreatedAtAction(nameof(GetAbout), new { id = aboutDto.AboutID }, aboutDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(AboutDto aboutDto)
        {
            try
            {
                await _aboutService.UpdateAsync(aboutDto);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var about = await _aboutService.GetByIdAsync(id);
            if (about == null)
            {
                return NotFound();
            }

            await _aboutService.RemoveAsync(about);
            return NoContent();
        }
    }
}
