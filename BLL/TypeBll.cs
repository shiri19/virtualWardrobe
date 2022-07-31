using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו מכילה פונקציות שמפעילות את הפונקציות הניגשות בפועל אל טבלת סוגי בגדים
   public class TypeBll
    {

        //אובייקט של המחלקה שמכילה את פונקציות הגישה למסד הנתונים בטבלת קטגוריות
        TypeDal typeDl = new TypeDal();

        //פונקציה לקבלת כל הסוגים
        public List<ClothingTypes> getAll()
        {
            return typeDl.getAll();
        }
        //פונקציה לקבלת סוג בודד לפי קוד
        public ClothingTypes getById(int id)
        {
            return typeDl.getById(id);
        }
        //פונקציית הוספה
        public List<ClothingTypes> add(ClothingTypes t)
        {
            return typeDl.add(t);
        }
        //פונקציית עדכון פרטי סוג
        public String update(int id, ClothingTypes t)
        {
            return typeDl.update(id, t);
        }
        //פונקציית מחיקה
        public String delete(int id)
        {
            return typeDl.delete(id);
        }



    }
}
