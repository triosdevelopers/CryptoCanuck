using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CryptoCanuck.Pages
{
    public class LearnModel : PageModel
    {
        private readonly ILogger<LearnModel> _logger;

        public LearnModel(ILogger<LearnModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
