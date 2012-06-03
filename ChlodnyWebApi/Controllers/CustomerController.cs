namespace ChlodnyWebApi.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Models;

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

        //public HttpResponseMessage<Customer> GetCustomer(int id)
        // Changed for Web Api RC
        // Get single customer record by ID
        public HttpResponseMessage GetCustomer(int id)
        {
            using (var context = new ChinookContext())
            {
                var request = (from i in context.Customers where i.CustomerId == id where i.Deleted == false select i).FirstOrDefault();

                if (request == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                    //var notfoundMessage = new HttpResponseMessage<Customer>(HttpStatusCode.NotFound);
                    //return notfoundMessage;
                }

                return Request.CreateResponse(HttpStatusCode.OK, request);

                //var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.OK);
                //return newMessage;
            }
           // return Request;
        }

        // public HttpResponseMessage<Customer> DeleteCustomer(int id)
        // Changed for Web Api RC
        // Delete = DELETE
        public HttpResponseMessage DeleteCustomer(int id)
        {
           // HttpResponseMessage<Customer> response;
            using (var context = new ChinookContext())
            {
                var request = context.Customers.Single(c => c.CustomerId == id && c.Deleted == false);

                if (request != null)
                {
                    request.Deleted = true;
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Accepted, request);
                    //response = new HttpResponseMessage<Customer>(HttpStatusCode.Accepted);
                }
                return Request.CreateResponse(HttpStatusCode.NotFound);
                // response = new HttpResponseMessage<Customer>(HttpStatusCode.NotFound);
            }

           // return Request;
        }

        // public HttpResponseMessage<Customer> PostCustomer(Customer customer)
        // Changed for Web Api RC
        // Create = Post
        public HttpResponseMessage PostCustomer(Customer customer)
        {
            using (var context = new ChinookContext())
            {
                Customer request = null;

                if (customer.CustomerId != 0)
                {
                    request = context.Customers.Single(c => c.CustomerId == customer.CustomerId);
                }

                if (request == null)
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    // var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.Created);

                    var response = Request.CreateResponse(HttpStatusCode.Created, customer);
                    response.Headers.Location = new Uri(Request.RequestUri, string.Format("Customer/{0}", customer.CustomerId));
                    return response;
                    
                    //newMessage.Headers.Location = new Uri(
                    //    Request.RequestUri, "/Customer/" + customer.CustomerId.ToString(CultureInfo.InvariantCulture));
                    //return newMessage;
                }

                return this.PutCustomer(customer);
            }
        }

        // public HttpResponseMessage<Customer> PutCustomer(Customer customer)
        // Changed for Web Api RC
        // Update = Put
        public HttpResponseMessage PutCustomer(Customer customer)
        {
            using (var context = new ChinookContext())
            {
                Customer request = null;

                if (customer.CustomerId != 0)
                {
                    request = context.Customers.Single(c => c.CustomerId == customer.CustomerId);
                }

                if (request == null)
                {
                    return this.PostCustomer(customer);
                }

                // todo this has to have an easier way.  Customer.Attach throws an error
                request.FirstName = customer.FirstName;
                request.LastName = customer.LastName;
                request.Address = customer.Address;
                request.City = customer.City;
                request.PostalCode = customer.PostalCode;
                request.State = customer.State;
                request.Country = customer.Country;
                request.Fax = customer.Fax;
                request.Email = customer.Email;
                request.Company = customer.Company;

                context.SaveChanges();

                var response = Request.CreateResponse(HttpStatusCode.Accepted, customer);
                response.Headers.Location = new Uri(Request.RequestUri, string.Format("Customer/{0}", customer.CustomerId));
                return response;

                //var newMessage = new HttpResponseMessage<Customer>(customer, HttpStatusCode.Accepted);

                //newMessage.Headers.Location = new Uri(
                //    Request.RequestUri, "/Customer/" + customer.CustomerId.ToString(CultureInfo.InvariantCulture));
                //return newMessage;
            }
        }
    }
}