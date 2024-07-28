using Microsoft.AspNetCore.Mvc;
using RestSharp;


namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TMDBController : ControllerBase
    {

        [HttpGet("movies/{name}")]
        public async Task<IActionResult> GetMovies(string name)
        {
            var query = "https://api.themoviedb.org/3/search/movie?query=" + name + "&include_adult=false&language=en-US&page=1";
            var options = new RestClientOptions(query);
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI3NDEyYjZjY2Y1YWYyZDcwZjAxYjY4NTJiMDk2ZmJhOSIsIm5iZiI6MTcyMjIwMDYyOC4xOTE1ODYsInN1YiI6IjY2YTZiMDVjYWY5ZDMyZDMyYWFiODE1ZiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.6mTwEZ62-CsarLG-gt6n1mWtE-3a0X6t2tenk4Lsgos");
            var response = await client.GetAsync(request);


            return Ok(response);

        }
    }
}
