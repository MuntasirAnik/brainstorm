using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brainstorm.Repository.Repository;
using Brainstorm.Model.Model;

namespace Brainstrom.BLL.BLL
{
    class CustomerManager
    {

        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
