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
        public List<Personage> personageses { get; set; }
       
      Controller() {
            Model1 = new Model1();
            personageses = new List<Personage>();
            personageses.AddRange(Model1.Personages.ToList());
        
        }

        
    }
}
