using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.DataAccess
{
    public class ContactTypeData : BaseDataAccess<ContactType>
    {
        public ContactType GetContactType(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.ContactTypes.FirstOrDefault(x => x.ContactTypeID == id);
            }
        }

        public ContactType GetContactTypeName(string nameContactType)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.ContactTypes.FirstOrDefault(x => x.Name == nameContactType);
            }
        }
    }
}
