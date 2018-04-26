using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserCenter.DTO;

namespace UserCenter.IService
{
    public interface IAppInfoService:IServiceSupport
    {
        Task<AppInfoDTO> GetByAppKeyAsync(string appKey);
    }
}
