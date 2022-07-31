using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
   //מחלקה זו ניגשת למסד הנתונים ועובדת על טבלת בגדים
   public class ClothingDal
    {

        virtualWardrobeContext db = new virtualWardrobeContext();
        //החזרת כל בגדים הקיימים במערכת
        public List<Clothing> getAll()
        {
            return db.Clothing.ToList();
        }
        //בגד בודד לפי קוד
        public Clothing getById(int id)
        {
            return db.Clothing.FirstOrDefault(x => x.Id == id);
        }
        //הוספת בגד
        public List<Clothing> add(Clothing newClothing)
        {
            try
            {
                //הוספה
                db.Clothing.Add(newClothing);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.Clothing.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //עדכון
        public String update(int id, Clothing c)
        {
            try
            {
                //איתור הפריט לעדכון
                Clothing cToEdit = db.Clothing.FirstOrDefault(x => x.Id == id);
                if (cToEdit != null)
                {
                    //עדכון השדות
                    cToEdit.ClothingName = c.ClothingName;
                    cToEdit.Picture = c.Picture;
                    cToEdit.KindNavigation = c.KindNavigation;
                    cToEdit.CategoryNavigation = c.CategoryNavigation;
                    cToEdit.SeasonNavigation = c.SeasonNavigation;
                    cToEdit.Gender = c.Gender;
                    cToEdit.User = c.User;
                    cToEdit.Set = c.Set;
                    cToEdit.Size = c.Size;
                    cToEdit.Shelf = c.Shelf;
                    cToEdit.Priority = c.Priority;
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
                Clothing cToDelete = db.Clothing.FirstOrDefault(x => x.Id == id);
                if (cToDelete != null)
                {
                    //הסרה מהטבלה
                    db.Clothing.Remove(cToDelete);
                    //שמירת שינויים במסד נתונים
                    db.SaveChanges();
                    //הפונקציה מחזירה מחרוזת המודיעה  על הצלחה
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
