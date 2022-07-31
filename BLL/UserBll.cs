using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו משויכת למשתמשים
  public  class UserBll
    {

        //אובייקט של המחלקה שמכילה את פונקציות הגישה למסד הנתונים בטבלת קטגוריות
        UserDal userDl = new UserDal();

        //פונקציה לקבלת כל המשתמשים
        public List<Users> getAll()
        {
            return userDl.getAll();
        }
        //פונקציה לקבלת משתמש בודד לפי קוד
        public Users getById(int id)
        {
            return userDl.getById(id);
        }
        //פונקציית הוספת משתמש חדש
        public List<Users> add(Users u)
        {
            return userDl.add(u);
        }
        //פונקציית עדכון פרטי משתמש
        public String update(int id, Users u)
        {
            return userDl.update(id, u);
        }
        //פונקציית הסרת משתמש
        public String delete(int id)
        {
            return userDl.delete(id);
        }



    }
}
