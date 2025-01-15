using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_3_RPSLSProNEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_C_3_RPSLSProNEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeepGameController : ControllerBase
    {
        
        private readonly DeepGameService _deepGameService;
        public DeepGameController(DeepGameService deepGameService)
        {
            _deepGameService = deepGameService;
        }

        [HttpGet]
        [Route("ThrowHand")]
        public string CPUChoice()
        {
            return _deepGameService.CPUChoice();
        }

    }
}