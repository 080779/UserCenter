using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserCenter.Helper;
using UserCenter.IService;
using UserCenter.Service.Entity;

namespace UserCenter.Service.Service
{
    public class UserService : IUserService
    {
        public async Task<long> Add(string mobile, string password)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                UserEntity user = new UserEntity();
                user.CreateTime = DateTime.Now;
                user.Mobile = mobile;
                user.Salt = CommonHelper.GetCaptcha(4);
                user.Password = CommonHelper.GetMD5(password+user.Salt);
                dbc.Users.Add(user);
                await dbc.SaveChangesAsync();
                return user.Id;
            }
        }
    }
}
