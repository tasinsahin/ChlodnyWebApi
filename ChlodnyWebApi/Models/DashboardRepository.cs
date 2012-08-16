namespace ChlodnyWebApi.Models
{
    using System.Data;
    using System.Linq;
    using BingServices.BingMaps;
    using DataAccess;
    using DomainClasses.EntitiesChinook;

    using GeoLocation = BingServices.BingMaps.GeoLocation;

    public interface IDashboardRepository
    {
        IQueryable<Customer> GetAllCustomers { get; }

        IQueryable<Employee> GetAllEmployees { get; }

        void PopulateGeoLocation();

        void InsertOrUpdate(Customer customer);

      //  void InsertOrUpdate(Employee employee);

        void Save();
    }

    public class DashboardRepository : IDashboardRepository
    {
        private readonly ChinookContext dashboardRepoContext = new ChinookContext();

        private readonly GeoLocation bingServices = new GeoLocation();

        public IQueryable<Customer> GetAllCustomers
        { 
            get
            {
                return this.dashboardRepoContext.Customers;
            } 
        }

        public IQueryable<Employee> GetAllEmployees
        {
            get
            {
                return this.dashboardRepoContext.Employees;
            }
        }

        public void PopulateGeoLocation()
        {
            var customersWithoutGeoLoc = this.GetCustomersWithoutGeoLocation();

            if (customersWithoutGeoLoc.Any())
            {
                this.GetAndSaveGeoLocation(customersWithoutGeoLoc, "Customer");
            }

            var employeesWithoutGeoLoc = this.GetEmployeesWithoutGeoLocation();

            if (employeesWithoutGeoLoc.Any())
            {
                this.GetAndSaveGeoLocation(employeesWithoutGeoLoc, "Employee");
            }
        }

        private void GetAndSaveGeoLocation(dynamic personWithoutGeoLoc, string whichTable)
        {
            foreach (var person in personWithoutGeoLoc)
            {
                string address = person.Address + " " + person.City + " " + person.State + " " + person.PostalCode;

                var location = this.bingServices.GeocodeAddress(address);
                var test = location;
                // person.Latitude = location.Latitude;
                // person.Longitude = location[1];

            }
        }

        private IQueryable<Employee> GetEmployeesWithoutGeoLocation()
        {
            return from e in this.dashboardRepoContext.Employees where e.GeoLoc == null select e;
        }

        private IQueryable<Customer> GetCustomersWithoutGeoLocation()
        {
            return from c in this.dashboardRepoContext.Customers where c.GeoLoc == null select c;
        }

        public void InsertOrUpdate(Customer customer)
        {
            if (customer.CustomerId == default(int))
            {
                this.dashboardRepoContext.Customers.Add(customer);
            }
            else
            {
                this.dashboardRepoContext.Entry(customer).State = EntityState.Modified;
            }
        }

        //public void InsertOrUpdate(Employee employee)
        //{
        //    if (employee.EmployeeId == default(int))
        //    {
        //        this.dashboardRepoContext.Customers.Add(employee);
        //    }
        //    else
        //    {
        //        this.dashboardRepoContext.Entry(employee).State = EntityState.Modified;
        //    }
        //}

        public void Save()
        {
            this.dashboardRepoContext.SaveChanges();
        }
    }
}