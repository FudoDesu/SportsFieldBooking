using AutoMapper;
using BusinessObject.Entity;
using BusinessObject.Model.UserModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryObject.Implement;
using RepositoryObject.Interface;

namespace SFB_WebApi.Controllers
{
    [ApiController]
    [Route("/UserController")]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository = new UserRepository();
        private readonly IMapper _mapper;
        private string Message;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: api/UserController/UserList
        [HttpGet("UserList")]
        [Authorize]
        public ActionResult<IEnumerable<User>> GetListUsers()
        {
            try
            {
                List<UserListModel> users = new List<UserListModel>();
                var userList = _userRepository.GetListAsync();
                if (userList == null)
                {
                    return NotFound("No data found");
                }
                else
                {
                    users = _mapper.Map<List<UserListModel>>(userList);
                    return Ok(users);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
