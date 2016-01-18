using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockContextTestRepoClass.Repo
{
    public class ManufacturerRepository
    {
        // The constructor allows us to pass in the mock context.
        private JB_FoodStoreEntities context = new JB_FoodStoreEntities();
        public ManufacturerRepository(JB_FoodStoreEntities context)
        {
            this.context = context;
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return context.Manufacturers.ToList();
        }

        public Manufacturer GetManufacturer(string mfg)
        {
            return context.Manufacturers.Where(m => m.mfg == mfg)
                          .FirstOrDefault();
        }

    }
}