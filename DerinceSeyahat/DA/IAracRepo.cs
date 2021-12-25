using DerinceSeyahat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.DA
{
    public interface IAracRepo
    {
        public Arac CreateArac(Arac a);
        public List<Arac> GetAracs();
        public Arac GetAracById(int id);
        public void DeleteArac(int id);
        public Arac UpdateArac(int id, Arac a);
    }
}
