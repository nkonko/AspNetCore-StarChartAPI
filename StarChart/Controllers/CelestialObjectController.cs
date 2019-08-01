using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
