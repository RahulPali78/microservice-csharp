using CustomerService.Data;
using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;
        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }
        async Task ICustomerRepository.AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }

        async Task<IEnumerable<Customer>> ICustomerRepository.GetAllCustomerAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        async Task<Customer> ICustomerRepository.GetCustomerByIdAsync(int Id) => await _context.Customers.FindAsync(Id);

        async Task<bool> ICustomerRepository.SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}