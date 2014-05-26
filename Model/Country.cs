using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideoChecker.Model
{
    public class Country
    {
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public string Flag { get; set; }

        public Country(string name)
        {
            this.Name = name;
        }

        public Country(string name, string iso2, string iso3)
        {
            this.Name = name;
            this.ISO2 = iso2;
            this.ISO3 = iso3;
        }

        public Country(string name, string iso2, string iso3, string flag)
        {
            this.Name = name;
            this.ISO2 = iso2;
            this.ISO3 = iso3;
            this.Flag = flag;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}/{2})",this.Name,this.ISO2,this.ISO3);
        }
    }
}
