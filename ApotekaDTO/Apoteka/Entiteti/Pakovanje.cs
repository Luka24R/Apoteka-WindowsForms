using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apoteka.Entiteti
{
    public class Pakovanje
    {
        public virtual int idPakovanja { get; set; }
        public virtual int kolicina { get; set; }
        public virtual string sastav { get; set; }
        public virtual string tipPakovanja { get; set; }
        public virtual Lek pakujeLek { get; set; }
    }

    public class Sirup:Pakovanje
    {

    }

    public class Tableta:Pakovanje
    {

    }

    public class Prasak:Pakovanje
    {

    }

    public class Inekcija:Pakovanje
    {

    }
}
