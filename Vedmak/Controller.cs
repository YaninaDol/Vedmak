using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedmak
{
    public class Controller
    {
       public Model1 Model1;
        public List<Personage> personages { get; set; }
       
      Controller() {
            Model1 = new Model1();
            personages = new List<Personage>();
            personages.AddRange(Model1.Personages.ToList());
        
        }

        
    }
}
