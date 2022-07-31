using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
namespace DAL
{
    //מחלקה זו מכילה פונקציות המעדכנות את טבלת הגדרות מערכת
   public class SettingsDal
    {
        //אובייקט של מחלקת בסיס הנתונים
        virtualWardrobeContext db = new virtualWardrobeContext();

        //פונקציה לקבלת ההגדרות ממסד הנתונים
        public List<SystemSettings> getAll()
        {
            return db.SystemSettings.ToList();
        }
       
        //פונקציית הוספת הגדרות
        public List<SystemSettings> add(SystemSettings newObj)
        {
            try
            {
                //הוספה
                db.SystemSettings.Add(newObj);
                //שמירה בפועל במסד הנתונים
                db.SaveChanges();
                //החזרת הרשימה המעודכנת לאחר ההוספה
                return db.SystemSettings.ToList();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //שינוי הגדרות
        public String update(int id, SystemSettings obj)
        {
            try
            {
                //איתור הפריט לעדכון
                SystemSettings objToEdit = db.SystemSettings.FirstOrDefault(x => x.Id == id);
                if (objToEdit != null)
                {
                    //עדכון השדות
                    objToEdit.UseChip = obj.UseChip;
                    objToEdit.FrequencyOfUse = obj.FrequencyOfUse;
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
        //מחיקת הגדרות
        public String delete(int id)
        {
            try
            {
                //איתור הפריט למחיקה
                SystemSettings objToDelete = db.SystemSettings.FirstOrDefault(x => x.Id == id);
                if (objToDelete != null)
                {
                    //הסרה מהטבלה
                    db.SystemSettings.Remove(objToDelete);
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
