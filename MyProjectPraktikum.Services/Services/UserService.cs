using AutoMapper;
using MyProjectPraktikum.Common.DTOs;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Repository.Interface;
using MyProjectPraktikum.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDTO> AddAsync(UserDTO user)
        {
            EGender g = (EGender)user.Gender;
            EHMO h = (EHMO)user.HMO;
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(new User() { Id = user.Id, Tz = user.Tz, FirstName = user.FirstName, LastName = user.LastName, BirthDate = user.BirthDate, Gender = g, HMO = h }));
        }
        public async Task DeleteAsync(int id)
        {
           await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
           return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
