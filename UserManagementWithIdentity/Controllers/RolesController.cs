using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagementWithIdentity.Models;
using UserManagementWithIdentity.ViewModels;

namespace UserManagementWithIdentity.Controllers
{
    [Authorize(Roles = ConstRoles.Admin)]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // GET: RolesController
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpPost()]
        [Route("addnewrole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(RoleFormViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index", await _roleManager.Roles.ToListAsync());
                }
                else
                {
                    var isRoleExist = await _roleManager.RoleExistsAsync(model.RoleName);
                    if (isRoleExist)
                    {
                        ModelState.AddModelError("RoleName", "This role is already exist");
                        return View("Index", await _roleManager.Roles.ToListAsync());
                    }
                    else { await _roleManager.CreateAsync(new IdentityRole() { Name = model.RoleName }); }

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
