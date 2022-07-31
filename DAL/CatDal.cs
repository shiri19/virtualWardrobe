using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
    //מחלקה זו עובדת על טבלת קטגוריות
   public class CatDal
    {
        //אובייקט של מחלקת מסד הנתונים מכילה רשימות אובייקטים של כל טבלה
        virtualWardrobeContext db = new virtualWardrobeContext();
        //פונקציה לקבלת רשימת הקטגוריות ממסד הנתונים
        public List<Categories> getAll()
        {
            return db.Categories.ToList();
        }
        //פונקציה לקבלת קטגוריה בודדת לפי הקוד
        public Categories getById(int id)
        {
            return db.Categories.FirstOrDefault(x => x.Id == id);
        }
        //פונקציית הוספת קטגוריה חדשה
        public List<Categories> add(Categories newCategory)
        {
            try
            {
                //הוספה
                db.Categories.Add(newCategory);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.Categories.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //עדכון פרטי קטגוריה
        public String update(int id, Categories c)
        {
            try
            {
                //איתור הפריט לעדכון
                Categories cToEdit = db.Categories.FirstOrDefault(x => x.Id == id);
                if (cToEdit != null)
                {
                    //עדכון השדות
                    cToEdit.CatName = c.CatName;
                    cToEdit.Clothing = c.Clothing;
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
        //מחיקת קטגוריה
        public String delete(int id)
        {
            try
            {
                //איתור הפריט למחיקה
                Categories cToDelete = db.Categories.FirstOrDefault(x => x.Id == id);
                if (cToDelete != null)
                {
                    //הסרה מהטבלה
                    db.Categories.Remove(cToDelete);
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
