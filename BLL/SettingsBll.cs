using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
namespace BLL
{
    //מחלקה זו מטפלת בעינייני הגדרות המערכת 
   public class SettingsBll
    {
        SettingsDal settingsDl = new SettingsDal();
        //קבלת ההגדרות ממסד הנתונים
        public List<SystemSettings> getAll()
        {
            return settingsDl.getAll();
        }
        //הוספת הגדרות
        public List<SystemSettings> add(SystemSettings newObj)
        {
            return settingsDl.add(newObj);
        }
        //שינוי הגדרות
        public string update(int id, SystemSettings obj)
        {
            return settingsDl.update(id, obj);
        }
        //מחיקת הגדרות
        public string delete(int id)
        {
            return settingsDl.delete(id);
        }

    }
}
