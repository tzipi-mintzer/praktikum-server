using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyProjectPraktikum.API.Models;
using MyProjectPraktikum.Common.DTOs;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Services.Interfaces;
using MyProjectPraktikum.Services.Services;
using System.Xml.Linq;

namespace MyProjectPraktikum.API.Controllers
{
  

    [Route("api/[controller]")]
    [ApiController]

    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> GetAll()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetById(int id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ChildDTO> AddChild([FromBody] ChildModel child)
        {
            return await _childService.AddAsync(new ChildDTO() { BirthDate=child.BirthDate, FirstName = child.FirstName, Tz=child.Tz,ParentId=child.ParentId });
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildModel child)
        {
            return await _childService.UpdateAsync(new ChildDTO() {BirthDate = child.BirthDate, FirstName = child.FirstName, Tz = child.Tz, ParentId = child.ParentId });
        }
    }
}
