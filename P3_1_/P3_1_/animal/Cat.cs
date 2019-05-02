using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3_1_.sound;

namespace P3_1_.animal
{
    class Cat: Talk
    {
        
      

        public void Talk()
        {
            Console.WriteLine(" soy el meow meow");  
        }

       

        public void meow()
        {
            Sound.Sonido();
            
        }

        
    }
}
