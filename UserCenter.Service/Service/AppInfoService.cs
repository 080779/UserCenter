using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserCenter.DTO;
using UserCenter.IService;

namespace UserCenter.Service.Service
{
    public class AppInfoService : IAppInfoService
    {
        public Task<AppInfoDTO> GetByAppKeyAsync(string appKey)
        {
            throw new NotImplementedException();
        }
    }
}
