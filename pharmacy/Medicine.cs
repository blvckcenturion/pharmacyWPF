using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QtyInExistance { get; set; }
        public int Price { get; set; }
        public Medicine( string _Name, int _QtyInExistance, int _price, int _id)
        {
            Id = _id;
            Name = _Name;
            QtyInExistance = _QtyInExistance;
            Price = _price;
        }
    }
}
