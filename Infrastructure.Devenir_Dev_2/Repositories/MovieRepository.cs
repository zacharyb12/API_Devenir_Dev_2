using Domain_Devenir_Dev_2.Entities;
using Domain_Devenir_Dev_2.Interfaces;
using Infrastructure.Devenir_Dev_2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Devenir_Dev_2.Repositories
{
    // Entity Framework Core
    // Entity Framework Core SQL Server
    // Entity Framework Core Tools
                                   // Injection du Context pour accéder à la base de données
    public class MovieRepository(MovieContext _context) : IMovieRepository
    {

        // Utilisation du contexte pour récupérer les films de la base de données
        public async Task<List<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

    }
}
