using Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anekdoti.ViewModel
{
    public class RoleViewModel
    {
        public List<Role> ListRole = new List<Role>();
        public RoleViewModel()
        {
            this.ListRole.Add(new Role
            {
                Id = 1,
                Name = "Директор"
            });
            this.ListRole.Add(new Role
            {
                Id = 2,
                Name = "Бухгалтер"
            });
            this.ListRole.Add(new Role
            {
                Id = 3,
                Name = "Менеджер"
            });
            this.ListRole.Add(new Role
            {
                Id = 4,
                Name = "Кскер"
            });
            this.ListRole.Add(new Role
            {
                Id = 5,
                Name = "Чурка"
            });
        }
        public Role GetRoleWithId(int index)
        {
           for(int i = 0; i < ListRole.Count; i++)
           {
                if (ListRole[i].Id == index)
                {
                    return ListRole[i];
                } 
           }

            return new Role(0, "NULL");
        }
    }
}
