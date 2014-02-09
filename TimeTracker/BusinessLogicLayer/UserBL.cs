using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class UserBL
    {
        public bool CreatUser(UserBO userBO)
        {
            UserDAL userDal = new UserDAL();
            return userDal.CreateUser(userBO);
            
        }
        public bool isValidUser(UserBO userBO)
        {
            UserDAL userDal = new UserDAL();
            if (userBO.Password == userDal.GetUserDetail(userBO))
                return true;
            else
                return false;
            
        }
       
    }
}
