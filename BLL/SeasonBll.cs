using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו מתווכת בין שכבת התצוגה לשכבת הגישה לנתונים בכל הקשור לטבלת עונות
   public class SeasonBll
    {
        //שניגשת אל מסד הנתונים SeasonDal אובייקט של מחלקת   
        SeasonDal seasonDl = new SeasonDal();

        //פונקציה לקבלת העונות
        public List<Seasons> getAll()
        {
            return seasonDl.getAll();
        }
        //פונקציה לקבלת עונה בודדת לפי קוד
        public Seasons getById(int id)
        {
            return seasonDl.getById(id);
        }
    }
}
