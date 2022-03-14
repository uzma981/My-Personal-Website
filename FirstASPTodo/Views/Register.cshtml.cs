using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstASPTodo.Models;

namespace FirstASPTodo.Views
{
    public class RegisterModel : PageModel
    {
        public Register Model { get; set; }
        public void OnGet()
        {

        }
    }
}
