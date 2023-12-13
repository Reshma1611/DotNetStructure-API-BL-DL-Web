using Demo.BAL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BAL.Repository
{
    public interface IUserRegistration
    {
        bool Add(TblUserRegistrationDTO tblUserRegistrationDTO);
    }
}
