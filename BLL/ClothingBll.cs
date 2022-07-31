using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו מתווכת בין שכבת התצוגה לשכבת הגישה לנתונים בטבלת בגדים
  public class ClothingBll
    {

        //שניגשת אל מסד הנתונים ClosetDal אובייקט של מחלקת   
        ClothingDal clothinDl = new ClothingDal();

        //פונקציה לקבלת הבגדים
        public List<Clothing> getAll()
        {
            return clothinDl.getAll();
        }
        //פונקציה לקבלת בגד בודד לפי קוד
        public Clothing getById(int id)
        {
            return clothinDl.getById(id);
        }
        //פונקציית הוספת בגד
        public List<Clothing> add(Clothing c)
        {
            return clothinDl.add(c);
        }
        //פונקציית עדכון פרטי בגד
        public String update(int id, Clothing c)
        {
            return clothinDl.update(id, c);
        }
        //פונקציית מחיקת בגד
        public String delete(int id)
        {
            return clothinDl.delete(id);
        }



    }
}
