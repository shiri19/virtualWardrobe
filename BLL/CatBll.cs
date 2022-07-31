using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
   public class CatBll
    {
        //אובייקט של המחלקה שמכילה את פונקציות הגישה למסד הנתונים בטבלת קטגוריות
        CatDal catDl = new CatDal();
        //פונקציה לקבלת כל הקטגוריןת
        public List<Categories> getAll()
        {
            return catDl.getAll();
        }
        //פונקציה לקבלת קטגוריה בודדת לפי קוד
        public Categories getById(int id)
        {
            return catDl.getById(id);
        }
        //פונקציית הוספת קטגוריה
        public List<Categories> add(Categories c)
        {
            return catDl.add(c);
        }
        //פונקציית עדכון פרטי קטגוריה
        public String update(int id, Categories c)
        {
            return catDl.update(id, c);
        }
        //פונקציית מחיקת קטגוריה
        public String delete(int id)
        {
            return catDl.delete(id);
        }

    }
}
