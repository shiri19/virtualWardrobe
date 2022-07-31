using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace DAL
{
    //מחלקה זו מקשרת לטבלת עונות
   public class SeasonDal
    {
        //אובייקט של מחלקת מסד הנתונים מכילה רשימות אובייקטים של כל טבלה
        virtualWardrobeContext db = new virtualWardrobeContext();
        //פונקציה לקבלת רשימת העונות ממסד הנתונים
        public List<Seasons> getAll()
        {
            return db.Seasons.ToList();
        }
        //פונקציה לקבלת עונה בודדת לפי הקוד
        public Seasons getById(int id)
        {
            return db.Seasons.FirstOrDefault(x => x.Id == id);
        }
    }
}
