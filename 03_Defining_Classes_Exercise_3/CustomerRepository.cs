using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_3
{
    public class CustomerRepository //repository class not concerned with UI; only business logic
    {
        private List<Customer> _customerRepository;

        public void AddCustomerToList(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public string EmailCustomer(Customer customer)
        {
            var message = "";

            if (customer.YearsWithKomodo > 1 && customer.YearsWithKomodo < 5)
                message = "Thanks for your support.";
            else if (customer.YearsWithKomodo >= 5)
                message = "You're a beast.";

            return message;
        }
    }
}
