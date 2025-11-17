using Microsoft.AspNetCore.Mvc;
using PetHome_MVC_Front.Models;

namespace PetHome_MVC_Front.Controllers.Front_Desk
{
    public class OwnerPetsController : Controller
    {
        private readonly HttpClient _httpClient;

        public OwnerPetsController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5001/");
        }
        // GET: OwnerPetsController
        public async Task<IActionResult> Index()
        {
            return View();
        }
        
        private Guid GetCurrentOwnerId()
        {
            Guid ownerId = Guid.Parse("D2D7D909-1003-4DA2-A26F-1DE697FB331A");

            return ownerId;
            // Example: If stored in claims:
            var value = User.Claims.FirstOrDefault(c => c.Type == "OwnerId")?.Value;

            if (Guid.TryParse(value, out var id))
                return id;

            throw new Exception("OwnerId is missing from user identity.");
        }

    }
}
