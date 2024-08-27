using Microsoft.AspNetCore.Mvc;

namespace ImageWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly ILogger<UploadController> _logger;

        public UploadController(ILogger<UploadController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostImage")]
        [Route("image")]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Upload = "Failure" } );
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { Upload = "Success", FilePath = $"/Images/{file.FileName}" });
        }

        [HttpGet]
        [Route("api/images")]
        public IActionResult GetImages()
        {
            var imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images");
            var imageFiles = Directory.GetFiles(imagesDirectory)
                                      .Select(f => new { FilePath = $"/Images/{Path.GetFileName(f)}" })
                                      .ToList();

            return Ok(imageFiles);
        }
    }
}
