using AutoMapper;
using Demo.BAL.ModelDTO;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BAL.Repository
{
    public class City : ICity
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;
        public City(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public List<TblCityDTO> GetAllCity(int stateId)
        {
            List<TblCityDTO> tblCityDTOs = new List<TblCityDTO>();
            List<TblCity> responseModel = _applicationContext.tblCity.Where(x => x.StateId == stateId).ToList();
            if (responseModel != null)
            {
                foreach (var cityData in responseModel)
                {
                    TblCityDTO tblCityDTO = new TblCityDTO();
                    tblCityDTO = _mapper.Map<TblCityDTO>(cityData);
                    tblCityDTOs.Add(tblCityDTO);
                }
            }
            return tblCityDTOs;
        }
    }

    public class City2 : ICity
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;
        public City2(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public List<TblCityDTO> GetAllCity(int stateId)
        {
            List<TblCityDTO> tblCityDTOs = new List<TblCityDTO>();
            List<TblCity> responseModel = _applicationContext.tblCity.Where(x => x.StateId == stateId).ToList();
            if (responseModel != null)
            {
                foreach (var cityData in responseModel)
                {
                    TblCityDTO tblCityDTO = new TblCityDTO();
                    tblCityDTO = _mapper.Map<TblCityDTO>(cityData);
                    tblCityDTOs.Add(tblCityDTO);
                }
            }
            return tblCityDTOs;
        }
    }
}
