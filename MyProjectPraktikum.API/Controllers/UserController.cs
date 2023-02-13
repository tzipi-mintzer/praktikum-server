using Microsoft.AspNetCore.Mvc;
using MyProjectPraktikum.API.Models;
using MyProjectPraktikum.Common.DTOs;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Services.Interfaces;

namespace MyProjectPraktikum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<List<UserDTO>> GetAll()
        {
            return await _userService.GetAllAsync();    
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<UserDTO>AddUser([FromBody] UserModel user)
        {
            return await _userService.AddAsync(new UserDTO() {FirstName=user.FirstName,LastName=user.LastName,BirthDate=user.BirthDate,Gender=user.Gender,HMO=user.HMO,Tz=user.Tz});
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<UserDTO> Update([FromBody] UserModel user)
        {
            return await _userService.UpdateAsync(new UserDTO() { FirstName = user.FirstName, LastName = user.LastName, BirthDate = user.BirthDate, Gender = user.Gender, HMO = user.HMO, Tz = user.Tz } );
        }
    }
   



}
