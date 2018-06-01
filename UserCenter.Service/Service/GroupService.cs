using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCenter.DTO;
using UserCenter.IService;
using UserCenter.Service.Entity;

namespace UserCenter.Service.Service
{
    public class GroupService : IGroupService
    {
        public async Task<GroupDTO[]> GetGroupByUserIdAsync(long id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var user = await dbc.Users.SingleOrDefaultAsync(u => u.Id == id);
                if (user == null)
                {
                    return null;
                }
                var groups = dbc.UserGroups.Where(u => u.UserId == id);
                return await groups.Select(u => ToDTO(u.Group)).ToArrayAsync();
            }
        }

        public GroupDTO ToDTO(GroupEntity group)
        {
            GroupDTO dto = new GroupDTO();
            dto.CreateTime = group.CreateTime;
            dto.Id = group.Id;
            dto.Name = group.Name;
            return dto;
        }
    }
}
