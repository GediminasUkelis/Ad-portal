using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.UsersService.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        public UserController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        
        [HttpPost("/api/Register")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> RegisterUserAsync([FromBody] RegisterDto obj)
        {
            return await uow.Mediator.Send(new Register.Command(obj));
        }
        [HttpPost("/api/Login")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<string> LoginUserAsync([FromBody] LoginDataDto obj)
        {
            return await uow.Mediator.Send(new Login.Command(obj));
          
        }
    }
}
