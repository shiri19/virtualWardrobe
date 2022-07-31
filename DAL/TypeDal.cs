using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
    //מחלקה זו עובדת על טבלת סוגי בגדים
   public class TypeDal
    {
        //אובייקט של מחלקת מסד הנתונים מכילה רשימות אובייקטים של כל טבלה
        virtualWardrobeContext db = new virtualWardrobeContext();

        //פונקציה לקבלת רשימת הסוגים ממסד הנתונים
        public List<ClothingTypes> getAll()
        {
            return db.ClothingTypes.ToList();
        }
        //פונקציה לקבלת סוג בודד לפי הקוד
        public ClothingTypes getById(int id)
        {
            return db.ClothingTypes.FirstOrDefault(x => x.Id == id);
        }
        //פונקציית הוספת סוג חדש
        public List<ClothingTypes> add(ClothingTypes newType)
        {
            try
            {
                //הוספה
                db.ClothingTypes.Add(newType);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.ClothingTypes.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //עדכון פרטי הסוג
        public String update(int id, ClothingTypes t)
        {
            try
            {
                //איתור הפריט לעדכון
                ClothingTypes tToEdit = db.ClothingTypes.FirstOrDefault(x => x.Id == id);
                if (tToEdit != null)
                {
                    //עדכון השדות
                    tToEdit.TypeName = t.TypeName;
                    tToEdit.Clothing = t.Clothing;
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
                ClothingTypes tToDelete = db.ClothingTypes.FirstOrDefault(x => x.Id == id);
                if (tToDelete != null)
                {
                    //הסרה מהטבלה
                    db.ClothingTypes.Remove(tToDelete);
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
