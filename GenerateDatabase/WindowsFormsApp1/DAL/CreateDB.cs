using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Order;
using WindowsFormsApp1.DTO.DTO_Person;

namespace WindowsFormsApp1
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLCinema>
    {
        protected override void Seed(QLCinema context)
        {
            context._Customers.AddRange(new Customer[]
            {
                new Customer{ _IDPerson = "1", _NamePerson = "NVA", _Phone = "0123123", _Address = "38 Do Anh Han", _Gender = true, _Birth = new DateTime(2015, 12, 25), _Username = "abc", _Password = "123", _VIP = false}
            });
            context._Orders.AddRange(new Order[]
            {
                new Order{_IDOrder = "1", _IDCustomer = "1", _TimeOrder = new DateTime(2015, 12, 25), _Code = ""}
            });
        }
    }
}
