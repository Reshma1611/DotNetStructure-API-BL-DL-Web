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
    public class State : IState
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;
        public State(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public List<TblStateDTO> GetAllState()
        {
            List<TblStateDTO> tblStateDTOs = new List<TblStateDTO>();
            List<TblState> responseModel = _applicationContext.tblState.Select(x => x).ToList();
            if(responseModel != null)
            {
                foreach(var stateData in responseModel)
                {
                    TblStateDTO tblStateDTO = new TblStateDTO();
                    tblStateDTO = _mapper.Map<TblStateDTO>(stateData);
                    tblStateDTOs.Add(tblStateDTO);
                }                
            }
            return tblStateDTOs;
        }
    }
}
