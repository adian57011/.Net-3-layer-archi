using DAL.Db;
using DAL.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CatagoryRepo
    {
        public static List<Catagory> All()
        {
            var db = new TierContext();
            return db.Catagories.ToList();
        }

        public static Catagory Get(int id)
        {
            var db = new TierContext();
            return db.Catagories.Find(id);
        }

        public static bool Create(Catagory c)
        {
            var db = new TierContext();

            db.Catagories.Add(c);

            if (db.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(int id)
        {
            var db = new TierContext();
            var data = db.Catagories.Find(id);

            db.Catagories.Remove(data);

            if (db.SaveChanges() > 0)
                return true;
            else
                return false;

        }

        public static bool Update(Catagory c)
        {
            var db = new TierContext();
            var ex = db.Catagories.Find(c.Id);

            db.Entry(ex).CurrentValues.SetValues(c);

            if (db.SaveChanges() > 0)
                return true;
            else
                return false;
        }

    }
}
