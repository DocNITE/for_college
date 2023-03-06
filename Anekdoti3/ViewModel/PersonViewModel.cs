using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anekdoti.ViewModel
{
    public class PersonViewModel
    {
        public List<Person> ListPerson = new List<Person>();
        public PersonViewModel(RoleViewModel roles)
        {
            this.ListPerson.Add(
            new Person
            {
                Id = 1,
                RoleId = roles.GetRoleWithId(1),
                FirstName = "Иван",
                LastName = "Иванов",
                Birthday = new DateTime(1980, 02, 28)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 2,
                RoleId = roles.GetRoleWithId(2),
                FirstName = "Петр",
                LastName = "Петров",
                Birthday = new DateTime(1981, 03, 20)
            });

            this.ListPerson.Add(
            new Person
            {
                Id = 3,
                RoleId = roles.GetRoleWithId(3),
                FirstName = "Виктор",
                LastName = "Викторов",
                Birthday = new DateTime(1982, 04, 15)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 4,
                RoleId = roles.GetRoleWithId(3),
                FirstName = "Сидор",
                LastName = "Сидоров",
                Birthday = new DateTime(1983, 05, 10)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 5,
                RoleId = roles.GetRoleWithId(4),
                FirstName = "Кирил",
                LastName = "Боев",
                Birthday = new DateTime(1983, 05, 10)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 6,
                RoleId = roles.GetRoleWithId(5),
                FirstName = "Максим",
                LastName = "Кожевников",
                Birthday = new DateTime(1983, 05, 10)
            });
        }
    }
}
