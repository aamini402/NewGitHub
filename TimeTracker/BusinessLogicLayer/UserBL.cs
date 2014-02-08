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

    }
}
