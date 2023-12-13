using Demo.BAL.ModelDTO;
using Demo.BAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeAPIController : ControllerBase
    {
        private readonly IState _state;
        private readonly ICity _city;
        private readonly IUserRegistration _userRegistration;
        public HomeAPIController(IState state, ICity city, IUserRegistration userRegistration)
        {
            _state = state;
            _city = city;
            _userRegistration = userRegistration;
        }
        [HttpGet("GetStates")]
        public async Task<IActionResult> GetAllState()
        {
            List<TblStateDTO> responseData = _state.GetAllState();            
            return new JsonResult(responseData);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]TblUserRegistrationDTO tblUserRegistrationDTO)
        {
            bool responseData = _userRegistration.Add(tblUserRegistrationDTO);
            return new JsonResult(responseData);
        }


        [HttpGet("GetCity")]
        public async Task<IActionResult> GetCity(int stateId)
        {
            List<TblCityDTO> responseData = _city.GetAllCity(stateId);
            return new JsonResult(responseData);
        }
        [HttpGet("abc")]
        public IActionResult abc()
        {
            return new JsonResult("smdh");
        }
        [HttpGet("xyz")]
        public IActionResult xyz()
        {
            return new JsonResult("smdh");
        }
    }
}
