using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages
{
    public class AccessDeniedModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Access Denied";
        }
    }
}
