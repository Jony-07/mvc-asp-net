using ticketEccommerce.Data.Base;
using ticketEccommerce.Data.ViewModels;
using ticketEccommerce.Models;

namespace ticketEccommerce.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }
}
