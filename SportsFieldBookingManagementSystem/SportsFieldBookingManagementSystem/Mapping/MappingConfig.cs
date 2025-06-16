using AutoMapper;
using BusinessObject.Entity;
using BusinessObject.Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            Map_User_UserListModel();
        }

        private void Map_User_UserListModel()
        {
            CreateMap<User, UserListModel>()
                .AfterMap<MappingAction_User_UserListModel>();
        }

        private void Map_User_UserViewModel()
        {
            CreateMap<User, UserViewModel>()
                .AfterMap<MappingAction_User_UserViewModel>();
        }
        public class MappingAction_User_UserListModel : IMappingAction<User, UserListModel>
        {
            public void Process(User source, UserListModel destination, ResolutionContext context)
            {
                //var db = new SportsFieldBookingContext();
                using (var db = new SportsFieldBookingContext())
                {
                    var role = db.Roles.FirstOrDefault(x => x.RoleId == source.RoleId);

                    destination.Role = role.RoleName;
                }
            }
        }

        public class MappingAction_User_UserViewModel : IMappingAction<User, UserViewModel>
        {
            public void Process(User source, UserViewModel destination, ResolutionContext context)
            {
                //var db = new SportsFieldBookingContext();
                using (var db = new SportsFieldBookingContext())
                {
                    var role = db.Roles.FirstOrDefault(x => x.RoleId == source.RoleId);

                    destination.Role = role.RoleName;
                }
            }
        }
    }
}
