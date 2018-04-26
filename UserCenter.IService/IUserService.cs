using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserCenter.IService
{
    public interface IUserService
    {
        Task<long> Add(string mobile,string password);
    }
}
