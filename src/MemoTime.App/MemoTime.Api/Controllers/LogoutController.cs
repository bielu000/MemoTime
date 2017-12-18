﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MemoTime.Api.Controllers
{
    public class LogoutController : ApiBaseController
    {
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok(new {});
        }
    }
}