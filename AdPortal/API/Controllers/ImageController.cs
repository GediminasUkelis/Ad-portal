using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.CarService.Queries;
using BLL.Dto;
using BLL.ImageService.Commands;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly IUnitOfWork uow;
        public ImageController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpDelete("/api/Image/{postId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Unit> DeleteImagesAsync([FromRoute]Guid postId, [FromBody]List<ImageDto> images)
        {
            return await uow.Mediator.Send(new Delete.Command(postId, images));
        }

        [HttpPost("/api/Image/{postId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Unit> InsertImagesAsync([FromRoute] Guid postId, [FromForm] List<IFormFile> images)
        {
            return await uow.Mediator.Send(new Insert.Command(postId, images));
        }


    }
}
