using System;
using System.Collections.Generic;
using System.Text;

namespace UserCenter.Service.Entity
{
    public class AppInfoEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsEnabled { get; set; }
    }
}
