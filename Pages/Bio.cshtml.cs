using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CryptoCanuck.Pages
{
    public class BioModel : PageModel
    {
        private readonly ILogger<BioModel> _logger;

        public BioModel(ILogger<BioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
