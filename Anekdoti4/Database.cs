using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public struct Role
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Role(int id, string name): this() 
        {
            Id = id;
            Name = name;
        }

        public bool Equals(Role p)
        {
            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != p.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            // Note that the base class is not invoked because it is
            // System.Object, which defines Equals as reference equality.
            return (Id == p.Id) && (Name == p.Name);
        }

        public override int GetHashCode() => (Id, Name).GetHashCode();

        public static bool operator ==(Role lhs, Role rhs)
        {
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Role lhs, Role rhs) => !(lhs == rhs);
    }

    public struct Person
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
            RoleId = new Role(role_id, "");
            FirstName = fName;
            LastName = sName;
            Birthday = birthday;
        }

        public bool Equals(Person p)
        {
            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != p.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            // Note that the base class is not invoked because it is
            // System.Object, which defines Equals as reference equality.
            return (Id == p.Id) && (RoleId == p.RoleId) && (FirstName == p.FirstName) && (LastName == p.LastName) && (Birthday == p.Birthday);
        }

        public override int GetHashCode() => (Id, RoleId, FirstName, LastName, Birthday).GetHashCode();

        public static bool operator ==(Person lhs, Person rhs)
        {
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Person lhs, Person rhs) => !(lhs == rhs);
    }
}
