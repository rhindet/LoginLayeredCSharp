using DataAcces;
using Common.cache;



namespace domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user , string pass) {
            return userDao.Login(user,pass);
        }
       
    }
}