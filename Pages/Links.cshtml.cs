using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CryptoCanuck.Pages
{
    public class LinksModel : PageModel
    {
        private readonly ILogger<LinksModel> _logger;

        public LinksModel(ILogger<LinksModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
