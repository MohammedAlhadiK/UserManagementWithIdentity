namespace UserManagementWithIdentity.ViewModels
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IList<RoleViewModel> Roles { get; set; }
    }
}
