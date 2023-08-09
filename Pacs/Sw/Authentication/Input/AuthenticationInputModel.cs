using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Authentication.Input
{
    public class AuthenticationInputModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

}
