﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TarefasApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de tarefas
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para atualização de tarefas
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para inativação de tarefas
        /// </summary>
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consulta de tarefas
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

    }
}
