using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_Pro.Models
{
    public interface IProduitService
    {
        // Definition des besoins fonctionnels
        public Produit Save(Produit p);
        public IEnumerable<Produit> GetAllProduct();
        public IEnumerable<Produit> GetProduitByMotCle(string mc);
        public Produit GetOne(int id);
        public void Update(Produit p);
        public void Delete(int id);


    }
}
