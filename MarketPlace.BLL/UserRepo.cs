using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Context;
using MarketPlace.Entity.Database_Entity;

namespace MarketPlace.BLL
{
    public class UserRepo
    {

        public User GetUserById(string id)
        {
            return new UserContext().GetUserByID(id);//Returns user by user Id
        }

        public bool AddNewUser(User user)
        {
            return new UserContext().CreateNewUser(user);//Adds new user to Database

        }

        public bool ModifyUser(User oldUser, User newUser)
        {
            return new UserContext().UpdateUser(oldUser, newUser);//Modifies the old user with the new one
        }

        public bool RemoveUser(User user)
        {
            return new UserContext().RemoveUser(user);//removes the given user from database and returns true
        }

        public List<User> GetAllUsers()
        {
            return new UserContext().GetAllUsers();//returns a list of all users 
        }

        public bool VeryfyUser(string userName, string userPassword)
        {
            return  new UserContext().VerifyUser(userName,userPassword);//validates user if in database
            //if any modification needed here ask me.
        }


    }
}
