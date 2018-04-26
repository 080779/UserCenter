using System;
using System.Collections.Generic;
using System.Text;

namespace UserCenter.Service.Entity
{
    public class UserEntity
    {
        public long Id { get; set; }
        public string Mobile { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
