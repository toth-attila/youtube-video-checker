using System;
using System.Collections.ObjectModel;
using YoutubeVideoChecker.Helper;
using YoutubeVideoChecker.Model;

namespace YoutubeVideoChecker.ViewModel
{
    public class CountriesViewModel : ObservableObject
    {
        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = new ObservableCollection<Country>();
                }
                return countries;
            }
            set
            {
                if (value != countries)
                {
                    countries = value;
                    RaisePropertyChangedEvent("Countries");
                } 
            }
        }

        private Country selectedCountry;
        public Country SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                if (value != selectedCountry)
                {
                    selectedCountry = value;
                    RaisePropertyChangedEvent("SelectedCountry");
                    WriteSelectedCountryIntoSetting();
                }
            }
        }

        public CountriesViewModel()
        {
            this.countries = new ObservableCollection<Country>();
            InitializeCountries();
            
        }

        private void WriteSelectedCountryIntoSetting()
        {
            //TODO: Implement it!
        }

        private void InitializeCountries()
        {
            if (this.countries == null)
            {
                this.countries = new ObservableCollection<Country>();
            }
            this.Countries.Add(new Country("Afghanistan", "AF", "AFG"));
            this.Countries.Add(new Country("Albania", "AL", "ALB"));
            this.Countries.Add(new Country("Algeria", "DZ", "DZA"));
            this.Countries.Add(new Country("American Samoa", "AS", "ASM"));
            this.Countries.Add(new Country("Andorra", "AD", "AND"));
            this.Countries.Add(new Country("Angola", "AO", "AGO"));
            this.Countries.Add(new Country("Anguilla", "AI", "AIA"));
            this.Countries.Add(new Country("Antarctica", "AQ", "ATA"));
            this.Countries.Add(new Country("Antigua and Barbuda", "AG", "ATG"));
            this.Countries.Add(new Country("Argentina", "AR", "ARG"));
            this.Countries.Add(new Country("Armenia", "AM", "ARM"));
            this.Countries.Add(new Country("Aruba", "AW", "ABW"));
            this.Countries.Add(new Country("Australia", "AU", "AUS"));
            this.Countries.Add(new Country("Austria", "AT", "AUT"));
            this.Countries.Add(new Country("Azerbaijan", "AZ", "AZE"));
            this.Countries.Add(new Country("Bahamas", "BS", "BHS"));
            this.Countries.Add(new Country("Bahrain", "BH", "BHR"));
            this.Countries.Add(new Country("Bangladesh", "BD", "BGD"));
            this.Countries.Add(new Country("Barbados", "BB", "BRB"));
            this.Countries.Add(new Country("Belarus", "BY", "BLR"));
            this.Countries.Add(new Country("Belgium", "BE", "BEL"));
            this.Countries.Add(new Country("Belize", "BZ", "BLZ"));
            this.Countries.Add(new Country("Benin", "BJ", "BEN"));
            this.Countries.Add(new Country("Bermuda", "BM", "BMU"));
            this.Countries.Add(new Country("Bhutan", "BT", "BTN"));
            this.Countries.Add(new Country("Bolivia", "BO", "BOL"));
            this.Countries.Add(new Country("Bosnia and Herzegovina", "BA", "BIH"));
            this.Countries.Add(new Country("Botswana", "BW", "BWA"));
            this.Countries.Add(new Country("Brazil", "BR", "BRA"));
            this.Countries.Add(new Country("British Indian Ocean Territory", "IO", "IOT"));
            this.Countries.Add(new Country("British Virgin Islands", "VG", "VGB"));
            this.Countries.Add(new Country("Brunei", "BN", "BRN"));
            this.Countries.Add(new Country("Bulgaria", "BG", "BGR"));
            this.Countries.Add(new Country("Burkina Faso", "BF", "BFA"));
            this.Countries.Add(new Country("Burma (Myanmar)", "MM", "MMR"));
            this.Countries.Add(new Country("Burundi", "BI", "BDI"));
            this.Countries.Add(new Country("Cambodia", "KH", "KHM"));
            this.Countries.Add(new Country("Cameroon", "CM", "CMR"));
            this.Countries.Add(new Country("Canada", "CA", "CAN"));
            this.Countries.Add(new Country("Cape Verde", "CV", "CPV"));
            this.Countries.Add(new Country("Cayman Islands", "KY", "CYM"));
            this.Countries.Add(new Country("Central African Republic", "CF", "CAF"));
            this.Countries.Add(new Country("Chad", "TD", "TCD"));
            this.Countries.Add(new Country("Chile", "CL", "CHL"));
            this.Countries.Add(new Country("China", "CN", "CHN"));
            this.Countries.Add(new Country("Christmas Island", "CX", "CXR"));
            this.Countries.Add(new Country("Cocos (Keeling) Islands", "CC", "CCK"));
            this.Countries.Add(new Country("Colombia", "CO", "COL"));
            this.Countries.Add(new Country("Comoros", "KM", "COM"));
            this.Countries.Add(new Country("Cook Islands", "CK", "COK"));
            this.Countries.Add(new Country("Costa Rica", "CR", "CRC"));
            this.Countries.Add(new Country("Croatia", "HR", "HRV"));
            this.Countries.Add(new Country("Cuba", "CU", "CUB"));
            this.Countries.Add(new Country("Cyprus", "CY", "CYP"));
            this.Countries.Add(new Country("Czech Republic", "CZ", "CZE"));
            this.Countries.Add(new Country("Democratic Republic of the Congo", "CD", "COD"));
            this.Countries.Add(new Country("Denmark", "DK", "DNK"));
            this.Countries.Add(new Country("Djibouti", "DJ", "DJI"));
            this.Countries.Add(new Country("Dominica", "DM", "DMA"));
            this.Countries.Add(new Country("Dominican Republic", "DO", "DOM"));
            this.Countries.Add(new Country("Ecuador", "EC", "ECU"));
            this.Countries.Add(new Country("Egypt", "EG", "EGY"));
            this.Countries.Add(new Country("El Salvador", "SV", "SLV"));
            this.Countries.Add(new Country("Equatorial Guinea", "GQ", "GNQ"));
            this.Countries.Add(new Country("Eritrea", "ER", "ERI"));
            this.Countries.Add(new Country("Estonia", "EE", "EST"));
            this.Countries.Add(new Country("Ethiopia", "ET", "ETH"));
            this.Countries.Add(new Country("Falkland Islands", "FK", "FLK"));
            this.Countries.Add(new Country("Faroe Islands", "FO", "FRO"));
            this.Countries.Add(new Country("Fiji", "FJ", "FJI"));
            this.Countries.Add(new Country("Finland", "FI", "FIN"));
            this.Countries.Add(new Country("France", "FR", "FRA"));
            this.Countries.Add(new Country("French Polynesia", "PF", "PYF"));
            this.Countries.Add(new Country("Gabon", "GA", "GAB"));
            this.Countries.Add(new Country("Gambia", "GM", "GMB"));
            this.Countries.Add(new Country("Georgia", "GE", "GEO"));
            this.Countries.Add(new Country("Germany", "DE", "DEU"));
            this.Countries.Add(new Country("Ghana", "GH", "GHA"));
            this.Countries.Add(new Country("Gibraltar", "GI", "GIB"));
            this.Countries.Add(new Country("Greece", "GR", "GRC"));
            this.Countries.Add(new Country("Greenland", "GL", "GRL"));
            this.Countries.Add(new Country("Grenada", "GD", "GRD"));
            this.Countries.Add(new Country("Guam", "GU", "GUM"));
            this.Countries.Add(new Country("Guatemala", "GT", "GTM"));
            this.Countries.Add(new Country("Guinea", "GN", "GIN"));
            this.Countries.Add(new Country("Guinea-Bissau", "GW", "GNB"));
            this.Countries.Add(new Country("Guyana", "GY", "GUY"));
            this.Countries.Add(new Country("Haiti", "HT", "HTI"));
            this.Countries.Add(new Country("Holy See (Vatican City)", "VA", "VAT"));
            this.Countries.Add(new Country("Honduras", "HN", "HND"));
            this.Countries.Add(new Country("Hong Kong", "HK", "HKG"));
            this.Countries.Add(new Country("Hungary", "HU", "HUN"));
            this.Countries.Add(new Country("Iceland", "IS", "/IS"));
            this.Countries.Add(new Country("India", "IN", "IND"));
            this.Countries.Add(new Country("Indonesia", "ID", "IDN"));
            this.Countries.Add(new Country("Iran", "IR", "IRN"));
            this.Countries.Add(new Country("Iraq", "IQ", "IRQ"));
            this.Countries.Add(new Country("Ireland", "IE", "IRL"));
            this.Countries.Add(new Country("Isle of Man", "IM", "IMN"));
            this.Countries.Add(new Country("Israel", "IL", "ISR"));
            this.Countries.Add(new Country("Italy", "IT", "ITA"));
            this.Countries.Add(new Country("Ivory Coast", "CI", "CIV"));
            this.Countries.Add(new Country("Jamaica", "JM", "JAM"));
            this.Countries.Add(new Country("Japan", "JP", "JPN"));
            this.Countries.Add(new Country("Jersey", "JE", "JEY"));
            this.Countries.Add(new Country("Jordan", "JO", "JOR"));
            this.Countries.Add(new Country("Kazakhstan", "KZ", "KAZ"));
            this.Countries.Add(new Country("Kenya", "KE", "KEN"));
            this.Countries.Add(new Country("Kiribati", "KI", "KIR"));
            this.Countries.Add(new Country("Kuwait", "KW", "KWT"));
            this.Countries.Add(new Country("Kyrgyzstan", "KG", "KGZ"));
            this.Countries.Add(new Country("Laos", "LA", "LAO"));
            this.Countries.Add(new Country("Latvia", "LV", "LVA"));
            this.Countries.Add(new Country("Lebanon", "LB", "LBN"));
            this.Countries.Add(new Country("Lesotho", "LS", "LSO"));
            this.Countries.Add(new Country("Liberia", "LR", "LBR"));
            this.Countries.Add(new Country("Libya", "LY", "LBY"));
            this.Countries.Add(new Country("Liechtenstein", "LI", "LIE"));
            this.Countries.Add(new Country("Lithuania", "LT", "LTU"));
            this.Countries.Add(new Country("Luxembourg", "LU", "LUX"));
            this.Countries.Add(new Country("Macau", "MO", "MAC"));
            this.Countries.Add(new Country("Macedonia", "MK", "MKD"));
            this.Countries.Add(new Country("Madagascar", "MG", "MDG"));
            this.Countries.Add(new Country("Malawi", "MW", "MWI"));
            this.Countries.Add(new Country("Malaysia", "MY", "MYS"));
            this.Countries.Add(new Country("Maldives", "MV", "MDV"));
            this.Countries.Add(new Country("Mali", "ML", "MLI"));
            this.Countries.Add(new Country("Malta", "MT", "MLT"));
            this.Countries.Add(new Country("Marshall Islands", "MH", "MHL"));
            this.Countries.Add(new Country("Mauritania", "MR", "MRT"));
            this.Countries.Add(new Country("Mauritius", "MU", "MUS"));
            this.Countries.Add(new Country("Mayotte", "YT", "MYT"));
            this.Countries.Add(new Country("Mexico", "MX", "MEX"));
            this.Countries.Add(new Country("Micronesia", "FM", "FSM"));
            this.Countries.Add(new Country("Moldova", "MD", "MDA"));
            this.Countries.Add(new Country("Monaco", "MC", "MCO"));
            this.Countries.Add(new Country("Mongolia", "MN", "MNG"));
            this.Countries.Add(new Country("Montenegro", "ME", "MNE"));
            this.Countries.Add(new Country("Montserrat", "MS", "MSR"));
            this.Countries.Add(new Country("Morocco", "MA", "MAR"));
            this.Countries.Add(new Country("Mozambique", "MZ", "MOZ"));
            this.Countries.Add(new Country("Namibia", "NA", "NAM"));
            this.Countries.Add(new Country("Nauru", "NR", "NRU"));
            this.Countries.Add(new Country("Nepal", "NP", "NPL"));
            this.Countries.Add(new Country("Netherlands", "NL", "NLD"));
            this.Countries.Add(new Country("Netherlands Antilles", "AN", "ANT"));
            this.Countries.Add(new Country("New Caledonia", "NC", "NCL"));
            this.Countries.Add(new Country("New Zealand", "NZ", "NZL"));
            this.Countries.Add(new Country("Nicaragua", "NI", "NIC"));
            this.Countries.Add(new Country("Niger", "NE", "NER"));
            this.Countries.Add(new Country("Nigeria", "NG", "NGA"));
            this.Countries.Add(new Country("Niue", "NU", "NIU"));
            this.Countries.Add(new Country("Norfolk Island", "/N", "NFK"));
            this.Countries.Add(new Country("North Korea", "KP", "PRK"));
            this.Countries.Add(new Country("Northern Mariana Islands", "MP", "MNP"));
            this.Countries.Add(new Country("Norway", "NO", "NOR"));
            this.Countries.Add(new Country("Oman", "OM", "OMN"));
            this.Countries.Add(new Country("Pakistan", "PK", "PAK"));
            this.Countries.Add(new Country("Palau", "PW", "PLW"));
            this.Countries.Add(new Country("Panama", "PA", "PAN"));
            this.Countries.Add(new Country("Papua New Guinea", "PG", "PNG"));
            this.Countries.Add(new Country("Paraguay", "PY", "PRY"));
            this.Countries.Add(new Country("Peru", "PE", "PER"));
            this.Countries.Add(new Country("Philippines", "PH", "PHL"));
            this.Countries.Add(new Country("Pitcairn Islands", "PN", "PCN"));
            this.Countries.Add(new Country("Poland", "PL", "POL"));
            this.Countries.Add(new Country("Portugal", "PT", "PRT"));
            this.Countries.Add(new Country("Puerto Rico", "PR", "PRI"));
            this.Countries.Add(new Country("Qatar", "QA", "QAT"));
            this.Countries.Add(new Country("Republic of the Congo", "CG", "COG"));
            this.Countries.Add(new Country("Romania", "RO", "ROU"));
            this.Countries.Add(new Country("Russia", "RU", "RUS"));
            this.Countries.Add(new Country("Rwanda", "RW", "RWA"));
            this.Countries.Add(new Country("Saint Barthelemy", "BL", "BLM"));
            this.Countries.Add(new Country("Saint Helena", "SH", "SHN"));
            this.Countries.Add(new Country("Saint Kitts and Nevis", "KN", "KNA"));
            this.Countries.Add(new Country("Saint Lucia", "LC", "LCA"));
            this.Countries.Add(new Country("Saint Martin", "MF", "MAF"));
            this.Countries.Add(new Country("Saint Pierre and Miquelon", "PM", "SPM"));
            this.Countries.Add(new Country("Saint Vincent and the Grenadines", "VC", "VCT"));
            this.Countries.Add(new Country("Samoa", "WS", "WSM"));
            this.Countries.Add(new Country("San Marino", "SM", "SMR"));
            this.Countries.Add(new Country("Sao Tome and Principe", "ST", "STP"));
            this.Countries.Add(new Country("Saudi Arabia", "SA", "SAU"));
            this.Countries.Add(new Country("Senegal", "SN", "SEN"));
            this.Countries.Add(new Country("Serbia", "RS", "SRB"));
            this.Countries.Add(new Country("Seychelles", "SC", "SYC"));
            this.Countries.Add(new Country("Sierra Leone", "SL", "SLE"));
            this.Countries.Add(new Country("Singapore", "SG", "SGP"));
            this.Countries.Add(new Country("Slovakia", "SK", "SVK"));
            this.Countries.Add(new Country("Slovenia", "SI", "SVN"));
            this.Countries.Add(new Country("Solomon Islands", "SB", "SLB"));
            this.Countries.Add(new Country("Somalia", "SO", "SOM"));
            this.Countries.Add(new Country("South Africa", "ZA", "ZAF"));
            this.Countries.Add(new Country("South Korea", "KR", "KOR"));
            this.Countries.Add(new Country("Spain", "ES", "ESP"));
            this.Countries.Add(new Country("Sri Lanka", "LK", "LKA"));
            this.Countries.Add(new Country("Sudan", "SD", "SDN"));
            this.Countries.Add(new Country("Suriname", "SR", "SUR"));
            this.Countries.Add(new Country("Svalbard", "SJ", "SJM"));
            this.Countries.Add(new Country("Swaziland", "SZ", "SWZ"));
            this.Countries.Add(new Country("Sweden", "SE", "SWE"));
            this.Countries.Add(new Country("Switzerland", "CH", "CHE"));
            this.Countries.Add(new Country("Syria", "SY", "SYR"));
            this.Countries.Add(new Country("Taiwan", "TW", "TWN"));
            this.Countries.Add(new Country("Tajikistan", "TJ", "TJK"));
            this.Countries.Add(new Country("Tanzania", "TZ", "TZA"));
            this.Countries.Add(new Country("Thailand", "TH", "THA"));
            this.Countries.Add(new Country("Timor-Leste", "TL", "TLS"));
            this.Countries.Add(new Country("Togo", "TG", "TGO"));
            this.Countries.Add(new Country("Tokelau", "TK", "TKL"));
            this.Countries.Add(new Country("Tonga", "TO", "TON"));
            this.Countries.Add(new Country("Trinidad and Tobago", "TT", "TTO"));
            this.Countries.Add(new Country("Tunisia", "TN", "TUN"));
            this.Countries.Add(new Country("Turkey", "TR", "TUR"));
            this.Countries.Add(new Country("Turkmenistan", "TM", "TKM"));
            this.Countries.Add(new Country("Turks and Caicos Islands", "TC", "TCA"));
            this.Countries.Add(new Country("Tuvalu", "TV", "TUV"));
            this.Countries.Add(new Country("Uganda", "UG", "UGA"));
            this.Countries.Add(new Country("Ukraine", "UA", "UKR"));
            this.Countries.Add(new Country("United Arab Emirates", "AE", "ARE"));
            this.Countries.Add(new Country("United Kingdom", "GB", "GBR"));
            this.Countries.Add(new Country("United States", "US", "USA"));
            this.Countries.Add(new Country("Uruguay", "UY", "URY"));
            this.Countries.Add(new Country("US Virgin Islands", "VI", "VIR"));
            this.Countries.Add(new Country("Uzbekistan", "UZ", "UZB"));
            this.Countries.Add(new Country("Vanuatu", "VU", "VUT"));
            this.Countries.Add(new Country("Venezuela", "VE", "VEN"));
            this.Countries.Add(new Country("Vietnam", "VN", "VNM"));
            this.Countries.Add(new Country("Wallis and Futuna", "WF", "WLF"));
            this.Countries.Add(new Country("Western Sahara", "EH", "ESH"));
            this.Countries.Add(new Country("Yemen", "YE", "YEM"));
            this.Countries.Add(new Country("Zambia", "ZM", "ZMB"));
            this.Countries.Add(new Country("Zimbabwe", "ZW", "ZWE"));
        }

    }
}
