using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו משויכת למחלקה שניגת לטבלת ארון
    public class ClosetBll
    {
        //שניגשת אל מסד הנתונים ClosetDal אובייקט של מחלקת   
        ClosetDal closetDl = new ClosetDal();

        //פונקציה לקבלת הארונות
        public List<Closet> getAll()
        {
            return closetDl.getAll();
        }
        //פונקציה לקבלת ארון בודד לפי קוד
        public Closet getById(int id)
        {
            return closetDl.getById(id);
        }
        //פונקציית הוספת ארון
        public List<Closet> add(Closet c)
        {
            return closetDl.add(c);
        }
        //פונקציית עדכון פרטי ארון
        public String update(int id,Closet c)
        {
            return closetDl.update(id, c);
        }
        //פונקציית מחיקת ארון
        public String delete(int id)
        {
            return closetDl.delete(id);
        }

    }
}
