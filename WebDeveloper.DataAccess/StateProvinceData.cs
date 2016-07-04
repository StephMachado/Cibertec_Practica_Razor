using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.DataAccess
{
    public class StateProvinceData : BaseDataAccess<StateProvince>
    {
        public StateProvince GetStateProvince(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.StateProvinces.FirstOrDefault(x => x.StateProvinceID == id);
            }
        }

        public IEnumerable<CountryRegion> ListCountryRegions()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.CountryRegions.ToList();
            }
        }
    }
}
