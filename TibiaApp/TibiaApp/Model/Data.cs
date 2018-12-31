using System;
using System.Collections.Generic;
using System.Text;

namespace TibiaApp.Model
{
    public class Data
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string vocation { get; set; }
        public string level { get; set; }
        public string achievement_points { get; set; }
        public string world { get; set; }
        public string residence { get; set; }
        public IList<LastLogin> last_login { get; set; }
        public string account_status { get; set; }
        public string status { get; set; }
    }
}
