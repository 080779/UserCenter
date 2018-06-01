using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCenter.DTO;
using UserCenter.IService;
using UserCenter.Service.Entity;
using Microsoft.EntityFrameworkCore;

namespace UserCenter.Service.Service
{
    public class AppInfoService : IAppInfoService
    {
        public async Task<AppInfoDTO> GetByAppKeyAsync(string appKey)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                //var appInfo= dbc.AppInfos.SingleOrDefault(a => a.AppKey == appKey);
                var appInfo = await dbc.AppInfos.SingleOrDefaultAsync(a => a.AppKey == appKey);
                if (appInfo==null)
                {
                    return null;
                }
                return ToDTO(appInfo);
            }
        }

        public AppInfoDTO GetByAppKey(string appKey)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var appInfo = dbc.AppInfos.SingleOrDefault(a => a.AppKey == appKey);
                if (appInfo == null)
                {
                    return null;
                }
                return ToDTO(appInfo);
            }
        }

        #region 实体转DTO异步方法
        public Task<AppInfoDTO> ToDTOAsync(AppInfoEntity appInfo)
        {
            return Task.Run(()=> {
                AppInfoDTO dto = new AppInfoDTO();
                dto.AppKey = appInfo.AppKey;
                dto.AppSecret = appInfo.AppSecret;
                dto.CreateTime = appInfo.CreateTime;
                dto.Id = appInfo.Id;
                dto.IsEnabled = appInfo.IsEnabled;
                dto.Name = appInfo.Name;
                return dto;
            });
        }
        #endregion
        #region 实体转DTO同步异步方法
        public AppInfoDTO ToDTO(AppInfoEntity appInfo)
        {
            AppInfoDTO dto = new AppInfoDTO();
            dto.AppKey = appInfo.AppKey;
            dto.AppSecret = appInfo.AppSecret;
            dto.CreateTime = appInfo.CreateTime;
            dto.Id = appInfo.Id;
            dto.IsEnabled = appInfo.IsEnabled;
            dto.Name = appInfo.Name;
            return dto;
        }
        #endregion
    }
}
