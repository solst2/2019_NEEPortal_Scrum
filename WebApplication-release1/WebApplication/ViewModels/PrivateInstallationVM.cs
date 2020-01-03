using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication.ViewModels
{
    public class PrivateInstallationVM
    {
        [DisplayName("Strasse")]
        public String strasse { get; set; }
        [DisplayName("Nummer")]
        public String no { get; set; }
        [DisplayName("Postleitzahl")]
        public String postleitzahl { get; set; }
        [DisplayName("Stadet")]
        public String stadt { get; set; }
    }
}