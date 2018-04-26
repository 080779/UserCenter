using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UserCenter.Helper;
using System.Threading;
using UserCenter.IService;
using UserCenter.Service.Service;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace UserCenter.OpenApi.Filter
{
    public class UCAuthorizationFilter : IAuthorizationFilter
    {
        private IAppInfoService appInfoService=new AppInfoService();
        public bool AllowMultiple => true;
        //public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        //{
        //    //获得报文头中的AppKey和Sign
        //    IEnumerable<string> appKeys;
        //    if (!actionContext.Request.Headers.TryGetValues("AppKey", out appKeys))
        //    {
        //        return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            Content = new StringContent("报文头中的AppKey为空")
        //        };
        //    }
        //    IEnumerable<string> signs;
        //    if (!actionContext.Request.Headers.TryGetValues("Sign", out signs))
        //    {
        //        return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            Content = new StringContent("报文头中的Sign为空")
        //        };
        //    }
        //    string appKey = appKeys.First();
        //    string sign = signs.First();
        //    var appInfo = await appInfoService.GetByAppKeyAsync(appKey);
        //    if (appInfo == null)
        //    {
        //        return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            Content = new StringContent("不存在的AppKey")
        //        };
        //    }
        //    if (!appInfo.IsEnabled)
        //    {
        //        return new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
        //        {
        //            Content = new StringContent("AppKey已经被封禁")
        //        };
        //    }
        //    //计算用户输入参数的连接+AppSecret的Md5值
        //    //orderedQS就是按照key（参数的名字）进行排序的QueryString集合
        //    var orderedQS = actionContext.Request.GetQueryNameValuePairs().OrderBy(kv => kv.Key);
        //    var segments = orderedQS.Select(kv => kv.Key + "=" + kv.Value);//拼接key=value的数组
        //    string qs = string.Join("&", segments);//用&符号拼接起来
        //    string computedSign = CommonHelper.GetMD5(qs + appInfo.AppSecret);//计算qs+secret的md5值  用户传进来md5值和计算出来的比对一下，就知道数据是否有被篡改过
        //    if (sign.Equals(computedSign, StringComparison.CurrentCultureIgnoreCase))
        //    {
        //        return await continuation();
        //    }
        //    else
        //    {
        //        return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
        //        {
        //            Content = new StringContent("sign验证失败")
        //        };
        //    }
        //}

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.Result = new UnauthorizedResult();
        }
    }
}
