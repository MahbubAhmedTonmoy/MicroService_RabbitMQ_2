using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceRabbit.Transfer.Application.Interfaces;
using MicroServiceRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {

        private readonly ITransferService _service;

        public TransferController(ITransferService service)
        {
            _service = service;
        }


        // GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_service.GetTansferLogs());
        }

        
    }
}
