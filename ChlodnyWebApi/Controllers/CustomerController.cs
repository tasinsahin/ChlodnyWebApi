namespace ChlodnyWebApi.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using DataAccess;
    using DataAccess.Entities;

    public class CustomerController : ApiController
    {
        private readonly ChinookContext contexts1 = new ChinookContext();

        public IQueryable<Customer> GetCustomer()
        {
            return this.contexts1.Customers.Where(c => c.Deleted == false);
        }

        public IQueryable<Customer> GetCustomer(int id)
        {
            return this.contexts1.Customers.Where(c => c.CustomerId == id && c.Deleted == false).AsQueryable();
        }

        public string DeleteCustomer(int id)
        {
            string response;
            using (var context = new ChinookContext())
            {
                var customerTest = context.Customers.Single(c => c.CustomerId == id);
                customerTest.Deleted = true;
                context.SaveChanges();
                response = new HttpResponseMessage<Customer>(customerTest, HttpStatusCode.Accepted).ToString();
            }

            return response;
        }

        public Customer PostCustomer(Customer customer)
        {
            using (var context = new ChinookContext())
            {
                Customer customerTest = null;

                if (customer.CustomerId != 0)
                {
                    customerTest = context.Customers.Single(c => c.CustomerId == customer.CustomerId);
                }

                if (customerTest == null)
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    return customer;
                }

                // todo this has to have an easier way.  Customer.Attach throws an error
                customerTest.FirstName = customer.FirstName;
                customerTest.LastName = customer.LastName;
                customerTest.Address = customer.Address;
                customerTest.City = customer.City;
                customerTest.PostalCode = customer.PostalCode;
                customerTest.State = customer.State;
                customerTest.Country = customer.Country;
                customerTest.Fax = customer.Fax;
                customerTest.Email = customer.Email;
                customerTest.Company = customer.Company;

                context.SaveChanges();
                 return customer;
            }
        }
    }
}
