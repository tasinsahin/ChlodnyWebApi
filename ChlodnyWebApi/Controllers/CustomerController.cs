namespace ChlodnyWebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using ChlodnyWebApi.Models;

    using DataAccess;
    using DataAccess.Entities;

    public class CustomerController : ApiController
    {
        private readonly ChinookContext contexts1 = new ChinookContext();

        // Retrieve = GET
        public IQueryable<Customer> GetCustomer()
        {
            return this.contexts1.Customers;
            //.Where(c => c.Deleted == false);
        }

        public IQueryable<Customer> SearchCustomerFirstName(SearchValues value)
        {
            if (value.WhichSearch == "CustomerFirstName")
            {
                return value.SearchType == "startwith"
                           ? this.contexts1.Customers.Where(
                               c => c.FirstName.StartsWith(value.Term) && c.Deleted == false).Take(value.MaxRowsReturn)
                           : this.contexts1.Customers.Where(c => c.FirstName.Contains(value.Term) && c.Deleted == false)
                                 .Take(value.MaxRowsReturn);
            }

            return null;
        }

        public HttpResponseMessage<Customer> GetCustomer(int id)
        {
            using (var context = new ChinookContext())
            {
                var customer = (from i in context.Customers where i.CustomerId == id where i.Deleted == false select i).FirstOrDefault();
                
                if (customer == null)
                {
                    var notfoundMessage = new HttpResponseMessage<Customer>(HttpStatusCode.NotFound);
                    return notfoundMessage;
                }

                var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.OK);
                return newMessage;
            }
        }

        // Delete = DELETE
        public HttpResponseMessage<Customer> DeleteCustomer(int id)
        {
            HttpResponseMessage<Customer> response;
            using (var context = new ChinookContext())
            {
                var customerTest = context.Customers.Single(c => c.CustomerId == id && c.Deleted == false);

                if (customerTest != null)
                {
                    customerTest.Deleted = true;
                    context.SaveChanges();
                    response = new HttpResponseMessage<Customer>(HttpStatusCode.Accepted);
                }
                else
                {
                    response = new HttpResponseMessage<Customer>(HttpStatusCode.NotFound);
                }
            }

            return response;
        }

        // Create = Post
        public HttpResponseMessage<Customer> PostCustomer(Customer customer)
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
                    var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.Created);

                    newMessage.Headers.Location = new Uri(
                        Request.RequestUri, "/Customer/" + customer.CustomerId.ToString(CultureInfo.InvariantCulture));
                    return newMessage;
                }

                return this.PutCustomer(customer);
            }
        } 

        // Update = Put
        public HttpResponseMessage<Customer> PutCustomer(Customer customer)
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
                    return this.PostCustomer(customer);
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

                var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.Accepted);

                newMessage.Headers.Location = new Uri(
                    Request.RequestUri, "/Customer/" + customer.CustomerId.ToString(CultureInfo.InvariantCulture));
                return newMessage;
            }
        }
    }
}