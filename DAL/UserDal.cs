using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
    //מחלקה זו ניגשת למסד הנתונים ועובדת על טבלת משתמשים
   public class UserDal
    {

        virtualWardrobeContext db = new virtualWardrobeContext();
        //החזרת כל המשתמשים הקיימים במערכת
        public List<Users> getAll()
        {
            return db.Users.ToList();
        }
        //משתמש בודד לפי קוד
        public Users getById(int id)
        {
            return db.Users.FirstOrDefault(x => x.Id == id);
        }
        //הוספת משתמש חדש
        public List<Users> add(Users newUser)
        {
            try
            {
                //הוספה
                db.Users.Add(newUser);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.Users.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //עדכון
        public String update(int id, Users u)
        {
            try
            {
                //איתור הפריט לעדכון
                Users uToEdit = db.Users.FirstOrDefault(x => x.Id == id);
                if (uToEdit != null)
                {
                    //עדכון השדות
                    uToEdit.UserName = u.UserName;
                    uToEdit.Gender = u.Gender;
                    uToEdit.BearthYear = u.BearthYear;
                    uToEdit.Size = u.Size;
                    uToEdit.Picture = u.Picture;
                    uToEdit.Clothing = u.Clothing;
                    //שמירה בפועל במסד הנתונים
                    db.SaveChanges();
                    return "success";
                }
                return "faild";

            }

            catch (Exception err)
            {
                return "faild";
            }

        }

        //מחיקה
        public String delete(int id)
        {
            try
            {
                //איתור הפריט למחיקה
                Users uToDelete = db.Users.FirstOrDefault(x => x.Id == id);
                if (uToDelete != null)
                {
                    //הסרה מהטבלה
                    db.Users.Remove(uToDelete);
                    //שמירת שינויים במסד נתונים
                    db.SaveChanges();
                    //הפןנקציה מחזירה מחרוזת המודיעה  על הצלחה
                    return "success";
                }
                //במקרה של כישלון תחזור מחרוזת המודיעה על כך
                return "faild";
            }
            catch (Exception err)
            {
                return "faild";
            }
        }



    }
}
