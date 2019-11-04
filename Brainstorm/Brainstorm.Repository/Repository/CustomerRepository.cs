using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brainstorm.DatabaseContext.DatabaseContext;
using Brainstorm.Model.Model;

namespace Brainstorm.Repository.Repository
{
   public class CustomerRepository
    {
        BrainstormDbContext dbContext = new BrainstormDbContext();

        public bool Add(Customer customer)
        {
            dbContext.Customers.Add(customer);

            return dbContext.SaveChanges() > 0;
        }


        public bool Delete(int id)
        {
            Customer aCustomer = dbContext.Customers.FirstOrDefault(c => c.ID == id);
            dbContext.Customers.Remove(aCustomer);
            return dbContext.SaveChanges() > 0;


        }

        public bool Update(Customer customer)
        {
            Customer aCustomer = dbContext.Customers.FirstOrDefault(c => c.ID == customer.ID);
            if (aCustomer != null)
            {
               //
            }
            return dbContext.SaveChanges() > 0;
        }




    }
}
