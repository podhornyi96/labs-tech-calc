using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabsTechTestTask.BAL.Services;
using LabsTechTestTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabsTechTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet]
        public async Task<ActionResult<CalculatorResponse>> Calculate([FromQuery] CalculationRequest request)
        {
            return Ok(_calculatorService.Calculate(request));
        }

    }
}