using System;
using System.Collections.Generic;
using System.Text;

namespace TibiaApp.Model
{
    public class Characters
    {
        public Data data { get; set; }
        public IList<object> achievements { get; set; }
        public IList<object> deaths { get; set; }
        public AccountInformation account_information { get; set; }
        public IList<OtherCharacter> other_characters { get; set; }
    }
}
