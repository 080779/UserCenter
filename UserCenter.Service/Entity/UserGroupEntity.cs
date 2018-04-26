using System;
using System.Collections.Generic;
using System.Text;

namespace UserCenter.Service.Entity
{
    public class UserGroupEntity
    {
        public long Id { get; set; }
        public UserEntity User { get; set; }
        public long UserId { get; set; }
        public GroupEntity Group { get; set; }
        public long GroupId { get; set; }
    }
}
