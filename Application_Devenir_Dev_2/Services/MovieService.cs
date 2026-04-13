using Application_Devenir_Dev_2.Services.Interfaces;
using Domain_Devenir_Dev_2.Entities;
using Domain_Devenir_Dev_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Devenir_Dev_2.Services
{
                                // Injection de la couche Domain pour accéder au données
    public class MovieService(IMovieRepository _repository) : IMovieService
    {

        // On demande l'information à la coucher Domain 
        public async Task<List<Movie>> GetAllAsync()
        {
            return await _repository.GetMovies();
        }

        public Task<Movie> CreateMovieAsync(Movie newMovie)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Movie?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateMovie(int id, Movie updatedMovie)
        {
            throw new NotImplementedException();
        }
    }
}
