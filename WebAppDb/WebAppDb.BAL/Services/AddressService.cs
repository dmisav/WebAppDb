using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDb.DAL.EntityModel;

namespace WebAppDb.BAL
{
    public class AddressService
    {

        public void GetAddress()
        {
            using (var dbContext = new WebAppDbEntitiesContext())
            {
                dbContext.Address.FirstOrDefault();
            }
        }

    }
}
