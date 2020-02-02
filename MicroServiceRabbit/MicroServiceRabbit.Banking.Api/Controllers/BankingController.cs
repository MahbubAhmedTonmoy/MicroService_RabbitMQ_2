using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceRabbit.Banking.Application.Interfaces;
using MicroServiceRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _service;
        public BankingController(IAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            var result = _service.GetAccounts();
            return Ok(result);
        }
    }
}