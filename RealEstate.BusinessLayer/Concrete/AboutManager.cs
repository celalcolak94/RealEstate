using AutoMapper;
using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DtoLayer.AboutDtos;
using RealEstate.EntityLayer.Entities;

namespace RealEstate.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        private readonly IMapper _mapper;

        public AboutManager(IAboutDal aboutDal, IMapper mapper)
        {
            _aboutDal = aboutDal;
            _mapper = mapper;
        }

        public async Task CreateAsync(AboutDto entity)
        {
            var value = _mapper.Map<About>(entity);
            await _aboutDal.CreateAsync(value);
        }

        public async Task<List<AboutDto>> GetAllAsync()
        {
            var value = await _aboutDal.GetAllAsync();
            return _mapper.Map<List<AboutDto>>(value);
        }

        public async Task<AboutDto> GetByIdAsync(int id)
        {
            var value = await _aboutDal.GetByIdAsync(id);
            return _mapper.Map<AboutDto>(value);
        }

        public async Task RemoveAsync(AboutDto entity)
        {
            var value = _mapper.Map<About>(entity);
            await _aboutDal.RemoveAsync(value);
        }

        public async Task UpdateAsync(AboutDto entity)
        {
            var value = await _aboutDal.GetByIdAsync(entity.AboutID);

            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _aboutDal.UpdateAsync(value);
        }
    }
}
