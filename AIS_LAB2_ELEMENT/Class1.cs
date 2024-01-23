using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB2_ELEMENT
{
    public class Detail 
    {
        public int code;
        public string name;
        public string material;
        public double mass;

        public Detail(int code, string name, string material, double mass) 
        { 
            this.code = code;
            this.name = name;
            this.material = material;
            this.mass = mass;
        }
    }

}
