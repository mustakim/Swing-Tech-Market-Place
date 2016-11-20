using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Entity.Database_Entity;

namespace MarketPlace.Context
{
    public class UserContext
    {
        public bool VerifyUser(string name, string pass)
        {
            using (var context = new DatabaseContext())
            {
                User User = (from user in context.Users
                             where user.Name == name && user.Password == pass
                             select user).FirstOrDefault();

                return User != null;
                //can returns true if User name and password matches in Database else false
            }
        }

        public List<User> GetAllUsers()
        {
            using (var context = new DatabaseContext())
            {
                return (from user in context.Users select user).ToList();
                //can return null if No userFound
            }
        }


        public List<User> GetAllUsersByType(string type)
        {
            using (var context = new DatabaseContext())
            {
                return (from user in context.Users where user.Type==type select user).ToList();
                //can return null if No userFound
            }
        }

        public User GetUserByName(string name)
        {
            using (var context = new DatabaseContext())
            {
                return (from user in context.Users where user.Name == name select user).FirstOrDefault();
                //can return null if No userFound
            }
        }

        public bool UpdateUser (User currentUser, User updatedUser)
        {
            //Takes a Old User Object and new User object and Updates New informations Returns true if successful

            using (var context = new DatabaseContext())
            {
                try
                {
                    var User = (from user in context.Users where user.Sl == currentUser.Sl select user).FirstOrDefault();
                    if (User == null) return false;
                    User.Name = updatedUser.Name;
                    User.Password = updatedUser.Password;
                    User.Type = updatedUser.Type;
                    User.Address = updatedUser.Address;
                    User.Email = updatedUser.Email;
                    User.Id = updatedUser.Id;
                    User.Mobile = updatedUser.Mobile;
                    context.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }


            }
        }

        public bool CreateNewUser(User user)
        {
            //Takes An User Object as Parameter returns true if Database is updated
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public bool RemoveUser(User user)
        {
            //Takes An User Object as Parameter returns true if User is Removed from database and Saved
            using (var context = new DatabaseContext())
            {
                try
                {
                    
                    User item = context.Set<User>().FirstOrDefault(r => r.Sl == user.Sl);
                    if (item == null) return false;
                    context.Users.Remove(item);
                    context.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }






    }
}
