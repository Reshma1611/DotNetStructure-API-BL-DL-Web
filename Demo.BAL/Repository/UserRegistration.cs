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
    public class UserRegistration : IUserRegistration
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;
        public UserRegistration(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public bool Add(TblUserRegistrationDTO tblUserRegistrationDTO)
        {
            try
            {
                TblUserRegistration tblUserRegistration = _mapper.Map<TblUserRegistration>(tblUserRegistrationDTO);
                _applicationContext.tblUserRegistration.Add(tblUserRegistration);
                _applicationContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
