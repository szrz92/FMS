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
        /// <summary>
        /// login api
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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
        /// <summary>
        /// register user
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest parameters)
        {
            var user = new ApplicationUser
            {
                UserName = parameters.UserName
            };
            var result = await _userManager.CreateAsync(user, parameters.Password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
            return await Login(new LoginRequest
            {
                UserName = parameters.UserName,
                Password = parameters.Password
            });
        }
        /// <summary>
        /// register a new user
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(FMSApplicationUserVM userVM)
        {
            try
            {
                var fmsuser = await _userManager.FindByNameAsync(userVM.UserName);
                if (fmsuser == null)
                {
                    var user = new ApplicationUser
                    {
                        UserName = userVM.UserName,
                        Email = userVM.Email,
                        NormalizedEmail = userVM.Email.ToUpper()
                    };
                    user.NormalizedUserName = user.UserName.ToUpper();
                    user.EmailConfirmed = true;
                    user.Id = userVM.Id;
                    user.Name = userVM.FullName;
                    user.SubRegion = userVM.SubRegion;
                    user.Region = userVM.Region;
                    user.Station = userVM.Station;
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
        /// <summary>
        /// api to update user
        /// </summary>
        /// <param name="userVM"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateUser(FMSApplicationUserVM userVM)
        {
            try
            {
                var fmsuser = await _userManager.FindByNameAsync(userVM.UserName);
                if (fmsuser != null)
                {
                    fmsuser.UserName = userVM.UserName;
                    fmsuser.Email = userVM.Email;
                    fmsuser.NormalizedEmail = userVM.Email.ToUpper();
                    fmsuser.NormalizedUserName = fmsuser.UserName.ToUpper();
                    fmsuser.EmailConfirmed = true;
                    fmsuser.Id = userVM.Id;
                    fmsuser.Name = userVM.FullName;
                    fmsuser.Region = userVM.Region;
                    fmsuser.SubRegion = userVM.SubRegion;
                    fmsuser.Station = userVM.Station;

                    var result = await _userManager.UpdateAsync(fmsuser);
                    if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
                    else
                    {
                        fmsuser = await _userManager.FindByNameAsync(userVM.UserName);
                        List<string> addedroles = (from r in dbContext.UserRoles where r.UserId == fmsuser.Id select r.RoleId).ToList();
                        await _userManager.RemoveFromRolesAsync(fmsuser, addedroles); 
                        await _userManager.AddToRolesAsync(fmsuser, userVM.Roles);
                        return Ok("User is edited successfully.");
                    }
                }
                else
                {
                    return BadRequest("User to be edited doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// api to delete a user by user name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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
        /// <summary>
        /// logout api
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
        [Authorize]
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
                                                              Roles = (from r in dbContext.UserRoles where r.UserId == u.Id select r.RoleId).ToList(),
                                                              Department = (from g in dbContext.GBMSUsers where g.XName == u.Name select g.XDepartmentDescription).SingleOrDefault(),
                                                              Region = u.Region,
                                                              SubRegion = u.SubRegion,
                                                              Station = u.Station
                                                          }).ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// getting a registered user against a user name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RegisteredUser(ApiRequest request)
        {
            try
            {
                FMSApplicationUserVM user = await (from u in dbContext.Users
                                                   where u.UserName == request.UserName
                                                   select new FMSApplicationUserVM()
                                                   {
                                                       Email = u.Email,
                                                       FullName = u.Name,
                                                       Id = u.Id,
                                                       Roles = (from r in dbContext.UserRoles where r.UserId == u.Id select r.RoleId).ToList(),
                                                       Department = (from g in dbContext.GBMSUsers where g.XName == u.Name select g.XDepartmentDescription).SingleOrDefault(),
                                                       Password = "Random123!@#",
                                                       ConfirmPassword = "Random123!@#",
                                                       Region = u.Region,
                                                       SubRegion = u.SubRegion,
                                                       Station=u.Station
                                                   }).SingleOrDefaultAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// get fms roles
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// api to get signed in user as current user
        /// </summary>
        /// <returns></returns>
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
