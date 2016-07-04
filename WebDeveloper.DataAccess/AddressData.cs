using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.DataAccess
{
    public class AddressData : BaseDataAccess<Address>
    {
        public Address GetAdress(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Addresses.FirstOrDefault(x => x.AddressID == id);
            }
        }

        public List<StateProvince> ListStateProvinces()
        {
            using (var dbContext = new WebContextDb())
            {
                var stateProvinces = new List<StateProvince>
                {
                    new StateProvince {StateProvinceID=1,StateProvinceCode= "HH", CountryRegionCode="BB", Name = "Hamburg", ModifiedDate = System.DateTime.Now, IsOnlyStateProvinceFlag= true},
                    new StateProvince {StateProvinceID=2,StateProvinceCode= "IL", CountryRegionCode="BB", Name = "Illinois", ModifiedDate = System.DateTime.Now, IsOnlyStateProvinceFlag= true},
                    new StateProvince {StateProvinceID=3,StateProvinceCode= "AL", CountryRegionCode="BB", Name = "Alabama", ModifiedDate = System.DateTime.Now, IsOnlyStateProvinceFlag= true}
                };
                stateProvinces.ForEach(c => dbContext.StateProvinces.Add(c));
                dbContext.SaveChanges();

                return stateProvinces.ToList();
            }
        }
    }
}
