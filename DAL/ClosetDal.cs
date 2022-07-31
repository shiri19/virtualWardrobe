using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
    //מחלקה זו שולפת ומעדכנת את טבלת ארון   closet
   public class ClosetDal
    {
        virtualWardrobeContext db = new virtualWardrobeContext();
        //החזרת כל הארונות הקיימים במערכת
        public List<Closet> getAll()
        {
            return db.Closet.ToList();
        }
        //ארון בודד לפי קוד
        public Closet getById(int id)
        {
            return db.Closet.FirstOrDefault(x => x.Id == id);
        }
        //הוספת ארון
        public List<Closet> add(Closet newCloset)
        {
            try
            {
                //הוספה
                db.Closet.Add(newCloset);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.Closet.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //עדכון
        public String update(int id,Closet c)
        {
            try
            {
                //איתור הפריט לעדכון
                Closet cToEdit = db.Closet.FirstOrDefault(x => x.Id == id);
                if (cToEdit != null)
                {
                    //עדכון השדות
                    cToEdit.ClosetNane = c.ClosetNane;
                    cToEdit.ClosetDesc = c.ClosetDesc;
                    cToEdit.Shelf = c.Shelf;
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
                Closet cToDelete = db.Closet.FirstOrDefault(x => x.Id == id);
                if (cToDelete != null)
                {
                    //הסרה מהטבלה
                    db.Closet.Remove(cToDelete);
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
