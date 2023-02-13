using AutoMapper;
using MyProjectPraktikum.Common.DTOs;
using MyProjectPraktikum.Repository.Entities;
using MyProjectPraktikum.Repository.Interface;
using MyProjectPraktikum.Repository.Repositories;
using MyProjectPraktikum.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Services.Services
{
    public class ChildService : IChildService
    {
        private readonly IMapper _mapper;
        private readonly IChildRepository _childRepository;
        public ChildService(IMapper mapper, IChildRepository childRepository)
        {
            _mapper = mapper;
            _childRepository = childRepository;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));

        }

        public async Task DeleteAsync(int id)
        {

            await _childRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
