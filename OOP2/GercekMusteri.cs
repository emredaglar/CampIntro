using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Indıvıual
    //miras inheritance
    internal class GercekMusteri:Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
