using Application_Devenir_Dev_2.Services.Interfaces;
using Domain_Devenir_Dev_2.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Devenir_Dev_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
                                // Injection de la couche Application pour accéder au données
    public class MovieController(IMovieService _service) : ControllerBase
    {
        // Le controlleur Renvoie les informations et ou message d'erreur
        #region Get All Movies
        /// <summary>
        /// Return a list of movies
        /// </summary>
        /// <returns> List of string </returns>
        // Le verbe permet à l'application de savoir ou rediriger la requete
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            List<Movie> movies = await _service.GetAllAsync();

            if(movies.Count < 1)
            {
                return NotFound("Aucun films à afficher");
            }

            return Ok(movies);
        }
        #endregion

        #region Get Movie By Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Movie movie = new Movie();

            return Ok(movie);
        }

        #endregion

        #region Create Movie
        [HttpPost]
        public async Task<IActionResult> CreateMovie(Movie newMovie)
        {
            string response = "Movie à été crée" + newMovie.Title;

            return Ok(response);
        }
        #endregion

        #region Update Movie
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id , Movie updatedMovie)
        {
            string response = "Movie à été modifié" + id + " " + updatedMovie.Title;

            return Ok();
        }
        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            string response = $" Le film avec l'id {id} à bien été supprimé";

            return Ok(id);
        }
        #endregion
    }
}
