using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sahibinden.Models
{
    internal class Color : Entity
    {
        public ICollection<Car> Cars { get; set; }
        public Color():base()
        {
            Cars = new List<Car>();
        }

        public Color(string name) : base(name)
        {
			Cars = new List<Car>();
		}
    }
}
