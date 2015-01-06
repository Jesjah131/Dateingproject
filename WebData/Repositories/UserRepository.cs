
using System.Collections.Generic;
using System.Linq;

using System.Data.Entity;


namespace WebData
{
    public class UserRepository
    {
        public static List<UserInfo> GetAll()
        {

            using (var context = new DejtingEntities())
            {
                var result = context.UserInfoes
                    .Include(x => x.UserInfo1)
                    .OrderBy(x => x.Firstname)
                    .ToList();

                return result;
            }

        }

        public void AddUser(UserInfo user)
        {

            using (var context = new DejtingEntities())
            {
                context.UserInfoes.Add(user);
                context.SaveChanges();
               
            }


        }
        public static UserInfo TestLogIn(string username, string password)
        {
            using (var context = new DejtingEntities())
            {
                return context.UserInfoes.FirstOrDefault(x =>
                    x.Username.Equals(username) &&
                    x.Password.Equals(password));
            }
        }

        public List<UserInfo> GetSearchedUsername(string query)
        {
            DejtingEntities db = new DejtingEntities();

            var queryz = db.UserInfoes.Where(x => x.Firstname.Contains(query));
            return queryz.ToList();
        }
    }
}

