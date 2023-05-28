using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client=new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt16( customer.NationalityId),customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
