using System;

namespace UserCenter.DTO
{
    public class AppInfoDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsEnabled { get; set; }
    }
}
