using DerinceSeyahat.Data;
using DerinceSeyahat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.DA
{
    public class AracRepoConcrete : IAracRepo
    {
        private readonly ApplicationDbContext db;
        public AracRepoConcrete(ApplicationDbContext context)
        {
            db = context;
        }

        public Arac CreateArac(Arac a)
        {
            db.Araclar.Add(a);
            db.SaveChanges();
            return a;
        }

        public void DeleteArac(int id)
        {
            var arac = db.Araclar.FirstOrDefault(x => x.AracId == id);
            db.Araclar.Remove(arac);
            db.SaveChanges();
        }

        public Arac GetAracById(int id)
        {
            return db.Araclar.FirstOrDefault(x => x.AracId == id);
        }

        public List<Arac> GetAracs()
        {
            return db.Araclar.ToList();
        }

        public Arac UpdateArac(int id, Arac a)
        {
            var arac = db.Araclar.FirstOrDefault(x => x.AracId == id);
            arac.AracAdet = a.AracAdet;
            db.Update(arac);
            db.SaveChanges();
            return arac;
        }
    }
}
