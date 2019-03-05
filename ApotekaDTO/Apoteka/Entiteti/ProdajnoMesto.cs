using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class ProdajnoMesto
    {
        public virtual string mestoProdajnogMesta { get; set; }
        public virtual string adresaProdajnogMesta { get; set; }
        public virtual string nazivProdajnogMesta { get; set; }
        public virtual int idProdajnogMesta { get; set; }

        public virtual IList<Prodaje> listaProdaja { get; set; }
        public virtual IList<Zaposleni> listaZaposlenih { get; set; }
        
        public virtual IList<Lek> listaLekova { get; set; }

        public virtual IList<Recept> listaIzdatihRecepata { get; set; }
        public ProdajnoMesto()
        {
            listaZaposlenih = new List<Zaposleni>();
            listaProdaja = new List<Prodaje>();
            
            listaLekova = new List<Lek>();

            listaIzdatihRecepata = new List<Recept>();
        }
    }
}
