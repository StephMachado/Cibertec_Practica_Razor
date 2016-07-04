using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess.ClassData
{
    public class CountryRegionData : BaseDataAccess<CountryRegion>
    {
        public CountryRegion GetCountryRegion(string id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.CountryRegions.FirstOrDefault(x => x.CountryRegionCode == id);
            }
        }
    }
}
