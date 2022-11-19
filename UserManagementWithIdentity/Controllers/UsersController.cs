using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Text.Encodings.Web;
using System.Text;
using UserManagementWithIdentity.Models;
using UserManagementWithIdentity.ViewModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace UserManagementWithIdentity.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }



        // GET: UsersController
        public async Task<IActionResult> Index()
        {
            var Users = await _userManager.Users.Select( user => new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Roles = _userManager.GetRolesAsync(user).Result,

            }).ToListAsync();
            return View(Users);
        }

        // GET: UsersController/Details/5
        [HttpGet]
        [Route("ManageRoles")]
        public async Task<IActionResult> ManageRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var roles = _roleManager.Roles.ToList();
            var userRoles = new UserRolesViewModel()
            {
                UserId = user.Id,
                UserName = user.FirstName + " " + user.LastName,
                Roles = roles.Select(role => new RoleViewModel() { RoleName = role.Name, isSelected = _userManager.IsInRoleAsync(user, role.Name).Result }).ToList(),
            };
            return View(userRoles);
        }
        [HttpPost]
        [Route("ManageUserRoles")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageUserRoles(UserRolesViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null) return NotFound();
            foreach (var role in model.Roles)
            {
                if (await _userManager.IsInRoleAsync(user, role.RoleName) && !role.isSelected)
                {
                    await _userManager.RemoveFromRoleAsync(user, role.RoleName);
                }
                if (!await _userManager.IsInRoleAsync(user, role.RoleName) && role.isSelected)
                {
                    await _userManager.AddToRoleAsync(user, role.RoleName);
                }
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Route("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            await _userManager.DeleteAsync(user); 

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("AddNewUser")]

        public async Task<IActionResult> AddNewUser()
        {
            return View(new AddNewUserViewModel());
        }

        [HttpPost]
        [Route("AddNewUser")]

        public async Task<IActionResult> AddNewUserPostAsync(AddNewUserViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return View("AddNewUser", model);
                }  //exist user
                if (await _userManager.FindByNameAsync(model.UserName) is not null)
                {
                    ModelState.AddModelError("UserName", $"User Name [{model.UserName}] is Already exist");
                    return View("AddNewUser", model);

                }
                //exist email
                if (await _userManager.FindByEmailAsync(model.Email) is not null)
                {
                    ModelState.AddModelError("Email", $"Email [{model.Email}] is Already exist");
                    return View("AddNewUser", model);

                }

                var user = new ApplicationUser()
                {
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,


                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, ConstRoles.User);
                    var id = user.Id;
                    return RedirectToAction(nameof(ManageRoles), "Users", new {  id });
                }
            }
            catch (Exception)
            {

                throw;
            }

            return View("AddNewUser", model);

        }





        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
