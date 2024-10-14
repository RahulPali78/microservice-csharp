using CustomerService.Models;

namespace CustomerService.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(int Id);
        Task AddCustomerAsync(Customer customer);
        Task<bool> SaveChangesAsync();
    }
}