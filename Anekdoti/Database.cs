using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    struct Role
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    struct Person
    {
        public int Id { set; get; }
        public Role RoleId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime Birthday { set; get; }

        public Person(int id, Role role, string fName, string sName, DateTime birthday)
        {
            Id = id;
            RoleId = role;
            FirstName = fName;
            LastName = sName;
            Birthday = birthday;
        }
        public Person(int id, int role_id, string fName, string sName, DateTime birthday)
        {
            Id = id;
            RoleId = new Role();
            FirstName = fName;
            LastName = sName;
            Birthday = birthday;
        }
    }
}
