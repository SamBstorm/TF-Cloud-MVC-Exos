using Microsoft.AspNetCore.Mvc;

namespace ASP_Exo_01.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return Content("Bienvenue sur le contrôleur Math");
        }

        [Route("/Math/Table/{nb}")]
        public IActionResult Table(int nb)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add($"{i} x {nb} = {i*nb}");
            }
            return Ok(list);
        }

        [Route("/Math/Addition/{nb1}/{nb2}")]
        [Route("/Math/{nb1}/plus/{nb2}")]
        public IActionResult Addition(int nb1, int nb2) {
            return Content($"{nb1} + {nb2} = {nb1 + nb2}");
        }

        public IActionResult Compteur(int id = 100)
        {
            List<int> result = new List<int>();
            for (int i = 0; i <= id; i++)
            {
                result.Add(i);
            }
            return Ok(result);
        }
    }
}
