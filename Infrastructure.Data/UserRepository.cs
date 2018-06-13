using Domain.Entity;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    
    {
       
        public IEnumerable<User> GetUsers()
        {

            var users = new List<User>()
            {
                // in reality you would connet to Database from this point, but for demo purposes
                // we will just return in-memory data
                    new User {  Name = "agwo hope", MatricNo = "fos/10/12/121", CGPA = "4.8"},
                    new User { Name = "sunil john", MatricNo = "fos/10/12/122",CGPA = "4.75"},
                    new User { Name = "shola micheal", MatricNo = "fos/10/12/123",CGPA = "4.7"},
                    new User {  Name = "tolu samuel", MatricNo = "fos/10/12/124", CGPA = "4.6"},
                    new User {  Name = "uba gift", MatricNo = "fos/10/12/125", CGPA = "4.5"},


            };
             return users;

        }
    }
}
