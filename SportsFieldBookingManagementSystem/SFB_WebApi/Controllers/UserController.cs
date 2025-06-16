using AutoMapper;
using BusinessObject.Entity;
using BusinessObject.Model.JwtTokenModel;
using BusinessObject.Model.UserModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryObject.Implement;
using RepositoryObject.Interface;

namespace SFB_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private string Message;

        public UserController(IUserRepository userRepository ,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // GET: api/UserController/UserList
        [HttpGet("UserList")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserListModel>>> GetListUsers()
        {
            try
            {
                List<UserListModel> users = new List<UserListModel>();
                var userList = await _userRepository.GetListAsync();
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

        [HttpPost("Login")]
        public async Task<ActionResult<UserViewModel>> Login([FromBody] LoginModel loginModel)
        {
            try
            {
                var user = await _userRepository.LoginAsync(loginModel.Email, loginModel.Password);
                if (user == null)
                {
                    return Unauthorized("Invalid email or password");
                }
                else
                {
                    var model = _mapper.Map<UserViewModel>(user);
                    var tokenModel = new TokenModel
                    {
                        UserID = user.UserId,
                        UserName = user.UserName,
                        Email = user.Email,
                        RoleID = user.RoleId
                    };

                    var tokenGenerator = new JwtTokenGenerator(this.HttpContext.RequestServices.GetRequiredService<IConfiguration>());
                    var token = tokenGenerator.GenerateToken(tokenModel);

                    return Ok(new
                    {
                        token, 
                        user = model
                    });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
