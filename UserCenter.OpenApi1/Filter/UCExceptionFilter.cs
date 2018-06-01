using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.IO;

namespace UserCenter.OpenApi.Filter
{
    public class UCExceptionFilter : IExceptionFilter
    {
        private ILogger logger;
        public UCExceptionFilter(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger(typeof(UCExceptionFilter));
        }
        public void OnException(ExceptionContext context)
        {
            this.logger.LogError("未处理异常：" + context.Exception);
            //File.WriteAllText("d:/log.txt","未处理异常：" + context.Exception);
        }
    }
}
