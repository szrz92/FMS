using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext dbContext;
        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return BadRequest("User does not exist");
            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!singInResult.Succeeded) return BadRequest("Invalid password");
            await _signInManager.SignInAsync(user, request.RememberMe);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest parameters)
        {
            var user = new ApplicationUser();
            user.UserName = parameters.UserName;
            var result = await _userManager.CreateAsync(user, parameters.Password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
            return await Login(new LoginRequest
            {
                UserName = parameters.UserName,
                Password = parameters.Password
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(FMSApplicationUserVM userVM)
        {
            try
            {
                var fmsuser = await _userManager.FindByNameAsync(userVM.UserName);
                if (fmsuser == null)
                {
                    var user = new ApplicationUser();
                    user.UserName = userVM.UserName;
                    user.Email = userVM.Email;
                    user.NormalizedEmail = userVM.Email.ToUpper();
                    user.NormalizedUserName = user.UserName.ToUpper();
                    user.EmailConfirmed = true;
                    user.Id = userVM.Id;
                    user.Name = userVM.FullName;
                    var result = await _userManager.CreateAsync(user, userVM.Password);
                    if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
                    else
                    {
                        user = await _userManager.FindByNameAsync(userVM.UserName);
                        foreach (var role in userVM.Roles)
                        {
                            var roleresult = await _userManager.AddToRoleAsync(user, role);
                        }
                        return Ok("User is added successfully.");
                    }
                }
                else
                {
                    return BadRequest("A user with this email/username already exists.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteUser(ApiRequest request)
        {
            try
            {
                //get User Data from Userid
                var user = await _userManager.FindByNameAsync(request.UserName);


                //Gets list of Roles associated with current user
                var rolesForUser = await _userManager.GetRolesAsync(user);

                if (rolesForUser.Count() > 0)
                {
                    foreach (var item in rolesForUser.ToList())
                    {
                        // item should be the name of the role
                        var result = await _userManager.RemoveFromRoleAsync(user, item);
                    }
                }

                //Delete User
                await _userManager.DeleteAsync(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
        [Authorize(Roles = "SA")]
        [HttpGet]
        public async Task<IActionResult> RegisteredUsers()
        {
            try
            {
                List<FMSApplicationUserVM> users = await (from u in dbContext.Users
                                                          where u.Id != "c58e1a9d-1c28-46db-830a-7b3f0b9663f1"
                                                          select new FMSApplicationUserVM()
                                                          {
                                                              Email = u.Email,
                                                              FullName = u.Name,
                                                              Id = u.Id,
                                                              Roles = (from r in dbContext.UserRoles where r.UserId == u.Id select r.RoleId).ToList()
                                                          }).ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "SA")]
        [HttpGet]
        public async Task<IActionResult> FMSRoles()
        {
            try
            {
                List<FMSRoleVM> roles = await (from u in dbContext.Roles
                                               select new FMSRoleVM()
                                               {
                                                   Id = u.Id
                                               }).ToListAsync();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        public CurrentUser CurrentUserInfo()
        {
            return new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Claims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
            };
        }
    }
}
