using System;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            //CountryRegion
            var countryRegions = new List<CountryRegion>
                    {
                        new CountryRegion {CountryRegionCode="BB", Name = "Barbados", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="BD", Name = "Bangladesh", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="BE", Name = "Belgium", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="BF", Name = "Burkina Faso", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="BG", Name = "Bulgaria", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="CA", Name = "Canada", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="CK", Name = "Cook Islands", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="DE", Name = "Germany", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="DO", Name = "Dominican Republic", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="FK", Name = "Falkland Islands (Islas Malvinas)", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="GB", Name = "United Kingdom", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="GM", Name = "Gambia, The", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="HK", Name = "Hong Kong SAR", ModifiedDate = System.DateTime.Now},
                        new CountryRegion {CountryRegionCode="HM", Name = "Heard Island and McDonald Islands", ModifiedDate = System.DateTime.Now}
                    };
            countryRegions.ForEach(c => context.CountryRegions.Add(c));
            context.SaveChanges();

            ////StateProvince
            //var stateProvinces = new List<StateProvince>
            //{
            //    new StateProvince {StateProvinceID=1,StateProvinceCode= "HH", CountryRegionCode="DE", Name = "Hamburg", ModifiedDate = System.DateTime.Now, IsOnlyStateProvinceFlag= true},
            //    new StateProvince {StateProvinceID=1,StateProvinceCode= "IL", CountryRegionCode="US", Name = "Illinois", ModifiedDate = System.DateTime.Now, IsOnlyStateProvinceFlag= true}
            //};
            //stateProvinces.ForEach(c => context.StateProvinces.Add(c));
            //context.SaveChanges();
        }
    }
}