using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_Pro.Models
{
    public class ProduitServiceImplementation : IProduitService
    {
        // supposons que les produits se truve stocker dans une collection
        Dictionary<int, Produit> listProd = new Dictionary<int, Produit>();
        // le constructeur pour alimenter la liste
        public ProduitServiceImplementation()
        {
            Save(new Produit { Description=  "Ordinateur HP 407", Prix= 600.0});
            Save(new Produit { Description = "Imprimante Canom 543", Prix = 300.0 });
            Save(new Produit { Description = "Portable Samsung A3", Prix = 400.0 });


        }
        public void Delete(int id)
        {
           listProd.Remove(id);
        }

        //edit
        public Produit GetOne(int id)
        {
          // chercher un objet dans une collection
            Produit p;
            listProd.TryGetValue(id, out p);
            return p;
        }

        public IEnumerable<Produit> GetAllProduct()
        {
            return listProd.Values;
        }

        public IEnumerable<Produit> GetProduitByMotCle(string mc)
        {
            return listProd.Values.Where(o => o.Description.Contains(mc));
        }

        public Produit Save(Produit p)
        {
            p.ProduitID = listProd.Count() + 1;
            // map
            listProd[p.ProduitID] = p;
            return p;
        }

        public void Update(Produit p)
        {
            listProd[p.ProduitID] = p;
        }

    
    }
}
