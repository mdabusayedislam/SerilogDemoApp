using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("You requested the index page");
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("Exc");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {value}", i);
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exception in the index page");
            }
        }
    }
}
