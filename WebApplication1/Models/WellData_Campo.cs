using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class WellData_Campo
    {
        public int Id { get; set; }
        public string Campo { get; set; }
        public string Mensaje_Error { get; set; }
        public bool Error { get; set; }
    }
}