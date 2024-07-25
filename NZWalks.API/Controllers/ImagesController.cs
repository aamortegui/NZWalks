using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository) 
        {
            this.imageRepository = imageRepository;
        }

        //Post: /api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImagesUploadRequestDto imagesUploadRequest)
        {
            ValidateFileUpload(imagesUploadRequest);
            if (ModelState.IsValid)
            {
                //Convert Dto to Domain model
                var imageDomainModel = new Image
                {
                    File = imagesUploadRequest.File,
                    FileExtension = Path.GetExtension(imagesUploadRequest.File.FileName),
                    FileSizeInBytes = imagesUploadRequest.File.Length,
                    FileName = imagesUploadRequest.FileName,
                    FileDescription = imagesUploadRequest.FileDescription
                };
                
                //User repository to upload image
                await imageRepository.Upload(imageDomainModel);

                return Ok (imageDomainModel);
            }

            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImagesUploadRequestDto imagesUploadRequest)
        {
            var allowExtensions = new string[] { ".jpg",".jpeg",".png"};
            if (!allowExtensions.Contains(Path.GetExtension(imagesUploadRequest.File.FileName)))
            {
                ModelState.AddModelError("file","Unsupported file extension");
            }

            if(imagesUploadRequest.File.Length > 10485760)
            {
                ModelState.AddModelError("File", "File size more than 10MB, please upload a smaller size file");
            }
        }
    }
}
