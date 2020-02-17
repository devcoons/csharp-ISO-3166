﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Common.Lists
{
    public class Geolocation : INotifyPropertyChanged
    {
        private string continent = "--";
        private string country = "---";
        private string subdivision="---";

        public string Continent
        {
            get { return continent; }
            set
            {
                if (value == continent)
                    return;
                continent = value;
                Country = "---";
                OnPropertyChanged("Continent");
                OnPropertyChanged("Countries");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (value == country)
                    return;
                country = value;
                Subdivision = "---";
                OnPropertyChanged("Country");
                OnPropertyChanged("Subdivisions");
            }
        }
        public string Subdivision
        {
            get { return subdivision; }
            set
            {
                if (value == subdivision)
                    return;
                subdivision = value;
                OnPropertyChanged("Subdivision");
            }
        }

        public List<KeyValuePair<string, string>> Continents
        {
            get { return ISO3166Base.Continents; }
        }
        public List<KeyValuePair<string, string>> Countries
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(Continent))
                        return new List<KeyValuePair<string, string>>();

                    var x = ISO3166Base.continentsCountries.FindAll(o => o.Key == Continent).ToDictionary(t => t.Value, t => t.Key).Keys;
                    var k = ISO3166Base.Countries.FindAll(t => x.Contains(t.Key));
                    return k;
                }
                catch (Exception)
                {
                    return new List<KeyValuePair<string, string>>();
                }
            }
        }
        public List<KeyValuePair<string, string>> Subdivisions
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(Country))
                        return new List<KeyValuePair<string, string>>();

                    switch (Country)
                    {
                        case "ZWE":
                            return ISO3166Base.provincesZWE;
                        case "ZMB":
                            return ISO3166Base.provincesZMB;
                        case "YEM":
                            return ISO3166Base.provincesYEM;
                        case "VNM":
                            return ISO3166Base.provincesVNM;
                        case "VEN":
                            return ISO3166Base.provincesVEN;
                        case "VUT":
                            return ISO3166Base.provincesVUT;
                        case "UZB":
                            return ISO3166Base.provincesUZB;
                        case "URY":
                            return ISO3166Base.provincesURY;
                        case "UMI":
                            return ISO3166Base.provincesUMI;
                        case "USA":
                            return ISO3166Base.provincesUSA;
                        case "GBR":
                            return ISO3166Base.provincesGBR;
                        case "ARE":
                            return ISO3166Base.provincesARE;
                        case "UKR":
                            return ISO3166Base.provincesUKR;
                        case "UGA":
                            return ISO3166Base.provincesUGA;
                        case "TUV":
                            return ISO3166Base.provincesTUV;
                        case "TKM":
                            return ISO3166Base.provincesTKM;
                        case "TUR":
                            return ISO3166Base.provincesTUR;
                        case "TUN":
                            return ISO3166Base.provincesTUN;
                        case "TTO":
                            return ISO3166Base.provincesTTO;
                        case "THA":
                            return ISO3166Base.provincesTHA;
                        case "TZA":
                            return ISO3166Base.provincesTZA;
                        case "TJK":
                            return ISO3166Base.provincesTJK;
                        case "TWN":
                            return ISO3166Base.provincesTWN;
                        case "SYR":
                            return ISO3166Base.provincesSYR;
                        case "CHE":
                            return ISO3166Base.provincesCHE;
                        case "SWE":
                            return ISO3166Base.provincesSWE;
                        case "SUR":
                            return ISO3166Base.provincesSUR;
                        case "SDN":
                            return ISO3166Base.provincesSDN;
                        case "LKA":
                            return ISO3166Base.provincesLKA;
                        case "ESP":
                            return ISO3166Base.provincesESP;
                        case "SSD":
                            return ISO3166Base.provincesSSD;
                        case "ZAF":
                            return ISO3166Base.provincesZAF;
                        case "SOM":
                            return ISO3166Base.provincesSOM;
                        case "SLE":
                            return ISO3166Base.provincesSLE;
                        case "SYC":
                            return ISO3166Base.provincesSYC;
                        case "SLB":
                            return ISO3166Base.provincesSLB;
                        case "SVN":
                            return ISO3166Base.provincesSVN;
                        case "SVK":
                            return ISO3166Base.provincesSVK;
                        case "SGP":
                            return ISO3166Base.provincesSGP;
                        case "SRB":
                            return ISO3166Base.provincesSRB;
                        case "SEN":
                            return ISO3166Base.provincesSEN;
                        case "SAU":
                            return ISO3166Base.provincesSAU;
                        case "STP":
                            return ISO3166Base.provincesSTP;
                        case "SMR":
                            return ISO3166Base.provincesSMR;
                        case "WSM":
                            return ISO3166Base.provincesWSM;
                        case "VCT":
                            return ISO3166Base.provincesVCT;
                        case "LCA":
                            return ISO3166Base.provincesLCA;
                        case "KNA":
                            return ISO3166Base.provincesKNA;
                        case "SHN":
                            return ISO3166Base.provincesSHN;
                        case "RWA":
                            return ISO3166Base.provincesRWA;
                        case "RUS":
                            return ISO3166Base.provincesRUS;
                        case "ROU":
                            return ISO3166Base.provincesROU;
                        case "QAT":
                            return ISO3166Base.provincesQAT;
                        case "PRT":
                            return ISO3166Base.provincesPRT;
                        case "POL":
                            return ISO3166Base.provincesPOL;
                        case "PHL":
                            return ISO3166Base.provincesPHL;
                        case "PER":
                            return ISO3166Base.provincesPER;
                        case "PRY":
                            return ISO3166Base.provincesPRY;
                        case "PNG":
                            return ISO3166Base.provincesPNG;
                        case "PAN":
                            return ISO3166Base.provincesPAN;
                        case "PSE":
                            return ISO3166Base.provincesPSE;
                        case "PLW":
                            return ISO3166Base.provincesPLW;
                        case "PAK":
                            return ISO3166Base.provincesPAK;
                        case "OMN":
                            return ISO3166Base.provincesOMN;
                        case "NOR":
                            return ISO3166Base.provincesNOR;
                        case "NGA":
                            return ISO3166Base.provincesNGA;
                        case "NER":
                            return ISO3166Base.provincesNER;
                        case "NIC":
                            return ISO3166Base.provincesNIC;
                        case "NZL":
                            return ISO3166Base.provincesNZL;
                        case "NLD":
                            return ISO3166Base.provincesNLD;
                        case "NPL":
                            return ISO3166Base.provincesNPL;
                        case "NRU":
                            return ISO3166Base.provincesNRU;
                        case "NAM":
                            return ISO3166Base.provincesNAM;
                        case "MMR":
                            return ISO3166Base.provincesMMR;
                        case "MOZ":
                            return ISO3166Base.provincesMOZ;
                        case "MAR":
                            return ISO3166Base.provincesMAR;
                        case "NME":
                            return ISO3166Base.provincesNME;
                        case "MNG":
                            return ISO3166Base.provincesMNG;
                        case "MCO":
                            return ISO3166Base.provincesMCO;
                        case "MDA":
                            return ISO3166Base.provincesMDA;
                        case "FSM":
                            return ISO3166Base.provincesFSM;
                        case "MEX":
                            return ISO3166Base.provincesMEX;
                        case "MUS":
                            return ISO3166Base.provincesMUS;
                        case "MRT":
                            return ISO3166Base.provincesMRT;
                        case "MHL":
                            return ISO3166Base.provincesMHL;
                        case "MLT":
                            return ISO3166Base.provincesMLT;
                        case "MLI":
                            return ISO3166Base.provincesMLI;
                        case "MDV":
                            return ISO3166Base.provincesMDV;
                        case "MYS":
                            return ISO3166Base.provincesMYS;
                        case "MWI":
                            return ISO3166Base.provincesMWI;
                        case "MDG":
                            return ISO3166Base.provincesMDG;
                        case "LUX":
                            return ISO3166Base.provincesLUX;
                        case "LIE":
                            return ISO3166Base.provincesLIE;
                        case "LBY":
                            return ISO3166Base.provincesLBY;
                        case "LBR":
                            return ISO3166Base.provincesLBR;
                        case "LSO":
                            return ISO3166Base.provincesLSO;
                        case "LBN":
                            return ISO3166Base.provincesLBN;
                        case "LVA":
                            return ISO3166Base.provincesLVA;
                        case "LAO":
                            return ISO3166Base.provincesLAO;
                        case "KGZ":
                            return ISO3166Base.provincesKGZ;
                        case "KWT":
                            return ISO3166Base.provincesKWT;
                        case "KOR":
                            return ISO3166Base.provincesKOR;
                        case "PRK":
                            return ISO3166Base.provincesPRK;
                        case "KIR":
                            return ISO3166Base.provincesKIR;
                        case "KEN":
                            return ISO3166Base.provincesKEN;
                        case "KAZ":
                            return ISO3166Base.provincesKAZ;
                        case "JOR":
                            return ISO3166Base.provincesJOR;
                        case "JPN":
                            return ISO3166Base.provincesJPN;
                        case "JAM":
                            return ISO3166Base.provincesJAM;
                        case "ISR":
                            return ISO3166Base.provincesISR;
                        case "IRL":
                            return ISO3166Base.provincesIRL;
                        case "IRQ":
                            return ISO3166Base.provincesIRQ;
                        case "IRN":
                            return ISO3166Base.provincesIRN;
                        case "IDN":
                            return ISO3166Base.provincesIDN;
                        case "IND":
                            return ISO3166Base.provincesIND;
                        case "ISL":
                            return ISO3166Base.provincesISL;
                        case "HUN":
                            return ISO3166Base.provincesHUN;
                        case "HND":
                            return ISO3166Base.provincesHND;
                        case "HTI":
                            return ISO3166Base.provincesHTI;
                        case "GUY":
                            return ISO3166Base.provincesGUY;
                        case "GNB":
                            return ISO3166Base.provincesGNB;
                        case "GIN":
                            return ISO3166Base.provincesGIN;
                        case "GTM":
                            return ISO3166Base.provincesGTM;
                        case "GRD":
                            return ISO3166Base.provincesGRD;
                        case "GRL":
                            return ISO3166Base.provincesGRL;
                        case "GRC":
                            return ISO3166Base.provincesGRC;
                        case "GHA":
                            return ISO3166Base.provincesGHA;
                        case "DEU":
                            return ISO3166Base.provincesDEU;
                        case "GEO":
                            return ISO3166Base.provincesGEO;
                        case "GMB":
                            return ISO3166Base.provincesGMB;
                        case "GAB":
                            return ISO3166Base.provincesGAB;
                        case "FRA":
                            return ISO3166Base.provincesFRA;
                        case "FIN":
                            return ISO3166Base.provincesFIN;
                        case "FJI":
                            return ISO3166Base.provincesFJI;
                        case "ETH":
                            return ISO3166Base.provincesETH;
                        case "EST":
                            return ISO3166Base.provincesEST;
                        case "ERI":
                            return ISO3166Base.provincesERI;
                        case "GNQ":
                            return ISO3166Base.provincesGNQ;
                        case "SLV":
                            return ISO3166Base.provincesSLV;
                        case "EGY":
                            return ISO3166Base.provincesEGY;
                        case "ECU":
                            return ISO3166Base.provincesECU;
                        case "DOM":
                            return ISO3166Base.provincesDOM;
                        case "DMA":
                            return ISO3166Base.provincesDMA;
                        case "DJI":
                            return ISO3166Base.provincesDJI;
                        case "DNK":
                            return ISO3166Base.provincesDNK;
                        case "CZE":
                            return ISO3166Base.provincesCZE;
                        case "CYP":
                            return ISO3166Base.provincesCYP;
                        case "CUB":
                            return ISO3166Base.provincesCUB;
                        case "HRV":
                            return ISO3166Base.provincesHRV;
                        case "CIV":
                            return ISO3166Base.provincesCIV;
                        case "CRI":
                            return ISO3166Base.provincesCRI;
                        case "COG":
                            return ISO3166Base.provincesCOG;
                        case "COD":
                            return ISO3166Base.provincesCOD;
                        case "COM":
                            return ISO3166Base.provincesCOM;
                        case "COL":
                            return ISO3166Base.provincesCOL;
                        case "CHN":
                            return ISO3166Base.provincesCHN;
                        case "CHL":
                            return ISO3166Base.provincesCHL;
                        case "TCD":
                            return ISO3166Base.provincesTCD;
                        case "CAF":
                            return ISO3166Base.provincesCAF;
                        case "CPV":
                            return ISO3166Base.provincesCPV;
                        case "CAN":
                            return ISO3166Base.provincesCAN;
                        case "CMR":
                            return ISO3166Base.provincesCMR;
                        case "KHM":
                            return ISO3166Base.provincesKHM;
                        case "BDI":
                            return ISO3166Base.provincesBDI;
                        case "BFA":
                            return ISO3166Base.provincesBFA;
                        case "BGR":
                            return ISO3166Base.provincesBGR;
                        case "BRN":
                            return ISO3166Base.provincesBRN;
                        case "BRA":
                            return ISO3166Base.provincesBRA;
                        case "BWA":
                            return ISO3166Base.provincesBWA;
                        case "BIH":
                            return ISO3166Base.provincesBIH;
                        case "BES":
                            return ISO3166Base.provincesBES;
                        case "BTN":
                            return ISO3166Base.provincesBTN;
                        case "BOL":
                            return ISO3166Base.provincesBOL;
                        case "BEN":
                            return ISO3166Base.provincesBEN;
                        case "BLZ":
                            return ISO3166Base.provincesBLZ;
                        case "BEL":
                            return ISO3166Base.provincesBEL;
                        case "BLR":
                            return ISO3166Base.provincesBLR;
                        case "BRB":
                            return ISO3166Base.provincesBRB;
                        case "BGD":
                            return ISO3166Base.provincesBGD;
                        case "BHR":
                            return ISO3166Base.provincesBHR;
                        case "BHS":
                            return ISO3166Base.provincesBHS;
                        case "AZE":
                            return ISO3166Base.provincesAZE;
                        case "AUT":
                            return ISO3166Base.provincesAUT;
                        case "AUS":
                            return ISO3166Base.provincesAUS;
                        case "ARM":
                            return ISO3166Base.provincesARM;
                        case "ARG":
                            return ISO3166Base.provincesARG;
                        case "ATG":
                            return ISO3166Base.provincesATG;
                        case "AGO":
                            return ISO3166Base.provincesAGO;
                        case "AND":
                            return ISO3166Base.provincesAND;
                        case "DZA":
                            return ISO3166Base.provincesDZA;
                        case "ALB":
                            return ISO3166Base.provincesALB;
                        case "AFG":
                            return ISO3166Base.provincesAFG;
                        case "ITA":
                            return ISO3166Base.provincesITA;
                        default:
                            return ISO3166Base.provincesNONE;
                    }
                }
                catch (Exception)
                {
                    return new List<KeyValuePair<string, string>>();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        protected static class ISO3166Base
        {
            public static List<KeyValuePair<string, string>> Continents = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("--", "- none -"),
                new KeyValuePair < string, string > ("AF", "Africa"),
                new KeyValuePair < string, string > ("AS", "Asia"),
                new KeyValuePair < string, string > ("EU", "Europe"),
                new KeyValuePair < string, string > ("NA", "North America"),
                new KeyValuePair < string, string > ("SA", "South America"),
                new KeyValuePair < string, string > ("AN", "Antartica"),
                new KeyValuePair < string, string > ("OC", "Oceania")
            };
            public static List<KeyValuePair<string, string>> Countries = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair < string,string > ("---", "- none -"),
                new KeyValuePair < string,string > ("AFG", "Afghanistan"),
                new KeyValuePair < string,string > ("ALB", "Albania"),
                new KeyValuePair < string,string > ("DZA", "Algeria"),
                new KeyValuePair < string,string > ("ASM", "American Samoa"),
                new KeyValuePair < string,string > ("AND", "Andorra"),
                new KeyValuePair < string,string > ("AGO", "Angola"),
                new KeyValuePair < string,string > ("AIA", "Anguilla"),
                new KeyValuePair < string,string > ("ATA", "Antarctica"),
                new KeyValuePair < string,string > ("ATG", "Antigua and Barbuda"),
                new KeyValuePair < string,string > ("ARG", "Argentina"),
                new KeyValuePair < string,string > ("ARM", "Armenia"),
                new KeyValuePair < string,string > ("ABW", "Aruba"),
                new KeyValuePair < string,string > ("AUS", "Australia"),
                new KeyValuePair < string,string > ("AUT", "Austria"),
                new KeyValuePair < string,string > ("AZE", "Azerbaijan"),
                new KeyValuePair < string,string > ("BHS", "Bahamas (the)"),
                new KeyValuePair < string,string > ("BHR", "Bahrain"),
                new KeyValuePair < string,string > ("BGD", "Bangladesh"),
                new KeyValuePair < string,string > ("BRB", "Barbados"),
                new KeyValuePair < string,string > ("BLR", "Belarus"),
                new KeyValuePair < string,string > ("BEL", "Belgium"),
                new KeyValuePair < string,string > ("BLZ", "Belize"),
                new KeyValuePair < string,string > ("BEN", "Benin"),
                new KeyValuePair < string,string > ("BMU", "Bermuda"),
                new KeyValuePair < string,string > ("BTN", "Bhutan"),
                new KeyValuePair < string,string > ("BOL", "Bolivia"),
                new KeyValuePair < string,string > ("BES", "Bonaire"),
                new KeyValuePair < string,string > ("BIH", "Bosnia and Herzegovina"),
                new KeyValuePair < string,string > ("BWA", "Botswana"),
                new KeyValuePair < string,string > ("BVT", "Bouvet Island"),
                new KeyValuePair < string,string > ("BRA", "Brazil"),
                new KeyValuePair < string,string > ("IOT", "British Indian Ocean Territory"),
                new KeyValuePair < string,string > ("BRN", "Brunei Darussalam"),
                new KeyValuePair < string,string > ("BGR", "Bulgaria"),
                new KeyValuePair < string,string > ("BFA", "Burkina Faso"),
                new KeyValuePair < string,string > ("BDI", "Burundi"),
                new KeyValuePair < string,string > ("CPV", "Cabo Verde"),
                new KeyValuePair < string,string > ("KHM", "Cambodia"),
                new KeyValuePair < string,string > ("CMR", "Cameroon"),
                new KeyValuePair < string,string > ("CAN", "Canada"),
                new KeyValuePair < string,string > ("CYM", "Cayman Islands"),
                new KeyValuePair < string,string > ("CAF", "Central African Republic"),
                new KeyValuePair < string,string > ("TCD", "Chad"),
                new KeyValuePair < string,string > ("CHL", "Chile"),
                new KeyValuePair < string,string > ("CHN", "China"),
                new KeyValuePair < string,string > ("CXR", "Christmas Island"),
                new KeyValuePair < string,string > ("CCK", "Cocos Islands"),
                new KeyValuePair < string,string > ("COL", "Colombia"),
                new KeyValuePair < string,string > ("COM", "Comoros"),
                new KeyValuePair < string,string > ("COD", "Congo (Democratic Republic)"),
                new KeyValuePair < string,string > ("COG", "Congo"),
                new KeyValuePair < string,string > ("COK", "Cook Islands"),
                new KeyValuePair < string,string > ("CRI", "Costa Rica"),
                new KeyValuePair < string,string > ("HRV", "Croatia"),
                new KeyValuePair < string,string > ("CUB", "Cuba"),
                new KeyValuePair < string,string > ("CUW", "Curaçao"),
                new KeyValuePair < string,string > ("CYP", "Cyprus"),
                new KeyValuePair < string,string > ("CZE", "Czechia"),
                new KeyValuePair < string,string > ("CIV", "Côte d'Ivoire"),
                new KeyValuePair < string,string > ("DNK", "Denmark"),
                new KeyValuePair < string,string > ("DJI", "Djibouti"),
                new KeyValuePair < string,string > ("DMA", "Dominica"),
                new KeyValuePair < string,string > ("DOM", "Dominican Republic"),
                new KeyValuePair < string,string > ("ECU", "Ecuador"),
                new KeyValuePair < string,string > ("EGY", "Egypt"),
                new KeyValuePair < string,string > ("SLV", "El Salvador"),
                new KeyValuePair < string,string > ("GNQ", "Equatorial Guinea"),
                new KeyValuePair < string,string > ("ERI", "Eritrea"),
                new KeyValuePair < string,string > ("EST", "Estonia"),
                new KeyValuePair < string,string > ("SWZ", "Eswatini"),
                new KeyValuePair < string,string > ("ETH", "Ethiopia"),
                new KeyValuePair < string,string > ("FLK", "Falkland Islands"),
                new KeyValuePair < string,string > ("FRO", "Faroe Islands"),
                new KeyValuePair < string,string > ("FJI", "Fiji"),
                new KeyValuePair < string,string > ("FIN", "Finland"),
                new KeyValuePair < string,string > ("FRA", "France"),
                new KeyValuePair < string,string > ("GUF", "French Guiana"),
                new KeyValuePair < string,string > ("PYF", "French Polynesia"),
                new KeyValuePair < string,string > ("ATF", "French Southern Ter/ies"),
                new KeyValuePair < string,string > ("GAB", "Gabon"),
                new KeyValuePair < string,string > ("GMB", "Gambia"),
                new KeyValuePair < string,string > ("GEO", "Georgia"),
                new KeyValuePair < string,string > ("DEU", "Germany"),
                new KeyValuePair < string,string > ("GHA", "Ghana"),
                new KeyValuePair < string,string > ("GIB", "Gibraltar"),
                new KeyValuePair < string,string > ("GRC", "Greece"),
                new KeyValuePair < string,string > ("GRL", "Greenland"),
                new KeyValuePair < string,string > ("GRD", "Grenada"),
                new KeyValuePair < string,string > ("GLP", "Guadeloupe"),
                new KeyValuePair < string,string > ("GUM", "Guam"),
                new KeyValuePair < string,string > ("GTM", "Guatemala"),
                new KeyValuePair < string,string > ("GGY", "Guernsey"),
                new KeyValuePair < string,string > ("GIN", "Guinea"),
                new KeyValuePair < string,string > ("GNB", "Guinea-Bissau"),
                new KeyValuePair < string,string > ("GUY", "Guyana"),
                new KeyValuePair < string,string > ("HTI", "Haiti"),
                new KeyValuePair < string,string > ("HMD", "Heard Island and McDonald Islands"),
                new KeyValuePair < string,string > ("VAT", "Holy See"),
                new KeyValuePair < string,string > ("HND", "Honduras"),
                new KeyValuePair < string,string > ("HKG", "Hong Kong"),
                new KeyValuePair < string,string > ("HUN", "Hungary"),
                new KeyValuePair < string,string > ("ISL", "Iceland"),
                new KeyValuePair < string,string > ("IND", "India"),
                new KeyValuePair < string,string > ("IDN", "Indonesia"),
                new KeyValuePair < string,string > ("IRN", "Iran"),
                new KeyValuePair < string,string > ("IRQ", "Iraq"),
                new KeyValuePair < string,string > ("IRL", "Ireland"),
                new KeyValuePair < string,string > ("IMN", "Isle of Man"),
                new KeyValuePair < string,string > ("ISR", "Israel"),
                new KeyValuePair < string,string > ("ITA", "Italy"),
                new KeyValuePair < string,string > ("JAM", "Jamaica"),
                new KeyValuePair < string,string > ("JPN", "Japan"),
                new KeyValuePair < string,string > ("JEY", "Jersey"),
                new KeyValuePair < string,string > ("JOR", "Jordan"),
                new KeyValuePair < string,string > ("KAZ", "Kazakhstan"),
                new KeyValuePair < string,string > ("KEN", "Kenya"),
                new KeyValuePair < string,string > ("KIR", "Kiribati"),
                new KeyValuePair < string,string > ("PRK", "Korea North"),
                new KeyValuePair < string,string > ("KOR", "Korea South"),
                new KeyValuePair < string,string > ("KWT", "Kuwait"),
                new KeyValuePair < string,string > ("KGZ", "Kyrgyzstan"),
                new KeyValuePair < string,string > ("LAO", "Lao"),
                new KeyValuePair < string,string > ("LVA", "Latvia"),
                new KeyValuePair < string,string > ("LBN", "Lebanon"),
                new KeyValuePair < string,string > ("LSO", "Lesotho"),
                new KeyValuePair < string,string > ("LBR", "Liberia"),
                new KeyValuePair < string,string > ("LBY", "Libya"),
                new KeyValuePair < string,string > ("LIE", "Liechtenstein"),
                new KeyValuePair < string,string > ("LTU", "Lithuania"),
                new KeyValuePair < string,string > ("LUX", "Luxembourg"),
                new KeyValuePair < string,string > ("MAC", "Macao"),
                new KeyValuePair < string,string > ("MDG", "Madagascar"),
                new KeyValuePair < string,string > ("MWI", "Malawi"),
                new KeyValuePair < string,string > ("MYS", "Malaysia"),
                new KeyValuePair < string,string > ("MDV", "Maldives"),
                new KeyValuePair < string,string > ("MLI", "Mali"),
                new KeyValuePair < string,string > ("MLT", "Malta"),
                new KeyValuePair < string,string > ("MHL", "Marshall Islands"),
                new KeyValuePair < string,string > ("MTQ", "Martinique"),
                new KeyValuePair < string,string > ("MRT", "Mauritania"),
                new KeyValuePair < string,string > ("MUS", "Mauritius"),
                new KeyValuePair < string,string > ("MYT", "Mayotte"),
                new KeyValuePair < string,string > ("MEX", "Mexico"),
                new KeyValuePair < string,string > ("FSM", "Micronesia"),
                new KeyValuePair < string,string > ("MDA", "Moldova"),
                new KeyValuePair < string,string > ("MCO", "Monaco"),
                new KeyValuePair < string,string > ("MNG", "Mongolia"),
                new KeyValuePair < string,string > ("MNE", "Montenegro"),
                new KeyValuePair < string,string > ("MSR", "Montserrat"),
                new KeyValuePair < string,string > ("MAR", "Morocco"),
                new KeyValuePair < string,string > ("MOZ", "Mozambique"),
                new KeyValuePair < string,string > ("MMR", "Myanmar"),
                new KeyValuePair < string,string > ("NAM", "Namibia"),
                new KeyValuePair < string,string > ("NRU", "Nauru"),
                new KeyValuePair < string,string > ("NPL", "Nepal"),
                new KeyValuePair < string,string > ("NLD", "Netherlands"),
                new KeyValuePair < string,string > ("NCL", "New Caledonia"),
                new KeyValuePair < string,string > ("NZL", "New Zealand"),
                new KeyValuePair < string,string > ("NIC", "Nicaragua"),
                new KeyValuePair < string,string > ("NER", "Niger"),
                new KeyValuePair < string,string > ("NGA", "Nigeria"),
                new KeyValuePair < string,string > ("NIU", "Niue"),
                new KeyValuePair < string,string > ("NFK", "Norfolk Island"),
                new KeyValuePair < string,string > ("MKD", "North Macedonia"),
                new KeyValuePair < string,string > ("MNP", "Northern Mariana Islands"),
                new KeyValuePair < string,string > ("NOR", "Norway"),
                new KeyValuePair < string,string > ("OMN", "Oman"),
                new KeyValuePair < string,string > ("PAK", "Pakistan"),
                new KeyValuePair < string,string > ("PLW", "Palau"),
                new KeyValuePair < string,string > ("PSE", "Palestine, State of"),
                new KeyValuePair < string,string > ("PAN", "Panama"),
                new KeyValuePair < string,string > ("PNG", "Papua New Guinea"),
                new KeyValuePair < string,string > ("PRY", "Paraguay"),
                new KeyValuePair < string,string > ("PER", "Peru"),
                new KeyValuePair < string,string > ("PHL", "Philippines (the)"),
                new KeyValuePair < string,string > ("PCN", "Pitcairn"),
                new KeyValuePair < string,string > ("POL", "Poland"),
                new KeyValuePair < string,string > ("PRT", "Portugal"),
                new KeyValuePair < string,string > ("PRI", "Puerto Rico"),
                new KeyValuePair < string,string > ("QAT", "Qatar"),
                new KeyValuePair < string,string > ("ROU", "Romania"),
                new KeyValuePair < string,string > ("RUS", "Russian Federation"),
                new KeyValuePair < string,string > ("RWA", "Rwanda"),
                new KeyValuePair < string,string > ("REU", "Réunion"),
                new KeyValuePair < string,string > ("BLM", "Saint Barthélemy"),
                new KeyValuePair < string,string > ("SHN", "Saint Helena"),
                new KeyValuePair < string,string > ("KNA", "Saint Kitts and Nevis"),
                new KeyValuePair < string,string > ("LCA", "Saint Lucia"),
                new KeyValuePair < string,string > ("MAF", "Saint Martin"),
                new KeyValuePair < string,string > ("SPM", "Saint Pierre - Miquelon"),
                new KeyValuePair < string,string > ("VCT", "Saint Vincent - Grenadines"),
                new KeyValuePair < string,string > ("WSM", "Samoa"),
                new KeyValuePair < string,string > ("SMR", "San Marino"),
                new KeyValuePair < string,string > ("STP", "Sao Tome and Principe"),
                new KeyValuePair < string,string > ("SAU", "Saudi Arabia"),
                new KeyValuePair < string,string > ("SEN", "Senegal"),
                new KeyValuePair < string,string > ("SRB", "Serbia"),
                new KeyValuePair < string,string > ("SYC", "Seychelles"),
                new KeyValuePair < string,string > ("SLE", "Sierra Leone"),
                new KeyValuePair < string,string > ("SGP", "Singapore"),
                new KeyValuePair < string,string > ("SXM", "Sint Maarten"),
                new KeyValuePair < string,string > ("SVK", "Slovakia"),
                new KeyValuePair < string,string > ("SVN", "Slovenia"),
                new KeyValuePair < string,string > ("SLB", "Solomon Islands"),
                new KeyValuePair < string,string > ("SOM", "Somalia"),
                new KeyValuePair < string,string > ("ZAF", "South Africa"),
                new KeyValuePair < string,string > ("SGS", "South Georgia & Sandwich Islands"),
                new KeyValuePair < string,string > ("SSD", "South Sudan"),
                new KeyValuePair < string,string > ("ESP", "Spain"),
                new KeyValuePair < string,string > ("LKA", "Sri Lanka"),
                new KeyValuePair < string,string > ("SDN", "Sudan (the)"),
                new KeyValuePair < string,string > ("SUR", "Suriname"),
                new KeyValuePair < string,string > ("SJM", "Svalbard and Jan Mayen"),
                new KeyValuePair < string,string > ("SWE", "Sweden"),
                new KeyValuePair < string,string > ("CHE", "Switzerland"),
                new KeyValuePair < string,string > ("SYR", "Syrian"),
                new KeyValuePair < string,string > ("TWN", "Taiwan"),
                new KeyValuePair < string,string > ("TJK", "Tajikistan"),
                new KeyValuePair < string,string > ("TZA", "Tanzania"),
                new KeyValuePair < string,string > ("THA", "Thailand"),
                new KeyValuePair < string,string > ("TLS", "Timor-Leste"),
                new KeyValuePair < string,string > ("TGO", "Togo"),
                new KeyValuePair < string,string > ("TKL", "Tokelau"),
                new KeyValuePair < string,string > ("TON", "Tonga"),
                new KeyValuePair < string,string > ("TTO", "Trinidad and Tobago"),
                new KeyValuePair < string,string > ("TUN", "Tunisia"),
                new KeyValuePair < string,string > ("TUR", "Turkey"),
                new KeyValuePair < string,string > ("TKM", "Turkmenistan"),
                new KeyValuePair < string,string > ("TCA", "Turks and Caicos Islands"),
                new KeyValuePair < string,string > ("TUV", "Tuvalu"),
                new KeyValuePair < string,string > ("UGA", "Uganda"),
                new KeyValuePair < string,string > ("UKR", "Ukraine"),
                new KeyValuePair < string,string > ("ARE", "United Arab Emirates"),
                new KeyValuePair < string,string > ("GBR", "United Kingdom and Northern Ireland"),
                new KeyValuePair < string,string > ("UMI", "United States Minor Outlying Islands"),
                new KeyValuePair < string,string > ("USA", "United States of America"),
                new KeyValuePair < string,string > ("URY", "Uruguay"),
                new KeyValuePair < string,string > ("UZB", "Uzbekistan"),
                new KeyValuePair < string,string > ("VUT", "Vanuatu"),
                new KeyValuePair < string,string > ("VEN", "Venezuela"),
                new KeyValuePair < string,string > ("VNM", "Viet Nam"),
                new KeyValuePair < string,string > ("VGB", "Virgin Islands (British)"),
                new KeyValuePair < string,string > ("VIR", "Virgin Islands (U.S.)"),
                new KeyValuePair < string,string > ("WLF", "Wallis and Futuna"),
                new KeyValuePair < string,string > ("ESH", "Western Sahara"),
                new KeyValuePair < string,string > ("YEM", "Yemen"),
                new KeyValuePair < string,string > ("ZMB", "Zambia"),
                new KeyValuePair < string,string > ("ZWE", "Zimbabwe"),
                new KeyValuePair < string,string > ("ALA", "Aland Islands")
            };
            public static List<KeyValuePair<string, string>> provincesNONE = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -")
            };
            public static List<KeyValuePair<string, string>> provincesZWE = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("HA", "Harare"),
                new KeyValuePair < string, string > ("MA", "Manicaland"),
                new KeyValuePair < string, string > ("MC", "Mashonaland Central"),
                new KeyValuePair < string, string > ("ME", "Mashonaland East"),
                new KeyValuePair < string, string > ("MI", "Midlands"),
                new KeyValuePair < string, string > ("MN", "Matabeleland North"),
                new KeyValuePair < string, string > ("MS", "Matabeleland South"),
                new KeyValuePair < string, string > ("MV", "Masvingo"),
                new KeyValuePair < string, string > ("MW", "Mashonaland West")
            };
            public static List<KeyValuePair<string, string>> provincesZMB = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("01", "Western"),
                new KeyValuePair < string, string > ("02", "Central"),
                new KeyValuePair < string, string > ("03", "Eastern"),
                new KeyValuePair < string, string > ("04", "Luapula"),
                new KeyValuePair < string, string > ("05", "Northern"),
                new KeyValuePair < string, string > ("06", "North-Western"),
                new KeyValuePair < string, string > ("07", "Southern"),
                new KeyValuePair < string, string > ("08", "Copperbelt"),
                new KeyValuePair < string, string > ("09", "Lusaka")
            };
            public static List<KeyValuePair<string, string>> provincesYEM = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("AB", "Abyan"),
                new KeyValuePair < string, string > ("AD", "'Adan"),
                new KeyValuePair < string, string > ("AM", "'Amran"),
                new KeyValuePair < string, string > ("BA", "Al Bayda'"),
                new KeyValuePair < string, string > ("DA", "Ad dali'"),
                new KeyValuePair < string, string > ("DH", "Dhamar"),
                new KeyValuePair < string, string > ("HD", "Ḩadramawt"),
                new KeyValuePair < string, string > ("HJ", "Ḩajjah"),
                new KeyValuePair < string, string > ("HU", "Al Ḩudaydah"),
                new KeyValuePair < string, string > ("IB", "Ibb"),
                new KeyValuePair < string, string > ("JA", "Al Jawf"),
                new KeyValuePair < string, string > ("LA", "Laḩij"),
                new KeyValuePair < string, string > ("MA", "Ma'rib"),
                new KeyValuePair < string, string > ("MR", "Al Mahrah"),
                new KeyValuePair < string, string > ("MW", "Al Maḩwit"),
                new KeyValuePair < string, string > ("RA", "Raymah"),
                new KeyValuePair < string, string > ("SD", "Sa'dah"),
                new KeyValuePair < string, string > ("SH", "Shabwah"),
                new KeyValuePair < string, string > ("SN", "san'a"),
                new KeyValuePair < string, string > ("TA", "Ta'izz"),
                new KeyValuePair < string, string > ("SA", "Aanʻa'")
            };
            public static List<KeyValuePair<string, string>> provincesVNM = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("CT", "Can Tho"),
                new KeyValuePair < string, string > ("DN", "Da Nang"),
                new KeyValuePair < string, string > ("HN", "Ha Noi"),
                new KeyValuePair < string, string > ("HP", "Hai Phong"),
                new KeyValuePair < string, string > ("SG", "Ho Chi Minh"),
                new KeyValuePair < string, string > ("01", "Lai Chau"),
                new KeyValuePair < string, string > ("02", "Lao Cai"),
                new KeyValuePair < string, string > ("03", "Ha Giang"),
                new KeyValuePair < string, string > ("04", "Cao Bang"),
                new KeyValuePair < string, string > ("05", "Son La"),
                new KeyValuePair < string, string > ("06", "Yen Bai"),
                new KeyValuePair < string, string > ("07", "Tuyen Quang"),
                new KeyValuePair < string, string > ("09", "Lang Son"),
                new KeyValuePair < string, string > ("13", "Quang Ninh"),
                new KeyValuePair < string, string > ("14", "Hoa Binh"),
                new KeyValuePair < string, string > ("15", "Ha Tay"),
                new KeyValuePair < string, string > ("18", "Ninh Binh"),
                new KeyValuePair < string, string > ("20", "Thai Binh"),
                new KeyValuePair < string, string > ("21", "Thanh Hoa"),
                new KeyValuePair < string, string > ("22", "Nghe An"),
                new KeyValuePair < string, string > ("23", "Ha Tinh"),
                new KeyValuePair < string, string > ("24", "Quang Binh"),
                new KeyValuePair < string, string > ("25", "Quang Tri"),
                new KeyValuePair < string, string > ("26", "Thua Thien-Hue"),
                new KeyValuePair < string, string > ("27", "Quang Nam"),
                new KeyValuePair < string, string > ("28", "Kon Tum"),
                new KeyValuePair < string, string > ("29", "Quang Ngai"),
                new KeyValuePair < string, string > ("30", "Gia Lai"),
                new KeyValuePair < string, string > ("31", "Binh Dinh"),
                new KeyValuePair < string, string > ("32", "Phu Yen"),
                new KeyValuePair < string, string > ("33", "Dac Lac"),
                new KeyValuePair < string, string > ("34", "Khanh Hoa"),
                new KeyValuePair < string, string > ("35", "Lam Dong"),
                new KeyValuePair < string, string > ("36", "Ninh Thuan"),
                new KeyValuePair < string, string > ("37", "Tay Ninh"),
                new KeyValuePair < string, string > ("39", "Dong Nai"),
                new KeyValuePair < string, string > ("40", "Binh Thuan"),
                new KeyValuePair < string, string > ("41", "Long An"),
                new KeyValuePair < string, string > ("43", "Ba Ria - Vung Tau"),
                new KeyValuePair < string, string > ("44", "An Giang"),
                new KeyValuePair < string, string > ("45", "Dong Thap"),
                new KeyValuePair < string, string > ("46", "Tien Giang"),
                new KeyValuePair < string, string > ("47", "Kien Giang"),
                new KeyValuePair < string, string > ("49", "Vinh Long"),
                new KeyValuePair < string, string > ("50", "Ben Tre"),
                new KeyValuePair < string, string > ("51", "Tra Vinh"),
                new KeyValuePair < string, string > ("52", "Soc Trang"),
                new KeyValuePair < string, string > ("53", "Bac Can"),
                new KeyValuePair < string, string > ("54", "Bac Giang"),
                new KeyValuePair < string, string > ("55", "Bac Lieu"),
                new KeyValuePair < string, string > ("56", "Bac Ninh"),
                new KeyValuePair < string, string > ("57", "Binh Duong"),
                new KeyValuePair < string, string > ("58", "Binh Phuoc"),
                new KeyValuePair < string, string > ("59", "Ca Mau"),
                new KeyValuePair < string, string > ("60", "Da Nang, thanh pho"),
                new KeyValuePair < string, string > ("61", "Hai Duong"),
                new KeyValuePair < string, string > ("62", "Hai Phong, thanh pho"),
                new KeyValuePair < string, string > ("63", "Ha Nam"),
                new KeyValuePair < string, string > ("66", "Hung Yen"),
                new KeyValuePair < string, string > ("67", "Nam Dinh"),
                new KeyValuePair < string, string > ("68", "Phu Tho"),
                new KeyValuePair < string, string > ("69", "Thai Nguyen"),
                new KeyValuePair < string, string > ("70", "Vinh Yen"),
                new KeyValuePair < string, string > ("71", "Dien Bien"),
                new KeyValuePair < string, string > ("72", "Dak Nong"),
                new KeyValuePair < string, string > ("73", "Hau Giang")
            };
            public static List<KeyValuePair<string, string>> provincesVEN = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("A", "Distrito Capital"),
                new KeyValuePair < string, string > ("B", "Anzoategui"),
                new KeyValuePair < string, string > ("C", "Apure"),
                new KeyValuePair < string, string > ("D", "Aragua"),
                new KeyValuePair < string, string > ("E", "Barinas"),
                new KeyValuePair < string, string > ("F", "Bolivar"),
                new KeyValuePair < string, string > ("G", "Carabobo"),
                new KeyValuePair < string, string > ("H", "Cojedes"),
                new KeyValuePair < string, string > ("I", "Falcon"),
                new KeyValuePair < string, string > ("J", "Guarico"),
                new KeyValuePair < string, string > ("K", "Lara"),
                new KeyValuePair < string, string > ("L", "Merida"),
                new KeyValuePair < string, string > ("M", "Miranda"),
                new KeyValuePair < string, string > ("N", "Monagas"),
                new KeyValuePair < string, string > ("O", "Nueva Esparta"),
                new KeyValuePair < string, string > ("P", "Portuguesa"),
                new KeyValuePair < string, string > ("R", "Sucre"),
                new KeyValuePair < string, string > ("S", "Tachira"),
                new KeyValuePair < string, string > ("T", "Trujillo"),
                new KeyValuePair < string, string > ("U", "Yaracuy"),
                new KeyValuePair < string, string > ("V", "Zulia"),
                new KeyValuePair < string, string > ("W", "Dependencias Federales"),
                new KeyValuePair < string, string > ("X", "vargas"),
                new KeyValuePair < string, string > ("Y", "Delta Amacuro"),
                new KeyValuePair < string, string > ("Z", "Amazonas")
            };
            public static List<KeyValuePair<string, string>> provincesVUT = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("MAP", "Malampa"),
                new KeyValuePair < string, string > ("PAM", "Penama"),
                new KeyValuePair < string, string > ("SAM", "Sanma"),
                new KeyValuePair < string, string > ("SEE", "Shefa"),
                new KeyValuePair < string, string > ("TAE", "Tafea"),
                new KeyValuePair < string, string > ("TOB", "Torba")
            };
            public static List<KeyValuePair<string, string>> provincesUZB = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("AN", "Andijon"),
                new KeyValuePair < string, string > ("BU", "Bukhoro"),
                new KeyValuePair < string, string > ("FA", "Farghona"),
                new KeyValuePair < string, string > ("JI", "Jizzakh"),
                new KeyValuePair < string, string > ("KH", "Khorazm"),
                new KeyValuePair < string, string > ("NG", "Namangan"),
                new KeyValuePair < string, string > ("NW", "Nawoiy"),
                new KeyValuePair < string, string > ("QA", "Qashqadaryo"),
                new KeyValuePair < string, string > ("QR", "Qoraqalpoghiston Respublikasi"),
                new KeyValuePair < string, string > ("SA", "Samarqand"),
                new KeyValuePair < string, string > ("SI", "Sirdaryo"),
                new KeyValuePair < string, string > ("SU", "Surkhondaryo"),
                new KeyValuePair < string, string > ("TK", "Toshkent"),
                new KeyValuePair < string, string > ("TO", "Toshkent"),
                new KeyValuePair < string, string > ("XO", "Xorazm")
            };
            public static List<KeyValuePair<string, string>> provincesURY = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("AR", "Artigas"),
                new KeyValuePair < string, string > ("CA", "Canelones"),
                new KeyValuePair < string, string > ("CL", "Cerro Largo"),
                new KeyValuePair < string, string > ("CO", "Colonia"),
                new KeyValuePair < string, string > ("DU", "Durazno"),
                new KeyValuePair < string, string > ("FD", "Florida"),
                new KeyValuePair < string, string > ("FS", "Flores"),
                new KeyValuePair < string, string > ("LA", "Lavalleja"),
                new KeyValuePair < string, string > ("MA", "Maldonado"),
                new KeyValuePair < string, string > ("MO", "Montevideo"),
                new KeyValuePair < string, string > ("PA", "Paysand&#250;"),
                new KeyValuePair < string, string > ("RN", "Rio Negro"),
                new KeyValuePair < string, string > ("RO", "Rocha"),
                new KeyValuePair < string, string > ("RV", "Rivera"),
                new KeyValuePair < string, string > ("SA", "Salto"),
                new KeyValuePair < string, string > ("SJ", "San Jose"),
                new KeyValuePair < string, string > ("SO", "Soriano"),
                new KeyValuePair < string, string > ("TA", "Tacuarembo"),
                new KeyValuePair < string, string > ("TT", "Treinta y Tres")
            };
            public static List<KeyValuePair<string, string>> provincesUMI = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("67", "Johnston Atoll"),
                new KeyValuePair < string, string > ("71", "Midway Islands"),
                new KeyValuePair < string, string > ("76", "Navassa Island"),
                new KeyValuePair < string, string > ("79", "Wake Island"),
                new KeyValuePair < string, string > ("81", "Baker Island"),
                new KeyValuePair < string, string > ("84", "Howland Island"),
                new KeyValuePair < string, string > ("86", "Jarvis Island"),
                new KeyValuePair < string, string > ("89", "Kingman Reef"),
                new KeyValuePair < string, string > ("95", "Palmyra Atoll")
            };
            public static List<KeyValuePair<string, string>> provincesUSA = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("AK", "Alaska"),
                new KeyValuePair < string, string > ("AL", "Alabama"),
                new KeyValuePair < string, string > ("AR", "Arkansas"),
                new KeyValuePair < string, string > ("AS", "American Samoa (see also separate entry under AS)"),
                new KeyValuePair < string, string > ("AZ", "Arizona"),
                new KeyValuePair < string, string > ("CA", "California"),
                new KeyValuePair < string, string > ("CO", "Colorado"),
                new KeyValuePair < string, string > ("CT", "Connecticut"),
                new KeyValuePair < string, string > ("DC", "District of Columbia"),
                new KeyValuePair < string, string > ("DE", "Delaware"),
                new KeyValuePair < string, string > ("FL", "Florida"),
                new KeyValuePair < string, string > ("GA", "Georgia"),
                new KeyValuePair < string, string > ("GU", "Guam (see also separate entry under GU)"),
                new KeyValuePair < string, string > ("HI", "Hawaii"),
                new KeyValuePair < string, string > ("IA", "Iowa"),
                new KeyValuePair < string, string > ("ID", "Idaho"),
                new KeyValuePair < string, string > ("IL", "Illinois"),
                new KeyValuePair < string, string > ("IN", "Indiana"),
                new KeyValuePair < string, string > ("KS", "Kansas"),
                new KeyValuePair < string, string > ("KY", "Kentucky"),
                new KeyValuePair < string, string > ("LA", "Louisiana"),
                new KeyValuePair < string, string > ("MA", "Massachusetts"),
                new KeyValuePair < string, string > ("MD", "Maryland"),
                new KeyValuePair < string, string > ("ME", "Maine"),
                new KeyValuePair < string, string > ("MI", "Michigan"),
                new KeyValuePair < string, string > ("MN", "Minnesota"),
                new KeyValuePair < string, string > ("MO", "Missouri"),
                new KeyValuePair < string, string > ("MP", "Northern Mariana Islands (see also separate entry MP)"),
                new KeyValuePair < string, string > ("MS", "Mississippi"),
                new KeyValuePair < string, string > ("MT", "Montana"),
                new KeyValuePair < string, string > ("NC", "North Carolina"),
                new KeyValuePair < string, string > ("ND", "North Dakota"),
                new KeyValuePair < string, string > ("NE", "Nebraska"),
                new KeyValuePair < string, string > ("NH", "New Hampshire"),
                new KeyValuePair < string, string > ("NJ", "New Jersey"),
                new KeyValuePair < string, string > ("NM", "New Mexico"),
                new KeyValuePair < string, string > ("NV", "Nevada"),
                new KeyValuePair < string, string > ("NY", "New York"),
                new KeyValuePair < string, string > ("OH", "Ohio"),
                new KeyValuePair < string, string > ("OK", "Oklahoma"),
                new KeyValuePair < string, string > ("OR", "Oregon"),
                new KeyValuePair < string, string > ("PA", "Pennsylvania"),
                new KeyValuePair < string, string > ("PR", "Puerto Rico (see also separate entry under PR)"),
                new KeyValuePair < string, string > ("RI", "Rhode Island"),
                new KeyValuePair < string, string > ("SC", "South Carolina"),
                new KeyValuePair < string, string > ("SD", "South Dakota"),
                new KeyValuePair < string, string > ("TN", "Tennessee"),
                new KeyValuePair < string, string > ("TX", "Texas"),
                new KeyValuePair < string, string > ("UM", "U.S. Minor Outlying Islands (cf. separate entry UM)"),
                new KeyValuePair < string, string > ("UT", "Utah"),
                new KeyValuePair < string, string > ("VA", "Virginia"),
                new KeyValuePair < string, string > ("VI", "Virgin Islands of the U.S. (see also separate entry VI)"),
                new KeyValuePair < string, string > ("VT", "Vermont"),
                new KeyValuePair < string, string > ("WA", "Washington"),
                new KeyValuePair < string, string > ("WI", "Wisconsin"),
                new KeyValuePair < string, string > ("WV", "West Virginia"),
                new KeyValuePair < string, string > ("WY", "Wyoming")
            };
            public static List<KeyValuePair<string, string>> provincesGBR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("ABD", "Aberdeenshire"),
            new KeyValuePair < string, string > ("ABE", "Aberdeen City"),
            new KeyValuePair < string, string > ("AGB", "Argyll and Bute"),
            new KeyValuePair < string, string > ("AGY", "Isle of Anglesey [Sir Ynys Mon GB-YNM]"),
            new KeyValuePair < string, string > ("ANS", "Angus"),
            new KeyValuePair < string, string > ("ANT", "Antrim"),
            new KeyValuePair < string, string > ("ARD", "Ards"),
            new KeyValuePair < string, string > ("ARM", "Armagh"),
            new KeyValuePair < string, string > ("BAS", "Bath and North East Somerset"),
            new KeyValuePair < string, string > ("BBD", "Blackburn with Darwen"),
            new KeyValuePair < string, string > ("BDF", "Bedfordshire"),
            new KeyValuePair < string, string > ("BDG", "Barking and Dagenham"),
            new KeyValuePair < string, string > ("BEN", "Brent"),
            new KeyValuePair < string, string > ("BEX", "Bexley"),
            new KeyValuePair < string, string > ("BFS", "Belfast"),
            new KeyValuePair < string, string > ("BGE", "Bridgend [Pen-y-bont ar Ogwr GB-POG]"),
            new KeyValuePair < string, string > ("BGW", "Blaenau Gwent"),
            new KeyValuePair < string, string > ("BIR", "Birmingham"),
            new KeyValuePair < string, string > ("BKM", "Buckinghamshire"),
            new KeyValuePair < string, string > ("BLA", "Ballymena"),
            new KeyValuePair < string, string > ("BLY", "Ballymoney"),
            new KeyValuePair < string, string > ("BMH", "Bournemouth"),
            new KeyValuePair < string, string > ("BNB", "Banbridge"),
            new KeyValuePair < string, string > ("BNE", "Barnet"),
            new KeyValuePair < string, string > ("BNH", "Brighton and Hove"),
            new KeyValuePair < string, string > ("BNS", "Barnsley"),
            new KeyValuePair < string, string > ("BOL", "Bolton"),
            new KeyValuePair < string, string > ("BPL", "Blackpool"),
            new KeyValuePair < string, string > ("BRC", "Bracknell Forest"),
            new KeyValuePair < string, string > ("BRD", "Bradford"),
            new KeyValuePair < string, string > ("BRY", "Bromley"),
            new KeyValuePair < string, string > ("BST", "Bristol, City of"),
            new KeyValuePair < string, string > ("BUR", "Bury"),
            new KeyValuePair < string, string > ("CAM", "Cambridgeshire"),
            new KeyValuePair < string, string > ("CAY", "Caerphilly [Caerffili GB-CAF]"),
            new KeyValuePair < string, string > ("CBF", "Central Bedfordshire"),
            new KeyValuePair < string, string > ("CGN", "Ceredigion [Sir Ceredigion]"),
            new KeyValuePair < string, string > ("CGV", "Craigavon"),
            new KeyValuePair < string, string > ("CHE", "Cheshire East"),
            new KeyValuePair < string, string > ("CHW", "Cheshire West and Chester"),
            new KeyValuePair < string, string > ("CKF", "Carrickfergus"),
            new KeyValuePair < string, string > ("CKT", "Cookstown"),
            new KeyValuePair < string, string > ("CLD", "Calderdale"),
            new KeyValuePair < string, string > ("CLK", "Clackmannanshire"),
            new KeyValuePair < string, string > ("CLR", "Coleraine"),
            new KeyValuePair < string, string > ("CMA", "Cumbria"),
            new KeyValuePair < string, string > ("CMD", "Camden"),
            new KeyValuePair < string, string > ("CMN", "Carmarthenshire [Sir Gaerfyrddin GB-GFY]"),
            new KeyValuePair < string, string > ("CON", "Cornwall"),
            new KeyValuePair < string, string > ("COV", "Coventry"),
            new KeyValuePair < string, string > ("CRF", "Cardiff [Caerdydd GB-CRD]"),
            new KeyValuePair < string, string > ("CRY", "Croydon"),
            new KeyValuePair < string, string > ("CSR", "Castlereagh"),
            new KeyValuePair < string, string > ("CWY", "Conwy"),
            new KeyValuePair < string, string > ("DAL", "Darlington"),
            new KeyValuePair < string, string > ("DBY", "Derbyshire"),
            new KeyValuePair < string, string > ("DEN", "Denbighshire [Sir Ddinbych GB-DDB]"),
            new KeyValuePair < string, string > ("DER", "Derby"),
            new KeyValuePair < string, string > ("DEV", "Devon"),
            new KeyValuePair < string, string > ("DGN", "Dungannon"),
            new KeyValuePair < string, string > ("DGY", "Dumfries and Galloway"),
            new KeyValuePair < string, string > ("DNC", "Doncaster"),
            new KeyValuePair < string, string > ("DND", "Dundee City"),
            new KeyValuePair < string, string > ("DOR", "Dorset"),
            new KeyValuePair < string, string > ("DOW", "Down"),
            new KeyValuePair < string, string > ("DRY", "Derry"),
            new KeyValuePair < string, string > ("DUD", "Dudley"),
            new KeyValuePair < string, string > ("DUR", "Durham"),
            new KeyValuePair < string, string > ("EAL", "Ealing"),
            new KeyValuePair < string, string > ("EAY", "East Ayrshire"),
            new KeyValuePair < string, string > ("EDH", "Edinburgh, City of"),
            new KeyValuePair < string, string > ("EDU", "East Dunbartonshire"),
            new KeyValuePair < string, string > ("ELN", "East Lothian"),
            new KeyValuePair < string, string > ("ELS", "Eilean Siar"),
            new KeyValuePair < string, string > ("ENF", "Enfield"),
            new KeyValuePair < string, string > ("ERW", "East Renfrewshire"),
            new KeyValuePair < string, string > ("ERY", "East Riding of Yorkshire"),
            new KeyValuePair < string, string > ("ESS", "Essex"),
            new KeyValuePair < string, string > ("ESX", "East Sussex"),
            new KeyValuePair < string, string > ("FAL", "Falkirk"),
            new KeyValuePair < string, string > ("FER", "Fermanagh"),
            new KeyValuePair < string, string > ("FIF", "Fife"),
            new KeyValuePair < string, string > ("FLN", "Flintshire [Sir y Fflint GB-FFL]"),
            new KeyValuePair < string, string > ("GAT", "Gateshead"),
            new KeyValuePair < string, string > ("GLG", "Glasgow City"),
            new KeyValuePair < string, string > ("GLS", "Gloucestershire"),
            new KeyValuePair < string, string > ("GRE", "Greenwich"),
            new KeyValuePair < string, string > ("GWN", "Gwynedd"),
            new KeyValuePair < string, string > ("HAL", "Halton"),
            new KeyValuePair < string, string > ("HAM", "Hampshire"),
            new KeyValuePair < string, string > ("HAV", "Havering"),
            new KeyValuePair < string, string > ("HCK", "Hackney"),
            new KeyValuePair < string, string > ("HEF", "Herefordshire, County of"),
            new KeyValuePair < string, string > ("HIL", "Hillingdon"),
            new KeyValuePair < string, string > ("HLD", "Highland"),
            new KeyValuePair < string, string > ("HMF", "Hammersmith and Fulham"),
            new KeyValuePair < string, string > ("HNS", "Hounslow"),
            new KeyValuePair < string, string > ("HPL", "Hartlepool"),
            new KeyValuePair < string, string > ("HRT", "Hertfordshire"),
            new KeyValuePair < string, string > ("HRW", "Harrow"),
            new KeyValuePair < string, string > ("HRY", "Haringey"),
            new KeyValuePair < string, string > ("IOW", "Isle of Wight"),
            new KeyValuePair < string, string > ("ISL", "Islington"),
            new KeyValuePair < string, string > ("IVC", "Inverclyde"),
            new KeyValuePair < string, string > ("KEC", "Kensington and Chelsea"),
            new KeyValuePair < string, string > ("KEN", "Kent"),
            new KeyValuePair < string, string > ("KHL", "Kingston upon Hull, City of"),
            new KeyValuePair < string, string > ("KIR", "Kirklees"),
            new KeyValuePair < string, string > ("KTT", "Kingston upon Thames"),
            new KeyValuePair < string, string > ("KWL", "Knowsley"),
            new KeyValuePair < string, string > ("LAN", "Lancashire"),
            new KeyValuePair < string, string > ("LBH", "Lambeth"),
            new KeyValuePair < string, string > ("LCE", "Leicester"),
            new KeyValuePair < string, string > ("LDS", "Leeds"),
            new KeyValuePair < string, string > ("LEC", "Leicestershire"),
            new KeyValuePair < string, string > ("LEW", "Lewisham"),
            new KeyValuePair < string, string > ("LIN", "Lincolnshire"),
            new KeyValuePair < string, string > ("LIV", "Liverpool"),
            new KeyValuePair < string, string > ("LMV", "Limavady"),
            new KeyValuePair < string, string > ("LND", "London, City of"),
            new KeyValuePair < string, string > ("LRN", "Larne"),
            new KeyValuePair < string, string > ("LSB", "Lisburn"),
            new KeyValuePair < string, string > ("LUT", "Luton"),
            new KeyValuePair < string, string > ("MAN", "Manchester"),
            new KeyValuePair < string, string > ("MDB", "Middlesbrough"),
            new KeyValuePair < string, string > ("MDW", "Medway"),
            new KeyValuePair < string, string > ("MFT", "Magherafelt"),
            new KeyValuePair < string, string > ("MIK", "Milton Keynes"),
            new KeyValuePair < string, string > ("MLN", "Midlothian"),
            new KeyValuePair < string, string > ("MON", "Monmouthshire [Sir Fynwy GB-FYN]"),
            new KeyValuePair < string, string > ("MRT", "Merton"),
            new KeyValuePair < string, string > ("MRY", "Moray"),
            new KeyValuePair < string, string > ("MTY", "Merthyr Tydfil [Merthyr Tudful GB-MTU]"),
            new KeyValuePair < string, string > ("MYL", "Moyle"),
            new KeyValuePair < string, string > ("NAY", "North Ayrshire"),
            new KeyValuePair < string, string > ("NBL", "Northumberland"),
            new KeyValuePair < string, string > ("NDN", "North Down"),
            new KeyValuePair < string, string > ("NEL", "North East Lincolnshire"),
            new KeyValuePair < string, string > ("NET", "Newcastle upon Tyne"),
            new KeyValuePair < string, string > ("NFK", "Norfolk"),
            new KeyValuePair < string, string > ("NGM", "Nottingham"),
            new KeyValuePair < string, string > ("NLK", "North Lanarkshire"),
            new KeyValuePair < string, string > ("NLN", "North Lincolnshire"),
            new KeyValuePair < string, string > ("NSM", "North Somerset"),
            new KeyValuePair < string, string > ("NTA", "Newtownabbey"),
            new KeyValuePair < string, string > ("NTH", "Northamptonshire"),
            new KeyValuePair < string, string > ("NTL", "Neath Port Talbot [Castell-nedd Port Talbot GB-CTL]"),
            new KeyValuePair < string, string > ("NTT", "Nottinghamshire"),
            new KeyValuePair < string, string > ("NTY", "North Tyneside"),
            new KeyValuePair < string, string > ("NWM", "Newham"),
            new KeyValuePair < string, string > ("NWP", "Newport [Casnewydd GB-CNW]"),
            new KeyValuePair < string, string > ("NYK", "North Yorkshire"),
            new KeyValuePair < string, string > ("NYM", "Newry and Mourne"),
            new KeyValuePair < string, string > ("OLD", "Oldham"),
            new KeyValuePair < string, string > ("OMH", "Omagh"),
            new KeyValuePair < string, string > ("ORK", "Orkney Islands"),
            new KeyValuePair < string, string > ("OXF", "Oxfordshire"),
            new KeyValuePair < string, string > ("PEM", "Pembrokeshire [Sir Benfro GB-BNF]"),
            new KeyValuePair < string, string > ("PKN", "Perth and Kinross"),
            new KeyValuePair < string, string > ("PLY", "Plymouth"),
            new KeyValuePair < string, string > ("POL", "Poole"),
            new KeyValuePair < string, string > ("POR", "Portsmouth"),
            new KeyValuePair < string, string > ("POW", "Powys"),
            new KeyValuePair < string, string > ("PTE", "Peterborough"),
            new KeyValuePair < string, string > ("RCC", "Redcar and Cleveland"),
            new KeyValuePair < string, string > ("RCH", "Rochdale"),
            new KeyValuePair < string, string > ("RCT", "Rhondda, Cynon, Taff [Rhondda, Cynon,Taf]"),
            new KeyValuePair < string, string > ("RDB", "Redbridge"),
            new KeyValuePair < string, string > ("RDG", "Reading"),
            new KeyValuePair < string, string > ("RFW", "Renfrewshire"),
            new KeyValuePair < string, string > ("RIC", "Richmond upon Thames"),
            new KeyValuePair < string, string > ("ROT", "Rotherham"),
            new KeyValuePair < string, string > ("RUT", "Rutland"),
            new KeyValuePair < string, string > ("SAW", "Sandwell"),
            new KeyValuePair < string, string > ("SAY", "South Ayrshire"),
            new KeyValuePair < string, string > ("SCB", "Scottish Borders, The"),
            new KeyValuePair < string, string > ("SFK", "Suffolk"),
            new KeyValuePair < string, string > ("SFT", "Sefton"),
            new KeyValuePair < string, string > ("SGC", "South Gloucestershire"),
            new KeyValuePair < string, string > ("SHF", "Sheffield"),
            new KeyValuePair < string, string > ("SHN", "St. Helens"),
            new KeyValuePair < string, string > ("SHR", "Shropshire"),
            new KeyValuePair < string, string > ("SKP", "Stockport"),
            new KeyValuePair < string, string > ("SLF", "Salford"),
            new KeyValuePair < string, string > ("SLG", "Slough"),
            new KeyValuePair < string, string > ("SLK", "South Lanarkshire"),
            new KeyValuePair < string, string > ("SND", "Sunderland"),
            new KeyValuePair < string, string > ("SOL", "Solihull"),
            new KeyValuePair < string, string > ("SOM", "Somerset"),
            new KeyValuePair < string, string > ("SOS", "Southend-on-Sea"),
            new KeyValuePair < string, string > ("SRY", "Surrey"),
            new KeyValuePair < string, string > ("STB", "Strabane"),
            new KeyValuePair < string, string > ("STE", "Stoke-on-Trent"),
            new KeyValuePair < string, string > ("STG", "Stirling"),
            new KeyValuePair < string, string > ("STH", "Southampton"),
            new KeyValuePair < string, string > ("STN", "Sutton"),
            new KeyValuePair < string, string > ("STS", "Staffordshire"),
            new KeyValuePair < string, string > ("STT", "Stockton-on-Tees"),
            new KeyValuePair < string, string > ("STY", "South Tyneside"),
            new KeyValuePair < string, string > ("SWA", "Swansea [Abertawe GB-ATA]"),
            new KeyValuePair < string, string > ("SWD", "Swindon"),
            new KeyValuePair < string, string > ("SWK", "Southwark"),
            new KeyValuePair < string, string > ("TAM", "Tameside"),
            new KeyValuePair < string, string > ("TFW", "Telford and Wrekin"),
            new KeyValuePair < string, string > ("THR", "Thurrock"),
            new KeyValuePair < string, string > ("TOB", "Torbay"),
            new KeyValuePair < string, string > ("TOF", "Torfaen [Tor-faen]"),
            new KeyValuePair < string, string > ("TRF", "Trafford"),
            new KeyValuePair < string, string > ("TWH", "Tower Hamlets"),
            new KeyValuePair < string, string > ("VGL", "Vale of Glamorgan, The [Bro Morgannwg GB-BMG]"),
            new KeyValuePair < string, string > ("WAR", "Warwickshire"),
            new KeyValuePair < string, string > ("WBK", "West Berkshire"),
            new KeyValuePair < string, string > ("WDU", "West Dunbartonshire"),
            new KeyValuePair < string, string > ("WFT", "Waltham Forest"),
            new KeyValuePair < string, string > ("WGN", "Wigan"),
            new KeyValuePair < string, string > ("WIL", "Wiltshire"),
            new KeyValuePair < string, string > ("WKF", "Wakefield"),
            new KeyValuePair < string, string > ("WLL", "Walsall"),
            new KeyValuePair < string, string > ("WLN", "West Lothian"),
            new KeyValuePair < string, string > ("WLV", "Wolverhampton"),
            new KeyValuePair < string, string > ("WND", "Wandsworth"),
            new KeyValuePair < string, string > ("WNM", "Windsor and Maidenhead"),
            new KeyValuePair < string, string > ("WOK", "Wokingham"),
            new KeyValuePair < string, string > ("WOR", "Worcestershire"),
            new KeyValuePair < string, string > ("WRL", "Wirral"),
            new KeyValuePair < string, string > ("WRT", "Warrington"),
            new KeyValuePair < string, string > ("WRX", "Wrexham [Wrecsam GB-WRC]"),
            new KeyValuePair < string, string > ("WSM", "Westminster"),
            new KeyValuePair < string, string > ("WSX", "West Sussex"),
            new KeyValuePair < string, string > ("YOR", "York"),
            new KeyValuePair < string, string > ("ZET", "Shetland Islands")
        };
            public static List<KeyValuePair<string, string>> provincesARE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AJ", "'Ajman"),
            new KeyValuePair < string, string > ("AZ", "Abu &#x0224;aby[Abu Dhabi]"),
            new KeyValuePair < string, string > ("DU", "Dubayy [Dubai]"),
            new KeyValuePair < string, string > ("FU", "Al Fujayrah"),
            new KeyValuePair < string, string > ("RK", "Ra's al Khaymah"),
            new KeyValuePair < string, string > ("SH", "Ash Shariqah [Sharjah]"),
            new KeyValuePair < string, string > ("UQ", "Umm al Qaywayn")
        };
            public static List<KeyValuePair<string, string>> provincesUKR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("05", "Vinnyts'ka Oblast'"),
            new KeyValuePair < string, string > ("07", "Volyns'ka Oblast'"),
            new KeyValuePair < string, string > ("09", "Luhans'ka Oblast'"),
            new KeyValuePair < string, string > ("12", "Dnipropetrovs'ka Oblast'"),
            new KeyValuePair < string, string > ("14", "Donets'ka Oblast'"),
            new KeyValuePair < string, string > ("18", "Zhytomyrs'ka Oblast'"),
            new KeyValuePair < string, string > ("21", "Zakarpats'ka Oblast'"),
            new KeyValuePair < string, string > ("23", "Zaporiz'ka Oblast'"),
            new KeyValuePair < string, string > ("26", "Ivano-Frankivs'ka Oblast'"),
            new KeyValuePair < string, string > ("30", "Kyiv"),
            new KeyValuePair < string, string > ("32", "Kylvs'ka Oblast'"),
            new KeyValuePair < string, string > ("35", "Kirovohrads'ka Oblast'"),
            new KeyValuePair < string, string > ("40", "Sevastopol'"),
            new KeyValuePair < string, string > ("46", "L'vivs'ka Oblast'"),
            new KeyValuePair < string, string > ("48", "Mykolaivs'ka Oblast'"),
            new KeyValuePair < string, string > ("51", "Odes'ka Oblast'"),
            new KeyValuePair < string, string > ("53", "Poltavs'ka Oblast'"),
            new KeyValuePair < string, string > ("56", "Rivnens'ka Oblast'"),
            new KeyValuePair < string, string > ("59", "Sums'ka Oblast'"),
            new KeyValuePair < string, string > ("61", "Ternopil's'ka Oblast'"),
            new KeyValuePair < string, string > ("63", "Kharkivs'ka Oblast'"),
            new KeyValuePair < string, string > ("68", "Khmel'nyts'ka Oblast'"),
            new KeyValuePair < string, string > ("71", "Cherkas'ka Oblast'"),
            new KeyValuePair < string, string > ("74", "Chernihivs'ka Oblast'"),
            new KeyValuePair < string, string > ("77", "Chernivets'ka Oblast'"),
            new KeyValuePair < string, string > ("43", "Respublika Krym")
        };
            public static List<KeyValuePair<string, string>> provincesUGA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("101", "Kalangala"),
            new KeyValuePair < string, string > ("102", "Kampala"),
            new KeyValuePair < string, string > ("103", "Kiboga"),
            new KeyValuePair < string, string > ("104", "Luwero"),
            new KeyValuePair < string, string > ("105", "Masaka"),
            new KeyValuePair < string, string > ("106", "Mpigi"),
            new KeyValuePair < string, string > ("107", "Mubende"),
            new KeyValuePair < string, string > ("108", "Mukono"),
            new KeyValuePair < string, string > ("109", "Nakasongola"),
            new KeyValuePair < string, string > ("110", "Rakai"),
            new KeyValuePair < string, string > ("111", "Sembabule"),
            new KeyValuePair < string, string > ("112", "Kayunga"),
            new KeyValuePair < string, string > ("113", "Wakiso"),
            new KeyValuePair < string, string > ("114", "Mityana"),
            new KeyValuePair < string, string > ("115", "Nakaseke"),
            new KeyValuePair < string, string > ("116", "Lyantonde"),
            new KeyValuePair < string, string > ("201", "Bugiri"),
            new KeyValuePair < string, string > ("202", "Busia"),
            new KeyValuePair < string, string > ("203", "Iganga"),
            new KeyValuePair < string, string > ("204", "Jinja"),
            new KeyValuePair < string, string > ("205", "Kamuli"),
            new KeyValuePair < string, string > ("206", "Kapchorwa"),
            new KeyValuePair < string, string > ("207", "Katakwi"),
            new KeyValuePair < string, string > ("208", "Kumi"),
            new KeyValuePair < string, string > ("209", "Mbale"),
            new KeyValuePair < string, string > ("210", "Pallisa"),
            new KeyValuePair < string, string > ("211", "Soroti"),
            new KeyValuePair < string, string > ("212", "Tororo"),
            new KeyValuePair < string, string > ("213", "Kaberamaido"),
            new KeyValuePair < string, string > ("214", "Mayuge"),
            new KeyValuePair < string, string > ("215", "Sironko"),
            new KeyValuePair < string, string > ("216", "Amuria"),
            new KeyValuePair < string, string > ("217", "Budaka"),
            new KeyValuePair < string, string > ("218", "Bukwa"),
            new KeyValuePair < string, string > ("219", "Butaleja"),
            new KeyValuePair < string, string > ("220", "Kaliro"),
            new KeyValuePair < string, string > ("221", "Manafwa"),
            new KeyValuePair < string, string > ("222", "Namutumba"),
            new KeyValuePair < string, string > ("223", "Bududa"),
            new KeyValuePair < string, string > ("224", "Bukedea"),
            new KeyValuePair < string, string > ("301", "Adjumani"),
            new KeyValuePair < string, string > ("302", "Apac"),
            new KeyValuePair < string, string > ("303", "Arua"),
            new KeyValuePair < string, string > ("304", "Gulu"),
            new KeyValuePair < string, string > ("305", "Kitgum"),
            new KeyValuePair < string, string > ("306", "Kotido"),
            new KeyValuePair < string, string > ("307", "Lira"),
            new KeyValuePair < string, string > ("308", "Moroto"),
            new KeyValuePair < string, string > ("309", "Moyo"),
            new KeyValuePair < string, string > ("310", "Nebbi"),
            new KeyValuePair < string, string > ("311", "Nakapiripirit"),
            new KeyValuePair < string, string > ("312", "Pader"),
            new KeyValuePair < string, string > ("313", "Yumbe"),
            new KeyValuePair < string, string > ("314", "Amolatar"),
            new KeyValuePair < string, string > ("315", "Kaabong"),
            new KeyValuePair < string, string > ("316", "Koboko"),
            new KeyValuePair < string, string > ("317", "Abim"),
            new KeyValuePair < string, string > ("318", "Dokolo"),
            new KeyValuePair < string, string > ("319", "Amuru"),
            new KeyValuePair < string, string > ("320", "Maracha"),
            new KeyValuePair < string, string > ("321", "Oyam"),
            new KeyValuePair < string, string > ("401", "Bundibugyo"),
            new KeyValuePair < string, string > ("402", "Bushenyi"),
            new KeyValuePair < string, string > ("403", "Hoima"),
            new KeyValuePair < string, string > ("404", "Kabale"),
            new KeyValuePair < string, string > ("405", "Kabarole"),
            new KeyValuePair < string, string > ("406", "Kasese"),
            new KeyValuePair < string, string > ("407", "Kibaale"),
            new KeyValuePair < string, string > ("408", "Kisoro"),
            new KeyValuePair < string, string > ("409", "Masindi"),
            new KeyValuePair < string, string > ("410", "Mbarara"),
            new KeyValuePair < string, string > ("411", "Ntungamo"),
            new KeyValuePair < string, string > ("412", "Rukungiri"),
            new KeyValuePair < string, string > ("413", "Kamwenge"),
            new KeyValuePair < string, string > ("414", "Kanungu"),
            new KeyValuePair < string, string > ("415", "Kyenjojo"),
            new KeyValuePair < string, string > ("416", "Ibanda"),
            new KeyValuePair < string, string > ("417", "Isingiro"),
            new KeyValuePair < string, string > ("418", "Kiruhura"),
            new KeyValuePair < string, string > ("419", "Buliisa"),
            new KeyValuePair < string, string > ("C", "Central"),
            new KeyValuePair < string, string > ("E", "Eastern"),
            new KeyValuePair < string, string > ("N", "Northern"),
            new KeyValuePair < string, string > ("W", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesTUV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("FUN", "Funafuti"),
            new KeyValuePair < string, string > ("NIT", "Niutao"),
            new KeyValuePair < string, string > ("NIU", "Nui"),
            new KeyValuePair < string, string > ("NKF", "Nukufetau"),
            new KeyValuePair < string, string > ("NKL", "Nukulaelae"),
            new KeyValuePair < string, string > ("NMA", "Nanumea"),
            new KeyValuePair < string, string > ("NMG", "Nanumanga"),
            new KeyValuePair < string, string > ("VAI", "Vaitupu")
        };
            public static List<KeyValuePair<string, string>> provincesTKM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Ahal"),
            new KeyValuePair < string, string > ("B", "Balkan"),
            new KeyValuePair < string, string > ("D", "Dasoguz"),
            new KeyValuePair < string, string > ("L", "Lebap"),
            new KeyValuePair < string, string > ("M", "Mary"),
            new KeyValuePair < string, string > ("S", "Asgabat")
        };
            public static List<KeyValuePair<string, string>> provincesTUR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Adana"),
            new KeyValuePair < string, string > ("02", "Adiyaman"),
            new KeyValuePair < string, string > ("03", "Afyon"),
            new KeyValuePair < string, string > ("04", "Agri"),
            new KeyValuePair < string, string > ("05", "Amasya"),
            new KeyValuePair < string, string > ("06", "Ankara"),
            new KeyValuePair < string, string > ("07", "Antalya"),
            new KeyValuePair < string, string > ("08", "Artvin"),
            new KeyValuePair < string, string > ("09", "Aydin"),
            new KeyValuePair < string, string > ("10", "Balikesir"),
            new KeyValuePair < string, string > ("11", "Bilecik"),
            new KeyValuePair < string, string > ("12", "Bingöl"),
            new KeyValuePair < string, string > ("13", "Bitlis"),
            new KeyValuePair < string, string > ("14", "Bolu"),
            new KeyValuePair < string, string > ("15", "Burdur"),
            new KeyValuePair < string, string > ("16", "Bursa"),
            new KeyValuePair < string, string > ("17", "canakkale"),
            new KeyValuePair < string, string > ("18", "cankiri"),
            new KeyValuePair < string, string > ("19", "corum"),
            new KeyValuePair < string, string > ("20", "Denizli"),
            new KeyValuePair < string, string > ("21", "Diyarbakir"),
            new KeyValuePair < string, string > ("22", "Edirne"),
            new KeyValuePair < string, string > ("23", "Elazig"),
            new KeyValuePair < string, string > ("24", "Erzincan"),
            new KeyValuePair < string, string > ("25", "Erzurum"),
            new KeyValuePair < string, string > ("26", "Eskisehir"),
            new KeyValuePair < string, string > ("27", "Gaziantep"),
            new KeyValuePair < string, string > ("28", "Giresun"),
            new KeyValuePair < string, string > ("29", "Gumushane"),
            new KeyValuePair < string, string > ("30", "Hakkari"),
            new KeyValuePair < string, string > ("31", "Hatay"),
            new KeyValuePair < string, string > ("32", "Isparta"),
            new KeyValuePair < string, string > ("33", "Icel"),
            new KeyValuePair < string, string > ("34", "Istanbul"),
            new KeyValuePair < string, string > ("35", "Izmir"),
            new KeyValuePair < string, string > ("36", "Kars"),
            new KeyValuePair < string, string > ("37", "Kastamonu"),
            new KeyValuePair < string, string > ("38", "Kayseri"),
            new KeyValuePair < string, string > ("39", "Kirklareli"),
            new KeyValuePair < string, string > ("40", "Kirsehir"),
            new KeyValuePair < string, string > ("41", "Kocaeli"),
            new KeyValuePair < string, string > ("42", "Konya"),
            new KeyValuePair < string, string > ("43", "Kutahya"),
            new KeyValuePair < string, string > ("44", "Malatya"),
            new KeyValuePair < string, string > ("45", "Manisa"),
            new KeyValuePair < string, string > ("46", "Kahramanmaras"),
            new KeyValuePair < string, string > ("47", "Mardin"),
            new KeyValuePair < string, string > ("48", "Mugla"),
            new KeyValuePair < string, string > ("49", "Mus"),
            new KeyValuePair < string, string > ("50", "Nevsehir"),
            new KeyValuePair < string, string > ("51", "Nigde"),
            new KeyValuePair < string, string > ("52", "Ordu"),
            new KeyValuePair < string, string > ("53", "Rize"),
            new KeyValuePair < string, string > ("54", "Sakarya"),
            new KeyValuePair < string, string > ("55", "Samsun"),
            new KeyValuePair < string, string > ("56", "Siirt"),
            new KeyValuePair < string, string > ("57", "Sinop"),
            new KeyValuePair < string, string > ("58", "Sivas"),
            new KeyValuePair < string, string > ("59", "Tekirdag"),
            new KeyValuePair < string, string > ("60", "Tokat"),
            new KeyValuePair < string, string > ("61", "Trabzon"),
            new KeyValuePair < string, string > ("62", "Tunceli"),
            new KeyValuePair < string, string > ("63", "sanliurfa"),
            new KeyValuePair < string, string > ("64", "Usak"),
            new KeyValuePair < string, string > ("65", "Van"),
            new KeyValuePair < string, string > ("66", "Yozgat"),
            new KeyValuePair < string, string > ("67", "Zonguldak"),
            new KeyValuePair < string, string > ("68", "Aksaray"),
            new KeyValuePair < string, string > ("69", "Bayburt"),
            new KeyValuePair < string, string > ("70", "Karaman"),
            new KeyValuePair < string, string > ("71", "Kirkkale"),
            new KeyValuePair < string, string > ("72", "Batman"),
            new KeyValuePair < string, string > ("73", "sirnak"),
            new KeyValuePair < string, string > ("74", "Bartin"),
            new KeyValuePair < string, string > ("75", "Ardahan"),
            new KeyValuePair < string, string > ("76", "Igdir"),
            new KeyValuePair < string, string > ("77", "Yalova"),
            new KeyValuePair < string, string > ("78", "Karabuk"),
            new KeyValuePair < string, string > ("79", "Kilis"),
            new KeyValuePair < string, string > ("80", "Osmaniye"),
            new KeyValuePair < string, string > ("81", "Duzce")
        };
            public static List<KeyValuePair<string, string>> provincesTUN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("11", "Tunis"),
            new KeyValuePair < string, string > ("12", "L'Ariana"),
            new KeyValuePair < string, string > ("13", "Ben Arous"),
            new KeyValuePair < string, string > ("14", "La Manouba"),
            new KeyValuePair < string, string > ("21", "Nabeul"),
            new KeyValuePair < string, string > ("22", "Zaghouan"),
            new KeyValuePair < string, string > ("23", "Bizerte"),
            new KeyValuePair < string, string > ("31", "Beja"),
            new KeyValuePair < string, string > ("32", "Jendouba"),
            new KeyValuePair < string, string > ("33", "Le Kef"),
            new KeyValuePair < string, string > ("34", "Siliana"),
            new KeyValuePair < string, string > ("41", "Kairouan"),
            new KeyValuePair < string, string > ("42", "Kasserine"),
            new KeyValuePair < string, string > ("43", "Sidi Bouzid"),
            new KeyValuePair < string, string > ("51", "Sousse"),
            new KeyValuePair < string, string > ("52", "Monastir"),
            new KeyValuePair < string, string > ("53", "Mahdia"),
            new KeyValuePair < string, string > ("61", "Sfax"),
            new KeyValuePair < string, string > ("71", "Gafsa"),
            new KeyValuePair < string, string > ("72", "Tozeur"),
            new KeyValuePair < string, string > ("73", "Kebili"),
            new KeyValuePair < string, string > ("81", "Gabes"),
            new KeyValuePair < string, string > ("82", "Medenine"),
            new KeyValuePair < string, string > ("83", "Tataouine")
        };
            public static List<KeyValuePair<string, string>> provincesTTO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("ARI", "Arima"),
            new KeyValuePair < string, string > ("CHA", "Chaguanas"),
            new KeyValuePair < string, string > ("CTT", "Couva-Tabaquite-Talparo"),
            new KeyValuePair < string, string > ("DMN", "Diego Martin"),
            new KeyValuePair < string, string > ("ETO", "Eastern Tobago"),
            new KeyValuePair < string, string > ("PED", "Penal-Debe"),
            new KeyValuePair < string, string > ("POS", "Port of Spain"),
            new KeyValuePair < string, string > ("PRT", "Princes Town"),
            new KeyValuePair < string, string > ("PTF", "Point Fortin"),
            new KeyValuePair < string, string > ("RCM", "Rio Claro-Mayaro"),
            new KeyValuePair < string, string > ("SFO", "San Fernando"),
            new KeyValuePair < string, string > ("SGE", "Sangre Grande"),
            new KeyValuePair < string, string > ("SIP", "Siparia"),
            new KeyValuePair < string, string > ("SJL", "San Juan-Laventille"),
            new KeyValuePair < string, string > ("TUP", "Tunapuna-Piarco"),
            new KeyValuePair < string, string > ("WTO", "Western Tobago")
        };
            public static List<KeyValuePair<string, string>> provincesTHA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("10", "Krung Thep Maha Nakhon [Bangkok]"),
            new KeyValuePair < string, string > ("11", "Samut Prakan"),
            new KeyValuePair < string, string > ("12", "Nonthaburi"),
            new KeyValuePair < string, string > ("13", "Pathum Thani"),
            new KeyValuePair < string, string > ("14", "Phra Nakhon Si Ayutthaya"),
            new KeyValuePair < string, string > ("15", "Ang Thong"),
            new KeyValuePair < string, string > ("16", "Lop Buri"),
            new KeyValuePair < string, string > ("17", "Sing Buri"),
            new KeyValuePair < string, string > ("18", "Chai Nat"),
            new KeyValuePair < string, string > ("19", "Saraburi"),
            new KeyValuePair < string, string > ("20", "Chon Buri"),
            new KeyValuePair < string, string > ("21", "Rayong"),
            new KeyValuePair < string, string > ("22", "Chanthaburi"),
            new KeyValuePair < string, string > ("23", "Trat"),
            new KeyValuePair < string, string > ("24", "Chachoengsao"),
            new KeyValuePair < string, string > ("25", "Prachin Buri"),
            new KeyValuePair < string, string > ("26", "Nakhon Nayok"),
            new KeyValuePair < string, string > ("27", "Sa Kaeo"),
            new KeyValuePair < string, string > ("30", "Nakhon Ratchasima"),
            new KeyValuePair < string, string > ("31", "Buri Ram"),
            new KeyValuePair < string, string > ("32", "Surin"),
            new KeyValuePair < string, string > ("33", "Si Sa Ket"),
            new KeyValuePair < string, string > ("34", "Ubon Ratchathani"),
            new KeyValuePair < string, string > ("35", "Yasothon"),
            new KeyValuePair < string, string > ("36", "Chaiyaphum"),
            new KeyValuePair < string, string > ("37", "Amnat Charoen"),
            new KeyValuePair < string, string > ("39", "Nong Bua Lam Phu"),
            new KeyValuePair < string, string > ("40", "Khon Kaen"),
            new KeyValuePair < string, string > ("41", "Udon Thani"),
            new KeyValuePair < string, string > ("42", "Loei"),
            new KeyValuePair < string, string > ("43", "Nong Khai"),
            new KeyValuePair < string, string > ("44", "Maha Sarakham"),
            new KeyValuePair < string, string > ("45", "Roi Et"),
            new KeyValuePair < string, string > ("46", "Kalasin"),
            new KeyValuePair < string, string > ("47", "Sakon Nakhon"),
            new KeyValuePair < string, string > ("48", "Nakhon Phanom"),
            new KeyValuePair < string, string > ("49", "Mukdahan"),
            new KeyValuePair < string, string > ("50", "Chiang Mai"),
            new KeyValuePair < string, string > ("51", "Lamphun"),
            new KeyValuePair < string, string > ("52", "Lampang"),
            new KeyValuePair < string, string > ("53", "Uttaradit"),
            new KeyValuePair < string, string > ("54", "Phrae"),
            new KeyValuePair < string, string > ("55", "Nan"),
            new KeyValuePair < string, string > ("56", "Phayao"),
            new KeyValuePair < string, string > ("57", "Chiang Rai"),
            new KeyValuePair < string, string > ("58", "Mae Hong Son"),
            new KeyValuePair < string, string > ("60", "Nakhon Sawan"),
            new KeyValuePair < string, string > ("61", "Uthai Thani"),
            new KeyValuePair < string, string > ("62", "Kamphaeng Phet"),
            new KeyValuePair < string, string > ("63", "Tak"),
            new KeyValuePair < string, string > ("64", "Sukhothai"),
            new KeyValuePair < string, string > ("65", "Phitsanulok"),
            new KeyValuePair < string, string > ("66", "Phichit"),
            new KeyValuePair < string, string > ("67", "Phetchabun"),
            new KeyValuePair < string, string > ("70", "Ratchaburi"),
            new KeyValuePair < string, string > ("71", "Kanchanaburi"),
            new KeyValuePair < string, string > ("72", "Suphan Buri"),
            new KeyValuePair < string, string > ("73", "Nakhon Pathom"),
            new KeyValuePair < string, string > ("74", "Samut Sakhon"),
            new KeyValuePair < string, string > ("75", "Samut Songkhram"),
            new KeyValuePair < string, string > ("76", "Phetchaburi"),
            new KeyValuePair < string, string > ("77", "Prachuap Khiri Khan"),
            new KeyValuePair < string, string > ("80", "Nakhon Si Thammarat"),
            new KeyValuePair < string, string > ("81", "Krabi"),
            new KeyValuePair < string, string > ("82", "Phangnga"),
            new KeyValuePair < string, string > ("83", "Phuket"),
            new KeyValuePair < string, string > ("84", "Surat Thani"),
            new KeyValuePair < string, string > ("85", "Ranong"),
            new KeyValuePair < string, string > ("86", "Chumphon"),
            new KeyValuePair < string, string > ("90", "Songkhla"),
            new KeyValuePair < string, string > ("91", "Satun"),
            new KeyValuePair < string, string > ("92", "Trang"),
            new KeyValuePair < string, string > ("93", "Phatthalung"),
            new KeyValuePair < string, string > ("94", "Pattani"),
            new KeyValuePair < string, string > ("95", "Yala"),
            new KeyValuePair < string, string > ("96", "Narathiwat"),
            new KeyValuePair < string, string > ("S ", "Phatthaya")
        };
            public static List<KeyValuePair<string, string>> provincesTZA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Arusha"),
            new KeyValuePair < string, string > ("02", "Dar es Salaam"),
            new KeyValuePair < string, string > ("03", "Dodoma"),
            new KeyValuePair < string, string > ("04", "Iringa"),
            new KeyValuePair < string, string > ("05", "Kagera"),
            new KeyValuePair < string, string > ("06", "Kaskazini Pemba"),
            new KeyValuePair < string, string > ("07", "Kaskazini Unguja"),
            new KeyValuePair < string, string > ("08", "Kigoma"),
            new KeyValuePair < string, string > ("09", "Kilimanjaro"),
            new KeyValuePair < string, string > ("10", "Kusini Pemba"),
            new KeyValuePair < string, string > ("11", "Kusini Unguja"),
            new KeyValuePair < string, string > ("12", "Lindi"),
            new KeyValuePair < string, string > ("13", "Mara"),
            new KeyValuePair < string, string > ("14", "Mbeya"),
            new KeyValuePair < string, string > ("15", "Mjini Magharibi"),
            new KeyValuePair < string, string > ("16", "Morogoro"),
            new KeyValuePair < string, string > ("17", "Mtwara"),
            new KeyValuePair < string, string > ("18", "Mwanza"),
            new KeyValuePair < string, string > ("19", "Pwani"),
            new KeyValuePair < string, string > ("20", "Rukwa"),
            new KeyValuePair < string, string > ("21", "Ruvuma"),
            new KeyValuePair < string, string > ("22", "Shinyanga"),
            new KeyValuePair < string, string > ("23", "Singida"),
            new KeyValuePair < string, string > ("24", "Tabora"),
            new KeyValuePair < string, string > ("25", "Tanga"),
            new KeyValuePair < string, string > ("26", "Manyara")
        };
            public static List<KeyValuePair<string, string>> provincesTJK = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("GB", "Gorno-Badakhshan"),
            new KeyValuePair < string, string > ("KT", "Khatlon"),
            new KeyValuePair < string, string > ("SU", "Sughd")
        };
            public static List<KeyValuePair<string, string>> provincesTWN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CHA", "Changhua"),
            new KeyValuePair < string, string > ("CYQ", "Chiayi"),
            new KeyValuePair < string, string > ("HSZQ", "Hsinchu"),
            new KeyValuePair < string, string > ("HUA", "Hualien"),
            new KeyValuePair < string, string > ("ILA", "Ilan"),
            new KeyValuePair < string, string > ("KHQ", "Kaohsiung"),
            new KeyValuePair < string, string > ("MIA", "Miaoli"),
            new KeyValuePair < string, string > ("NAN", "Nantou"),
            new KeyValuePair < string, string > ("PEN", "Penghu"),
            new KeyValuePair < string, string > ("PIF", "Pingtung"),
            new KeyValuePair < string, string > ("TAO", "Taoyuan"),
            new KeyValuePair < string, string > ("TNQ", "Tainan"),
            new KeyValuePair < string, string > ("TPQ", "Taipei"),
            new KeyValuePair < string, string > ("TTT", "Taitung"),
            new KeyValuePair < string, string > ("TXQ", "Taichung"),
            new KeyValuePair < string, string > ("YUN", "Yunlin"),
            new KeyValuePair < string, string > ("CYI", "Chiayi"),
            new KeyValuePair < string, string > ("HSZ", "Hsinchu"),
            new KeyValuePair < string, string > ("KEE", "Keelung"),
            new KeyValuePair < string, string > ("TNN", "Tainan"),
            new KeyValuePair < string, string > ("TXG", "Taichung"),
            new KeyValuePair < string, string > ("KHH", "Kaohsiung"),
            new KeyValuePair < string, string > ("TPE", "Taipei")
        };
            public static List<KeyValuePair<string, string>> provincesSYR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DI", "Dimashq"),
            new KeyValuePair < string, string > ("DR", "Dar'a"),
            new KeyValuePair < string, string > ("DY", "Dayr az Zawr"),
            new KeyValuePair < string, string > ("HA", "Al Ḩasakah"),
            new KeyValuePair < string, string > ("HI", "Ḩims"),
            new KeyValuePair < string, string > ("HL", "Ḩalab"),
            new KeyValuePair < string, string > ("HM", "Ḩamah"),
            new KeyValuePair < string, string > ("ID", "Idlib"),
            new KeyValuePair < string, string > ("LA", "Al Ladhiqiyah"),
            new KeyValuePair < string, string > ("Qu", "Al Qunaytirah"),
            new KeyValuePair < string, string > ("RA", "Ar Raqqah"),
            new KeyValuePair < string, string > ("RD", "Rif Dimashq"),
            new KeyValuePair < string, string > ("SU", "As Suwayda'"),
            new KeyValuePair < string, string > ("TA", "tartus")
        };
            public static List<KeyValuePair<string, string>> provincesCHE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AG", "Aargau (de)"),
            new KeyValuePair < string, string > ("AI", "Appenzell Innerrhoden (de)"),
            new KeyValuePair < string, string > ("AR", "Appenzell Ausserrhoden (de)"),
            new KeyValuePair < string, string > ("BE", "Bern (de)"),
            new KeyValuePair < string, string > ("BL", "Basel-Landschaft (de)"),
            new KeyValuePair < string, string > ("BS", "Basel-Stadt (de)"),
            new KeyValuePair < string, string > ("FR", "Fribourg (fr)"),
            new KeyValuePair < string, string > ("GE", "Geneve (fr)"),
            new KeyValuePair < string, string > ("GL", "Glarus (de)"),
            new KeyValuePair < string, string > ("GR", "Graubunden (de)"),
            new KeyValuePair < string, string > ("JU", "Jura (fr)"),
            new KeyValuePair < string, string > ("LU", "Luzern (de)"),
            new KeyValuePair < string, string > ("NE", "Neuch&#226;tel (fr)"),
            new KeyValuePair < string, string > ("NW", "Nidwalden (de)"),
            new KeyValuePair < string, string > ("OW", "Obwalden (de)"),
            new KeyValuePair < string, string > ("SG", "Sankt Gallen (de)"),
            new KeyValuePair < string, string > ("SH", "Schaffhausen (de)"),
            new KeyValuePair < string, string > ("SO", "Solothurn (de)"),
            new KeyValuePair < string, string > ("SZ", "Schwyz (de)"),
            new KeyValuePair < string, string > ("TG", "Thurgau (de)"),
            new KeyValuePair < string, string > ("TI", "Ticino (it)"),
            new KeyValuePair < string, string > ("UR", "Uri (de)"),
            new KeyValuePair < string, string > ("VD", "Vaud (fr)"),
            new KeyValuePair < string, string > ("VS", "Valais (fr)"),
            new KeyValuePair < string, string > ("ZG", "Zug (de)"),
            new KeyValuePair < string, string > ("ZH", "Zurich (de)")
        };
            public static List<KeyValuePair<string, string>> provincesSWE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AB", "Stockholms lan]"),
            new KeyValuePair < string, string > ("AC", "Vasterbottens lan"),
            new KeyValuePair < string, string > ("BD", "Norrbottens lan"),
            new KeyValuePair < string, string > ("C", "Uppsala lan"),
            new KeyValuePair < string, string > ("D", "Sodermanlands lan"),
            new KeyValuePair < string, string > ("E", "&#214;stergotlands lan"),
            new KeyValuePair < string, string > ("F", "Jonkopings lan"),
            new KeyValuePair < string, string > ("G", "Kronoborgs lan"),
            new KeyValuePair < string, string > ("H", "Kalmar lan"),
            new KeyValuePair < string, string > ("I", "Gotlands lan"),
            new KeyValuePair < string, string > ("K", "Blekinge lan"),
            new KeyValuePair < string, string > ("M", "Sk&#229;ne lan"),
            new KeyValuePair < string, string > ("N", "Hallands lan"),
            new KeyValuePair < string, string > ("O", "Vastra Gotalands lan"),
            new KeyValuePair < string, string > ("S", "Varmlands lan"),
            new KeyValuePair < string, string > ("T", "&#214;rebro lan"),
            new KeyValuePair < string, string > ("U", "Vastmanlands lan"),
            new KeyValuePair < string, string > ("W", "Dalarnes lan["),
            new KeyValuePair < string, string > ("X", "Gavleborgs lan"),
            new KeyValuePair < string, string > ("Y", "Vasternorrlands lan"),
            new KeyValuePair < string, string > ("Z", "Jamtlands lan")
        };
            public static List<KeyValuePair<string, string>> provincesSUR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BR", "Brokopondo"),
            new KeyValuePair < string, string > ("CM", "Commewijne"),
            new KeyValuePair < string, string > ("CR", "Coronie"),
            new KeyValuePair < string, string > ("MA", "Marowijne"),
            new KeyValuePair < string, string > ("NI", "Nickerie"),
            new KeyValuePair < string, string > ("PM", "Saramacca"),
            new KeyValuePair < string, string > ("PR", "Para"),
            new KeyValuePair < string, string > ("SA", "Saramacca"),
            new KeyValuePair < string, string > ("SI", "Sipaliwini"),
            new KeyValuePair < string, string > ("WA", "Wanica")
        };
            public static List<KeyValuePair<string, string>> provincesSDN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DC", "Central Darfur"),
            new KeyValuePair < string, string > ("DE", "East Darfur"),
            new KeyValuePair < string, string > ("DN", "North Darfur"),
            new KeyValuePair < string, string > ("DS", "South Darfur"),
            new KeyValuePair < string, string > ("DW", "West Darfur"),
            new KeyValuePair < string, string > ("GD", "Gedaref"),
            new KeyValuePair < string, string > ("GZ", "Gezira"),
            new KeyValuePair < string, string > ("KA", "Kassala"),
            new KeyValuePair < string, string > ("KH", "Khartoum"),
            new KeyValuePair < string, string > ("KN1", "North Kordofan"),
            new KeyValuePair < string, string > ("KS", "South Kordofan"),
            new KeyValuePair < string, string > ("NB", "Blue Nile"),
            new KeyValuePair < string, string > ("NO", "Northern"),
            new KeyValuePair < string, string > ("NR", "River Nile"),
            new KeyValuePair < string, string > ("NW", "White Nile"),
            new KeyValuePair < string, string > ("RS", "Red Sea"),
            new KeyValuePair < string, string > ("SI", "Sennar")
        };
            public static List<KeyValuePair<string, string>> provincesLKA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Basnahira paḷata"),
            new KeyValuePair < string, string > ("11", "Kŏḷamba"),
            new KeyValuePair < string, string > ("12", "Gampaha"),
            new KeyValuePair < string, string > ("13", "Kaḷutara"),
            new KeyValuePair < string, string > ("2", "Madhyama paḷata"),
            new KeyValuePair < string, string > ("21", "Mahanuvara"),
            new KeyValuePair < string, string > ("22", "Matale"),
            new KeyValuePair < string, string > ("23", "Nuvara Ĕliya"),
            new KeyValuePair < string, string > ("3", "Dakuṇu paḷata"),
            new KeyValuePair < string, string > ("31", "Galla"),
            new KeyValuePair < string, string > ("32", "Matara"),
            new KeyValuePair < string, string > ("33", "Hambantŏṭa"),
            new KeyValuePair < string, string > ("4", "Uturu paḷata"),
            new KeyValuePair < string, string > ("41", "Yapanaya"),
            new KeyValuePair < string, string > ("42", "Kilinŏchchi"),
            new KeyValuePair < string, string > ("43", "Mannarama"),
            new KeyValuePair < string, string > ("44", "Vavuniyava"),
            new KeyValuePair < string, string > ("45", "Mulativ"),
            new KeyValuePair < string, string > ("5", "Næ̆gĕnahira paḷata"),
            new KeyValuePair < string, string > ("51", "Maḍakalapuva"),
            new KeyValuePair < string, string > ("52", "Ampara"),
            new KeyValuePair < string, string > ("53", "Trikuṇamalaya"),
            new KeyValuePair < string, string > ("6", "Vayamba paḷata"),
            new KeyValuePair < string, string > ("61", "Kuruṇægala"),
            new KeyValuePair < string, string > ("62", "Puttalama"),
            new KeyValuePair < string, string > ("7", "Uturumæ̆da paḷata"),
            new KeyValuePair < string, string > ("71", "Anuradhapura"),
            new KeyValuePair < string, string > ("72", "Pŏḷŏnnaruva"),
            new KeyValuePair < string, string > ("8", "uva paḷata"),
            new KeyValuePair < string, string > ("81", "Badulla"),
            new KeyValuePair < string, string > ("82", "Mŏṇaragala"),
            new KeyValuePair < string, string > ("9", "Sabaragamuva paḷata"),
            new KeyValuePair < string, string > ("91", "Ratnapura"),
            new KeyValuePair < string, string > ("92", "Kægalla")
        };
            public static List<KeyValuePair<string, string>> provincesESP = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Alicante / Alacant"),
            new KeyValuePair < string, string > ("AB", "Albacete"),
            new KeyValuePair < string, string > ("AL", "Almeria"),
            new KeyValuePair < string, string > ("AV", "&#193;vila"),
            new KeyValuePair < string, string > ("B", "Barcelona [Barcelona]"),
            new KeyValuePair < string, string > ("BA", "Badajoz"),
            new KeyValuePair < string, string > ("BI", "Vizcaya / Biskaia"),
            new KeyValuePair < string, string > ("BU", "Burgos"),
            new KeyValuePair < string, string > ("C", "A Coru&#241;a [La Coru&#241;a]"),
            new KeyValuePair < string, string > ("CA", "Cadiz"),
            new KeyValuePair < string, string > ("CC", "Caceres"),
            new KeyValuePair < string, string > ("CE", "Ceuta"),
            new KeyValuePair < string, string > ("CO", "Cordoba"),
            new KeyValuePair < string, string > ("CR", "Ciudad Real"),
            new KeyValuePair < string, string > ("CS", "Castellon / Castello"),
            new KeyValuePair < string, string > ("CU", "Cuenca"),
            new KeyValuePair < string, string > ("GC", "Las Palmas"),
            new KeyValuePair < string, string > ("GI", "Girona [Gerona]"),
            new KeyValuePair < string, string > ("GR", "Granada"),
            new KeyValuePair < string, string > ("GU", "Guadalajara"),
            new KeyValuePair < string, string > ("H", "Huelva"),
            new KeyValuePair < string, string > ("HU", "Huesca"),
            new KeyValuePair < string, string > ("J", "Jaen"),
            new KeyValuePair < string, string > ("L", "Lleida [Lerida]"),
            new KeyValuePair < string, string > ("LE", "Leon"),
            new KeyValuePair < string, string > ("LO", "La Rioja"),
            new KeyValuePair < string, string > ("LU", "Lugo [Lugo]"),
            new KeyValuePair < string, string > ("M", "Madrid"),
            new KeyValuePair < string, string > ("MA", "Malaga"),
            new KeyValuePair < string, string > ("ML", "Melilla"),
            new KeyValuePair < string, string > ("MU", "Murcia"),
            new KeyValuePair < string, string > ("NA", "Navarra / Nafarroa"),
            new KeyValuePair < string, string > ("O", "Asturias"),
            new KeyValuePair < string, string > ("OR", "Ourense [Orense]"),
            new KeyValuePair < string, string > ("P", "Palencia"),
            new KeyValuePair < string, string > ("PM", "Balears [Baleares]"),
            new KeyValuePair < string, string > ("PO", "Pontevedra [Pontevedra]"),
            new KeyValuePair < string, string > ("S", "Cantabria"),
            new KeyValuePair < string, string > ("SA", "Salamanca"),
            new KeyValuePair < string, string > ("SE", "Sevilla"),
            new KeyValuePair < string, string > ("SG", "Segovia"),
            new KeyValuePair < string, string > ("SO", "Soria"),
            new KeyValuePair < string, string > ("SS", "Guip&#250;zcoa / Gipuzkoa"),
            new KeyValuePair < string, string > ("T", "Tarragona [Tarragona]"),
            new KeyValuePair < string, string > ("TE", "Teruel"),
            new KeyValuePair < string, string > ("TF", "Santa Cruz de Tenerife"),
            new KeyValuePair < string, string > ("TO", "Toledo"),
            new KeyValuePair < string, string > ("V", "Valencia / Valencia"),
            new KeyValuePair < string, string > ("VA", "Valladolid"),
            new KeyValuePair < string, string > ("VI", "&#193;lava / Araba"),
            new KeyValuePair < string, string > ("Z", "Zaragoza"),
            new KeyValuePair < string, string > ("ZA", "Zamora")
        };
            public static List<KeyValuePair<string, string>> provincesSSD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BN", "Northern Bahr el-Ghazal"),
            new KeyValuePair < string, string > ("BW", "Western Bahr el-Ghazal"),
            new KeyValuePair < string, string > ("EC", "Central Equatoria"),
            new KeyValuePair < string, string > ("EE", "Eastern Equatoria"),
            new KeyValuePair < string, string > ("EW", "Western Equatoria"),
            new KeyValuePair < string, string > ("JG", "Jonglei"),
            new KeyValuePair < string, string > ("LK", "Lakes"),
            new KeyValuePair < string, string > ("NU", "Upper Nile"),
            new KeyValuePair < string, string > ("UY", "Unity"),
            new KeyValuePair < string, string > ("WR", "Warrap")
        };
            public static List<KeyValuePair<string, string>> provincesZAF = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("EC", "Eastern Cape"),
            new KeyValuePair < string, string > ("FS", "Free State"),
            new KeyValuePair < string, string > ("GT", "Gauteng"),
            new KeyValuePair < string, string > ("LP", "Limpopo"),
            new KeyValuePair < string, string > ("MP", "Mpumalanga"),
            new KeyValuePair < string, string > ("NC", "Northern Cape"),
            new KeyValuePair < string, string > ("NL", "Kwazulu-Natal"),
            new KeyValuePair < string, string > ("NW", "North-West"),
            new KeyValuePair < string, string > ("WC", "Western Cape")
        };
            public static List<KeyValuePair<string, string>> provincesSOM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AW", "Awdal"),
            new KeyValuePair < string, string > ("BK", "Bakool"),
            new KeyValuePair < string, string > ("BN", "Banaadir"),
            new KeyValuePair < string, string > ("BR", "Bari"),
            new KeyValuePair < string, string > ("BY", "Bay"),
            new KeyValuePair < string, string > ("GA", "Galguduud"),
            new KeyValuePair < string, string > ("GE", "Gedo"),
            new KeyValuePair < string, string > ("HI", "Hiiraan"),
            new KeyValuePair < string, string > ("JD", "Jubbada Dhexe"),
            new KeyValuePair < string, string > ("JH", "Jubbada Hoose"),
            new KeyValuePair < string, string > ("MU", "Mudug"),
            new KeyValuePair < string, string > ("NU", "Nugaal"),
            new KeyValuePair < string, string > ("SA", "Sanaag"),
            new KeyValuePair < string, string > ("SD", "Shabeellaha Dhexe"),
            new KeyValuePair < string, string > ("SH", "Shabeellaha Hoose"),
            new KeyValuePair < string, string > ("SO", "Sool"),
            new KeyValuePair < string, string > ("TO", "Togdheer"),
            new KeyValuePair < string, string > ("WO", "Woqooyi Galbeed")
        };
            public static List<KeyValuePair<string, string>> provincesSLE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("E", "Eastern"),
            new KeyValuePair < string, string > ("N", "Northern"),
            new KeyValuePair < string, string > ("S", "Southern"),
            new KeyValuePair < string, string > ("W", "Western Area (Freetown)")
        };
            public static List<KeyValuePair<string, string>> provincesSYC = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Anse aux Pins"),
            new KeyValuePair < string, string > ("02", "Anse Boileau "),
            new KeyValuePair < string, string > ("03", "Anse &#201;toile "),
            new KeyValuePair < string, string > ("04", "Au Cap "),
            new KeyValuePair < string, string > ("05", "Anse Royale "),
            new KeyValuePair < string, string > ("06", "Baie Lazare "),
            new KeyValuePair < string, string > ("07", "Baie Sainte-Anne "),
            new KeyValuePair < string, string > ("08", "Beau Vallon "),
            new KeyValuePair < string, string > ("09", "Bel Air "),
            new KeyValuePair < string, string > ("10", "Bel Ombre "),
            new KeyValuePair < string, string > ("11", "Cascade "),
            new KeyValuePair < string, string > ("12", "Glacis "),
            new KeyValuePair < string, string > ("13", "Grand' Anse Mahe "),
            new KeyValuePair < string, string > ("14", "Grand' Anse Praslin"),
            new KeyValuePair < string, string > ("15", "La Digue "),
            new KeyValuePair < string, string > ("16", "La Riviere Anglaise "),
            new KeyValuePair < string, string > ("17", "Mont Buxton "),
            new KeyValuePair < string, string > ("18", "Mont Fleuri "),
            new KeyValuePair < string, string > ("19", "Plaisance "),
            new KeyValuePair < string, string > ("20", "Pointe La Rue "),
            new KeyValuePair < string, string > ("21", "Port Glaud "),
            new KeyValuePair < string, string > ("22", "Saint Louis "),
            new KeyValuePair < string, string > ("23", "Takamaka "),
            new KeyValuePair < string, string > ("24", "Les Mamelles "),
            new KeyValuePair < string, string > ("25", "Roche Caïman ")
        };
            public static List<KeyValuePair<string, string>> provincesSLB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CE", "Central"),
            new KeyValuePair < string, string > ("CH", "Choiseul"),
            new KeyValuePair < string, string > ("CT", "Capital Territory (Honiara)"),
            new KeyValuePair < string, string > ("GU", "Guadalcanal"),
            new KeyValuePair < string, string > ("IS", "Isabel"),
            new KeyValuePair < string, string > ("MK", "Makira-Ulawa"),
            new KeyValuePair < string, string > ("ML", "Malaita"),
            new KeyValuePair < string, string > ("RB", "Rennell and Bellona"),
            new KeyValuePair < string, string > ("TE", "Temotu"),
            new KeyValuePair < string, string > ("WE", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesSVN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("001", "Ajdovscina"),
            new KeyValuePair < string, string > ("002", "Beltinci"),
            new KeyValuePair < string, string > ("003", "Bled"),
            new KeyValuePair < string, string > ("004", "Bohinj"),
            new KeyValuePair < string, string > ("005", "Borovnica"),
            new KeyValuePair < string, string > ("006", "Bovec"),
            new KeyValuePair < string, string > ("007", "Brda"),
            new KeyValuePair < string, string > ("008", "Brezovica"),
            new KeyValuePair < string, string > ("009", "Brežice"),
            new KeyValuePair < string, string > ("010", "Tisina"),
            new KeyValuePair < string, string > ("011", "Celje"),
            new KeyValuePair < string, string > ("012", "Cerklje na Gorenjskem"),
            new KeyValuePair < string, string > ("013", "Cerknica"),
            new KeyValuePair < string, string > ("014", "Cerkno"),
            new KeyValuePair < string, string > ("015", "crensovci"),
            new KeyValuePair < string, string > ("016", "crna na Koroskem"),
            new KeyValuePair < string, string > ("017", "crnomelj"),
            new KeyValuePair < string, string > ("018", "Destrnik"),
            new KeyValuePair < string, string > ("019", "Divaca"),
            new KeyValuePair < string, string > ("020", "Dobrepolje"),
            new KeyValuePair < string, string > ("021", "Dobrova-Polhov Gradec"),
            new KeyValuePair < string, string > ("022", "Dol pri Ljubljani"),
            new KeyValuePair < string, string > ("023", "Domžale"),
            new KeyValuePair < string, string > ("024", "Dornava"),
            new KeyValuePair < string, string > ("025", "Dravograd"),
            new KeyValuePair < string, string > ("026", "Duplek"),
            new KeyValuePair < string, string > ("027", "Gorenja vas-Poljane"),
            new KeyValuePair < string, string > ("028", "Gorisnica"),
            new KeyValuePair < string, string > ("029", "Gornja Radgona"),
            new KeyValuePair < string, string > ("030", "Gornji Grad"),
            new KeyValuePair < string, string > ("031", "Gornji Petrovci"),
            new KeyValuePair < string, string > ("032", "Grosuplje"),
            new KeyValuePair < string, string > ("033", "salovci"),
            new KeyValuePair < string, string > ("034", "Hrastnik"),
            new KeyValuePair < string, string > ("035", "Hrpelje-Kozina"),
            new KeyValuePair < string, string > ("036", "Idrija"),
            new KeyValuePair < string, string > ("037", "Ig"),
            new KeyValuePair < string, string > ("038", "Ilirska Bistrica"),
            new KeyValuePair < string, string > ("039", "Ivancna Gorica"),
            new KeyValuePair < string, string > ("040", "Izola"),
            new KeyValuePair < string, string > ("041", "Jesenice"),
            new KeyValuePair < string, string > ("042", "Jursinci"),
            new KeyValuePair < string, string > ("043", "Kamnik"),
            new KeyValuePair < string, string > ("044", "Kanal"),
            new KeyValuePair < string, string > ("045", "Kidricevo"),
            new KeyValuePair < string, string > ("046", "Kobarid"),
            new KeyValuePair < string, string > ("047", "Kobilje"),
            new KeyValuePair < string, string > ("048", "Kocevje"),
            new KeyValuePair < string, string > ("049", "Komen"),
            new KeyValuePair < string, string > ("050", "Koper"),
            new KeyValuePair < string, string > ("051", "Kozje"),
            new KeyValuePair < string, string > ("052", "Kranj"),
            new KeyValuePair < string, string > ("053", "Kranjska Gora"),
            new KeyValuePair < string, string > ("054", "Krsko"),
            new KeyValuePair < string, string > ("055", "Kungota"),
            new KeyValuePair < string, string > ("056", "Kuzma"),
            new KeyValuePair < string, string > ("057", "Lasko"),
            new KeyValuePair < string, string > ("058", "Lenart"),
            new KeyValuePair < string, string > ("059", "Lendava"),
            new KeyValuePair < string, string > ("060", "Litija"),
            new KeyValuePair < string, string > ("061", "Ljubljana"),
            new KeyValuePair < string, string > ("062", "Ljubno"),
            new KeyValuePair < string, string > ("063", "Ljutomer"),
            new KeyValuePair < string, string > ("064", "Logatec"),
            new KeyValuePair < string, string > ("065", "Loska Dolina"),
            new KeyValuePair < string, string > ("066", "Loski Potok"),
            new KeyValuePair < string, string > ("067", "Luce"),
            new KeyValuePair < string, string > ("068", "Lukovica"),
            new KeyValuePair < string, string > ("069", "Majsperk"),
            new KeyValuePair < string, string > ("070", "Maribor"),
            new KeyValuePair < string, string > ("071", "Medvode"),
            new KeyValuePair < string, string > ("072", "Menges"),
            new KeyValuePair < string, string > ("073", "Metlika"),
            new KeyValuePair < string, string > ("074", "Mežica"),
            new KeyValuePair < string, string > ("075", "Miren-Kostanjevica"),
            new KeyValuePair < string, string > ("076", "Mislinja"),
            new KeyValuePair < string, string > ("077", "Moravce"),
            new KeyValuePair < string, string > ("078", "Moravske Toplice"),
            new KeyValuePair < string, string > ("079", "Mozirje"),
            new KeyValuePair < string, string > ("080", "Murska Sobota"),
            new KeyValuePair < string, string > ("081", "Muta"),
            new KeyValuePair < string, string > ("082", "Naklo"),
            new KeyValuePair < string, string > ("083", "Nazarje"),
            new KeyValuePair < string, string > ("084", "Nova Gorica"),
            new KeyValuePair < string, string > ("085", "Novo mesto"),
            new KeyValuePair < string, string > ("086", "Odranci"),
            new KeyValuePair < string, string > ("087", "Ormož"),
            new KeyValuePair < string, string > ("088", "Osilnica"),
            new KeyValuePair < string, string > ("089", "Pesnica"),
            new KeyValuePair < string, string > ("090", "Piran"),
            new KeyValuePair < string, string > ("091", "Pivka"),
            new KeyValuePair < string, string > ("092", "Podcetrtek"),
            new KeyValuePair < string, string > ("093", "Podvelka"),
            new KeyValuePair < string, string > ("094", "Postojna"),
            new KeyValuePair < string, string > ("095", "Preddvor"),
            new KeyValuePair < string, string > ("096", "Ptuj"),
            new KeyValuePair < string, string > ("097", "Puconci"),
            new KeyValuePair < string, string > ("098", "Race-Fram"),
            new KeyValuePair < string, string > ("099", "Radece"),
            new KeyValuePair < string, string > ("100", "Radenci"),
            new KeyValuePair < string, string > ("101", "Radlje ob Dravi"),
            new KeyValuePair < string, string > ("102", "Radovljica"),
            new KeyValuePair < string, string > ("103", "Ravne na Koroskem"),
            new KeyValuePair < string, string > ("104", "Ribnica"),
            new KeyValuePair < string, string > ("105", "Rogasovci"),
            new KeyValuePair < string, string > ("106", "Rogaska Slatina"),
            new KeyValuePair < string, string > ("107", "Rogatec"),
            new KeyValuePair < string, string > ("108", "Ruse"),
            new KeyValuePair < string, string > ("109", "Semic"),
            new KeyValuePair < string, string > ("110", "Semic"),
            new KeyValuePair < string, string > ("111", "Sežana"),
            new KeyValuePair < string, string > ("112", "Slovenj Gradec"),
            new KeyValuePair < string, string > ("113", "Slovenska Bistrica"),
            new KeyValuePair < string, string > ("114", "Slovenske Konjice"),
            new KeyValuePair < string, string > ("115", "Starse"),
            new KeyValuePair < string, string > ("116", "Sveti Jurij"),
            new KeyValuePair < string, string > ("117", "sencur"),
            new KeyValuePair < string, string > ("118", "sentilj"),
            new KeyValuePair < string, string > ("119", "sentjernej"),
            new KeyValuePair < string, string > ("120", "sentjur"),
            new KeyValuePair < string, string > ("121", "skocjan"),
            new KeyValuePair < string, string > ("122", "skofja Loka"),
            new KeyValuePair < string, string > ("123", "skofljica"),
            new KeyValuePair < string, string > ("124", "smarje pri Jelsah"),
            new KeyValuePair < string, string > ("125", "smartno ob Paki"),
            new KeyValuePair < string, string > ("126", "sostanj"),
            new KeyValuePair < string, string > ("127", "store"),
            new KeyValuePair < string, string > ("128", "Tolmin"),
            new KeyValuePair < string, string > ("129", "Trbovlje"),
            new KeyValuePair < string, string > ("130", "Trebnje"),
            new KeyValuePair < string, string > ("131", "Tržic"),
            new KeyValuePair < string, string > ("132", "Turnisce"),
            new KeyValuePair < string, string > ("133", "Velenje"),
            new KeyValuePair < string, string > ("134", "Velike Lasce"),
            new KeyValuePair < string, string > ("135", "Videm"),
            new KeyValuePair < string, string > ("136", "Vipava"),
            new KeyValuePair < string, string > ("137", "Vitanje"),
            new KeyValuePair < string, string > ("138", "Vodice"),
            new KeyValuePair < string, string > ("139", "Vojnik"),
            new KeyValuePair < string, string > ("140", "Vrhnika"),
            new KeyValuePair < string, string > ("141", "Vuzenica"),
            new KeyValuePair < string, string > ("142", "Zagorje ob Savi"),
            new KeyValuePair < string, string > ("143", "Zavrc"),
            new KeyValuePair < string, string > ("144", "Zrece"),
            new KeyValuePair < string, string > ("146", "Železniki"),
            new KeyValuePair < string, string > ("147", "Žiri"),
            new KeyValuePair < string, string > ("148", "Benedikt"),
            new KeyValuePair < string, string > ("149", "Bistrica ob Sotli"),
            new KeyValuePair < string, string > ("150", "Bloke"),
            new KeyValuePair < string, string > ("151", "Braslovce"),
            new KeyValuePair < string, string > ("152", "Cankova"),
            new KeyValuePair < string, string > ("153", "Cerkvenjak"),
            new KeyValuePair < string, string > ("154", "Dobje"),
            new KeyValuePair < string, string > ("155", "Dobrna"),
            new KeyValuePair < string, string > ("156", "Dobrovnik"),
            new KeyValuePair < string, string > ("157", "Dolenjske Toplice"),
            new KeyValuePair < string, string > ("158", "Grad"),
            new KeyValuePair < string, string > ("159", "Hajdina"),
            new KeyValuePair < string, string > ("160", "Hoce-Slivnica"),
            new KeyValuePair < string, string > ("161", "Hodos"),
            new KeyValuePair < string, string > ("162", "Horjul"),
            new KeyValuePair < string, string > ("163", "Jezersko"),
            new KeyValuePair < string, string > ("164", "Komenda"),
            new KeyValuePair < string, string > ("165", "Kostel"),
            new KeyValuePair < string, string > ("166", "Križevci"),
            new KeyValuePair < string, string > ("167", "Lovrenc na Pohorju"),
            new KeyValuePair < string, string > ("168", "Markovci"),
            new KeyValuePair < string, string > ("169", "Miklavž na Dravskem Polju"),
            new KeyValuePair < string, string > ("170", "Mirna Pec"),
            new KeyValuePair < string, string > ("171", "Oplotnica"),
            new KeyValuePair < string, string > ("172", "Podlehnik"),
            new KeyValuePair < string, string > ("173", "Polzela"),
            new KeyValuePair < string, string > ("174", "Prebold"),
            new KeyValuePair < string, string > ("175", "Prevalje"),
            new KeyValuePair < string, string > ("176", "Razkrižje"),
            new KeyValuePair < string, string > ("177", "Ribnica na Pohorju"),
            new KeyValuePair < string, string > ("178", "Selnica ob Dravi"),
            new KeyValuePair < string, string > ("179", "Sodražica"),
            new KeyValuePair < string, string > ("180", "Solcava"),
            new KeyValuePair < string, string > ("181", "Sveta Ana"),
            new KeyValuePair < string, string > ("182", "Sveti Andraž v Slovenskih Goricah"),
            new KeyValuePair < string, string > ("183", "sempeter-Vrtojba"),
            new KeyValuePair < string, string > ("184", "Tabor"),
            new KeyValuePair < string, string > ("185", "Trnovska vas"),
            new KeyValuePair < string, string > ("186", "Trzin"),
            new KeyValuePair < string, string > ("187", "Velika Polana"),
            new KeyValuePair < string, string > ("188", "Veržej"),
            new KeyValuePair < string, string > ("189", "Vransko"),
            new KeyValuePair < string, string > ("190", "Žalec"),
            new KeyValuePair < string, string > ("191", "Žetale"),
            new KeyValuePair < string, string > ("192", "Žirovnica"),
            new KeyValuePair < string, string > ("193", "Žužemberk"),
            new KeyValuePair < string, string > ("195", "Apace"),
            new KeyValuePair < string, string > ("196", "Cirkulane"),
            new KeyValuePair < string, string > ("197", "Kosanjevica na Krki"),
            new KeyValuePair < string, string > ("198", "Makole"),
            new KeyValuePair < string, string > ("199", "Mokronog-Trebelno"),
            new KeyValuePair < string, string > ("200", "Poljcane"),
            new KeyValuePair < string, string > ("201", "Rence-Vogrsko"),
            new KeyValuePair < string, string > ("202", "Sredisce ob Dravi"),
            new KeyValuePair < string, string > ("203", "Straža"),
            new KeyValuePair < string, string > ("204", "Sveta Trojica v Slovenskih Goricah"),
            new KeyValuePair < string, string > ("205", "Sveti Tomaž"),
            new KeyValuePair < string, string > ("206", "smarjeske Toplice"),
            new KeyValuePair < string, string > ("207", "Gorje"),
            new KeyValuePair < string, string > ("208", "Log-Dragomer"),
            new KeyValuePair < string, string > ("209", "Recica ob Savinji"),
            new KeyValuePair < string, string > ("210", "Sveti Jurij v Slovenskih Goricah"),
            new KeyValuePair < string, string > ("211", "sentrupert")
        };
            public static List<KeyValuePair<string, string>> provincesSVK = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BC", "Banskobystricky kraj"),
            new KeyValuePair < string, string > ("BL", "Bratislavsky kraj"),
            new KeyValuePair < string, string > ("KI", "Kosicky kraj"),
            new KeyValuePair < string, string > ("NI", "Nitriansky kraj"),
            new KeyValuePair < string, string > ("PV", "Presovsky kraj"),
            new KeyValuePair < string, string > ("TA", "Trnavsky kraj"),
            new KeyValuePair < string, string > ("TC", "Trenciansky kraj"),
            new KeyValuePair < string, string > ("ZI", "Žilinsky kraj")
        };
            public static List<KeyValuePair<string, string>> provincesSGP = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Central Singapore"),
            new KeyValuePair < string, string > ("02", "North East"),
            new KeyValuePair < string, string > ("03", "North West"),
            new KeyValuePair < string, string > ("04", "South East"),
            new KeyValuePair < string, string > ("05", "South West")
        };
            public static List<KeyValuePair<string, string>> provincesSRB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("KM", "Kosovo-Metohija"),
            new KeyValuePair < string, string > ("VO", "Vojvodina"),
            new KeyValuePair < string, string > ("00", "Beograd"),
            new KeyValuePair < string, string > ("01", "Severnobacki okrug"),
            new KeyValuePair < string, string > ("02", "Srednjebanatski okrug"),
            new KeyValuePair < string, string > ("03", "Severnobanatski okrug"),
            new KeyValuePair < string, string > ("04", "Južnobanatski okrug"),
            new KeyValuePair < string, string > ("05", "Zapadnobacki okrug"),
            new KeyValuePair < string, string > ("06", "Južnobacki okrug"),
            new KeyValuePair < string, string > ("07", "Sremski okrug"),
            new KeyValuePair < string, string > ("08", "Macvanski okrug"),
            new KeyValuePair < string, string > ("09", "Kolubarski okrug"),
            new KeyValuePair < string, string > ("10", "Podunavski okrug"),
            new KeyValuePair < string, string > ("11", "Branicevski okrug"),
            new KeyValuePair < string, string > ("12", "sumadijski okrug"),
            new KeyValuePair < string, string > ("13", "Pomoravski okrug"),
            new KeyValuePair < string, string > ("14", "Borski okrug"),
            new KeyValuePair < string, string > ("15", "Zajecarski okrug"),
            new KeyValuePair < string, string > ("16", "Zlatiborski okrug"),
            new KeyValuePair < string, string > ("17", "Moravicki okrug"),
            new KeyValuePair < string, string > ("18", "Raski okrug"),
            new KeyValuePair < string, string > ("19", "Rasinski okrug"),
            new KeyValuePair < string, string > ("20", "Nisavski okrug"),
            new KeyValuePair < string, string > ("21", "Toplicki okrug"),
            new KeyValuePair < string, string > ("22", "Pirotski okrug"),
            new KeyValuePair < string, string > ("23", "Jablanicki okrug"),
            new KeyValuePair < string, string > ("24", "Pcinjski okrug"),
            new KeyValuePair < string, string > ("25", "Kosovski okrug"),
            new KeyValuePair < string, string > ("26", "Pecki okrug"),
            new KeyValuePair < string, string > ("27", "Prizrenski okrug"),
            new KeyValuePair < string, string > ("28", "Kosovsko-Mitrovacki okrug"),
            new KeyValuePair < string, string > ("29", "Kosovsko-Pomoravski okrug")
        };
            public static List<KeyValuePair<string, string>> provincesSEN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DB", "Diourbel"),
            new KeyValuePair < string, string > ("DK", "Dakar"),
            new KeyValuePair < string, string > ("FK", "Fatick"),
            new KeyValuePair < string, string > ("KA", "Kaffrine"),
            new KeyValuePair < string, string > ("KD", "Kolda"),
            new KeyValuePair < string, string > ("KE", "Kedougou"),
            new KeyValuePair < string, string > ("KL", "Kaolack"),
            new KeyValuePair < string, string > ("LG", "Louga"),
            new KeyValuePair < string, string > ("MT", "Matam"),
            new KeyValuePair < string, string > ("SE", "Sedhiou"),
            new KeyValuePair < string, string > ("SL", "Saint-Louis"),
            new KeyValuePair < string, string > ("TC", "Tambacounda"),
            new KeyValuePair < string, string > ("TH", "Thies"),
            new KeyValuePair < string, string > ("ZG", "Ziguinchor")
        };
            public static List<KeyValuePair<string, string>> provincesSAU = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Ar Riyad"),
            new KeyValuePair < string, string > ("02", "Makkah"),
            new KeyValuePair < string, string > ("03", "Al Madinah"),
            new KeyValuePair < string, string > ("04", "Ash Sharqiyah"),
            new KeyValuePair < string, string > ("05", "Al Qasim"),
            new KeyValuePair < string, string > ("06", "Ḩa'il"),
            new KeyValuePair < string, string > ("07", "Tabuk"),
            new KeyValuePair < string, string > ("08", "Al Ḩudud ash Shamaliyah"),
            new KeyValuePair < string, string > ("09", "Jizan"),
            new KeyValuePair < string, string > ("10", "Najran"),
            new KeyValuePair < string, string > ("11", "Al Baḩah"),
            new KeyValuePair < string, string > ("12", "AI Jawf"),
            new KeyValuePair < string, string > ("14", "'Asir")
        };
            public static List<KeyValuePair<string, string>> provincesSTP = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("P", "Principe"),
            new KeyValuePair < string, string > ("S", "Sao Tome")
        };
            public static List<KeyValuePair<string, string>> provincesSMR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Acquaviva "),
            new KeyValuePair < string, string > ("02", "Chiesanuova "),
            new KeyValuePair < string, string > ("03", "Domagnano "),
            new KeyValuePair < string, string > ("04", "Faetano "),
            new KeyValuePair < string, string > ("05", "Fiorentino "),
            new KeyValuePair < string, string > ("06", "Borgo Maggiore "),
            new KeyValuePair < string, string > ("07", "San Marino "),
            new KeyValuePair < string, string > ("08", "Montegiardino "),
            new KeyValuePair < string, string > ("09", "Serravalle ")
        };
            public static List<KeyValuePair<string, string>> provincesWSM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AA", "Alana"),
            new KeyValuePair < string, string > ("AL", "Aiga-I-le-Tai"),
            new KeyValuePair < string, string > ("AT", "Atua"),
            new KeyValuePair < string, string > ("FA", "Fa'asaleleaga"),
            new KeyValuePair < string, string > ("GE", "Gaga'emauga"),
            new KeyValuePair < string, string > ("GI", "Gagaifomauga"),
            new KeyValuePair < string, string > ("PA", "Palauli"),
            new KeyValuePair < string, string > ("SA", "Satupa 'itea"),
            new KeyValuePair < string, string > ("TU", "Tuamasaga"),
            new KeyValuePair < string, string > ("VF", "Va'a-o-Fonoti"),
            new KeyValuePair < string, string > ("VS", "Vaisigano")
        };
            public static List<KeyValuePair<string, string>> provincesVCT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Charlotte "),
            new KeyValuePair < string, string > ("02", "Saint Andrew "),
            new KeyValuePair < string, string > ("03", "Saint David "),
            new KeyValuePair < string, string > ("04", "Saint George "),
            new KeyValuePair < string, string > ("05", "Saint Patrick "),
            new KeyValuePair < string, string > ("06", "Grenadines ")
        };
            public static List<KeyValuePair<string, string>> provincesLCA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Anse la Raye"),
            new KeyValuePair < string, string > ("02", "Castries"),
            new KeyValuePair < string, string > ("03", "Choiseul"),
            new KeyValuePair < string, string > ("04", "Dauphin"),
            new KeyValuePair < string, string > ("05", "Dennery"),
            new KeyValuePair < string, string > ("06", "Gros Islet"),
            new KeyValuePair < string, string > ("07", "Laborie"),
            new KeyValuePair < string, string > ("08", "Micoud"),
            new KeyValuePair < string, string > ("09", "Praslin"),
            new KeyValuePair < string, string > ("10", "Soufrière"),
            new KeyValuePair < string, string > ("11", "Vieux Fort")
        };
            public static List<KeyValuePair<string, string>> provincesKNA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Christ Church Nichola Town"),
            new KeyValuePair < string, string > ("02", "Saint Anne Sandy Point"),
            new KeyValuePair < string, string > ("03", "Saint George Basseterre"),
            new KeyValuePair < string, string > ("04", "Saint George Gingerland"),
            new KeyValuePair < string, string > ("05", "Saint James Windward"),
            new KeyValuePair < string, string > ("06", "Saint John Capisterre"),
            new KeyValuePair < string, string > ("07", "Saint John Figtree"),
            new KeyValuePair < string, string > ("08", "Saint Mary Cayon"),
            new KeyValuePair < string, string > ("09", "Saint Paul Capisterre"),
            new KeyValuePair < string, string > ("10", "Saint Paul Charlestown"),
            new KeyValuePair < string, string > ("11", "Saint Peter Basseterre"),
            new KeyValuePair < string, string > ("12", "Saint Thomas Lowland"),
            new KeyValuePair < string, string > ("13", "Saint Thomas Middle Island"),
            new KeyValuePair < string, string > ("15", "Trinity Palmetto Point")
        };
            public static List<KeyValuePair<string, string>> provincesSHN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AC", "Ascension"),
            new KeyValuePair < string, string > ("HL", "Saint Helena"),
            new KeyValuePair < string, string > ("TA", "Tristan da Cunha")
        };
            public static List<KeyValuePair<string, string>> provincesRWA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("02", "Est"),
            new KeyValuePair < string, string > ("03", "Nord"),
            new KeyValuePair < string, string > ("04", "Ouest"),
            new KeyValuePair < string, string > ("05", "Sud"),
            new KeyValuePair < string, string > ("01", "Ville de Kigali")
        };
            public static List<KeyValuePair<string, string>> provincesRUS = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AMU", "Amurskaya oblast'"),
            new KeyValuePair < string, string > ("ARK", "Arkhangel'skaya oblast,"),
            new KeyValuePair < string, string > ("AST", "Astrakhanskaya oblast'"),
            new KeyValuePair < string, string > ("BEL", "Belgorodskaya oblast'"),
            new KeyValuePair < string, string > ("BRY", "Bryanskaya oblast'"),
            new KeyValuePair < string, string > ("CHE", "Chelyabinskaya oblast'"),
            new KeyValuePair < string, string > ("IRK", "Irkutskaya oblast'"),
            new KeyValuePair < string, string > ("IVA", "Ivanovskaya oblast'"),
            new KeyValuePair < string, string > ("KEM", "Kemerovskaya oblast'"),
            new KeyValuePair < string, string > ("KGD", "Kaliningradskaya oblast,"),
            new KeyValuePair < string, string > ("KGN", "Kurganskaya oblast'"),
            new KeyValuePair < string, string > ("KIR", "Kirovskaya oblast'"),
            new KeyValuePair < string, string > ("KLU", "Kaluzhskaya oblast'"),
            new KeyValuePair < string, string > ("KOS", "Kostromskaya oblast'"),
            new KeyValuePair < string, string > ("KRS", "Kurskaya oblast'"),
            new KeyValuePair < string, string > ("LEN", "Leningradskaya oblast'"),
            new KeyValuePair < string, string > ("LIP", "Lipetskaya oblast'"),
            new KeyValuePair < string, string > ("MAG", "Magadanskaya oblast'"),
            new KeyValuePair < string, string > ("MOS", "Moskovskaya oblast'"),
            new KeyValuePair < string, string > ("MUR", "Murmanskaya oblast'"),
            new KeyValuePair < string, string > ("NGR", "Novgorodskaya oblast'"),
            new KeyValuePair < string, string > ("NIZ", "Nizbegorodskaya oblast,"),
            new KeyValuePair < string, string > ("NVS", "Novosibirskaya oblast'"),
            new KeyValuePair < string, string > ("OMS", "Omskaya oblast'"),
            new KeyValuePair < string, string > ("ORE", "Orenburgskaya oblast'"),
            new KeyValuePair < string, string > ("ORL", "Orlovskaya oblast'"),
            new KeyValuePair < string, string > ("PNZ", "Penzenskaya oblast'"),
            new KeyValuePair < string, string > ("PSK", "Pskovskaya oblast'"),
            new KeyValuePair < string, string > ("ROS", "Rostovskaya oblast'"),
            new KeyValuePair < string, string > ("RYA", "Ryazanskaya oblast'"),
            new KeyValuePair < string, string > ("SAK", "Sakhalinskaya oblast'"),
            new KeyValuePair < string, string > ("SAM", "Samarskaya oblast'"),
            new KeyValuePair < string, string > ("SAR", "Saratovskaya oblast'"),
            new KeyValuePair < string, string > ("SMO", "Smolenskaya oblast'"),
            new KeyValuePair < string, string > ("SVE", "Sverdlovskaya oblast'"),
            new KeyValuePair < string, string > ("TAM", "Tambovskaya oblast'"),
            new KeyValuePair < string, string > ("TOM", "Tomskaya oblast'"),
            new KeyValuePair < string, string > ("TUL", "Tul'skaya oblast'"),
            new KeyValuePair < string, string > ("TVE", "Tverskaya oblast'"),
            new KeyValuePair < string, string > ("TYU", "Tyumenskaya oblast'"),
            new KeyValuePair < string, string > ("ULY", "Ul'yanovskaya oblast'"),
            new KeyValuePair < string, string > ("VGG", "Volgogradskaya oblast'"),
            new KeyValuePair < string, string > ("VLA", "Vladimirskaya oblast'"),
            new KeyValuePair < string, string > ("VLG", "Vologodskaya oblast'"),
            new KeyValuePair < string, string > ("VOR", "Voronezhskaya oblast'"),
            new KeyValuePair < string, string > ("YAR", "Yaroslavskaya oblast'"),
            new KeyValuePair < string, string > ("ALT", "Altayskiy kray"),
            new KeyValuePair < string, string > ("KAM", "Kamchatskiy kray"),
            new KeyValuePair < string, string > ("KDA", "Krasnodarskiy kray"),
            new KeyValuePair < string, string > ("KHA", "Khabarovskiy kray"),
            new KeyValuePair < string, string > ("KYA", "Krasnoyarskiy kray"),
            new KeyValuePair < string, string > ("PER", "Permskiy kray"),
            new KeyValuePair < string, string > ("PRI", "Primorskiy kray"),
            new KeyValuePair < string, string > ("STA", "Stavropol'skiy kray"),
            new KeyValuePair < string, string > ("ZAB", "Zabaykal'skiy kray"),
            new KeyValuePair < string, string > ("MOW", "Moskva"),
            new KeyValuePair < string, string > ("SPE", "Sankt-Peterburg"),
            new KeyValuePair < string, string > ("CHU", "Chukotskiy avtonomnyy okrug"),
            new KeyValuePair < string, string > ("KHM", "Khanty-Mansiyskiy avtonomnyy okrug-Yugra"),
            new KeyValuePair < string, string > ("NEN", "Nenetskiy avtonomnyy okrug"),
            new KeyValuePair < string, string > ("YAN", "Yamalo-Nenetskiy avtonomnyy okrug"),
            new KeyValuePair < string, string > ("YEV", "Yevreyskaya avtonomnaya oblast'ug")
        };
            public static List<KeyValuePair<string, string>> provincesROU = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AB", "Alba"),
            new KeyValuePair < string, string > ("AG", "Arges"),
            new KeyValuePair < string, string > ("AR", "Arad"),
            new KeyValuePair < string, string > ("B", "Bucuresti"),
            new KeyValuePair < string, string > ("BC", "Bacău"),
            new KeyValuePair < string, string > ("BH", "Bihor"),
            new KeyValuePair < string, string > ("BN", "Bistrita-Năsăud"),
            new KeyValuePair < string, string > ("BR", "Brăila"),
            new KeyValuePair < string, string > ("BT", "Botosani"),
            new KeyValuePair < string, string > ("BV", "Brasov"),
            new KeyValuePair < string, string > ("BZ", "Buzău"),
            new KeyValuePair < string, string > ("CJ", "Cluj"),
            new KeyValuePair < string, string > ("CL", "Călărasi"),
            new KeyValuePair < string, string > ("CS", "Caras-Severin"),
            new KeyValuePair < string, string > ("CT", "Constanta"),
            new KeyValuePair < string, string > ("CV", "Covasna"),
            new KeyValuePair < string, string > ("DB", "Dambovita"),
            new KeyValuePair < string, string > ("DJ", "Dolj"),
            new KeyValuePair < string, string > ("GJ", "Gorj"),
            new KeyValuePair < string, string > ("GL", "Galati"),
            new KeyValuePair < string, string > ("GR", "Giurgiu"),
            new KeyValuePair < string, string > ("HD", "Hunedoara"),
            new KeyValuePair < string, string > ("HR", "Harghita"),
            new KeyValuePair < string, string > ("IF", "Ilfov"),
            new KeyValuePair < string, string > ("IL", "Ialomita"),
            new KeyValuePair < string, string > ("IS", "Iasi"),
            new KeyValuePair < string, string > ("MH", "Mehedinti"),
            new KeyValuePair < string, string > ("MM", "Maramures"),
            new KeyValuePair < string, string > ("MS", "Mures"),
            new KeyValuePair < string, string > ("NT", "Neamt"),
            new KeyValuePair < string, string > ("OT", "Olt"),
            new KeyValuePair < string, string > ("PH", "Prahova"),
            new KeyValuePair < string, string > ("SB", "Sibiu"),
            new KeyValuePair < string, string > ("SJ", "Sălaj"),
            new KeyValuePair < string, string > ("SM", "Satu Mare"),
            new KeyValuePair < string, string > ("SV", "Suceava"),
            new KeyValuePair < string, string > ("TL", "Tulcea"),
            new KeyValuePair < string, string > ("TM", "Timis"),
            new KeyValuePair < string, string > ("TR", "Teleorman"),
            new KeyValuePair < string, string > ("VL", "Valcea"),
            new KeyValuePair < string, string > ("VN", "Vrancea"),
            new KeyValuePair < string, string > ("VS", "Vaslui")
        };
            public static List<KeyValuePair<string, string>> provincesQAT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DA", "Ad Dawḩah"),
            new KeyValuePair < string, string > ("KH", "Al Khawr wa adh Dhakhirah"),
            new KeyValuePair < string, string > ("MS", "Ash Shamal"),
            new KeyValuePair < string, string > ("RA", "Ar Rayyan"),
            new KeyValuePair < string, string > ("US", "Umm salal"),
            new KeyValuePair < string, string > ("WA", "Al Wakrah"),
            new KeyValuePair < string, string > ("ZA", "Az̧ Z̧a‘ayin")
        };
            public static List<KeyValuePair<string, string>> provincesPRT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Aveiro"),
            new KeyValuePair < string, string > ("02", "Beja"),
            new KeyValuePair < string, string > ("03", "Braga"),
            new KeyValuePair < string, string > ("04", "Braganca"),
            new KeyValuePair < string, string > ("05", "Castelo Branco"),
            new KeyValuePair < string, string > ("06", "Coimbra"),
            new KeyValuePair < string, string > ("07", "&#201;vora"),
            new KeyValuePair < string, string > ("08", "Faro"),
            new KeyValuePair < string, string > ("09", "Guarda"),
            new KeyValuePair < string, string > ("10", "Leiria"),
            new KeyValuePair < string, string > ("11", "Lisboa"),
            new KeyValuePair < string, string > ("12", "Portalegre"),
            new KeyValuePair < string, string > ("13", "Porto"),
            new KeyValuePair < string, string > ("14", "Santarem"),
            new KeyValuePair < string, string > ("15", "Set&#250;bal"),
            new KeyValuePair < string, string > ("16", "Viana do Castelo"),
            new KeyValuePair < string, string > ("17", "Vila Real"),
            new KeyValuePair < string, string > ("18", "Viseu"),
            new KeyValuePair < string, string > ("20", "Regiao Autonoma dos Acores"),
            new KeyValuePair < string, string > ("30", "Regiao Autonoma da Madeira")
        };
            public static List<KeyValuePair<string, string>> provincesPOL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DS", "Dolnoslaskie"),
            new KeyValuePair < string, string > ("KP", "Kujawsko-pomorskie"),
            new KeyValuePair < string, string > ("LB", "Lubuskie"),
            new KeyValuePair < string, string > ("LD", "Lodzkie"),
            new KeyValuePair < string, string > ("LU", "Lubelskie"),
            new KeyValuePair < string, string > ("MA", "Malopolskie"),
            new KeyValuePair < string, string > ("MZ", "Mazowieckie"),
            new KeyValuePair < string, string > ("OP", "Opolskie"),
            new KeyValuePair < string, string > ("PD", "Podlaskie"),
            new KeyValuePair < string, string > ("PK", "Podkarpackie"),
            new KeyValuePair < string, string > ("PM", "Pomorskie"),
            new KeyValuePair < string, string > ("SK", "Swietokrzyskie"),
            new KeyValuePair < string, string > ("SL", "Slaskie"),
            new KeyValuePair < string, string > ("WN", "Warminsko-mazurskie"),
            new KeyValuePair < string, string > ("WP", "Wielkopolskie"),
            new KeyValuePair < string, string > ("ZP", "Zachodniopomorskie")
        };
            public static List<KeyValuePair<string, string>> provincesPHL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("ABR", "Abra"),
            new KeyValuePair < string, string > ("AGN", "Agusan del Norte"),
            new KeyValuePair < string, string > ("AGS", "Agusan del Sur"),
            new KeyValuePair < string, string > ("AKL", "Aklan"),
            new KeyValuePair < string, string > ("ALB", "Albay"),
            new KeyValuePair < string, string > ("ANT", "Antique"),
            new KeyValuePair < string, string > ("APA", "Apayao"),
            new KeyValuePair < string, string > ("AUR", "Aurora"),
            new KeyValuePair < string, string > ("BAN", "Bataan"),
            new KeyValuePair < string, string > ("BAS", "Basilan"),
            new KeyValuePair < string, string > ("BEN", "Benguet"),
            new KeyValuePair < string, string > ("BIL", "Biliran"),
            new KeyValuePair < string, string > ("BOH", "Bohol"),
            new KeyValuePair < string, string > ("BTG", "Batangas"),
            new KeyValuePair < string, string > ("BTN", "Batanes"),
            new KeyValuePair < string, string > ("BUK", "Bukidnon"),
            new KeyValuePair < string, string > ("BUL", "Bulacan"),
            new KeyValuePair < string, string > ("CAG", "Cagayan"),
            new KeyValuePair < string, string > ("CAM", "Camiguin"),
            new KeyValuePair < string, string > ("CAN", "Camarines Norte"),
            new KeyValuePair < string, string > ("CAP", "Capiz"),
            new KeyValuePair < string, string > ("CAS", "Camarines Sur"),
            new KeyValuePair < string, string > ("CAT", "Catanduanes"),
            new KeyValuePair < string, string > ("CAV", "Cavite"),
            new KeyValuePair < string, string > ("CEB", "Cebu"),
            new KeyValuePair < string, string > ("COM", "Compostela Valley"),
            new KeyValuePair < string, string > ("DAO", "Davao Oriental"),
            new KeyValuePair < string, string > ("DAS", "Davao del Sur"),
            new KeyValuePair < string, string > ("DAV", "Davao"),
            new KeyValuePair < string, string > ("DIN", "Dinagat Islands"),
            new KeyValuePair < string, string > ("EAS", "Eastern Samar"),
            new KeyValuePair < string, string > ("GUI", "Guimaras"),
            new KeyValuePair < string, string > ("IFU", "Ifugao"),
            new KeyValuePair < string, string > ("ILI", "Iloilo"),
            new KeyValuePair < string, string > ("ILN", "Ilocos Norte"),
            new KeyValuePair < string, string > ("ILS", "Ilocoq Sur"),
            new KeyValuePair < string, string > ("ISA", "Isabela"),
            new KeyValuePair < string, string > ("KAL", "Kalinga-Apayao"),
            new KeyValuePair < string, string > ("LAG", "Laguna"),
            new KeyValuePair < string, string > ("LAN", "Lanao del Norte"),
            new KeyValuePair < string, string > ("LAS", "Lanao del Sur"),
            new KeyValuePair < string, string > ("LEY", "Leyte"),
            new KeyValuePair < string, string > ("LUN", "La Union"),
            new KeyValuePair < string, string > ("MAD", "Marinduque"),
            new KeyValuePair < string, string > ("MAG", "Maguindanao"),
            new KeyValuePair < string, string > ("MAS", "Masbate"),
            new KeyValuePair < string, string > ("MDC", "Mindoro Occidental"),
            new KeyValuePair < string, string > ("MDR", "Mindoro Oriental"),
            new KeyValuePair < string, string > ("MOU", "Mountain Province"),
            new KeyValuePair < string, string > ("MSC", "Misamis Occidental"),
            new KeyValuePair < string, string > ("MSR", "Misamis Oriental"),
            new KeyValuePair < string, string > ("NCO", "North Cotabato"),
            new KeyValuePair < string, string > ("NEC", "Negros occidental"),
            new KeyValuePair < string, string > ("NER", "Negros oriental"),
            new KeyValuePair < string, string > ("NSA", "Northern Samar"),
            new KeyValuePair < string, string > ("NUE", "Nueva Ecija"),
            new KeyValuePair < string, string > ("NUV", "Nueva Vizcaya"),
            new KeyValuePair < string, string > ("PAM", "Pampanga"),
            new KeyValuePair < string, string > ("PAN", "Pangasinan"),
            new KeyValuePair < string, string > ("PLW", "Palawan"),
            new KeyValuePair < string, string > ("QUE", "Quezon"),
            new KeyValuePair < string, string > ("QUI", "Quirino"),
            new KeyValuePair < string, string > ("RIZ", "Rizal"),
            new KeyValuePair < string, string > ("ROM", "Romblon"),
            new KeyValuePair < string, string > ("SAR", "Sarangani"),
            new KeyValuePair < string, string > ("SCO", "South Cotabato"),
            new KeyValuePair < string, string > ("SIG", "Siquijor"),
            new KeyValuePair < string, string > ("SLE", "Southern Leyte"),
            new KeyValuePair < string, string > ("SLU", "Sulu"),
            new KeyValuePair < string, string > ("SOR", "Sorsogon"),
            new KeyValuePair < string, string > ("SUK", "Sultan Kudarat"),
            new KeyValuePair < string, string > ("SUN", "Surigao del Norte"),
            new KeyValuePair < string, string > ("SUR", "Surigao del Sur"),
            new KeyValuePair < string, string > ("TAR", "Tarlac"),
            new KeyValuePair < string, string > ("TAW", "Tawi-Tawi"),
            new KeyValuePair < string, string > ("WSA", "Western Samar"),
            new KeyValuePair < string, string > ("ZAN", "Zamboanga del Norte"),
            new KeyValuePair < string, string > ("ZAS", "Zamboanga del Sur"),
            new KeyValuePair < string, string > ("ZMB", "Zambales"),
            new KeyValuePair < string, string > ("ZSI", "Zamboanga Sibuguey [Zamboanga Sibugay]")
        };
            public static List<KeyValuePair<string, string>> provincesPER = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CAL", "El Callao"),
            new KeyValuePair < string, string > ("AMA", "Amazonas"),
            new KeyValuePair < string, string > ("ANC", "Ancash"),
            new KeyValuePair < string, string > ("APU", "Apurimac"),
            new KeyValuePair < string, string > ("ARE", "Arequipa"),
            new KeyValuePair < string, string > ("AYA", "Ayacucho"),
            new KeyValuePair < string, string > ("CAJ", "Cajamarca"),
            new KeyValuePair < string, string > ("CUS", "Cuzco [Cusco]"),
            new KeyValuePair < string, string > ("HUC", "Huanuco"),
            new KeyValuePair < string, string > ("HUV", "Huancavelica"),
            new KeyValuePair < string, string > ("ICA", "Ica"),
            new KeyValuePair < string, string > ("JUN", "Junin"),
            new KeyValuePair < string, string > ("LAL", "La Libertad"),
            new KeyValuePair < string, string > ("LAX", "Lambayeque"),
            new KeyValuePair < string, string > ("LIM", "Lima"),
            new KeyValuePair < string, string > ("LOR", "Loreto"),
            new KeyValuePair < string, string > ("MDD", "Madre de Dios"),
            new KeyValuePair < string, string > ("MOQ", "Moquegua"),
            new KeyValuePair < string, string > ("PAS", "Pasco"),
            new KeyValuePair < string, string > ("PIU", "Piura"),
            new KeyValuePair < string, string > ("PUN", "Puno"),
            new KeyValuePair < string, string > ("SAM", "San Martin"),
            new KeyValuePair < string, string > ("TAC", "Tacna"),
            new KeyValuePair < string, string > ("TUM", "Tumbes"),
            new KeyValuePair < string, string > ("UCA", "Ucayali"),
            new KeyValuePair < string, string > ("LMA", "Municipalidad Metropolitana de Lima")
        };
            public static List<KeyValuePair<string, string>> provincesPRY = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Concepcion"),
            new KeyValuePair < string, string > ("10", "Alto Parana"),
            new KeyValuePair < string, string > ("11", "Central"),
            new KeyValuePair < string, string > ("12", "&#209;eembuc&#250;"),
            new KeyValuePair < string, string > ("13", "Amambay"),
            new KeyValuePair < string, string > ("14", "Canindey&#250;"),
            new KeyValuePair < string, string > ("15", "Presidente Hayes"),
            new KeyValuePair < string, string > ("16", "Alto Paraguay"),
            new KeyValuePair < string, string > ("19", "Boqueron"),
            new KeyValuePair < string, string > ("2", "San Pedro"),
            new KeyValuePair < string, string > ("3", "Cordillera"),
            new KeyValuePair < string, string > ("4", "Guaira"),
            new KeyValuePair < string, string > ("5", "Caaguaz&#250;"),
            new KeyValuePair < string, string > ("6", "Caazapa"),
            new KeyValuePair < string, string > ("7", "Itap&#250;a"),
            new KeyValuePair < string, string > ("8", "Misiones"),
            new KeyValuePair < string, string > ("9", "Paraguari"),
            new KeyValuePair < string, string > ("ASU", "Asuncion")
        };
            public static List<KeyValuePair<string, string>> provincesPNG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("NSB", "Bougainville"),
            new KeyValuePair < string, string > ("NCD", "National Capital District (Port Moresby)"),
            new KeyValuePair < string, string > ("CPK", "Chimbu"),
            new KeyValuePair < string, string > ("CPM", "Central"),
            new KeyValuePair < string, string > ("EBR", "East New Britain"),
            new KeyValuePair < string, string > ("EHG", "Eastern Highlands"),
            new KeyValuePair < string, string > ("EPW", "Enga"),
            new KeyValuePair < string, string > ("ESW", "East Sepik"),
            new KeyValuePair < string, string > ("GPK", "Gulf"),
            new KeyValuePair < string, string > ("MBA", "Milne Bay"),
            new KeyValuePair < string, string > ("MPL", "Morobe"),
            new KeyValuePair < string, string > ("MPM", "Madang"),
            new KeyValuePair < string, string > ("MRL", "Manus"),
            new KeyValuePair < string, string > ("NIK", "New Ireland"),
            new KeyValuePair < string, string > ("NPP", "Northern"),
            new KeyValuePair < string, string > ("SAN", "Sandaun (West Sepik)"),
            new KeyValuePair < string, string > ("SHM", "Southern Highlands"),
            new KeyValuePair < string, string > ("WBK", "West New Britain"),
            new KeyValuePair < string, string > ("WHM", "Western Highlands"),
            new KeyValuePair < string, string > ("WPD", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesPAN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("EM", "Emberá"),
            new KeyValuePair < string, string > ("KY", "Kuna Yala"),
            new KeyValuePair < string, string > ("NB", "Ngöbe-Bugle"),
            new KeyValuePair < string, string > ("1", "Bocas del Toro"),
            new KeyValuePair < string, string > ("2", "Cocle"),
            new KeyValuePair < string, string > ("3", "Colon"),
            new KeyValuePair < string, string > ("4", "Chiriqui"),
            new KeyValuePair < string, string > ("5", "Darien"),
            new KeyValuePair < string, string > ("6", "Herrera"),
            new KeyValuePair < string, string > ("7", "Los Santos"),
            new KeyValuePair < string, string > ("8", "Panama"),
            new KeyValuePair < string, string > ("9", "Veraguas")
        };
            public static List<KeyValuePair<string, string>> provincesPSE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BTH", "Bethlehem"),
            new KeyValuePair < string, string > ("DEB", "Deir El Balah"),
            new KeyValuePair < string, string > ("GZA", "Gaza"),
            new KeyValuePair < string, string > ("HBN", "Hebron"),
            new KeyValuePair < string, string > ("JEM", "Jerusalem"),
            new KeyValuePair < string, string > ("JEN", "Jenin"),
            new KeyValuePair < string, string > ("JRH", "Jericho – Al Aghwar"),
            new KeyValuePair < string, string > ("KYS", "Khan Yunis"),
            new KeyValuePair < string, string > ("NBS", "Nablus"),
            new KeyValuePair < string, string > ("NGZ", "North Gaza"),
            new KeyValuePair < string, string > ("QQA", "Qalqilya"),
            new KeyValuePair < string, string > ("RBH", "Ramallah"),
            new KeyValuePair < string, string > ("RFH", "Rafah"),
            new KeyValuePair < string, string > ("SLT", "Salfit"),
            new KeyValuePair < string, string > ("TBS", "Tubas"),
            new KeyValuePair < string, string > ("TKM", "Tulkarm")
        };
            public static List<KeyValuePair<string, string>> provincesPLW = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("002", "Aimeliik"),
            new KeyValuePair < string, string > ("004", "Airai"),
            new KeyValuePair < string, string > ("010", "Angaur"),
            new KeyValuePair < string, string > ("050", "Hatobohei"),
            new KeyValuePair < string, string > ("100", "Kayangel"),
            new KeyValuePair < string, string > ("150", "Koror"),
            new KeyValuePair < string, string > ("212", "Melekeok"),
            new KeyValuePair < string, string > ("214", "Ngaraard"),
            new KeyValuePair < string, string > ("218", "Ngarchelong"),
            new KeyValuePair < string, string > ("222", "Ngardmau"),
            new KeyValuePair < string, string > ("224", "Ngatpang"),
            new KeyValuePair < string, string > ("226", "Ngchesar"),
            new KeyValuePair < string, string > ("227", "Ngeremlengui"),
            new KeyValuePair < string, string > ("228", "Ngiwal"),
            new KeyValuePair < string, string > ("350", "Peleliu"),
            new KeyValuePair < string, string > ("370", "Sonsorol")
        };
            public static List<KeyValuePair<string, string>> provincesPAK = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("IS", "Islamabad"),
            new KeyValuePair < string, string > ("GB", "Gilgit-Baltistan"),
            new KeyValuePair < string, string > ("JK", "Azad Kashmir"),
            new KeyValuePair < string, string > ("BA", "Baluchistan"),
            new KeyValuePair < string, string > ("KP", "Khyber Pakhtunkhwa"),
            new KeyValuePair < string, string > ("PB", "Punjab"),
            new KeyValuePair < string, string > ("SD", "Sind"),
            new KeyValuePair < string, string > ("TA", "Federally Administered Tribal Areas")
        };
            public static List<KeyValuePair<string, string>> provincesOMN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BU", "Al Buraymi"),
            new KeyValuePair < string, string > ("MA", "Masqat"),
            new KeyValuePair < string, string > ("MU", "Musandam"),
            new KeyValuePair < string, string > ("ZU", "Z̧ufar"),
            new KeyValuePair < string, string > ("BA", "Al Batinah"),
            new KeyValuePair < string, string > ("DA", "Ad Dakhiliyah"),
            new KeyValuePair < string, string > ("SH", "Ash Sharqiyah"),
            new KeyValuePair < string, string > ("WU", "Al Wustá"),
            new KeyValuePair < string, string > ("ZA", "A&#x0225; &#x0224;ahirah")
        };
            public static List<KeyValuePair<string, string>> provincesNOR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Ostfold"),
            new KeyValuePair < string, string > ("02", "Akershus"),
            new KeyValuePair < string, string > ("03", "Oslo"),
            new KeyValuePair < string, string > ("04", "Hedmark"),
            new KeyValuePair < string, string > ("05", "Oppland"),
            new KeyValuePair < string, string > ("06", "Buskerud"),
            new KeyValuePair < string, string > ("07", "Vestfold"),
            new KeyValuePair < string, string > ("08", "Telemark"),
            new KeyValuePair < string, string > ("09", "Aust-Agder"),
            new KeyValuePair < string, string > ("10", "Vest-Agder"),
            new KeyValuePair < string, string > ("11", "Rogaland"),
            new KeyValuePair < string, string > ("12", "Hordaland"),
            new KeyValuePair < string, string > ("14", "Sogn og Fjordane"),
            new KeyValuePair < string, string > ("15", "More og Romsdal"),
            new KeyValuePair < string, string > ("16", "Sor-Trondelag"),
            new KeyValuePair < string, string > ("17", "Nord-Trondelag"),
            new KeyValuePair < string, string > ("18", "Nordland"),
            new KeyValuePair < string, string > ("19", "Troms"),
            new KeyValuePair < string, string > ("20", "Finnmark")
        };
            public static List<KeyValuePair<string, string>> provincesNGA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AB", "Abia"),
            new KeyValuePair < string, string > ("AD", "Adamawa"),
            new KeyValuePair < string, string > ("AK", "Akwa Ibom"),
            new KeyValuePair < string, string > ("AN", "Anambra"),
            new KeyValuePair < string, string > ("BA", "Bauchi"),
            new KeyValuePair < string, string > ("BE", "Benue"),
            new KeyValuePair < string, string > ("BO", "Borno"),
            new KeyValuePair < string, string > ("BY", "Bayelsa"),
            new KeyValuePair < string, string > ("CR", "Cross River"),
            new KeyValuePair < string, string > ("DE", "Delta"),
            new KeyValuePair < string, string > ("EB", "Ebonyi"),
            new KeyValuePair < string, string > ("ED", "Edo"),
            new KeyValuePair < string, string > ("EK", "Ekiti"),
            new KeyValuePair < string, string > ("EN", "Enugu"),
            new KeyValuePair < string, string > ("FC", "Abuja Capital Territory"),
            new KeyValuePair < string, string > ("GO", "Gombe"),
            new KeyValuePair < string, string > ("IM", "Imo"),
            new KeyValuePair < string, string > ("JI", "Jigawa"),
            new KeyValuePair < string, string > ("KD", "Kaduna"),
            new KeyValuePair < string, string > ("KE", "Kebbi"),
            new KeyValuePair < string, string > ("KN", "Kano"),
            new KeyValuePair < string, string > ("KO", "Kogi"),
            new KeyValuePair < string, string > ("KT", "Katsina"),
            new KeyValuePair < string, string > ("KW", "Kwara"),
            new KeyValuePair < string, string > ("LA", "Lagos"),
            new KeyValuePair < string, string > ("NA", "Nassarawa"),
            new KeyValuePair < string, string > ("NI", "Niger"),
            new KeyValuePair < string, string > ("OG", "Ogun"),
            new KeyValuePair < string, string > ("ON", "Ondo"),
            new KeyValuePair < string, string > ("OS", "Osun"),
            new KeyValuePair < string, string > ("OY", "Oyo"),
            new KeyValuePair < string, string > ("PL", "Plateau"),
            new KeyValuePair < string, string > ("RI", "Rivers"),
            new KeyValuePair < string, string > ("SO", "Sokoto"),
            new KeyValuePair < string, string > ("TA", "Taraba"),
            new KeyValuePair < string, string > ("YO", "Yobe"),
            new KeyValuePair < string, string > ("ZA", "Zamfara")
        };
            public static List<KeyValuePair<string, string>> provincesNER = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Agadez"),
            new KeyValuePair < string, string > ("2", "Diffa"),
            new KeyValuePair < string, string > ("3", "Dosso"),
            new KeyValuePair < string, string > ("4", "Maradi"),
            new KeyValuePair < string, string > ("5", "Tahoua"),
            new KeyValuePair < string, string > ("6", "Tillaberi"),
            new KeyValuePair < string, string > ("7", "Zinder"),
            new KeyValuePair < string, string > ("8", "Niamey")
        };
            public static List<KeyValuePair<string, string>> provincesNIC = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AN", "Atlantico Norte"),
            new KeyValuePair < string, string > ("AS", "Atlantico Sur"),
            new KeyValuePair < string, string > ("BO", "Boaco"),
            new KeyValuePair < string, string > ("CA", "Carazo"),
            new KeyValuePair < string, string > ("CI", "Chinandega"),
            new KeyValuePair < string, string > ("CO", "Chontales"),
            new KeyValuePair < string, string > ("ES", "Esteli"),
            new KeyValuePair < string, string > ("GR", "Granada"),
            new KeyValuePair < string, string > ("JI", "Jinotega"),
            new KeyValuePair < string, string > ("LE", "Leon"),
            new KeyValuePair < string, string > ("MD", "Madriz"),
            new KeyValuePair < string, string > ("MN", "Managua"),
            new KeyValuePair < string, string > ("MS", "Masaya"),
            new KeyValuePair < string, string > ("MT", "Matagalpa"),
            new KeyValuePair < string, string > ("NS", "Nueva Segovia"),
            new KeyValuePair < string, string > ("RI", "Rivas"),
            new KeyValuePair < string, string > ("SJ", "Rio San Juan")
        };
            public static List<KeyValuePair<string, string>> provincesNZL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AUK", "Auckland"),
            new KeyValuePair < string, string > ("BOP", "Bay of Plenty"),
            new KeyValuePair < string, string > ("CAN", "Canterbury"),
            new KeyValuePair < string, string > ("CIT", "Chatham Islands Territory"),
            new KeyValuePair < string, string > ("GIS", "Gisborne District"),
            new KeyValuePair < string, string > ("HKB", "Hawkes's Bay"),
            new KeyValuePair < string, string > ("MBH", "Marlborough District"),
            new KeyValuePair < string, string > ("MWT", "Manawatu-Wanganui"),
            new KeyValuePair < string, string > ("NSN", "Nelson City"),
            new KeyValuePair < string, string > ("NTL", "Northland"),
            new KeyValuePair < string, string > ("OTA", "Otago"),
            new KeyValuePair < string, string > ("STL", "Southland"),
            new KeyValuePair < string, string > ("TAS", "Tasman District"),
            new KeyValuePair < string, string > ("TKI", "Taranaki"),
            new KeyValuePair < string, string > ("WGN", "Wellington"),
            new KeyValuePair < string, string > ("WKO", "Waikato"),
            new KeyValuePair < string, string > ("WTC", "West Coast")
        };
            public static List<KeyValuePair<string, string>> provincesNLD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DR", "Drenthe"),
            new KeyValuePair < string, string > ("FL", "Flevoland"),
            new KeyValuePair < string, string > ("FR", "Friesland"),
            new KeyValuePair < string, string > ("GE", "Gelderland"),
            new KeyValuePair < string, string > ("GR", "Groningen"),
            new KeyValuePair < string, string > ("LI", "Limburg"),
            new KeyValuePair < string, string > ("NB", "Noord-Brabant"),
            new KeyValuePair < string, string > ("NH", "Noord-Holland"),
            new KeyValuePair < string, string > ("OV", "Overijssel"),
            new KeyValuePair < string, string > ("UT", "Utrecht"),
            new KeyValuePair < string, string > ("ZE", "Zeeland"),
            new KeyValuePair < string, string > ("ZH", "Zuid-Holland")
        };
            public static List<KeyValuePair<string, string>> provincesNPL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Madhyamanchal"),
            new KeyValuePair < string, string > ("2", "Madhya Pashchimanchal"),
            new KeyValuePair < string, string > ("3", "Pashchimanchal"),
            new KeyValuePair < string, string > ("4", "Purwanchal"),
            new KeyValuePair < string, string > ("5", "Sudur Pashchimanchal"),
            new KeyValuePair < string, string > ("BA", "Bagmati"),
            new KeyValuePair < string, string > ("BH", "Bheri"),
            new KeyValuePair < string, string > ("DH", "Dhawalagiri"),
            new KeyValuePair < string, string > ("GA", "Gandaki"),
            new KeyValuePair < string, string > ("JA", "Janakpur"),
            new KeyValuePair < string, string > ("KA", "Karnali"),
            new KeyValuePair < string, string > ("KO", "Kosi [Koshi]"),
            new KeyValuePair < string, string > ("LU", "Lumbini"),
            new KeyValuePair < string, string > ("MA", "Mahakali"),
            new KeyValuePair < string, string > ("ME", "Mechi"),
            new KeyValuePair < string, string > ("NA", "Narayani"),
            new KeyValuePair < string, string > ("RA", "Rapti"),
            new KeyValuePair < string, string > ("SA", "Sagarmatha"),
            new KeyValuePair < string, string > ("SE", "Seti")
        };
            public static List<KeyValuePair<string, string>> provincesNRU = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Aiwo"),
            new KeyValuePair < string, string > ("02", "Anabar"),
            new KeyValuePair < string, string > ("03", "Anetan"),
            new KeyValuePair < string, string > ("04", "Anibare"),
            new KeyValuePair < string, string > ("05", "Baiti"),
            new KeyValuePair < string, string > ("06", "Boe"),
            new KeyValuePair < string, string > ("07", "Buada"),
            new KeyValuePair < string, string > ("08", "Denigomodu"),
            new KeyValuePair < string, string > ("09", "Ewa"),
            new KeyValuePair < string, string > ("10", "Ijuw"),
            new KeyValuePair < string, string > ("11", "Meneng"),
            new KeyValuePair < string, string > ("12", "Nibok"),
            new KeyValuePair < string, string > ("13", "Uaboe"),
            new KeyValuePair < string, string > ("14", "Yaren")
        };
            public static List<KeyValuePair<string, string>> provincesNAM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CA", "Caprivi"),
            new KeyValuePair < string, string > ("ER", "Erongo"),
            new KeyValuePair < string, string > ("HA", "Hardap"),
            new KeyValuePair < string, string > ("KA", "Karas"),
            new KeyValuePair < string, string > ("KH", "Khomas"),
            new KeyValuePair < string, string > ("KU", "Kunene"),
            new KeyValuePair < string, string > ("OD", "Otjozondjupa"),
            new KeyValuePair < string, string > ("OH", "Omaheke"),
            new KeyValuePair < string, string > ("OK", "Okavango"),
            new KeyValuePair < string, string > ("ON", "Oshana"),
            new KeyValuePair < string, string > ("OS", "Omusati"),
            new KeyValuePair < string, string > ("OT", "Oshikoto"),
            new KeyValuePair < string, string > ("OW", "Ohangwena")
        };
            public static List<KeyValuePair<string, string>> provincesMMR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Sagaing"),
            new KeyValuePair < string, string > ("02", "Bago"),
            new KeyValuePair < string, string > ("03", "Magway"),
            new KeyValuePair < string, string > ("04", "Mandalay"),
            new KeyValuePair < string, string > ("05", "Tanintharyi"),
            new KeyValuePair < string, string > ("06", "Yangon"),
            new KeyValuePair < string, string > ("07", "Ayeyarwady"),
            new KeyValuePair < string, string > ("11", "Kachin"),
            new KeyValuePair < string, string > ("12", "Kayah"),
            new KeyValuePair < string, string > ("13", "Kayin"),
            new KeyValuePair < string, string > ("14", "Chin"),
            new KeyValuePair < string, string > ("15", "Mon"),
            new KeyValuePair < string, string > ("16", "Rakhine"),
            new KeyValuePair < string, string > ("17", "Shan")
        };
            public static List<KeyValuePair<string, string>> provincesMOZ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("MPM", "Maputo"),
            new KeyValuePair < string, string > ("A", "Niaosa"),
            new KeyValuePair < string, string > ("B", "Manica"),
            new KeyValuePair < string, string > ("G", "Gaza"),
            new KeyValuePair < string, string > ("I", "Inhambane"),
            new KeyValuePair < string, string > ("L", "Maputo"),
            new KeyValuePair < string, string > ("N", "Nampula"),
            new KeyValuePair < string, string > ("P", "Cabo Delgado"),
            new KeyValuePair < string, string > ("Q", "Zambezia"),
            new KeyValuePair < string, string > ("S", "Sofala"),
            new KeyValuePair < string, string > ("T", "Tete")
        };
            public static List<KeyValuePair<string, string>> provincesMAR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Tanger-Tetouan"),
            new KeyValuePair < string, string > ("02", "Gharb-Chrarda-Beni Hssen"),
            new KeyValuePair < string, string > ("03", "Taza-Al Hoceima-Taounate"),
            new KeyValuePair < string, string > ("04", "L'Oriental"),
            new KeyValuePair < string, string > ("05", "Fes-Boulemane"),
            new KeyValuePair < string, string > ("06", "Meknes-Tafilalet"),
            new KeyValuePair < string, string > ("07", "Rabat-Sale-Zemmour-Zaer"),
            new KeyValuePair < string, string > ("08", "Grand Casablanca"),
            new KeyValuePair < string, string > ("09", "Chaouia-Ouardigha"),
            new KeyValuePair < string, string > ("10", "Doukhala-Abda"),
            new KeyValuePair < string, string > ("11", "Marrakech-Tensift-Al Haouz"),
            new KeyValuePair < string, string > ("12", "Tadla-Azilal"),
            new KeyValuePair < string, string > ("13", "Sous-Massa-Draa"),
            new KeyValuePair < string, string > ("14", "Guelmim-Es Smara"),
            new KeyValuePair < string, string > ("15", "La&#226;youne-Boujdour-Sakia el Hamra"),
            new KeyValuePair < string, string > ("16", "Oued ed Dahab-Lagouira (EH)"),
            new KeyValuePair < string, string > ("AGD", "Agadir-Ida-Outanane"),
            new KeyValuePair < string, string > ("AOU", "Aousserd (EH)"),
            new KeyValuePair < string, string > ("CAS", "Casablanca [Dar el Beida]*"),
            new KeyValuePair < string, string > ("FAH", "Fahs-Beni Makada"),
            new KeyValuePair < string, string > ("FES", "Fès-Dar-Dbibegh"),
            new KeyValuePair < string, string > ("INE", "Inezgane-Ait Melloul"),
            new KeyValuePair < string, string > ("MEK", "Meknès"),
            new KeyValuePair < string, string > ("MMD", "Marrakech-Medina"),
            new KeyValuePair < string, string > ("MMN", "Marrakech-Menara"),
            new KeyValuePair < string, string > ("MOH", "Mohammadia"),
            new KeyValuePair < string, string > ("OUJ", "Oujda-Angad"),
            new KeyValuePair < string, string > ("RAB", "Rabat"),
            new KeyValuePair < string, string > ("SAL", "Sale"),
            new KeyValuePair < string, string > ("SKH", "Skhirate-Temara"),
            new KeyValuePair < string, string > ("SYB", "Sidi Youssef Ben Ali"),
            new KeyValuePair < string, string > ("TET", "Tetouan"),
            new KeyValuePair < string, string > ("TNG", "Tanger-Assilah"),
            new KeyValuePair < string, string > ("ASZ", "Assa-Zag"),
            new KeyValuePair < string, string > ("AZI", "Azilal"),
            new KeyValuePair < string, string > ("BEM", "Beni Mellal"),
            new KeyValuePair < string, string > ("BER", "Berkane"),
            new KeyValuePair < string, string > ("BES", "Ben Slimane"),
            new KeyValuePair < string, string > ("BOD", "Boujdour (EH)"),
            new KeyValuePair < string, string > ("BOM", "Boulemane"),
            new KeyValuePair < string, string > ("CHE", "Chefchaouene"),
            new KeyValuePair < string, string > ("CHI", "Chichaoua"),
            new KeyValuePair < string, string > ("CHT", "Chtouka-Ait Baha"),
            new KeyValuePair < string, string > ("ERR", "Errachidia"),
            new KeyValuePair < string, string > ("ESI", "Essaouira"),
            new KeyValuePair < string, string > ("ESM", "Es Smara (EH)"),
            new KeyValuePair < string, string > ("FIG", "Figuig"),
            new KeyValuePair < string, string > ("GUE", "Guelmim"),
            new KeyValuePair < string, string > ("HAJ", "El Hajeb"),
            new KeyValuePair < string, string > ("HAO", "Al Haouz"),
            new KeyValuePair < string, string > ("HOC", "Al Hoceïma"),
            new KeyValuePair < string, string > ("IFR", "Ifrane"),
            new KeyValuePair < string, string > ("JDI", "El Jadida"),
            new KeyValuePair < string, string > ("JRA", "Jrada"),
            new KeyValuePair < string, string > ("KEN", "Kenitra"),
            new KeyValuePair < string, string > ("KES", "Kelaat es Sraghna"),
            new KeyValuePair < string, string > ("KHE", "Khemisset"),
            new KeyValuePair < string, string > ("KHN", "Khenifra"),
            new KeyValuePair < string, string > ("KHO", "Khouribga"),
            new KeyValuePair < string, string > ("LAA", "Laayoune"),
            new KeyValuePair < string, string > ("LAR", "Larache"),
            new KeyValuePair < string, string > ("MED", "Mediouna"),
            new KeyValuePair < string, string > ("MOU", "Moulay Yacoub"),
            new KeyValuePair < string, string > ("NAD", "Nador"),
            new KeyValuePair < string, string > ("NOU", "Nouaceur"),
            new KeyValuePair < string, string > ("OUA", "Ouarzazate"),
            new KeyValuePair < string, string > ("OUD", "Oued ed Dahab (EH)"),
            new KeyValuePair < string, string > ("SAF", "Safi"),
            new KeyValuePair < string, string > ("SEF", "Sefrou"),
            new KeyValuePair < string, string > ("SET", "Settat"),
            new KeyValuePair < string, string > ("SIK", "Sidi Kacem"),
            new KeyValuePair < string, string > ("TAI", "Taourirt"),
            new KeyValuePair < string, string > ("TAO", "Taounate"),
            new KeyValuePair < string, string > ("TAR", "Taroudant"),
            new KeyValuePair < string, string > ("TAT", "Tata"),
            new KeyValuePair < string, string > ("TAZ", "Taza"),
            new KeyValuePair < string, string > ("TIZ", "Tiznit"),
            new KeyValuePair < string, string > ("TNT", "Tan-Tan"),
            new KeyValuePair < string, string > ("ZAG", "Zagora")
        };
            public static List<KeyValuePair<string, string>> provincesNME = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Andrijevica"),
            new KeyValuePair < string, string > ("02", "Bar"),
            new KeyValuePair < string, string > ("03", "Berane"),
            new KeyValuePair < string, string > ("04", "Bijelo Polje"),
            new KeyValuePair < string, string > ("05", "Budva"),
            new KeyValuePair < string, string > ("06", "Cetinje"),
            new KeyValuePair < string, string > ("07", "Danilovgrad"),
            new KeyValuePair < string, string > ("08", "Herceg-Novi"),
            new KeyValuePair < string, string > ("09", "Kolasin"),
            new KeyValuePair < string, string > ("10", "Kotor"),
            new KeyValuePair < string, string > ("11", "Mojkovac"),
            new KeyValuePair < string, string > ("12", "Niksic"),
            new KeyValuePair < string, string > ("13", "Plav"),
            new KeyValuePair < string, string > ("14", "Pljevlja"),
            new KeyValuePair < string, string > ("15", "Plužine"),
            new KeyValuePair < string, string > ("16", "Podgorica"),
            new KeyValuePair < string, string > ("17", "Rožaje"),
            new KeyValuePair < string, string > ("18", "savnik"),
            new KeyValuePair < string, string > ("19", "Tivat"),
            new KeyValuePair < string, string > ("20", "Ulcinj"),
            new KeyValuePair < string, string > ("21", "Žabljak")
        };
            public static List<KeyValuePair<string, string>> provincesMNG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("035", "Orhon"),
            new KeyValuePair < string, string > ("037", "Darhan uul"),
            new KeyValuePair < string, string > ("039", "Hentiy"),
            new KeyValuePair < string, string > ("041", "Hovagol"),
            new KeyValuePair < string, string > ("043", "Hovd"),
            new KeyValuePair < string, string > ("046", "Uvs"),
            new KeyValuePair < string, string > ("047", "Tov"),
            new KeyValuePair < string, string > ("049", "Selenge"),
            new KeyValuePair < string, string > ("051", "Suhbaatar"),
            new KeyValuePair < string, string > ("053", "Omnogovi"),
            new KeyValuePair < string, string > ("055", "Ovorhangay"),
            new KeyValuePair < string, string > ("057", "Dzavhan"),
            new KeyValuePair < string, string > ("059", "Dundgovi"),
            new KeyValuePair < string, string > ("061", "Dornod"),
            new KeyValuePair < string, string > ("063", "Dornogovi"),
            new KeyValuePair < string, string > ("064", "Govi-Sumber"),
            new KeyValuePair < string, string > ("065", "Govi-Altay"),
            new KeyValuePair < string, string > ("067", "Bulgan"),
            new KeyValuePair < string, string > ("069", "Bayanhongor"),
            new KeyValuePair < string, string > ("071", "Bayan-Olgiy"),
            new KeyValuePair < string, string > ("073", "Arhangay"),
            new KeyValuePair < string, string > ("1", "Ulaanbaatar")
        };
            public static List<KeyValuePair<string, string>> provincesMCO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CL", "La Colle"),
            new KeyValuePair < string, string > ("CO", "La Condamine"),
            new KeyValuePair < string, string > ("FO", "Fontvieille"),
            new KeyValuePair < string, string > ("FO", "Fontvieille"),
            new KeyValuePair < string, string > ("GA", "La Gare"),
            new KeyValuePair < string, string > ("JE", "Jardin Exotique"),
            new KeyValuePair < string, string > ("LA", "Larvotto"),
            new KeyValuePair < string, string > ("MA", "Malbousquet"),
            new KeyValuePair < string, string > ("MC", "Monte-Carlo"),
            new KeyValuePair < string, string > ("MG", "Moneghetti"),
            new KeyValuePair < string, string > ("MO", "Monaco-Ville"),
            new KeyValuePair < string, string > ("MU", "Moulins"),
            new KeyValuePair < string, string > ("PH", "Port-Hercule"),
            new KeyValuePair < string, string > ("SD", "Sainte-Devote"),
            new KeyValuePair < string, string > ("SO", "La Source"),
            new KeyValuePair < string, string > ("SP", "Spelugues"),
            new KeyValuePair < string, string > ("SR", "Saint-Roman"),
            new KeyValuePair < string, string > ("VR", "Vallon de la Rousse")
        };
            public static List<KeyValuePair<string, string>> provincesMDA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("GA", "Gagauzia, Unitatea teritoriala autonoma"),
            new KeyValuePair < string, string > ("BA", "Balti"),
            new KeyValuePair < string, string > ("BD", "Tighina"),
            new KeyValuePair < string, string > ("CU", "Chisinau"),
            new KeyValuePair < string, string > ("AN", "Anenii Noi"),
            new KeyValuePair < string, string > ("BR", "Briceni"),
            new KeyValuePair < string, string > ("BS", "Basarabeasca"),
            new KeyValuePair < string, string > ("CA", "Cahul"),
            new KeyValuePair < string, string > ("CL", "Calarasi"),
            new KeyValuePair < string, string > ("CM", "Cimislia"),
            new KeyValuePair < string, string > ("CR", "Criuleni"),
            new KeyValuePair < string, string > ("CS", "Causeni"),
            new KeyValuePair < string, string > ("CT", "Cantemir"),
            new KeyValuePair < string, string > ("DO", "Donduseni"),
            new KeyValuePair < string, string > ("DR", "Drochia"),
            new KeyValuePair < string, string > ("DU", "Dubasari"),
            new KeyValuePair < string, string > ("ED", "Edinet"),
            new KeyValuePair < string, string > ("FA", "Falesti"),
            new KeyValuePair < string, string > ("FL", "Floresti"),
            new KeyValuePair < string, string > ("GL", "Glodeni"),
            new KeyValuePair < string, string > ("HI", "Hincesti"),
            new KeyValuePair < string, string > ("IA", "Ialoveni"),
            new KeyValuePair < string, string > ("LE", "Leova"),
            new KeyValuePair < string, string > ("NI", "Nisporeni"),
            new KeyValuePair < string, string > ("OC", "Ocnita"),
            new KeyValuePair < string, string > ("OR", "Orhei"),
            new KeyValuePair < string, string > ("RE", "Rezina"),
            new KeyValuePair < string, string > ("RI", "Riscani"),
            new KeyValuePair < string, string > ("SD", "soldanesti"),
            new KeyValuePair < string, string > ("SI", "Singerei"),
            new KeyValuePair < string, string > ("SO", "Soroca"),
            new KeyValuePair < string, string > ("ST", "Straseni"),
            new KeyValuePair < string, string > ("SV", "Stefan Voda"),
            new KeyValuePair < string, string > ("TA", "Taraclia"),
            new KeyValuePair < string, string > ("TE", "Telenesti"),
            new KeyValuePair < string, string > ("UN", "Ungheni"),
            new KeyValuePair < string, string > ("SN", "Stinga Nistrului, unitatea teritoriala din")
        };
            public static List<KeyValuePair<string, string>> provincesFSM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("KSA", "Kosrae"),
            new KeyValuePair < string, string > ("PNI", "Pohnpei"),
            new KeyValuePair < string, string > ("TRK", "Chuuk"),
            new KeyValuePair < string, string > ("YAP", "Yap")
        };
            public static List<KeyValuePair<string, string>> provincesMEX = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AGU", "Aguascalientes"),
            new KeyValuePair < string, string > ("BCN", "Baja California"),
            new KeyValuePair < string, string > ("BCS", "Baja California Sur"),
            new KeyValuePair < string, string > ("CAM", "Campeche"),
            new KeyValuePair < string, string > ("CHH", "Chihuahua"),
            new KeyValuePair < string, string > ("CHP", "Chiapas"),
            new KeyValuePair < string, string > ("COA", "Coahuila"),
            new KeyValuePair < string, string > ("COL", "Colima"),
            new KeyValuePair < string, string > ("DIF", "Distrito Federal"),
            new KeyValuePair < string, string > ("DUR", "Durango"),
            new KeyValuePair < string, string > ("GRO", "Guerrero"),
            new KeyValuePair < string, string > ("GUA", "Guanajuato"),
            new KeyValuePair < string, string > ("HID", "Hidalgo"),
            new KeyValuePair < string, string > ("JAL", "Jalisco"),
            new KeyValuePair < string, string > ("MEX", "Mexico"),
            new KeyValuePair < string, string > ("MIC", "Michoacan"),
            new KeyValuePair < string, string > ("MOR", "Morelos"),
            new KeyValuePair < string, string > ("NAY", "Nayarit"),
            new KeyValuePair < string, string > ("NLE", "Nuevo Leon"),
            new KeyValuePair < string, string > ("OAX", "Oaxaca"),
            new KeyValuePair < string, string > ("PUE", "Puebla"),
            new KeyValuePair < string, string > ("QUE", "Queretaro"),
            new KeyValuePair < string, string > ("ROO", "Quintana Roo"),
            new KeyValuePair < string, string > ("SIN", "Sinaloa"),
            new KeyValuePair < string, string > ("SLP", "San Luis Potosi"),
            new KeyValuePair < string, string > ("SON", "Sonora"),
            new KeyValuePair < string, string > ("TAB", "Tabasco"),
            new KeyValuePair < string, string > ("TAM", "Tamaulipas"),
            new KeyValuePair < string, string > ("TLA", "Tlaxcala"),
            new KeyValuePair < string, string > ("VER", "Veracruz"),
            new KeyValuePair < string, string > ("YUC", "Yucatan"),
            new KeyValuePair < string, string > ("ZAC", "Zacatecas")
        };
            public static List<KeyValuePair<string, string>> provincesMUS = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AG", "Agalega Islands"),
            new KeyValuePair < string, string > ("BL", "Black River"),
            new KeyValuePair < string, string > ("BR", "Beau Bassin-Rose Hill"),
            new KeyValuePair < string, string > ("CC", "Cargados Carajos Shoals "),
            new KeyValuePair < string, string > ("CU", "Curepipe"),
            new KeyValuePair < string, string > ("FL", "Flacq"),
            new KeyValuePair < string, string > ("GP", "Grand Port"),
            new KeyValuePair < string, string > ("MO", "Moka"),
            new KeyValuePair < string, string > ("PA", "Pamplemousses"),
            new KeyValuePair < string, string > ("PL", "Part Louis"),
            new KeyValuePair < string, string > ("PU", "Port Louis"),
            new KeyValuePair < string, string > ("PW", "Plaines wilhems"),
            new KeyValuePair < string, string > ("QB", "Quatre Bornes"),
            new KeyValuePair < string, string > ("RO", "Rodrigues Island"),
            new KeyValuePair < string, string > ("RR", "Riviere du Rempart"),
            new KeyValuePair < string, string > ("SA", "Savanne"),
            new KeyValuePair < string, string > ("VP", "Vacoas-Phoenix")
        };
            public static List<KeyValuePair<string, string>> provincesMRT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Hodh ech Chargui"),
            new KeyValuePair < string, string > ("02", "Hodh el Gharbi"),
            new KeyValuePair < string, string > ("03", "Assaba"),
            new KeyValuePair < string, string > ("04", "Gorgol"),
            new KeyValuePair < string, string > ("05", "Brakna"),
            new KeyValuePair < string, string > ("06", "Trarza"),
            new KeyValuePair < string, string > ("07", "Adrar"),
            new KeyValuePair < string, string > ("08", "Dakhlet Nouadhibou"),
            new KeyValuePair < string, string > ("09", "Tagant"),
            new KeyValuePair < string, string > ("10", "Guidimaka"),
            new KeyValuePair < string, string > ("11", "Tiris Zemmour"),
            new KeyValuePair < string, string > ("12", "Inchiri"),
            new KeyValuePair < string, string > ("NKC", "Nouakchott")
        };
            public static List<KeyValuePair<string, string>> provincesMHL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("ALK", "Ailuk"),
            new KeyValuePair < string, string > ("ALL", "Ailinglapalap"),
            new KeyValuePair < string, string > ("ARN", "Arno"),
            new KeyValuePair < string, string > ("AUR", "Aur"),
            new KeyValuePair < string, string > ("EBO", "Ebon"),
            new KeyValuePair < string, string > ("ENI", "Eniwetok"),
            new KeyValuePair < string, string > ("JAB", "Jabat"),
            new KeyValuePair < string, string > ("JAL", "Jaluit"),
            new KeyValuePair < string, string > ("KIL", "Kili"),
            new KeyValuePair < string, string > ("KWA", "Kwajalein"),
            new KeyValuePair < string, string > ("L", "Ralik chain"),
            new KeyValuePair < string, string > ("LAE", "Lae"),
            new KeyValuePair < string, string > ("LIB", "Lib"),
            new KeyValuePair < string, string > ("LIK", "Likiep"),
            new KeyValuePair < string, string > ("MAJ", "Majuro"),
            new KeyValuePair < string, string > ("MAL", "Maloelap"),
            new KeyValuePair < string, string > ("MEJ", "Mejit"),
            new KeyValuePair < string, string > ("MIL", "Mili"),
            new KeyValuePair < string, string > ("NMK", "Namorik"),
            new KeyValuePair < string, string > ("NMU", "Namu"),
            new KeyValuePair < string, string > ("RON", "Rongelap"),
            new KeyValuePair < string, string > ("T", "Ratak chain"),
            new KeyValuePair < string, string > ("UJA", "Ujae"),
            new KeyValuePair < string, string > ("UTI", "Utirik"),
            new KeyValuePair < string, string > ("WTH", "Wotho"),
            new KeyValuePair < string, string > ("WTJ", "Wotje")
        };
            public static List<KeyValuePair<string, string>> provincesMLT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Attard"),
            new KeyValuePair < string, string > ("02", "Balzan"),
            new KeyValuePair < string, string > ("03", "Birgu"),
            new KeyValuePair < string, string > ("04", "Birkirkara"),
            new KeyValuePair < string, string > ("05", "Birżebbuġa"),
            new KeyValuePair < string, string > ("06", "Bormla"),
            new KeyValuePair < string, string > ("07", "Dingli"),
            new KeyValuePair < string, string > ("08", "Fgura"),
            new KeyValuePair < string, string > ("09", "Floriana"),
            new KeyValuePair < string, string > ("10", "Fontana"),
            new KeyValuePair < string, string > ("11", "Gudja"),
            new KeyValuePair < string, string > ("12", "Gżira"),
            new KeyValuePair < string, string > ("13", "Għajnsielem"),
            new KeyValuePair < string, string > ("14", "Għarb"),
            new KeyValuePair < string, string > ("15", "Għargħur"),
            new KeyValuePair < string, string > ("16", "Għasri"),
            new KeyValuePair < string, string > ("17", "Għaxaq"),
            new KeyValuePair < string, string > ("18", "Ħamrun"),
            new KeyValuePair < string, string > ("19", "Iklin"),
            new KeyValuePair < string, string > ("20", "Isla"),
            new KeyValuePair < string, string > ("21", "Kalkara"),
            new KeyValuePair < string, string > ("22", "Kerċem"),
            new KeyValuePair < string, string > ("23", "Kirkop"),
            new KeyValuePair < string, string > ("24", "Lija"),
            new KeyValuePair < string, string > ("25", "Luqa"),
            new KeyValuePair < string, string > ("26", "Marsa"),
            new KeyValuePair < string, string > ("27", "Marsaskala"),
            new KeyValuePair < string, string > ("28", "Marsaxlokk"),
            new KeyValuePair < string, string > ("29", "Mdina"),
            new KeyValuePair < string, string > ("30", "Mellieħa"),
            new KeyValuePair < string, string > ("31", "Mġarr"),
            new KeyValuePair < string, string > ("32", "Mosta"),
            new KeyValuePair < string, string > ("33", "Mqabba"),
            new KeyValuePair < string, string > ("34", "Msida"),
            new KeyValuePair < string, string > ("35", "Mtarfa"),
            new KeyValuePair < string, string > ("36", "Munxar"),
            new KeyValuePair < string, string > ("37", "Nadur"),
            new KeyValuePair < string, string > ("38", "Naxxar"),
            new KeyValuePair < string, string > ("39", "Paola"),
            new KeyValuePair < string, string > ("40", "Pembroke"),
            new KeyValuePair < string, string > ("41", "Pietà"),
            new KeyValuePair < string, string > ("42", "Qala"),
            new KeyValuePair < string, string > ("43", "Qormi"),
            new KeyValuePair < string, string > ("44", "Qrendi"),
            new KeyValuePair < string, string > ("45", "Rabat Gozo"),
            new KeyValuePair < string, string > ("46", "Rabat Malta"),
            new KeyValuePair < string, string > ("47", "Safi"),
            new KeyValuePair < string, string > ("48", "Saint Julian’s"),
            new KeyValuePair < string, string > ("49", "Saint John"),
            new KeyValuePair < string, string > ("50", "Saint Lawrence"),
            new KeyValuePair < string, string > ("51", "Saint Paul’s Bay"),
            new KeyValuePair < string, string > ("52", "Sannat"),
            new KeyValuePair < string, string > ("53", "Saint Lucia’s"),
            new KeyValuePair < string, string > ("54", "Santa Venera"),
            new KeyValuePair < string, string > ("55", "Siġġiewi"),
            new KeyValuePair < string, string > ("56", "Sliema"),
            new KeyValuePair < string, string > ("57", "Swieqi"),
            new KeyValuePair < string, string > ("58", "Ta’ Xbiex"),
            new KeyValuePair < string, string > ("59", "Tarxien"),
            new KeyValuePair < string, string > ("60", "Valletta"),
            new KeyValuePair < string, string > ("61", "Xagħra"),
            new KeyValuePair < string, string > ("62", "Xewkija"),
            new KeyValuePair < string, string > ("63", "Xgħajra"),
            new KeyValuePair < string, string > ("64", "Żabbar"),
            new KeyValuePair < string, string > ("65", "Żebbuġ Gozo"),
            new KeyValuePair < string, string > ("66", "Żebbuġ Malta"),
            new KeyValuePair < string, string > ("67", "Żejtun"),
            new KeyValuePair < string, string > ("68", "Żurrieq")
        };
            public static List<KeyValuePair<string, string>> provincesMLI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Kayes"),
            new KeyValuePair < string, string > ("2", "Koulikoro"),
            new KeyValuePair < string, string > ("3", "Sikasso"),
            new KeyValuePair < string, string > ("4", "Segou"),
            new KeyValuePair < string, string > ("5", "Mopti"),
            new KeyValuePair < string, string > ("6", "Tombouctou"),
            new KeyValuePair < string, string > ("7", "Gao"),
            new KeyValuePair < string, string > ("8", "Kidal"),
            new KeyValuePair < string, string > ("BKO", "Bamako")
        };
            public static List<KeyValuePair<string, string>> provincesMDV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("00", "Alifu Dhaalu"),
            new KeyValuePair < string, string > ("01", "Seenu"),
            new KeyValuePair < string, string > ("02", "Alifu Alifu"),
            new KeyValuePair < string, string > ("03", "Lhaviyani"),
            new KeyValuePair < string, string > ("04", "Vaavu"),
            new KeyValuePair < string, string > ("05", "Laamu"),
            new KeyValuePair < string, string > ("07", "Haa Alifu"),
            new KeyValuePair < string, string > ("08", "Thaa"),
            new KeyValuePair < string, string > ("12", "Meemu"),
            new KeyValuePair < string, string > ("13", "Raa"),
            new KeyValuePair < string, string > ("14", "Faafu"),
            new KeyValuePair < string, string > ("17", "Dhaalu"),
            new KeyValuePair < string, string > ("20", "Baa"),
            new KeyValuePair < string, string > ("23", "Haa Dhaalu"),
            new KeyValuePair < string, string > ("24", "Shaviyani"),
            new KeyValuePair < string, string > ("25", "Noonu"),
            new KeyValuePair < string, string > ("26", "Kaafu"),
            new KeyValuePair < string, string > ("27", "Gaaf Alifu"),
            new KeyValuePair < string, string > ("28", "Gaafu Dhaalu"),
            new KeyValuePair < string, string > ("29", "Gnaviyani"),
            new KeyValuePair < string, string > ("MLE", "Male")
        };
            public static List<KeyValuePair<string, string>> provincesMYS = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Johor"),
            new KeyValuePair < string, string > ("02", "Kedah"),
            new KeyValuePair < string, string > ("03", "Kelantan"),
            new KeyValuePair < string, string > ("04", "Melaka"),
            new KeyValuePair < string, string > ("05", "Negeri Sembilan"),
            new KeyValuePair < string, string > ("06", "Pahang"),
            new KeyValuePair < string, string > ("07", "Pulau Pinang"),
            new KeyValuePair < string, string > ("08", "Perak"),
            new KeyValuePair < string, string > ("09", "Perlis"),
            new KeyValuePair < string, string > ("10", "Selangor"),
            new KeyValuePair < string, string > ("11", "Terengganu"),
            new KeyValuePair < string, string > ("12", "Sabah"),
            new KeyValuePair < string, string > ("13", "Sarawak"),
            new KeyValuePair < string, string > ("14", "Wilayah Persekutuan Kuala Lumpur"),
            new KeyValuePair < string, string > ("15", "Wilayah Persekutuan Labuan"),
            new KeyValuePair < string, string > ("16", "Wilayah Persekutuan Putrajaya")
        };
            public static List<KeyValuePair<string, string>> provincesMWI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Balaka"),
            new KeyValuePair < string, string > ("C", "Central"),
            new KeyValuePair < string, string > ("CK", "Chikwawa"),
            new KeyValuePair < string, string > ("CR", "Chiradzulu"),
            new KeyValuePair < string, string > ("CT", "Chitipa"),
            new KeyValuePair < string, string > ("DE", "Dedza"),
            new KeyValuePair < string, string > ("DO", "Dowa"),
            new KeyValuePair < string, string > ("KR", "Karonga"),
            new KeyValuePair < string, string > ("KS", "Kasungu"),
            new KeyValuePair < string, string > ("LI", "Lilongwe"),
            new KeyValuePair < string, string > ("LK", "Likoma Island"),
            new KeyValuePair < string, string > ("MC", "Mchinji"),
            new KeyValuePair < string, string > ("MG", "Mangochi"),
            new KeyValuePair < string, string > ("MH", "Machinga"),
            new KeyValuePair < string, string > ("MU", "Mulanje"),
            new KeyValuePair < string, string > ("MW", "Mwanza"),
            new KeyValuePair < string, string > ("MZ", "Mzimba"),
            new KeyValuePair < string, string > ("N", "Northern"),
            new KeyValuePair < string, string > ("NB", "Nkhata Bay"),
            new KeyValuePair < string, string > ("NE", "Neno"),
            new KeyValuePair < string, string > ("NI", "Ntchisi"),
            new KeyValuePair < string, string > ("NK", "Nkhotakota"),
            new KeyValuePair < string, string > ("NS", "Nsanje"),
            new KeyValuePair < string, string > ("NU", "Ntcheu"),
            new KeyValuePair < string, string > ("PH", "Phalombe"),
            new KeyValuePair < string, string > ("RU", "Rumphi"),
            new KeyValuePair < string, string > ("S", "Southern"),
            new KeyValuePair < string, string > ("SA", "Salima"),
            new KeyValuePair < string, string > ("TH", "Thyolo"),
            new KeyValuePair < string, string > ("ZO", "Zomba")
        };
            public static List<KeyValuePair<string, string>> provincesMDG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Toamasina"),
            new KeyValuePair < string, string > ("D", "Antsiranana"),
            new KeyValuePair < string, string > ("F", "Fianarantsoa"),
            new KeyValuePair < string, string > ("M", "Mahajanga"),
            new KeyValuePair < string, string > ("T", "Antananarivo"),
            new KeyValuePair < string, string > ("U", "Toliara")
        };
            public static List<KeyValuePair<string, string>> provincesLUX = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("D", "Diekirch"),
            new KeyValuePair < string, string > ("G", "Grevenmacher"),
            new KeyValuePair < string, string > ("L", "Luxembourg (fr)")
        };
            public static List<KeyValuePair<string, string>> provincesLIE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Balzers"),
            new KeyValuePair < string, string > ("02", "Eschen"),
            new KeyValuePair < string, string > ("03", "Gamprin"),
            new KeyValuePair < string, string > ("04", "Mauren"),
            new KeyValuePair < string, string > ("05", "Planken"),
            new KeyValuePair < string, string > ("06", "Ruggell"),
            new KeyValuePair < string, string > ("07", "Schaan"),
            new KeyValuePair < string, string > ("08", "Schellenberg"),
            new KeyValuePair < string, string > ("09", "Triesen"),
            new KeyValuePair < string, string > ("10", "Triesenberg"),
            new KeyValuePair < string, string > ("11", "Vaduz")
        };
            public static List<KeyValuePair<string, string>> provincesLBY = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Banghazi"),
            new KeyValuePair < string, string > ("BU", "Al Butnan"),
            new KeyValuePair < string, string > ("DR", "Darnah"),
            new KeyValuePair < string, string > ("GT", "Ghat"),
            new KeyValuePair < string, string > ("JA", "Al Jabal al Akhdar"),
            new KeyValuePair < string, string > ("JG", "Al Jabal al Gharbi"),
            new KeyValuePair < string, string > ("JI", "Al Jifarah"),
            new KeyValuePair < string, string > ("JU", "Al Jufrah"),
            new KeyValuePair < string, string > ("KF", "Al Kufrah"),
            new KeyValuePair < string, string > ("MB", "Al Marqab"),
            new KeyValuePair < string, string > ("MI", "Misratah"),
            new KeyValuePair < string, string > ("MJ", "Al Marj"),
            new KeyValuePair < string, string > ("MQ", "Murzuq"),
            new KeyValuePair < string, string > ("NL", "Nalut"),
            new KeyValuePair < string, string > ("NQ", "An Nuqat al Khams"),
            new KeyValuePair < string, string > ("SB", "Sabha"),
            new KeyValuePair < string, string > ("SR", "Surt"),
            new KeyValuePair < string, string > ("TB", "tarabulus"),
            new KeyValuePair < string, string > ("WA", "Al Waḩat"),
            new KeyValuePair < string, string > ("WD", "Wadi al Ḩayat"),
            new KeyValuePair < string, string > ("WS", "Wadi ash Shatiʾ"),
            new KeyValuePair < string, string > ("ZA", "Az Zawiyah")
        };
            public static List<KeyValuePair<string, string>> provincesLBR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BG", "Bong"),
            new KeyValuePair < string, string > ("BM", "Bomi"),
            new KeyValuePair < string, string > ("CM", "Grand Cape Mount"),
            new KeyValuePair < string, string > ("GB", "Grand Bassa"),
            new KeyValuePair < string, string > ("GG", "Grand Gedeh"),
            new KeyValuePair < string, string > ("GK", "Grand Kru"),
            new KeyValuePair < string, string > ("GP", "Gbarpolu"),
            new KeyValuePair < string, string > ("LO", "Lofa"),
            new KeyValuePair < string, string > ("MG", "Margibi"),
            new KeyValuePair < string, string > ("MO", "Montserrado"),
            new KeyValuePair < string, string > ("MY", "Maryland"),
            new KeyValuePair < string, string > ("NI", "Nimba"),
            new KeyValuePair < string, string > ("RG", "River Gee"),
            new KeyValuePair < string, string > ("RI", "Rivercess"),
            new KeyValuePair < string, string > ("SI", "Sinoe")
        };
            public static List<KeyValuePair<string, string>> provincesLSO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Maseru"),
            new KeyValuePair < string, string > ("B", "Butha-Buthe"),
            new KeyValuePair < string, string > ("C", "Leribe"),
            new KeyValuePair < string, string > ("D", "Berea"),
            new KeyValuePair < string, string > ("E", "Mafeteng"),
            new KeyValuePair < string, string > ("F", "Mohale's Hoek"),
            new KeyValuePair < string, string > ("G", "Quthing"),
            new KeyValuePair < string, string > ("H", "Qacha's Nek"),
            new KeyValuePair < string, string > ("J", "Mokhotlong"),
            new KeyValuePair < string, string > ("K", "Thaba-Tseka")
        };
            public static List<KeyValuePair<string, string>> provincesLBN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AK", "Aakkarali"),
            new KeyValuePair < string, string > ("AS", "Liban-Nordali"),
            new KeyValuePair < string, string > ("BA", "Beyrouth"),
            new KeyValuePair < string, string > ("BH", "Baalbek-Hermel"),
            new KeyValuePair < string, string > ("BI", "Beqaa"),
            new KeyValuePair < string, string > ("JA", "Liban-Sudabi"),
            new KeyValuePair < string, string > ("JL", "Mont-Liban"),
            new KeyValuePair < string, string > ("NA", "Nabatiye")
        };
            public static List<KeyValuePair<string, string>> provincesLVA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("DGV", "Daugavpils"),
            new KeyValuePair < string, string > ("JEL", "Jelgava"),
            new KeyValuePair < string, string > ("JKB", "Jēkabpils"),
            new KeyValuePair < string, string > ("JUR", "Jurmala"),
            new KeyValuePair < string, string > ("LPX", "Liepaja"),
            new KeyValuePair < string, string > ("REZ", "Rēzekne"),
            new KeyValuePair < string, string > ("RIX", "Riga"),
            new KeyValuePair < string, string > ("VEN", "Ventspils"),
            new KeyValuePair < string, string > ("VMR", "Valmiera"),
            new KeyValuePair < string, string > ("001", "Aglonas novads (Aglona)"),
            new KeyValuePair < string, string > ("002", "Aizkraukles novads (Aizkraukle)"),
            new KeyValuePair < string, string > ("003", "Aizputes novads (Aizpute)"),
            new KeyValuePair < string, string > ("004", "Aknistes novads (Akniste)"),
            new KeyValuePair < string, string > ("005", "Alojas novads (Aloja)"),
            new KeyValuePair < string, string > ("006", "Alsungas novads (Alsunga)"),
            new KeyValuePair < string, string > ("007", "Aluksnes novads (Aluksne)"),
            new KeyValuePair < string, string > ("008", "Amatas novads (Amata)"),
            new KeyValuePair < string, string > ("009", "Apes novads (Ape)"),
            new KeyValuePair < string, string > ("010", "Auces novads (Auce)"),
            new KeyValuePair < string, string > ("011", "adažu novads (adaži)"),
            new KeyValuePair < string, string > ("012", "Babites novads (Babite)"),
            new KeyValuePair < string, string > ("013", "Baldones novads (Baldone)"),
            new KeyValuePair < string, string > ("014", "Baltinavas novads (Baltinava)"),
            new KeyValuePair < string, string > ("015", "Balvu novads (Balvi)"),
            new KeyValuePair < string, string > ("016", "Bauskas novads (Bauska)"),
            new KeyValuePair < string, string > ("017", "Beverinas novads (Beverina)"),
            new KeyValuePair < string, string > ("018", "Brocēnu novads (Brocēni)"),
            new KeyValuePair < string, string > ("019", "Burtnieku novads (Burtnieki)"),
            new KeyValuePair < string, string > ("020", "Carnikavas novads (Carnikava)"),
            new KeyValuePair < string, string > ("021", "Cesvaines novads (Cesvaine)"),
            new KeyValuePair < string, string > ("022", "Cēsu novads (Cēsis)"),
            new KeyValuePair < string, string > ("023", "Ciblas novads (Cibla)"),
            new KeyValuePair < string, string > ("024", "Dagdas novads (Dagda)"),
            new KeyValuePair < string, string > ("025", "Daugavpils novads (Daugavpils)"),
            new KeyValuePair < string, string > ("026", "Dobeles novads (Dobele)"),
            new KeyValuePair < string, string > ("027", "Dundagas novads (Dundaga)"),
            new KeyValuePair < string, string > ("028", "Durbes novads (Durbe)"),
            new KeyValuePair < string, string > ("029", "Engures novads (Engure)"),
            new KeyValuePair < string, string > ("030", "Ērgļu novads (Ērgļi)"),
            new KeyValuePair < string, string > ("031", "Garkalnes novads (Garkalne))"),
            new KeyValuePair < string, string > ("032", "Grobiņas novads (Grobiņa)"),
            new KeyValuePair < string, string > ("033", "Gulbenes novads (Gulbene)"),
            new KeyValuePair < string, string > ("034", "Iecavas novads (Iecava)"),
            new KeyValuePair < string, string > ("035", "Iksķiles novads (Iksķile)"),
            new KeyValuePair < string, string > ("036", "Ilukstes novads (Ilukste)"),
            new KeyValuePair < string, string > ("037", "Incukalna novads (Incukalns)"),
            new KeyValuePair < string, string > ("038", "Jaunjelgavas novads (Jaunjelgava)"),
            new KeyValuePair < string, string > ("039", "Jaunpiebalgas novads (Jaunpiebalga)"),
            new KeyValuePair < string, string > ("040", "Jaunpils novads (Jaunpils)"),
            new KeyValuePair < string, string > ("041", "Jelgavas novads (Jelgava)"),
            new KeyValuePair < string, string > ("042", "Jēkabpils novads (Jēkabpils)"),
            new KeyValuePair < string, string > ("043", "Kandavas novads (Kandava)"),
            new KeyValuePair < string, string > ("044", "Karsavas novads (Karsava)"),
            new KeyValuePair < string, string > ("045", "Kocēnu novads"),
            new KeyValuePair < string, string > ("046", "Kokneses novads (Koknese)"),
            new KeyValuePair < string, string > ("047", "Kraslavas novads (Kraslava)"),
            new KeyValuePair < string, string > ("048", "Krimuldas novads (Krimulda)"),
            new KeyValuePair < string, string > ("049", "Krustpils novads (Krustpils)"),
            new KeyValuePair < string, string > ("050", "Kuldigas novads (Kuldiga)"),
            new KeyValuePair < string, string > ("051", "Ķeguma novads (Ķegums)"),
            new KeyValuePair < string, string > ("052", "Ķekavas novads (Ķekava)"),
            new KeyValuePair < string, string > ("053", "Lielvardes novads (Lielvarde)"),
            new KeyValuePair < string, string > ("054", "Limbažu novads (Limbaži)"),
            new KeyValuePair < string, string > ("055", "Ligatnes novads (Ligatne)"),
            new KeyValuePair < string, string > ("056", "Livanu novads (Livani)"),
            new KeyValuePair < string, string > ("057", "Lubanas novads (Lubana)"),
            new KeyValuePair < string, string > ("058", "Ludzas novads (Ludza)"),
            new KeyValuePair < string, string > ("059", "Madonas novads (Madona)"),
            new KeyValuePair < string, string > ("060", "Mazsalacas novads (Mazsalaca)"),
            new KeyValuePair < string, string > ("061", "Malpils novads (Malpils)"),
            new KeyValuePair < string, string > ("062", "Marupes novads (Marupe)"),
            new KeyValuePair < string, string > ("063", "Mērsraga novads"),
            new KeyValuePair < string, string > ("064", "Nauksēnu novads (Nauksēni)"),
            new KeyValuePair < string, string > ("065", "Neretas novads (Nereta)"),
            new KeyValuePair < string, string > ("066", "Nicas novads (Nica)"),
            new KeyValuePair < string, string > ("067", "Ogres novads (Ogre)"),
            new KeyValuePair < string, string > ("068", "Olaines novads (Olaine)"),
            new KeyValuePair < string, string > ("069", "Ozolnieku novads (Ozolnieki)"),
            new KeyValuePair < string, string > ("070", "Pargaujas novads (Pargauja)"),
            new KeyValuePair < string, string > ("071", "Pavilostas novads (Pavilosta)"),
            new KeyValuePair < string, string > ("072", "Pļaviņu novads (Pļaviņas)"),
            new KeyValuePair < string, string > ("073", "Preiļu novads (Preiļi)"),
            new KeyValuePair < string, string > ("074", "Priekules novads (Priekule)"),
            new KeyValuePair < string, string > ("075", "Priekuļu novads (Priekuļi)"),
            new KeyValuePair < string, string > ("076", "Raunas novads (Rauna)"),
            new KeyValuePair < string, string > ("077", "Rēzeknes novads (Rēzekne)"),
            new KeyValuePair < string, string > ("078", "Riebiņu novads (Riebiņi)"),
            new KeyValuePair < string, string > ("079", "Rojas novads (Roja)"),
            new KeyValuePair < string, string > ("080", "Ropažu novads (Ropaži)"),
            new KeyValuePair < string, string > ("081", "Rucavas novads (Rucava)"),
            new KeyValuePair < string, string > ("082", "Rugaju novads (Rugaji)"),
            new KeyValuePair < string, string > ("083", "Rundales novads (Rundale)"),
            new KeyValuePair < string, string > ("084", "Rujienas novads (Rujiena)"),
            new KeyValuePair < string, string > ("085", "Salas novads (Sala)"),
            new KeyValuePair < string, string > ("086", "Salacgrivas novads (Salacgriva)"),
            new KeyValuePair < string, string > ("087", "Salaspils novads (Salaspils)"),
            new KeyValuePair < string, string > ("088", "Saldus novads (Saldus)"),
            new KeyValuePair < string, string > ("089", "Saulkrastu novads (Saulkrasti)"),
            new KeyValuePair < string, string > ("090", "Sējas novads (Sēja)"),
            new KeyValuePair < string, string > ("091", "Siguldas novads (Sigulda)"),
            new KeyValuePair < string, string > ("092", "Skriveru novads (Skriveri)"),
            new KeyValuePair < string, string > ("093", "Skrundas novads (Skrunda)"),
            new KeyValuePair < string, string > ("094", "Smiltenes novads (Smiltene)"),
            new KeyValuePair < string, string > ("095", "Stopiņu novads (Stopiņi)"),
            new KeyValuePair < string, string > ("096", "Strencu novads (Strenci)"),
            new KeyValuePair < string, string > ("097", "Talsu novads (Talsi)"),
            new KeyValuePair < string, string > ("098", "Tērvetes novads (Tērvete)"),
            new KeyValuePair < string, string > ("099", "Tukuma novads (Tukums)"),
            new KeyValuePair < string, string > ("100", "Vaiņodes novads (Vaiņode)"),
            new KeyValuePair < string, string > ("101", "Valkas novads (Valka)"),
            new KeyValuePair < string, string > ("102", "Varakļanu novads (Varakļani)"),
            new KeyValuePair < string, string > ("103", "Varkavas novads (Varkava)"),
            new KeyValuePair < string, string > ("104", "Vecpiebalgas novads (Vecpiebalga)"),
            new KeyValuePair < string, string > ("105", "Vecumnieku novads (Vecumnieki)"),
            new KeyValuePair < string, string > ("106", "Ventspils novads (Ventspils)"),
            new KeyValuePair < string, string > ("107", "Viesites novads (Viesite)"),
            new KeyValuePair < string, string > ("108", "Viļakas novads (Viļaka)"),
            new KeyValuePair < string, string > ("109", "Viļanu novads (Viļani)"),
            new KeyValuePair < string, string > ("110", "Zilupes novads (Zilupe)")
        };
            public static List<KeyValuePair<string, string>> provincesLAO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AT", "Attapu [Attopeu]"),
            new KeyValuePair < string, string > ("BK", "Bokeo"),
            new KeyValuePair < string, string > ("BL", "Bolikhamxai [Borikhane]"),
            new KeyValuePair < string, string > ("CH", "Champasak [Champassak]"),
            new KeyValuePair < string, string > ("HO", "Houaphan"),
            new KeyValuePair < string, string > ("KH", "Khammouan"),
            new KeyValuePair < string, string > ("LM", "Louang Namtha"),
            new KeyValuePair < string, string > ("LP", "Louangphabang [Louang Prabang)"),
            new KeyValuePair < string, string > ("OU", "Oudomxai [Oudomsai]"),
            new KeyValuePair < string, string > ("PH", "Phongsali [Phong Saly]"),
            new KeyValuePair < string, string > ("SL", "Salavan [Saravane]"),
            new KeyValuePair < string, string > ("SV", "Savannakhet"),
            new KeyValuePair < string, string > ("VI", "Vientiane"),
            new KeyValuePair < string, string > ("VT", "Vientiane"),
            new KeyValuePair < string, string > ("XA", "Xaignabouli [Sayaboury]"),
            new KeyValuePair < string, string > ("XE", "Xekong [Sekong]"),
            new KeyValuePair < string, string > ("XI", "Xiangkhoang [Xieng Khouang]"),
            new KeyValuePair < string, string > ("XN", "Xaisomboun")
        };
            public static List<KeyValuePair<string, string>> provincesKGZ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("B", "Batken"),
            new KeyValuePair < string, string > ("C", "Chu"),
            new KeyValuePair < string, string > ("GB", "Bishkek"),
            new KeyValuePair < string, string > ("J", "Jalal-Abad"),
            new KeyValuePair < string, string > ("N", "Naryn"),
            new KeyValuePair < string, string > ("O", "Osh"),
            new KeyValuePair < string, string > ("T", "Talas"),
            new KeyValuePair < string, string > ("Y", "Ysyk-Kol")
        };
            public static List<KeyValuePair<string, string>> provincesKWT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AH", "Al Aḩmadi"),
            new KeyValuePair < string, string > ("FA", "Al Farwaniyah"),
            new KeyValuePair < string, string > ("HA", "Ḩawalli"),
            new KeyValuePair < string, string > ("JA", "Al Jahra'"),
            new KeyValuePair < string, string > ("KU", "Al Kuwayt (Al 'asimah)"),
            new KeyValuePair < string, string > ("MU", "Mubarak al Kabir")
        };
            public static List<KeyValuePair<string, string>> provincesKOR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("11", "Seoul Teugbyeolsi "),
            new KeyValuePair < string, string > ("26", "Busan Gwang'yeogsi"),
            new KeyValuePair < string, string > ("27", "Daegu Gwang'yeogsi"),
            new KeyValuePair < string, string > ("28", "Incheon Gwang'yeogsiv "),
            new KeyValuePair < string, string > ("29", "Gwangju Gwang'yeogsi "),
            new KeyValuePair < string, string > ("30", "Daejeon Gwang'yeogsi "),
            new KeyValuePair < string, string > ("31", "Ulsan Gwang'yeogsi "),
            new KeyValuePair < string, string > ("41", "Gyeonggido "),
            new KeyValuePair < string, string > ("42", "Gang'weondo "),
            new KeyValuePair < string, string > ("43", "Chungcheongbugdo "),
            new KeyValuePair < string, string > ("44", "Chungcheongnamdo "),
            new KeyValuePair < string, string > ("45", "Jeonrabugdo "),
            new KeyValuePair < string, string > ("46", "Jeonranamdo "),
            new KeyValuePair < string, string > ("47", "Gyeongsangbugdo "),
            new KeyValuePair < string, string > ("48", "Gyeongsangnamdo "),
            new KeyValuePair < string, string > ("49", "Jejudo ")
        };
            public static List<KeyValuePair<string, string>> provincesPRK = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Phyeongyang"),
            new KeyValuePair < string, string > ("02", "Phyeongannamto"),
            new KeyValuePair < string, string > ("03", "Phyeonganpukto"),
            new KeyValuePair < string, string > ("04", "Jakangto"),
            new KeyValuePair < string, string > ("05", "Hwanghainamto"),
            new KeyValuePair < string, string > ("06", "Hwanghaipukto"),
            new KeyValuePair < string, string > ("07", "Kangweonto"),
            new KeyValuePair < string, string > ("08", "Hamkyeongnamto"),
            new KeyValuePair < string, string > ("09", "Hamkyeongpukto"),
            new KeyValuePair < string, string > ("10", "Yanggang-do"),
            new KeyValuePair < string, string > ("13", "Nasǒn")
        };
            public static List<KeyValuePair<string, string>> provincesKIR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("G", "Gilbert Islands"),
            new KeyValuePair < string, string > ("L", "Line Islands"),
            new KeyValuePair < string, string > ("P", "Phoenix Islands")
        };
            public static List<KeyValuePair<string, string>> provincesKEN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("110", "Nairobi"),
            new KeyValuePair < string, string > ("200", "Central"),
            new KeyValuePair < string, string > ("300", "Coast"),
            new KeyValuePair < string, string > ("400", "Eastern"),
            new KeyValuePair < string, string > ("500", "North-Eastern"),
            new KeyValuePair < string, string > ("600", "Nyanza"),
            new KeyValuePair < string, string > ("700", "Rift Valley"),
            new KeyValuePair < string, string > ("800", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesKAZ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AKM", "Aqmola oblysy"),
            new KeyValuePair < string, string > ("AKT", "Aqtöbe oblysy"),
            new KeyValuePair < string, string > ("ALA", "Almaty"),
            new KeyValuePair < string, string > ("ALM", "Almaty oblysy"),
            new KeyValuePair < string, string > ("AST", "Astana"),
            new KeyValuePair < string, string > ("ATY", "Atyrau oblysy"),
            new KeyValuePair < string, string > ("KAR", "Qaraghandy oblysy"),
            new KeyValuePair < string, string > ("KUS", "Qostanay oblysy"),
            new KeyValuePair < string, string > ("KZY", "Qyzylorda oblysy"),
            new KeyValuePair < string, string > ("MAN", "Mangghystau oblysy"),
            new KeyValuePair < string, string > ("PAV", "Pavlodar oblysy"),
            new KeyValuePair < string, string > ("SEV", "Soltustik Qazaqstan oblysy"),
            new KeyValuePair < string, string > ("VOS", "Shyghys Qazaqstan oblysy"),
            new KeyValuePair < string, string > ("YUZ", "Ongtustik Qazaqstan oblysy"),
            new KeyValuePair < string, string > ("ZAP", "Batys Qazaqstan oblysy"),
            new KeyValuePair < string, string > ("ZHA", "Zhambyl oblysy")
        };
            public static List<KeyValuePair<string, string>> provincesJOR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AJ", "ʽAjlun"),
            new KeyValuePair < string, string > ("AM", "‘Amman (Al ‘Asimah)"),
            new KeyValuePair < string, string > ("AQ", "Al'Aqaba"),
            new KeyValuePair < string, string > ("AT", "At tafilah"),
            new KeyValuePair < string, string > ("AZ", "Az Zarqa'"),
            new KeyValuePair < string, string > ("BA", "Al Balqa'"),
            new KeyValuePair < string, string > ("IR", "Irbid"),
            new KeyValuePair < string, string > ("JA", "Jarash"),
            new KeyValuePair < string, string > ("KA", "AI Karak"),
            new KeyValuePair < string, string > ("MA", "AI Mafraq"),
            new KeyValuePair < string, string > ("MD", "Madaba"),
            new KeyValuePair < string, string > ("MN", "Ma'an")
        };
            public static List<KeyValuePair<string, string>> provincesJPN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Hokkaidô [Hokkaido]"),
            new KeyValuePair < string, string > ("02", "Aomori"),
            new KeyValuePair < string, string > ("03", "Iwate"),
            new KeyValuePair < string, string > ("04", "Miyagi"),
            new KeyValuePair < string, string > ("05", "Akita"),
            new KeyValuePair < string, string > ("06", "Yamagata"),
            new KeyValuePair < string, string > ("07", "Hukusima [Fukushima]"),
            new KeyValuePair < string, string > ("08", "Ibaraki"),
            new KeyValuePair < string, string > ("09", "Totigi [Tochigi]"),
            new KeyValuePair < string, string > ("10", "Gunma"),
            new KeyValuePair < string, string > ("11", "Saitama"),
            new KeyValuePair < string, string > ("12", "Tiba [Chiba]"),
            new KeyValuePair < string, string > ("13", "Tôkyô [Tokyo]"),
            new KeyValuePair < string, string > ("14", "Kanagawa"),
            new KeyValuePair < string, string > ("15", "Niigata"),
            new KeyValuePair < string, string > ("16", "Toyama"),
            new KeyValuePair < string, string > ("17", "Isikawa [Ishikawa]"),
            new KeyValuePair < string, string > ("18", "Hukui [Fukui]"),
            new KeyValuePair < string, string > ("19", "Yamanasi [Yamanashi]"),
            new KeyValuePair < string, string > ("20", "Nagano"),
            new KeyValuePair < string, string > ("21", "Gihu [Gifu]"),
            new KeyValuePair < string, string > ("22", "Sizuoka [Shizuoka]"),
            new KeyValuePair < string, string > ("23", "Aiti [Aichi]"),
            new KeyValuePair < string, string > ("24", "Mie"),
            new KeyValuePair < string, string > ("25", "Siga [Shiga]"),
            new KeyValuePair < string, string > ("26", "Kyôto [Kyoto]"),
            new KeyValuePair < string, string > ("27", "Ôsaka [Osaka]"),
            new KeyValuePair < string, string > ("28", "Hyôgo [Hyogo]"),
            new KeyValuePair < string, string > ("29", "Nara"),
            new KeyValuePair < string, string > ("30", "Wakayama"),
            new KeyValuePair < string, string > ("31", "Tottori"),
            new KeyValuePair < string, string > ("32", "Simane [Shimane]"),
            new KeyValuePair < string, string > ("33", "Okayama"),
            new KeyValuePair < string, string > ("34", "Hirosima [Hiroshima]"),
            new KeyValuePair < string, string > ("35", "Yamaguti [Yamaguchi]"),
            new KeyValuePair < string, string > ("36", "Tokusima [Tokushima]"),
            new KeyValuePair < string, string > ("37", "Kagawa"),
            new KeyValuePair < string, string > ("38", "Ehime"),
            new KeyValuePair < string, string > ("39", "Kôti [Kochi]"),
            new KeyValuePair < string, string > ("40", "Hukuoka [Fukuoka]"),
            new KeyValuePair < string, string > ("41", "Saga"),
            new KeyValuePair < string, string > ("42", "Nagasaki"),
            new KeyValuePair < string, string > ("43", "Kumamoto"),
            new KeyValuePair < string, string > ("44", "Ôita [Oita]"),
            new KeyValuePair < string, string > ("45", "Miyazaki"),
            new KeyValuePair < string, string > ("46", "Kagosima [Kagoshima]"),
            new KeyValuePair < string, string > ("47", "Okinawa")
        };
            public static List<KeyValuePair<string, string>> provincesJAM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Kingston"),
            new KeyValuePair < string, string > ("02", "Saint Andrew"),
            new KeyValuePair < string, string > ("03", "Saint Thomas"),
            new KeyValuePair < string, string > ("04", "Portland"),
            new KeyValuePair < string, string > ("05", "Saint Mary"),
            new KeyValuePair < string, string > ("06", "Saint Ann"),
            new KeyValuePair < string, string > ("07", "Trelawny"),
            new KeyValuePair < string, string > ("08", "Saint James"),
            new KeyValuePair < string, string > ("09", "Hanover"),
            new KeyValuePair < string, string > ("10", "Westmoreland"),
            new KeyValuePair < string, string > ("11", "Saint Elizabeth"),
            new KeyValuePair < string, string > ("12", "Manchester"),
            new KeyValuePair < string, string > ("13", "Clarendon"),
            new KeyValuePair < string, string > ("14", "Saint Catherine")
        };
            public static List<KeyValuePair<string, string>> provincesISR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("D", "El Janubi / HaDarom"),
            new KeyValuePair < string, string > ("HA", "Ḥeifa / H̱efa "),
            new KeyValuePair < string, string > ("JM", "Al Quds / Yerushalayim"),
            new KeyValuePair < string, string > ("M", "HaDarom / HaMerkaz"),
            new KeyValuePair < string, string > ("TA", "Tell Abib / Tel-Aviv"),
            new KeyValuePair < string, string > ("Z", "Esh Shamali / Ha Ẕafon")
        };
            public static List<KeyValuePair<string, string>> provincesIRL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CE", "Clare"),
            new KeyValuePair < string, string > ("CN", "Cavan"),
            new KeyValuePair < string, string > ("CO", "Cork"),
            new KeyValuePair < string, string > ("CW", "Carlow"),
            new KeyValuePair < string, string > ("D", "Dublin"),
            new KeyValuePair < string, string > ("DL", "Donegal"),
            new KeyValuePair < string, string > ("G", "Galway"),
            new KeyValuePair < string, string > ("KE", "Kildare"),
            new KeyValuePair < string, string > ("KK", "Kilkenny"),
            new KeyValuePair < string, string > ("KY", "Kerry"),
            new KeyValuePair < string, string > ("LD", "Longford"),
            new KeyValuePair < string, string > ("LH", "Louth"),
            new KeyValuePair < string, string > ("LK", "Limerick"),
            new KeyValuePair < string, string > ("LM", "Leitrim"),
            new KeyValuePair < string, string > ("LS", "Laois"),
            new KeyValuePair < string, string > ("MH", "Meath"),
            new KeyValuePair < string, string > ("MN", "Monaghan"),
            new KeyValuePair < string, string > ("MO", "Mayo"),
            new KeyValuePair < string, string > ("OY", "Offaly"),
            new KeyValuePair < string, string > ("RN", "Roscommon"),
            new KeyValuePair < string, string > ("SO", "Sligo"),
            new KeyValuePair < string, string > ("TA", "Tipperary"),
            new KeyValuePair < string, string > ("WD", "Waterford"),
            new KeyValuePair < string, string > ("WH", "Westmeath"),
            new KeyValuePair < string, string > ("WW", "Wicklow"),
            new KeyValuePair < string, string > ("WX", "Wexford")
        };
            public static List<KeyValuePair<string, string>> provincesIRQ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AN", "Al Anbar"),
            new KeyValuePair < string, string > ("AR", "Arbil"),
            new KeyValuePair < string, string > ("BA", "Al Basrah"),
            new KeyValuePair < string, string > ("BB", "Babil"),
            new KeyValuePair < string, string > ("BG", "Baghdad"),
            new KeyValuePair < string, string > ("DA", "Dahuk"),
            new KeyValuePair < string, string > ("DI", "Diyalá"),
            new KeyValuePair < string, string > ("DQ", "Dhi Qar"),
            new KeyValuePair < string, string > ("KA", "Karbala'"),
            new KeyValuePair < string, string > ("MA", "Maysan"),
            new KeyValuePair < string, string > ("MU", "Al Muthannáa"),
            new KeyValuePair < string, string > ("NA", "An Najaf"),
            new KeyValuePair < string, string > ("NI", "Ninawá"),
            new KeyValuePair < string, string > ("QA", "Al Qadisiyah"),
            new KeyValuePair < string, string > ("SD", "salaḩ ad Din"),
            new KeyValuePair < string, string > ("SU", "As Sulaymaniyah"),
            new KeyValuePair < string, string > ("TS", "At Ta'mim"),
            new KeyValuePair < string, string > ("WA", "Wasit")
        };
            public static List<KeyValuePair<string, string>> provincesIRN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Azarbayjan-e Sharqi"),
            new KeyValuePair < string, string > ("02", "Azarbayjan-e Gharbi"),
            new KeyValuePair < string, string > ("03", "Ardabil"),
            new KeyValuePair < string, string > ("04", "Esfahann"),
            new KeyValuePair < string, string > ("05", "Ilam"),
            new KeyValuePair < string, string > ("06", "Bushehr"),
            new KeyValuePair < string, string > ("07", "Tehran"),
            new KeyValuePair < string, string > ("08", "Chahar Maḩall va Bakhtiari"),
            new KeyValuePair < string, string > ("10", "Khuzestan"),
            new KeyValuePair < string, string > ("11", "Zanjan"),
            new KeyValuePair < string, string > ("12", "Semnan"),
            new KeyValuePair < string, string > ("13", "Sistan va Baluchestan"),
            new KeyValuePair < string, string > ("14", "Fars"),
            new KeyValuePair < string, string > ("15", "Kerman"),
            new KeyValuePair < string, string > ("16", "Kordestan"),
            new KeyValuePair < string, string > ("17", "Kermanshah"),
            new KeyValuePair < string, string > ("18", "Kohgiluyeh va Buyer Aḩmad"),
            new KeyValuePair < string, string > ("19", "Gilan"),
            new KeyValuePair < string, string > ("20", "Lorestan"),
            new KeyValuePair < string, string > ("21", "Mazandaran"),
            new KeyValuePair < string, string > ("22", "Markazi"),
            new KeyValuePair < string, string > ("23", "Hormozgan"),
            new KeyValuePair < string, string > ("24", "Hamadan"),
            new KeyValuePair < string, string > ("25", "Yazd"),
            new KeyValuePair < string, string > ("26", "Qom"),
            new KeyValuePair < string, string > ("27", "Golestan"),
            new KeyValuePair < string, string > ("28", "Qazvin"),
            new KeyValuePair < string, string > ("29", "Khorasan-e Janubi"),
            new KeyValuePair < string, string > ("30", "Khorasan-e Razavi"),
            new KeyValuePair < string, string > ("31", "Khorasan-e Shemali")
        };
            public static List<KeyValuePair<string, string>> provincesIDN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AC", "Aceh"),
            new KeyValuePair < string, string > ("BA", "Bali"),
            new KeyValuePair < string, string > ("BB", "Bangka Belitung"),
            new KeyValuePair < string, string > ("BE", "Bengkulu"),
            new KeyValuePair < string, string > ("BT", "Banten"),
            new KeyValuePair < string, string > ("GO", "Gorontalo"),
            new KeyValuePair < string, string > ("JA", "Jambi"),
            new KeyValuePair < string, string > ("JB", "Jawa Barat"),
            new KeyValuePair < string, string > ("JI", "Jawa Timur"),
            new KeyValuePair < string, string > ("JK", "Jakarta Raya"),
            new KeyValuePair < string, string > ("JT", "Jawa Tengah"),
            new KeyValuePair < string, string > ("KB", "Kalimantan Barat"),
            new KeyValuePair < string, string > ("KI", "Kalimantan Timur"),
            new KeyValuePair < string, string > ("KR", "Kepulauan Riau"),
            new KeyValuePair < string, string > ("KS", "Kalimantan Selatan"),
            new KeyValuePair < string, string > ("KT", "Kalimantan Tengah"),
            new KeyValuePair < string, string > ("LA", "Lampung"),
            new KeyValuePair < string, string > ("MA", "Maluku"),
            new KeyValuePair < string, string > ("MU", "Maluku Utara"),
            new KeyValuePair < string, string > ("NB", "Nusa Tenggara Barat"),
            new KeyValuePair < string, string > ("NT", "Nusa Tenggara Timur"),
            new KeyValuePair < string, string > ("PA", "Papua"),
            new KeyValuePair < string, string > ("PB", "Papua Barat"),
            new KeyValuePair < string, string > ("PB", "Papua Barat"),
            new KeyValuePair < string, string > ("RI", "Riau"),
            new KeyValuePair < string, string > ("SA", "Sulawesi Utara"),
            new KeyValuePair < string, string > ("SB", "Sumatera Barat"),
            new KeyValuePair < string, string > ("SG", "Sulawesi Tenggara"),
            new KeyValuePair < string, string > ("SN", "Sulawesi Selatan"),
            new KeyValuePair < string, string > ("SS", "Sumatera Selatan"),
            new KeyValuePair < string, string > ("ST", "Sulawesi Tengah"),
            new KeyValuePair < string, string > ("SU", "Sumatera Utara"),
            new KeyValuePair < string, string > ("YO", "Yogyakarta")
        };
            public static List<KeyValuePair<string, string>> provincesIND = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AN", "Andaman and Nicobar Islands"),
            new KeyValuePair < string, string > ("AP", "Andhra Pradesh"),
            new KeyValuePair < string, string > ("AR", "Arunachal Pradesh"),
            new KeyValuePair < string, string > ("AS", "Assam"),
            new KeyValuePair < string, string > ("BR", "Bihar"),
            new KeyValuePair < string, string > ("CH", "Chandigarh"),
            new KeyValuePair < string, string > ("CT", "Chhattisgarh"),
            new KeyValuePair < string, string > ("DD", "Daman and Diu"),
            new KeyValuePair < string, string > ("DL", "Delhi"),
            new KeyValuePair < string, string > ("DN", "Dadra and Nagar Haveli"),
            new KeyValuePair < string, string > ("GA", "Goa"),
            new KeyValuePair < string, string > ("GJ", "Gujarat"),
            new KeyValuePair < string, string > ("HP", "Himachal Pradesh"),
            new KeyValuePair < string, string > ("HR", "Haryana"),
            new KeyValuePair < string, string > ("JH", "Jharkhand"),
            new KeyValuePair < string, string > ("JK", "Jammu and Kashmir"),
            new KeyValuePair < string, string > ("KA", "Karnataka"),
            new KeyValuePair < string, string > ("KL", "Kerala"),
            new KeyValuePair < string, string > ("LD", "Lakshadweep"),
            new KeyValuePair < string, string > ("MH", "Maharashtra"),
            new KeyValuePair < string, string > ("ML", "Meghalaya"),
            new KeyValuePair < string, string > ("MN", "Manipur"),
            new KeyValuePair < string, string > ("MP", "Madhya Pradesh"),
            new KeyValuePair < string, string > ("MZ", "Mizoram"),
            new KeyValuePair < string, string > ("NL", "Nagaland"),
            new KeyValuePair < string, string > ("OR", "Orissa"),
            new KeyValuePair < string, string > ("PB", "Punjab"),
            new KeyValuePair < string, string > ("PY", "Pondicherry"),
            new KeyValuePair < string, string > ("RJ", "Rajasthan"),
            new KeyValuePair < string, string > ("SK", "Sikkim"),
            new KeyValuePair < string, string > ("TN", "Tamil Nadu"),
            new KeyValuePair < string, string > ("TR", "Tripura"),
            new KeyValuePair < string, string > ("UP", "Uttar Pradesh"),
            new KeyValuePair < string, string > ("WB", "West Bengal")
        };
            public static List<KeyValuePair<string, string>> provincesISL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("0", "Reykjavik"),
            new KeyValuePair < string, string > ("1", "Höfuðborgarsvæði utan Reykjavikur"),
            new KeyValuePair < string, string > ("2", "Suðurnes"),
            new KeyValuePair < string, string > ("3", "Vesturland"),
            new KeyValuePair < string, string > ("4", "Vestfirðir"),
            new KeyValuePair < string, string > ("5", "Norðurland vestra"),
            new KeyValuePair < string, string > ("6", "Norðurland eystra"),
            new KeyValuePair < string, string > ("7", "Austurland"),
            new KeyValuePair < string, string > ("8", "Suðurland")
        };
            public static List<KeyValuePair<string, string>> provincesHUN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Baranya"),
            new KeyValuePair < string, string > ("BC", "Bekescsaba"),
            new KeyValuePair < string, string > ("BE", "Bekes"),
            new KeyValuePair < string, string > ("BK", "Bacs-Kiskun"),
            new KeyValuePair < string, string > ("BU", "Budapest"),
            new KeyValuePair < string, string > ("BZ", "Borsod-Aba&#250;j-Zemplen"),
            new KeyValuePair < string, string > ("CS", "Csongrad"),
            new KeyValuePair < string, string > ("DE", "Debrecen"),
            new KeyValuePair < string, string > ("DU", "Dunaujvaros"),
            new KeyValuePair < string, string > ("EG", "Eger"),
            new KeyValuePair < string, string > ("FE", "Fejer"),
            new KeyValuePair < string, string > ("GS", "Gyor-Moson-Sopron"),
            new KeyValuePair < string, string > ("GY", "Gyor"),
            new KeyValuePair < string, string > ("HB", "Hajd&#250;-Bihar"),
            new KeyValuePair < string, string > ("HE", "Heves"),
            new KeyValuePair < string, string > ("HV", "Hodmezovasarhely"),
            new KeyValuePair < string, string > ("JN", "Jasz-Nagykun-Szolnok"),
            new KeyValuePair < string, string > ("KE", "Komarom-Esztergom"),
            new KeyValuePair < string, string > ("KM", "Kecskemet"),
            new KeyValuePair < string, string > ("KV", "Kaposvar"),
            new KeyValuePair < string, string > ("MI", "Miskolc"),
            new KeyValuePair < string, string > ("NK", "Nagykanizsa"),
            new KeyValuePair < string, string > ("NO", "Nograd"),
            new KeyValuePair < string, string > ("NY", "Nyiregyhaza"),
            new KeyValuePair < string, string > ("PE", "Pest"),
            new KeyValuePair < string, string > ("PS", "Pecs"),
            new KeyValuePair < string, string > ("SD", "Szeged"),
            new KeyValuePair < string, string > ("SF", "Szekesfehervar"),
            new KeyValuePair < string, string > ("SH", "Szombathely"),
            new KeyValuePair < string, string > ("SK", "Szolnok"),
            new KeyValuePair < string, string > ("SN", "Sopron"),
            new KeyValuePair < string, string > ("SO", "Somogy"),
            new KeyValuePair < string, string > ("SS", "Szekszard"),
            new KeyValuePair < string, string > ("ST", "Salgotarjan"),
            new KeyValuePair < string, string > ("SZ", "Szabolcs-Szatmar-Bereg"),
            new KeyValuePair < string, string > ("TB", "Tatabanya"),
            new KeyValuePair < string, string > ("TO", "Tolna"),
            new KeyValuePair < string, string > ("VA", "Vas"),
            new KeyValuePair < string, string > ("VE", "Veszprem"),
            new KeyValuePair < string, string > ("VM", "Veszprem"),
            new KeyValuePair < string, string > ("ZA", "Zala"),
            new KeyValuePair < string, string > ("ZE", "Zalaegerszeg")
        };
            public static List<KeyValuePair<string, string>> provincesHND = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AT", "Atlantida"),
            new KeyValuePair < string, string > ("CH", "Choluteca"),
            new KeyValuePair < string, string > ("CL", "Colon"),
            new KeyValuePair < string, string > ("CM", "Comayagua"),
            new KeyValuePair < string, string > ("CP", "Copan"),
            new KeyValuePair < string, string > ("CR", "Cortes"),
            new KeyValuePair < string, string > ("EP", "El Paraiso"),
            new KeyValuePair < string, string > ("FM", "Francisco Morazan"),
            new KeyValuePair < string, string > ("GD", "Gracias a Dios"),
            new KeyValuePair < string, string > ("IB", "Islas de la Bahia"),
            new KeyValuePair < string, string > ("IN", "Intibuca"),
            new KeyValuePair < string, string > ("LE", "Lempira"),
            new KeyValuePair < string, string > ("LP", "La Paz"),
            new KeyValuePair < string, string > ("OC", "Ocotepeque"),
            new KeyValuePair < string, string > ("OL", "Olancho"),
            new KeyValuePair < string, string > ("SB", "Santa Barbara"),
            new KeyValuePair < string, string > ("VA", "Valle"),
            new KeyValuePair < string, string > ("YO", "Yoro")
        };
            public static List<KeyValuePair<string, string>> provincesHTI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AR", "Artibonite"),
            new KeyValuePair < string, string > ("CE", "Centre"),
            new KeyValuePair < string, string > ("GA", "Grande-Anse"),
            new KeyValuePair < string, string > ("ND", "Nord"),
            new KeyValuePair < string, string > ("NE", "Nord-Est"),
            new KeyValuePair < string, string > ("NI", "Nippes"),
            new KeyValuePair < string, string > ("NO", "Nord-Ouest"),
            new KeyValuePair < string, string > ("OU", "Ouest"),
            new KeyValuePair < string, string > ("SD", "Sud"),
            new KeyValuePair < string, string > ("SE", "Sud-Est")
        };
            public static List<KeyValuePair<string, string>> provincesGUY = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Barima-Waini"),
            new KeyValuePair < string, string > ("CU", "Cuyuni-Mazaruni"),
            new KeyValuePair < string, string > ("DE", "Demerara-Mahaica"),
            new KeyValuePair < string, string > ("EB", "East Berbice-Corentyne"),
            new KeyValuePair < string, string > ("ES", "Essequibo Islands-West Demerara"),
            new KeyValuePair < string, string > ("MA", "Mahaica-Berbice"),
            new KeyValuePair < string, string > ("PM", "Pomeroon-Supenaam"),
            new KeyValuePair < string, string > ("PT", "Potaro-Siparuni"),
            new KeyValuePair < string, string > ("UD", "Upper Demerara-Berbice"),
            new KeyValuePair < string, string > ("UT", "Upper Takutu-Upper Essequibo")
        };
            public static List<KeyValuePair<string, string>> provincesGNB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Bafata"),
            new KeyValuePair < string, string > ("BL", "Bolama"),
            new KeyValuePair < string, string > ("BM", "Biombo"),
            new KeyValuePair < string, string > ("BS", "Bissau"),
            new KeyValuePair < string, string > ("CA", "Cacheu"),
            new KeyValuePair < string, string > ("GA", "Gab&#250;"),
            new KeyValuePair < string, string > ("OI", "Oio"),
            new KeyValuePair < string, string > ("QU", "Quinara"),
            new KeyValuePair < string, string > ("TO", "Tombali ")
        };
            public static List<KeyValuePair<string, string>> provincesGIN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BE", "Beyla"),
            new KeyValuePair < string, string > ("BF", "Boffa"),
            new KeyValuePair < string, string > ("BK", "Boke"),
            new KeyValuePair < string, string > ("CO", "Coyah"),
            new KeyValuePair < string, string > ("DB", "Dabola"),
            new KeyValuePair < string, string > ("DI", "Dinguiraye"),
            new KeyValuePair < string, string > ("DL", "Dalaba"),
            new KeyValuePair < string, string > ("DU", "Dubreka"),
            new KeyValuePair < string, string > ("FA", "Faranah"),
            new KeyValuePair < string, string > ("FO", "Forecariah"),
            new KeyValuePair < string, string > ("FR", "Fria"),
            new KeyValuePair < string, string > ("GA", "Gaoual"),
            new KeyValuePair < string, string > ("GU", "Guekedou"),
            new KeyValuePair < string, string > ("KA", "Kankan"),
            new KeyValuePair < string, string > ("KB", "Koubia"),
            new KeyValuePair < string, string > ("KD", "Kindia"),
            new KeyValuePair < string, string > ("KE", "Kerouane"),
            new KeyValuePair < string, string > ("KN", "Koundara"),
            new KeyValuePair < string, string > ("KO", "Kouroussa"),
            new KeyValuePair < string, string > ("KS", "Kissidougou"),
            new KeyValuePair < string, string > ("LA", "Labe"),
            new KeyValuePair < string, string > ("LE", "Lelouma"),
            new KeyValuePair < string, string > ("LO", "Lola"),
            new KeyValuePair < string, string > ("MC", "Macenta"),
            new KeyValuePair < string, string > ("MD", "Mandiana"),
            new KeyValuePair < string, string > ("ML", "Mali"),
            new KeyValuePair < string, string > ("MM", "Mamou"),
            new KeyValuePair < string, string > ("NZ", "Nzerekore"),
            new KeyValuePair < string, string > ("PI", "Pita"),
            new KeyValuePair < string, string > ("SI", "Siguiri"),
            new KeyValuePair < string, string > ("TE", "Telimele"),
            new KeyValuePair < string, string > ("TO", "Tougue"),
            new KeyValuePair < string, string > ("YO", "Yomou")
        };
            public static List<KeyValuePair<string, string>> provincesGTM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AV", "Alta Verapaz"),
            new KeyValuePair < string, string > ("BV", "Baja Verapaz"),
            new KeyValuePair < string, string > ("CM", "Chimaltenango"),
            new KeyValuePair < string, string > ("CQ", "Chiquimula"),
            new KeyValuePair < string, string > ("ES", "Escuintla"),
            new KeyValuePair < string, string > ("GU", "Guatemala"),
            new KeyValuePair < string, string > ("HU", "Huehuetenango"),
            new KeyValuePair < string, string > ("IZ", "Izabal"),
            new KeyValuePair < string, string > ("JA", "Jalapa"),
            new KeyValuePair < string, string > ("JU", "Jutiapa"),
            new KeyValuePair < string, string > ("PE", "Peten"),
            new KeyValuePair < string, string > ("PR", "El Progreso"),
            new KeyValuePair < string, string > ("QC", "Quiche"),
            new KeyValuePair < string, string > ("QZ", "Quetzaltenango"),
            new KeyValuePair < string, string > ("RE", "Retalhuleu"),
            new KeyValuePair < string, string > ("SA", "Sacatepequez"),
            new KeyValuePair < string, string > ("SM", "San Marcos"),
            new KeyValuePair < string, string > ("SO", "Solola"),
            new KeyValuePair < string, string > ("SR", "Santa Rosa"),
            new KeyValuePair < string, string > ("SU", "Suchitepequez"),
            new KeyValuePair < string, string > ("TO", "Totonicapan"),
            new KeyValuePair < string, string > ("ZA", "Zacapa")
        };
            public static List<KeyValuePair<string, string>> provincesGRD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Saint Andrew"),
            new KeyValuePair < string, string > ("02", "Saint David"),
            new KeyValuePair < string, string > ("03", "Saint George"),
            new KeyValuePair < string, string > ("04", "Saint John"),
            new KeyValuePair < string, string > ("05", "Saint Mark"),
            new KeyValuePair < string, string > ("06", "Saint Patrick"),
            new KeyValuePair < string, string > ("10", "Southern Grenadine Islands")
        };
            public static List<KeyValuePair<string, string>> provincesGRL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("KU", "Kommune Kujalleq"),
            new KeyValuePair < string, string > ("QA", "Qaasuitsup Kommunia"),
            new KeyValuePair < string, string > ("QE", "Qeqqata Kommunia"),
            new KeyValuePair < string, string > ("SM", "Kommuneqarfik Sermersooq")
        };
            public static List<KeyValuePair<string, string>> provincesGRC = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Aitolia kai Akarnania"),
            new KeyValuePair < string, string > ("03", "Voiotia"),
            new KeyValuePair < string, string > ("04", "Evvoia"),
            new KeyValuePair < string, string > ("05", "Evrytania"),
            new KeyValuePair < string, string > ("06", "Fthiotida"),
            new KeyValuePair < string, string > ("07", "Fokida"),
            new KeyValuePair < string, string > ("11", "Argolida"),
            new KeyValuePair < string, string > ("12", "Arkadia"),
            new KeyValuePair < string, string > ("13", "Achaia"),
            new KeyValuePair < string, string > ("14", "Ileia"),
            new KeyValuePair < string, string > ("15", "Korinthia"),
            new KeyValuePair < string, string > ("16", "Lakonia"),
            new KeyValuePair < string, string > ("17", "Messinia"),
            new KeyValuePair < string, string > ("21", "Zakynthos"),
            new KeyValuePair < string, string > ("22", "Kerkyra"),
            new KeyValuePair < string, string > ("23", "Kefallonia"),
            new KeyValuePair < string, string > ("24", "Lefkada"),
            new KeyValuePair < string, string > ("31", "Arta"),
            new KeyValuePair < string, string > ("32", "Thesprotia"),
            new KeyValuePair < string, string > ("33", "Ioannina"),
            new KeyValuePair < string, string > ("34", "Preveza"),
            new KeyValuePair < string, string > ("41", "Karditsa"),
            new KeyValuePair < string, string > ("42", "Larisa"),
            new KeyValuePair < string, string > ("43", "Magnisia"),
            new KeyValuePair < string, string > ("44", "Trikala"),
            new KeyValuePair < string, string > ("51", "Grevena"),
            new KeyValuePair < string, string > ("52", "Drama"),
            new KeyValuePair < string, string > ("53", "Imathia"),
            new KeyValuePair < string, string > ("54", "Thessaloniki"),
            new KeyValuePair < string, string > ("55", "Kavala"),
            new KeyValuePair < string, string > ("56", "Kastoria"),
            new KeyValuePair < string, string > ("57", "Kilkis"),
            new KeyValuePair < string, string > ("58", "Kozani"),
            new KeyValuePair < string, string > ("59", "Pella"),
            new KeyValuePair < string, string > ("61", "Pieria"),
            new KeyValuePair < string, string > ("62", "Serres"),
            new KeyValuePair < string, string > ("63", "Florina"),
            new KeyValuePair < string, string > ("64", "Chalkidiki"),
            new KeyValuePair < string, string > ("69", "Agio Oros"),
            new KeyValuePair < string, string > ("71", "Evros"),
            new KeyValuePair < string, string > ("72", "Xanthi"),
            new KeyValuePair < string, string > ("73", "Rodopi"),
            new KeyValuePair < string, string > ("81", "Dodekanisos"),
            new KeyValuePair < string, string > ("82", "Kyklades"),
            new KeyValuePair < string, string > ("83", "Lesvos"),
            new KeyValuePair < string, string > ("84", "Samos"),
            new KeyValuePair < string, string > ("85", "Chios"),
            new KeyValuePair < string, string > ("91", "Irakleio"),
            new KeyValuePair < string, string > ("92", "Lasithi"),
            new KeyValuePair < string, string > ("93", "Rethymno"),
            new KeyValuePair < string, string > ("94", "Chania"),
            new KeyValuePair < string, string > ("A1", "Attiki")
        };
            public static List<KeyValuePair<string, string>> provincesGHA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AA", "Greater Accra"),
            new KeyValuePair < string, string > ("AH", "Ashanti"),
            new KeyValuePair < string, string > ("BA", "Brong-Ahafo"),
            new KeyValuePair < string, string > ("CP", "Central"),
            new KeyValuePair < string, string > ("EP", "Eastern"),
            new KeyValuePair < string, string > ("NP", "Northern"),
            new KeyValuePair < string, string > ("TV", "Volta"),
            new KeyValuePair < string, string > ("UE", "Upper East"),
            new KeyValuePair < string, string > ("UW", "Upper West"),
            new KeyValuePair < string, string > ("WP", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesDEU = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BB", "Brandenburg"),
            new KeyValuePair < string, string > ("BE", "Berlin"),
            new KeyValuePair < string, string > ("BW", "Baden-Wurttemberg"),
            new KeyValuePair < string, string > ("BY", "Bayern"),
            new KeyValuePair < string, string > ("HB", "Bremen"),
            new KeyValuePair < string, string > ("HE", "Hessen"),
            new KeyValuePair < string, string > ("HH", "Hamburg"),
            new KeyValuePair < string, string > ("MV", "Mecklenburg-Vorpommern"),
            new KeyValuePair < string, string > ("NI", "Niedersachsen"),
            new KeyValuePair < string, string > ("NW", "Nordrhein-Westfalen"),
            new KeyValuePair < string, string > ("RP", "Rheinland-Pfalz"),
            new KeyValuePair < string, string > ("SH", "Schleswig-Holstein"),
            new KeyValuePair < string, string > ("SL", "Saarland"),
            new KeyValuePair < string, string > ("SN", "Sachsen"),
            new KeyValuePair < string, string > ("ST", "Sachsen-Anhalt"),
            new KeyValuePair < string, string > ("TH", "Thuringen")
        };
            public static List<KeyValuePair<string, string>> provincesGEO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AB", "Abkhazia"),
            new KeyValuePair < string, string > ("AJ", "Ajaria"),
            new KeyValuePair < string, string > ("GU", "Guria"),
            new KeyValuePair < string, string > ("IM", "Imeret'i"),
            new KeyValuePair < string, string > ("KA", "Kakhet'i"),
            new KeyValuePair < string, string > ("KK", "K'vemo K'art'li"),
            new KeyValuePair < string, string > ("MM", "Mts'khet'a-Mt'ianet'i"),
            new KeyValuePair < string, string > ("RL", "Racha-Lech'khumi-K'vemo Svanet'i"),
            new KeyValuePair < string, string > ("SJ", "Samts'khe-Javakhet'i"),
            new KeyValuePair < string, string > ("SK", "Shida K'art'li"),
            new KeyValuePair < string, string > ("SZ", "Samegrelo-Zemo Svanet'i"),
            new KeyValuePair < string, string > ("TB", "T'bilisi")
        };
            public static List<KeyValuePair<string, string>> provincesGMB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("B", "Banjul"),
            new KeyValuePair < string, string > ("L", "Lower River"),
            new KeyValuePair < string, string > ("M", "Central River"),
            new KeyValuePair < string, string > ("N", "North Bank"),
            new KeyValuePair < string, string > ("U", "Upper River"),
            new KeyValuePair < string, string > ("W", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesGAB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Estuaire"),
            new KeyValuePair < string, string > ("2", "Haut-Ogooue"),
            new KeyValuePair < string, string > ("3", "Moyen-Ogooue"),
            new KeyValuePair < string, string > ("4", "Ngounie"),
            new KeyValuePair < string, string > ("5", "Nyanga"),
            new KeyValuePair < string, string > ("6", "Ogooue-Ivindo"),
            new KeyValuePair < string, string > ("7", "Ogooue-Lolo"),
            new KeyValuePair < string, string > ("8", "Ogooue-Maritime"),
            new KeyValuePair < string, string > ("9", "Woleu-Ntem")
        };
            public static List<KeyValuePair<string, string>> provincesFRA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CP", "Clipperton"),
            new KeyValuePair < string, string > ("01", "Ain"),
            new KeyValuePair < string, string > ("02", "Aisne"),
            new KeyValuePair < string, string > ("03", "Allier"),
            new KeyValuePair < string, string > ("04", "Alpes-de-Haute-Provence"),
            new KeyValuePair < string, string > ("05", "Hautes-Alpes"),
            new KeyValuePair < string, string > ("06", "Alpes-Maritimes"),
            new KeyValuePair < string, string > ("07", "Ardeche"),
            new KeyValuePair < string, string > ("08", "Ardennes"),
            new KeyValuePair < string, string > ("09", "Ariege"),
            new KeyValuePair < string, string > ("10", "Aube"),
            new KeyValuePair < string, string > ("11", "Aude"),
            new KeyValuePair < string, string > ("12", "Aveyron"),
            new KeyValuePair < string, string > ("13", "Bouches-du-Rhone"),
            new KeyValuePair < string, string > ("14", "Calvados"),
            new KeyValuePair < string, string > ("15", "Cantal"),
            new KeyValuePair < string, string > ("16", "Charente"),
            new KeyValuePair < string, string > ("17", "Charente-Maritime"),
            new KeyValuePair < string, string > ("18", "Cher"),
            new KeyValuePair < string, string > ("19", "Correze"),
            new KeyValuePair < string, string > ("21", "Cote-d'Or"),
            new KeyValuePair < string, string > ("22", "Cotes-d'Armor"),
            new KeyValuePair < string, string > ("23", "Creuse"),
            new KeyValuePair < string, string > ("24", "Dordogne"),
            new KeyValuePair < string, string > ("25", "Doubs"),
            new KeyValuePair < string, string > ("26", "Drome"),
            new KeyValuePair < string, string > ("27", "Eure"),
            new KeyValuePair < string, string > ("28", "Eure-et-Loir"),
            new KeyValuePair < string, string > ("29", "Finistere"),
            new KeyValuePair < string, string > ("2A", "Corse-du-Sud"),
            new KeyValuePair < string, string > ("2B", "Haute-Corse"),
            new KeyValuePair < string, string > ("30", "Gard"),
            new KeyValuePair < string, string > ("31", "Haute-Garonne"),
            new KeyValuePair < string, string > ("32", "Gers"),
            new KeyValuePair < string, string > ("33", "Gironde"),
            new KeyValuePair < string, string > ("34", "Herault"),
            new KeyValuePair < string, string > ("35", "Ille-et-Vilaine"),
            new KeyValuePair < string, string > ("36", "Indre"),
            new KeyValuePair < string, string > ("37", "Indre-et-Loire"),
            new KeyValuePair < string, string > ("38", "Isere"),
            new KeyValuePair < string, string > ("39", "Jura"),
            new KeyValuePair < string, string > ("40", "Landes"),
            new KeyValuePair < string, string > ("41", "Loir-et-Cher"),
            new KeyValuePair < string, string > ("42", "Loire"),
            new KeyValuePair < string, string > ("43", "Haute-Loire"),
            new KeyValuePair < string, string > ("44", "Loire-Atlantique"),
            new KeyValuePair < string, string > ("45", "Loiret"),
            new KeyValuePair < string, string > ("46", "Lot"),
            new KeyValuePair < string, string > ("47", "Lot-et-Garonne"),
            new KeyValuePair < string, string > ("48", "Lozere"),
            new KeyValuePair < string, string > ("49", "Maine-et-Loire"),
            new KeyValuePair < string, string > ("50", "Manche"),
            new KeyValuePair < string, string > ("51", "Marne"),
            new KeyValuePair < string, string > ("52", "Haute-Marne"),
            new KeyValuePair < string, string > ("53", "Mayenne"),
            new KeyValuePair < string, string > ("54", "Meurthe-et-Moselle"),
            new KeyValuePair < string, string > ("55", "Meuse"),
            new KeyValuePair < string, string > ("56", "Morbihan"),
            new KeyValuePair < string, string > ("57", "Moselle"),
            new KeyValuePair < string, string > ("58", "Nievre"),
            new KeyValuePair < string, string > ("59", "Nord"),
            new KeyValuePair < string, string > ("60", "Oise"),
            new KeyValuePair < string, string > ("61", "Orne"),
            new KeyValuePair < string, string > ("62", "Pas-de-Calais"),
            new KeyValuePair < string, string > ("63", "Puy-de-Dome"),
            new KeyValuePair < string, string > ("64", "Pyrenees-Atlantiques"),
            new KeyValuePair < string, string > ("65", "Hautes-Pyrenees"),
            new KeyValuePair < string, string > ("66", "Pyrenees-Orientales"),
            new KeyValuePair < string, string > ("67", "Bas-Rhin"),
            new KeyValuePair < string, string > ("68", "Haut-Rhin"),
            new KeyValuePair < string, string > ("69", "Rhone"),
            new KeyValuePair < string, string > ("70", "Haute-Saone"),
            new KeyValuePair < string, string > ("71", "Saone-et-Loire"),
            new KeyValuePair < string, string > ("72", "Sarthe"),
            new KeyValuePair < string, string > ("73", "Savoie"),
            new KeyValuePair < string, string > ("74", "Haute-Savoie"),
            new KeyValuePair < string, string > ("75", "Paris"),
            new KeyValuePair < string, string > ("76", "Seine-Maritime"),
            new KeyValuePair < string, string > ("77", "Seine-et-Marne"),
            new KeyValuePair < string, string > ("78", "Yvelines"),
            new KeyValuePair < string, string > ("79", "Deux-Sevres"),
            new KeyValuePair < string, string > ("80", "Somme"),
            new KeyValuePair < string, string > ("81", "Tarn"),
            new KeyValuePair < string, string > ("82", "Tarn-et-Garonne"),
            new KeyValuePair < string, string > ("83", "Var"),
            new KeyValuePair < string, string > ("84", "Vaucluse"),
            new KeyValuePair < string, string > ("85", "Vendee"),
            new KeyValuePair < string, string > ("86", "Vienne"),
            new KeyValuePair < string, string > ("87", "Haute-Vienne"),
            new KeyValuePair < string, string > ("88", "Vosges"),
            new KeyValuePair < string, string > ("89", "Yonne"),
            new KeyValuePair < string, string > ("90", "Territoire de Belfort"),
            new KeyValuePair < string, string > ("91", "Essonne"),
            new KeyValuePair < string, string > ("92", "Hauts-de-Seine"),
            new KeyValuePair < string, string > ("93", "Seine-Saint-Denis"),
            new KeyValuePair < string, string > ("94", "Val-de-Marne"),
            new KeyValuePair < string, string > ("95", "Val-d'Oise")
        };
            public static List<KeyValuePair<string, string>> provincesFIN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Ahvenanmaan maakunta"),
            new KeyValuePair < string, string > ("02", "Etela-Karjala"),
            new KeyValuePair < string, string > ("03", "Etela-Pohjanmaa"),
            new KeyValuePair < string, string > ("04", "Etela-Savo"),
            new KeyValuePair < string, string > ("05", "Kainuu"),
            new KeyValuePair < string, string > ("06", "Kanta-Hame"),
            new KeyValuePair < string, string > ("07", "Keski-Pohjanmaa"),
            new KeyValuePair < string, string > ("08", "Keski-Suomi"),
            new KeyValuePair < string, string > ("09", "Kymenlaakso"),
            new KeyValuePair < string, string > ("10", "Lappi"),
            new KeyValuePair < string, string > ("11", "Pirkanmaa"),
            new KeyValuePair < string, string > ("12", "Pohjanmaa"),
            new KeyValuePair < string, string > ("13", "Pohjois-Karjala"),
            new KeyValuePair < string, string > ("14", "Pohjois-Pohjanmaa"),
            new KeyValuePair < string, string > ("15", "Pohjois-Savo"),
            new KeyValuePair < string, string > ("16", "Paijat-Hame"),
            new KeyValuePair < string, string > ("17", "Satakunta"),
            new KeyValuePair < string, string > ("18", "Uusimaa"),
            new KeyValuePair < string, string > ("19", "Varsinais-Suomi")
        };
            public static List<KeyValuePair<string, string>> provincesFJI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("C", "Central"),
            new KeyValuePair < string, string > ("E", "Eastern"),
            new KeyValuePair < string, string > ("N", "Northern"),
            new KeyValuePair < string, string > ("R", "Rotuma"),
            new KeyValuePair < string, string > ("W", "Western")
        };
            public static List<KeyValuePair<string, string>> provincesETH = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AA", "Adis Abeba"),
            new KeyValuePair < string, string > ("AF", "Afar"),
            new KeyValuePair < string, string > ("AM", "Amara"),
            new KeyValuePair < string, string > ("BE", "Binshangul Gumuz"),
            new KeyValuePair < string, string > ("DD", "Dire Dawa"),
            new KeyValuePair < string, string > ("GA", "Gambela Hizboch"),
            new KeyValuePair < string, string > ("HA", "Hareri Hizb"),
            new KeyValuePair < string, string > ("OR", "Oromiya"),
            new KeyValuePair < string, string > ("SN", "YeDebub Biheroch Bihereseboch")
        };
            public static List<KeyValuePair<string, string>> provincesEST = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("37", "Harjumaa"),
            new KeyValuePair < string, string > ("39", "Hiiumaa"),
            new KeyValuePair < string, string > ("44", "Ida-Virumaa"),
            new KeyValuePair < string, string > ("49", "J&#245;gevamaa"),
            new KeyValuePair < string, string > ("51", "Jarvamaa"),
            new KeyValuePair < string, string > ("57", "Laanemaa"),
            new KeyValuePair < string, string > ("59", "Laane-Virumaa"),
            new KeyValuePair < string, string > ("65", "P&#245;lvamaa"),
            new KeyValuePair < string, string > ("67", "Parnumaa"),
            new KeyValuePair < string, string > ("70", "Raplamaa"),
            new KeyValuePair < string, string > ("74", "Saaremaa"),
            new KeyValuePair < string, string > ("78", "Tartumaa"),
            new KeyValuePair < string, string > ("82", "Valgamaa"),
            new KeyValuePair < string, string > ("84", "Viljandimaa"),
            new KeyValuePair < string, string > ("86", "V&#245;rumaa")
        };
            public static List<KeyValuePair<string, string>> provincesERI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AN", "Anseba"),
            new KeyValuePair < string, string > ("DK", "Debubawi Keyih Bahri"),
            new KeyValuePair < string, string > ("DU", "Debub"),
            new KeyValuePair < string, string > ("GB", "Gash-Barka"),
            new KeyValuePair < string, string > ("MA", "Maakel"),
            new KeyValuePair < string, string > ("SK", "Semenawi Keyih Bahri")
        };
            public static List<KeyValuePair<string, string>> provincesGNQ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AN", "Annobon"),
            new KeyValuePair < string, string > ("BN", "Bioko Norte"),
            new KeyValuePair < string, string > ("BS", "Bioko Sur"),
            new KeyValuePair < string, string > ("CS", "Centro Sur"),
            new KeyValuePair < string, string > ("KN", "Kie-Ntem"),
            new KeyValuePair < string, string > ("LI", "Litoral"),
            new KeyValuePair < string, string > ("WN", "Wele-Nzas")
        };
            public static List<KeyValuePair<string, string>> provincesSLV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AH", "Ahuachapan"),
            new KeyValuePair < string, string > ("CA", "Caba&#241;as"),
            new KeyValuePair < string, string > ("CH", "Chalatenango"),
            new KeyValuePair < string, string > ("CU", "Cuscatlan"),
            new KeyValuePair < string, string > ("LI", "La Libertad"),
            new KeyValuePair < string, string > ("MO", "Morazan"),
            new KeyValuePair < string, string > ("PA", "La Paz"),
            new KeyValuePair < string, string > ("SA", "Santa Ana"),
            new KeyValuePair < string, string > ("SM", "San Miguel"),
            new KeyValuePair < string, string > ("SO", "Sonsonate"),
            new KeyValuePair < string, string > ("SS", "San Salvador"),
            new KeyValuePair < string, string > ("SV", "San Vicente"),
            new KeyValuePair < string, string > ("UN", "La Union"),
            new KeyValuePair < string, string > ("US", "Usulutan")
        };
            public static List<KeyValuePair<string, string>> provincesEGY = new List<KeyValuePair<string, string>>()
        {
                new KeyValuePair < string, string > ("---", "- none -"),
                new KeyValuePair < string, string > ("ALX", "Al Iskandariyah"),
                new KeyValuePair < string, string > ("ASN", "Aswan"),
                new KeyValuePair < string, string > ("AST", "Asyut"),
                new KeyValuePair < string, string > ("BA", "Al Baḩr al Aḩmar"),
                new KeyValuePair < string, string > ("BH", "Al Buḩayrah"),
                new KeyValuePair < string, string > ("BNS", "Bani Suwayf"),
                new KeyValuePair < string, string > ("C", "Al Qahirah"),
                new KeyValuePair < string, string > ("DK", "Ad Daqahliyah"),
                new KeyValuePair < string, string > ("DT", "Dumyat"),
                new KeyValuePair < string, string > ("FYM", "Al Fayyum"),
                new KeyValuePair < string, string > ("GH", "Al Gharbiyah"),
                new KeyValuePair < string, string > ("GZ", "Al Jizah"),
                new KeyValuePair < string, string > ("HU", "Ḩulwan"),
                new KeyValuePair < string, string > ("IS", "Al Isma'iliyah"),
                new KeyValuePair < string, string > ("JS", "Janub Sina'"),
                new KeyValuePair < string, string > ("KB", "Al Qalyubiyah"),
                new KeyValuePair < string, string > ("KFS", "Kafr ash Shaykh"),
                new KeyValuePair < string, string > ("KN", "Qina"),
                new KeyValuePair < string, string > ("LX", "Al Uqsur"),
                new KeyValuePair < string, string > ("MN", "Al Minya"),
                new KeyValuePair < string, string > ("MNF", "Al Minufiyah"),
                new KeyValuePair < string, string > ("MT", "Matruḩ"),
                new KeyValuePair < string, string > ("PTS", "Bur Sa‘id"),
                new KeyValuePair < string, string > ("SHG", "Suhaj"),
                new KeyValuePair < string, string > ("SHR", "Ash Sharqiyah"),
                new KeyValuePair < string, string > ("SIN", "Shamal Sina'"),
                new KeyValuePair < string, string > ("SU", "As Sadis min Uktubar"),
                new KeyValuePair < string, string > ("SUZ", "As Suways"),
                new KeyValuePair < string, string > ("WAD", "Al Wadi al Jadid")
            };
            public static List<KeyValuePair<string, string>> provincesECU = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Azuay"),
            new KeyValuePair < string, string > ("B", "Bolivar"),
            new KeyValuePair < string, string > ("C", "Carchi"),
            new KeyValuePair < string, string > ("D", "Orellana"),
            new KeyValuePair < string, string > ("E", "Esmeraldas"),
            new KeyValuePair < string, string > ("F", "Ca&#241;ar"),
            new KeyValuePair < string, string > ("G", "Guayas"),
            new KeyValuePair < string, string > ("H", "Chimborazo"),
            new KeyValuePair < string, string > ("I", "Imbabura"),
            new KeyValuePair < string, string > ("L", "Loja"),
            new KeyValuePair < string, string > ("M", "Manabi"),
            new KeyValuePair < string, string > ("N", "Napo"),
            new KeyValuePair < string, string > ("O", "El Oro"),
            new KeyValuePair < string, string > ("P", "Pichincha"),
            new KeyValuePair < string, string > ("R", "Los Rios"),
            new KeyValuePair < string, string > ("S", "Morona-Santiago"),
            new KeyValuePair < string, string > ("SD", "Santo Domingo de los Tsáchilas"),
            new KeyValuePair < string, string > ("SE", "Santa Elena"),
            new KeyValuePair < string, string > ("T", "Tungurahua"),
            new KeyValuePair < string, string > ("U", "Sucumbios"),
            new KeyValuePair < string, string > ("W", "Galapagos"),
            new KeyValuePair < string, string > ("X", "Cotopaxi"),
            new KeyValuePair < string, string > ("Y", "Pastaza"),
            new KeyValuePair < string, string > ("Z", "Zamora-Chinchipe")
        };
            public static List<KeyValuePair<string, string>> provincesDOM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Distrito Nacional (Santo Domingo)"),
            new KeyValuePair < string, string > ("02", "Azua"),
            new KeyValuePair < string, string > ("03", "Bahoruco"),
            new KeyValuePair < string, string > ("04", "Barahona"),
            new KeyValuePair < string, string > ("05", "Dajabon"),
            new KeyValuePair < string, string > ("06", "Duarte"),
            new KeyValuePair < string, string > ("07", "La Estrelleta "),
            new KeyValuePair < string, string > ("08", "El Seybo"),
            new KeyValuePair < string, string > ("09", "Espaillat"),
            new KeyValuePair < string, string > ("10", "Independencia"),
            new KeyValuePair < string, string > ("11", "La Altagracia"),
            new KeyValuePair < string, string > ("12", "La Romana"),
            new KeyValuePair < string, string > ("13", "La Vega"),
            new KeyValuePair < string, string > ("14", "Maria Trinidad Sanchez"),
            new KeyValuePair < string, string > ("15", "Monte Cristi"),
            new KeyValuePair < string, string > ("16", "Pedernales"),
            new KeyValuePair < string, string > ("17", "Peravia"),
            new KeyValuePair < string, string > ("18", "Puerto Plata"),
            new KeyValuePair < string, string > ("19", "Salcedo"),
            new KeyValuePair < string, string > ("20", "Samana"),
            new KeyValuePair < string, string > ("21", "San Cristobal"),
            new KeyValuePair < string, string > ("22", "San Juan"),
            new KeyValuePair < string, string > ("23", "San Pedro de Macoris"),
            new KeyValuePair < string, string > ("24", "Sanchez Ramirez"),
            new KeyValuePair < string, string > ("25", "Santiago"),
            new KeyValuePair < string, string > ("26", "Santiago Rodriguez"),
            new KeyValuePair < string, string > ("27", "Valverde"),
            new KeyValuePair < string, string > ("28", "Monse&#241;or Nouel"),
            new KeyValuePair < string, string > ("29", "Monte Plata"),
            new KeyValuePair < string, string > ("30", "Hato Mayor"),
            new KeyValuePair < string, string > ("31", "San Jose de Ocoa"),
            new KeyValuePair < string, string > ("32", "Santo Domingo")
        };
            public static List<KeyValuePair<string, string>> provincesDMA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("02", "Saint Andrew"),
            new KeyValuePair < string, string > ("03", "Saint David"),
            new KeyValuePair < string, string > ("04", "Saint George"),
            new KeyValuePair < string, string > ("05", "Saint John"),
            new KeyValuePair < string, string > ("06", "Saint Joseph"),
            new KeyValuePair < string, string > ("07", "Saint Luke"),
            new KeyValuePair < string, string > ("08", "Saint Mark"),
            new KeyValuePair < string, string > ("09", "Saint Patrick"),
            new KeyValuePair < string, string > ("10", "Saint Paul"),
            new KeyValuePair < string, string > ("11", "Saint Peter")
        };
            public static List<KeyValuePair<string, string>> provincesDJI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AR", "‘Arta"),
            new KeyValuePair < string, string > ("AS", "Ali Sabieh"),
            new KeyValuePair < string, string > ("DI", "Dikhil"),
            new KeyValuePair < string, string > ("DJ", "Djibouti"),
            new KeyValuePair < string, string > ("OB", "Obock"),
            new KeyValuePair < string, string > ("TA", "Tadjoura")
        };
            public static List<KeyValuePair<string, string>> provincesDNK = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("81", "Region Nordjylland"),
            new KeyValuePair < string, string > ("82", "Region Midtjylland"),
            new KeyValuePair < string, string > ("83", "Region Syddanmark"),
            new KeyValuePair < string, string > ("84", "Region Hovedstaden"),
            new KeyValuePair < string, string > ("85", "Region Sjalland")
        };
            public static List<KeyValuePair<string, string>> provincesCZE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("JC", "Jihocesky kraj"),
            new KeyValuePair < string, string > ("JM", "Jihomoravsky kraj"),
            new KeyValuePair < string, string > ("KA", "Karlovarsky kraj"),
            new KeyValuePair < string, string > ("KR", "Kralovehradecky kraj"),
            new KeyValuePair < string, string > ("LI", "Liberecky kraj"),
            new KeyValuePair < string, string > ("MO", "Moravskoslezsky kraj"),
            new KeyValuePair < string, string > ("OL", "Olomoucky kraj"),
            new KeyValuePair < string, string > ("PA", "Pardubicky kraj"),
            new KeyValuePair < string, string > ("PL", "Plzensky kraj"),
            new KeyValuePair < string, string > ("PR", "Praha, hlavni mesto"),
            new KeyValuePair < string, string > ("ST", "Stredocesky kraj"),
            new KeyValuePair < string, string > ("US", "Ustecky kraj"),
            new KeyValuePair < string, string > ("VY", "Vysocina"),
            new KeyValuePair < string, string > ("ZL", "Zlinsky kraj")
        };
            public static List<KeyValuePair<string, string>> provincesCYP = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Lefkosia"),
            new KeyValuePair < string, string > ("02", "Lemesos"),
            new KeyValuePair < string, string > ("03", "Larnaka"),
            new KeyValuePair < string, string > ("04", "Ammochostos"),
            new KeyValuePair < string, string > ("05", "Pafos"),
            new KeyValuePair < string, string > ("06", "Keryneia")
        };
            public static List<KeyValuePair<string, string>> provincesCUB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Pinar del Rio"),
            new KeyValuePair < string, string > ("02", "La Habana"),
            new KeyValuePair < string, string > ("03", "Ciudad de La Habana"),
            new KeyValuePair < string, string > ("04", "Matanzas"),
            new KeyValuePair < string, string > ("05", "Villa Clara"),
            new KeyValuePair < string, string > ("06", "Cienfuegos"),
            new KeyValuePair < string, string > ("07", "Sancti Spiritus"),
            new KeyValuePair < string, string > ("08", "Ciego de &#193;vila"),
            new KeyValuePair < string, string > ("09", "Camaguey"),
            new KeyValuePair < string, string > ("10", "Las Tunas"),
            new KeyValuePair < string, string > ("11", "Holguin"),
            new KeyValuePair < string, string > ("12", "Granma"),
            new KeyValuePair < string, string > ("13", "Santiago de Cuba"),
            new KeyValuePair < string, string > ("14", "Guantanamo"),
            new KeyValuePair < string, string > ("99", "Isla de la Juventud")
        };
            public static List<KeyValuePair<string, string>> provincesHRV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Zagrebacka županija"),
            new KeyValuePair < string, string > ("02", "Krapinsko-zagorska županija"),
            new KeyValuePair < string, string > ("03", "Sisacko-moslavacka županija"),
            new KeyValuePair < string, string > ("04", "Karlovacka županija"),
            new KeyValuePair < string, string > ("05", "Varaždinska županija"),
            new KeyValuePair < string, string > ("06", "Koprivnicko-križevacka županija"),
            new KeyValuePair < string, string > ("07", "Bjelovarsko-bilogorska županija"),
            new KeyValuePair < string, string > ("08", "Primorsko-goranska županija"),
            new KeyValuePair < string, string > ("09", "Licko-senjska županija"),
            new KeyValuePair < string, string > ("10", "Viroviticko-podravska županija"),
            new KeyValuePair < string, string > ("11", "Požesko-slavonska županija"),
            new KeyValuePair < string, string > ("12", "Brodsko-posavska županija"),
            new KeyValuePair < string, string > ("13", "Zadarska županija"),
            new KeyValuePair < string, string > ("14", "Osjecko-baranjska županija"),
            new KeyValuePair < string, string > ("15", "sibensko-kninska županija"),
            new KeyValuePair < string, string > ("16", "Vukovarsko-srijemska �upanija"),
            new KeyValuePair < string, string > ("17", "Vukovarsko-srijemska županija"),
            new KeyValuePair < string, string > ("18", "Istarska županija"),
            new KeyValuePair < string, string > ("19", "Dubrovacko-neretvanska županija"),
            new KeyValuePair < string, string > ("20", "Međimurska županija"),
            new KeyValuePair < string, string > ("21", "Grad Zagreb")
        };
            public static List<KeyValuePair<string, string>> provincesCIV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Lagunes (Region des)"),
            new KeyValuePair < string, string > ("02", "Haut-Sassandra (Region du)"),
            new KeyValuePair < string, string > ("03", "Savanes (Region des)"),
            new KeyValuePair < string, string > ("04", "Vallee du Bandama (Region de la)"),
            new KeyValuePair < string, string > ("05", "Moyen-Comoe (Region du)"),
            new KeyValuePair < string, string > ("06", "18 Montagnes (Region des)"),
            new KeyValuePair < string, string > ("07", "Lacs (Region des)"),
            new KeyValuePair < string, string > ("08", "Zanzan (Region du)"),
            new KeyValuePair < string, string > ("09", "Bas-Sassandra (Region du)"),
            new KeyValuePair < string, string > ("10", "Denguele (Region du)"),
            new KeyValuePair < string, string > ("11", "Nzi-Comoe (Region)"),
            new KeyValuePair < string, string > ("12", "Marahoue (Region de la)"),
            new KeyValuePair < string, string > ("13", "Sud-Comoe (Region du)"),
            new KeyValuePair < string, string > ("14", "Worodougou (Region du)"),
            new KeyValuePair < string, string > ("15", "Sud-Bandama (Region du)"),
            new KeyValuePair < string, string > ("16", "Agnebi (Region de l')"),
            new KeyValuePair < string, string > ("17", "Bafing (Region du)"),
            new KeyValuePair < string, string > ("18", "Fromager (Region du)"),
            new KeyValuePair < string, string > ("19", "Moyen-Cavally (Region du)")
        };
            public static List<KeyValuePair<string, string>> provincesCRI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Alajuela"),
            new KeyValuePair < string, string > ("C", "Cartago"),
            new KeyValuePair < string, string > ("G", "Guanacaste"),
            new KeyValuePair < string, string > ("H", "Heredia"),
            new KeyValuePair < string, string > ("L", "Limon"),
            new KeyValuePair < string, string > ("P", "Puntarenas"),
            new KeyValuePair < string, string > ("SJ", "San Jose")
        };
            public static List<KeyValuePair<string, string>> provincesCOG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BC", "Bas-Congo"),
            new KeyValuePair < string, string > ("BN", "Bandundu"),
            new KeyValuePair < string, string > ("EQ", "&#201;quateur"),
            new KeyValuePair < string, string > ("KA", "Katanga"),
            new KeyValuePair < string, string > ("KE", "Kasai-Oriental"),
            new KeyValuePair < string, string > ("KN", "Kinshasa"),
            new KeyValuePair < string, string > ("KW", "Kasai-Occidental"),
            new KeyValuePair < string, string > ("MA", "Maniema"),
            new KeyValuePair < string, string > ("NK", "Nord-Kivu"),
            new KeyValuePair < string, string > ("OR", "Orientale"),
            new KeyValuePair < string, string > ("SK", "Sud-Kivu")
        };
            public static List<KeyValuePair<string, string>> provincesCOD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("11", "Bouenza"),
            new KeyValuePair < string, string > ("12", "Pool"),
            new KeyValuePair < string, string > ("13", "Sangha"),
            new KeyValuePair < string, string > ("14", "Plateaux"),
            new KeyValuePair < string, string > ("15", "Cuvette-Ouest"),
            new KeyValuePair < string, string > ("2", "Lekoumou"),
            new KeyValuePair < string, string > ("5", "Kouilou"),
            new KeyValuePair < string, string > ("7", "Likouala"),
            new KeyValuePair < string, string > ("8", "Cuvette"),
            new KeyValuePair < string, string > ("9", "Niari"),
            new KeyValuePair < string, string > ("BZV", "Brazzaville")
        };
            public static List<KeyValuePair<string, string>> provincesCOM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Anjouan"),
            new KeyValuePair < string, string > ("G", "Grande Comore"),
            new KeyValuePair < string, string > ("M", "Moheli")
        };
            public static List<KeyValuePair<string, string>> provincesCOL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AMA", "Amazonas"),
            new KeyValuePair < string, string > ("ANT", "Antioquia"),
            new KeyValuePair < string, string > ("ARA", "Arauca"),
            new KeyValuePair < string, string > ("ATL", "Atlantico"),
            new KeyValuePair < string, string > ("BOL", "Bolivar"),
            new KeyValuePair < string, string > ("BOY", "Boyaca"),
            new KeyValuePair < string, string > ("CAL", "Caldas"),
            new KeyValuePair < string, string > ("CAQ", "Caqueta"),
            new KeyValuePair < string, string > ("CAS", "Casanare"),
            new KeyValuePair < string, string > ("CAU", "Cauca"),
            new KeyValuePair < string, string > ("CES", "Cesar"),
            new KeyValuePair < string, string > ("CHO", "Choco"),
            new KeyValuePair < string, string > ("COR", "Cordoba"),
            new KeyValuePair < string, string > ("CUN", "Cundinamarca"),
            new KeyValuePair < string, string > ("DC", "Distrito Capital de Bogota"),
            new KeyValuePair < string, string > ("GUA", "Guainia"),
            new KeyValuePair < string, string > ("GUV", "Guaviare"),
            new KeyValuePair < string, string > ("HUI", "Huila"),
            new KeyValuePair < string, string > ("LAG", "La Guajira"),
            new KeyValuePair < string, string > ("MAG", "Magdalena"),
            new KeyValuePair < string, string > ("MET", "Meta"),
            new KeyValuePair < string, string > ("NAR", "Nari&#241;o"),
            new KeyValuePair < string, string > ("NSA", "Norte de Santander"),
            new KeyValuePair < string, string > ("PUT", "Putumayo"),
            new KeyValuePair < string, string > ("QUI", "Quindio"),
            new KeyValuePair < string, string > ("RIS", "Risaralda"),
            new KeyValuePair < string, string > ("SAN", "Santander"),
            new KeyValuePair < string, string > ("SAP", "San Andres, Providencia y Santa Catalina"),
            new KeyValuePair < string, string > ("SUC", "Sucre"),
            new KeyValuePair < string, string > ("TOL", "Tolima"),
            new KeyValuePair < string, string > ("VAC", "Valle del Cauca"),
            new KeyValuePair < string, string > ("VAU", "Vaupes"),
            new KeyValuePair < string, string > ("VID", "Vichada")
        };
            public static List<KeyValuePair<string, string>> provincesCHN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("11", "Beijing"),
            new KeyValuePair < string, string > ("12", "Tianjin"),
            new KeyValuePair < string, string > ("13", "Hebei"),
            new KeyValuePair < string, string > ("14", "Shanxi"),
            new KeyValuePair < string, string > ("15", "Nei Mongol (mn)"),
            new KeyValuePair < string, string > ("21", "Liaoning"),
            new KeyValuePair < string, string > ("22", "Jilin"),
            new KeyValuePair < string, string > ("23", "Heilongjiang"),
            new KeyValuePair < string, string > ("31", "Shanghai"),
            new KeyValuePair < string, string > ("32", "Jiangsu"),
            new KeyValuePair < string, string > ("33", "Zhejiang"),
            new KeyValuePair < string, string > ("34", "Anhui"),
            new KeyValuePair < string, string > ("35", "Fujian"),
            new KeyValuePair < string, string > ("36", "Jiangxi"),
            new KeyValuePair < string, string > ("37", "Shandong"),
            new KeyValuePair < string, string > ("41", "Henan"),
            new KeyValuePair < string, string > ("42", "Hubei"),
            new KeyValuePair < string, string > ("43", "Hunan"),
            new KeyValuePair < string, string > ("44", "Guangdong"),
            new KeyValuePair < string, string > ("45", "Guangxi"),
            new KeyValuePair < string, string > ("46", "Hainan"),
            new KeyValuePair < string, string > ("50", "Chongqing"),
            new KeyValuePair < string, string > ("51", "Sichuan"),
            new KeyValuePair < string, string > ("52", "Guizhou"),
            new KeyValuePair < string, string > ("53", "Yunnan"),
            new KeyValuePair < string, string > ("54", "Xizang"),
            new KeyValuePair < string, string > ("61", "Shaanxi"),
            new KeyValuePair < string, string > ("62", "Gansu"),
            new KeyValuePair < string, string > ("63", "Qinghai"),
            new KeyValuePair < string, string > ("64", "Ningxia"),
            new KeyValuePair < string, string > ("65", "Xinjiang"),
            new KeyValuePair < string, string > ("71", "Taiwan"),
            new KeyValuePair < string, string > ("91", "Xianggang"),
            new KeyValuePair < string, string > ("92", "Aomen")
        };
            public static List<KeyValuePair<string, string>> provincesCHL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AI", "Aisen del General Carlos Ibanez del Campo"),
            new KeyValuePair < string, string > ("AN", "Antofagasta"),
            new KeyValuePair < string, string > ("AP", "Arica y Parinacota"),
            new KeyValuePair < string, string > ("AR", "Araucania"),
            new KeyValuePair < string, string > ("AT", "Atacama"),
            new KeyValuePair < string, string > ("BI", "Bio-Bio"),
            new KeyValuePair < string, string > ("CO", "Coquimbo"),
            new KeyValuePair < string, string > ("LI", "Libertador General Bernardo O'Higgins"),
            new KeyValuePair < string, string > ("LL", "Los Lagos"),
            new KeyValuePair < string, string > ("LR", "Los Rios"),
            new KeyValuePair < string, string > ("MA", "Magallanes"),
            new KeyValuePair < string, string > ("ML", "Maule"),
            new KeyValuePair < string, string > ("RM", "Region Metropolitana de Santiago"),
            new KeyValuePair < string, string > ("TA", "Tarapaca"),
            new KeyValuePair < string, string > ("VS", "Valparaiso")
        };
            public static List<KeyValuePair<string, string>> provincesTCD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BA", "Batha"),
            new KeyValuePair < string, string > ("BG", "Bahr el Gazel"),
            new KeyValuePair < string, string > ("BO", "Borkou"),
            new KeyValuePair < string, string > ("CB", "Chari-Baguirmi"),
            new KeyValuePair < string, string > ("EN", "Ennedi"),
            new KeyValuePair < string, string > ("GR", "Guera"),
            new KeyValuePair < string, string > ("HL", "Hadjer Lamis"),
            new KeyValuePair < string, string > ("KA", "Kanem"),
            new KeyValuePair < string, string > ("LC", "Lac"),
            new KeyValuePair < string, string > ("LO", "Logone-Occidental"),
            new KeyValuePair < string, string > ("LR", "Logone-Oriental"),
            new KeyValuePair < string, string > ("MA", "Mandoul"),
            new KeyValuePair < string, string > ("MC", "Moyen-Chari"),
            new KeyValuePair < string, string > ("ME", "Mayo-Kebbi-Est"),
            new KeyValuePair < string, string > ("MO", "Mayo-Kebbi-Ouest"),
            new KeyValuePair < string, string > ("ND", "Ndjamena"),
            new KeyValuePair < string, string > ("OD", "Ouaddai"),
            new KeyValuePair < string, string > ("SA", "Salamat"),
            new KeyValuePair < string, string > ("SI", "Sila"),
            new KeyValuePair < string, string > ("TA", "Tandjile"),
            new KeyValuePair < string, string > ("TI", "Tibesti"),
            new KeyValuePair < string, string > ("WF", "Wadi Fira")
        };
            public static List<KeyValuePair<string, string>> provincesCAF = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AC", "Ouham"),
            new KeyValuePair < string, string > ("BB", "Bamingui-Bangoran"),
            new KeyValuePair < string, string > ("BGF", "Bangui"),
            new KeyValuePair < string, string > ("BK", "Basse-Kotto"),
            new KeyValuePair < string, string > ("HK", "Haute-Kotto"),
            new KeyValuePair < string, string > ("HM", "Haut-Mbomou"),
            new KeyValuePair < string, string > ("HS", "Haute-Sangha / Mambere-Kadeï"),
            new KeyValuePair < string, string > ("KB", "Gribingui"),
            new KeyValuePair < string, string > ("KG", "Kemo-Gribingui"),
            new KeyValuePair < string, string > ("LB", "Lobaye"),
            new KeyValuePair < string, string > ("MB", "Mbomou"),
            new KeyValuePair < string, string > ("MP", "Ombella-Mpoko"),
            new KeyValuePair < string, string > ("NM", "Nana-Mambere"),
            new KeyValuePair < string, string > ("OP", "Ouham-Pende"),
            new KeyValuePair < string, string > ("SE", "Sangha"),
            new KeyValuePair < string, string > ("UK", "Ouaka"),
            new KeyValuePair < string, string > ("VK", "Vakaga")
        };
            public static List<KeyValuePair<string, string>> provincesCPV = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BR", "Brava"),
            new KeyValuePair < string, string > ("BV", "Boa Vista"),
            new KeyValuePair < string, string > ("CA", "Santa Catarina"),
            new KeyValuePair < string, string > ("CF", "Santa Catarina do Fogo"),
            new KeyValuePair < string, string > ("CR", "Santa Cruz"),
            new KeyValuePair < string, string > ("MA", "Maio"),
            new KeyValuePair < string, string > ("MO", "Mosteiros"),
            new KeyValuePair < string, string > ("PA", "Paul"),
            new KeyValuePair < string, string > ("PN", "Porto Novo"),
            new KeyValuePair < string, string > ("PR", "Praia"),
            new KeyValuePair < string, string > ("RB", "Ribeira Brava"),
            new KeyValuePair < string, string > ("RG", "Ribeira Grande"),
            new KeyValuePair < string, string > ("RS", "Ribeira Grande de Santiago"),
            new KeyValuePair < string, string > ("SD", "Sao Domingos"),
            new KeyValuePair < string, string > ("SF", "Sao Filipe"),
            new KeyValuePair < string, string > ("SL", "Sal"),
            new KeyValuePair < string, string > ("SM", "São Miguel"),
            new KeyValuePair < string, string > ("SS", "São Salvador do Mundo"),
            new KeyValuePair < string, string > ("SV", "São Vicente"),
            new KeyValuePair < string, string > ("TA", "Tarrafal"),
            new KeyValuePair < string, string > ("TS", "Tarrafal de São Nicolau")
        };
            public static List<KeyValuePair<string, string>> provincesCAN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AB", "Alberta"),
            new KeyValuePair < string, string > ("BC", "British Columbia"),
            new KeyValuePair < string, string > ("MB", "Manitoba"),
            new KeyValuePair < string, string > ("NB", "New Brunswick"),
            new KeyValuePair < string, string > ("NL", "Newfoundland and Labrador"),
            new KeyValuePair < string, string > ("NS", "Nova Scotia"),
            new KeyValuePair < string, string > ("NT", "Northwest Ter/ies"),
            new KeyValuePair < string, string > ("NU", "Nunavut"),
            new KeyValuePair < string, string > ("ON", "Ontario"),
            new KeyValuePair < string, string > ("PE", "Prince Edward Island"),
            new KeyValuePair < string, string > ("QC", "Quebec"),
            new KeyValuePair < string, string > ("SK", "Saskatchewan"),
            new KeyValuePair < string, string > ("YT", "Yukon Territory")
        };
            public static List<KeyValuePair<string, string>> provincesCMR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AD", "Adamaoua"),
            new KeyValuePair < string, string > ("CE", "Centre"),
            new KeyValuePair < string, string > ("EN", "Far North"),
            new KeyValuePair < string, string > ("ES", "East"),
            new KeyValuePair < string, string > ("LT", "Littoral"),
            new KeyValuePair < string, string > ("NO", "North"),
            new KeyValuePair < string, string > ("NW", "North-West"),
            new KeyValuePair < string, string > ("OU", "West"),
            new KeyValuePair < string, string > ("SU", "South"),
            new KeyValuePair < string, string > ("SW", "South-West")
        };
            public static List<KeyValuePair<string, string>> provincesKHM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Banteay Mean Chey"),
            new KeyValuePair < string, string > ("10", "Kracheh "),
            new KeyValuePair < string, string > ("11", "Mondol Kiri "),
            new KeyValuePair < string, string > ("12", "Phnom Penh "),
            new KeyValuePair < string, string > ("13", "Preah Vihear "),
            new KeyValuePair < string, string > ("14", "Prey Veaeng "),
            new KeyValuePair < string, string > ("15", "Pousaat "),
            new KeyValuePair < string, string > ("16", "Rotanak Kiri "),
            new KeyValuePair < string, string > ("17", "Siem Reab "),
            new KeyValuePair < string, string > ("18", "Krong Preah Sihanouk "),
            new KeyValuePair < string, string > ("19", "Stueng Traeng"),
            new KeyValuePair < string, string > ("2", "Baat Dambang "),
            new KeyValuePair < string, string > ("20", "Svaay Rieng "),
            new KeyValuePair < string, string > ("21", "Taakaev "),
            new KeyValuePair < string, string > ("22", "Otdar Mean Chey "),
            new KeyValuePair < string, string > ("23", "Krong Kaeb "),
            new KeyValuePair < string, string > ("24", "Krong Pailin "),
            new KeyValuePair < string, string > ("3", "Kampong Chaam "),
            new KeyValuePair < string, string > ("4", "Kampong Chhnang "),
            new KeyValuePair < string, string > ("5", "Kampong Spueu "),
            new KeyValuePair < string, string > ("6", "Kampong Thum "),
            new KeyValuePair < string, string > ("7", "Kampot "),
            new KeyValuePair < string, string > ("8", "Kandaal "),
            new KeyValuePair < string, string > ("9", "Kaoh Kong ")
        };
            public static List<KeyValuePair<string, string>> provincesBDI = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BB", "Bubanza"),
            new KeyValuePair < string, string > ("BL", "Bujumbura Rural"),
            new KeyValuePair < string, string > ("BM", "Bujumbura Mairie"),
            new KeyValuePair < string, string > ("BR", "Bururi"),
            new KeyValuePair < string, string > ("CA", "Cankuzo"),
            new KeyValuePair < string, string > ("CI", "Cibitoke"),
            new KeyValuePair < string, string > ("GI", "Gitega"),
            new KeyValuePair < string, string > ("KI", "Kirundo"),
            new KeyValuePair < string, string > ("KR", "Karuzi"),
            new KeyValuePair < string, string > ("KY", "Kayanza"),
            new KeyValuePair < string, string > ("MA", "Makamba"),
            new KeyValuePair < string, string > ("MU", "Muramvya"),
            new KeyValuePair < string, string > ("MW", "Mwaro"),
            new KeyValuePair < string, string > ("MY", "Muyinga"),
            new KeyValuePair < string, string > ("NG", "Ngozi"),
            new KeyValuePair < string, string > ("RT", "Rutana"),
            new KeyValuePair < string, string > ("RY", "Ruyigi")
        };
            public static List<KeyValuePair<string, string>> provincesBFA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BAL", "Bale"),
            new KeyValuePair < string, string > ("BAM", "Bam"),
            new KeyValuePair < string, string > ("BAN", "Banwa"),
            new KeyValuePair < string, string > ("BAZ", "Bazega"),
            new KeyValuePair < string, string > ("BGR", "Bougouriba"),
            new KeyValuePair < string, string > ("BLG", "Boulgou"),
            new KeyValuePair < string, string > ("BLK", "Boulkiemde"),
            new KeyValuePair < string, string > ("COM", "Comoe"),
            new KeyValuePair < string, string > ("GAN", "Ganzourgou"),
            new KeyValuePair < string, string > ("GNA", "Gnagna"),
            new KeyValuePair < string, string > ("GOU", "Gourma"),
            new KeyValuePair < string, string > ("HOU", "Houet"),
            new KeyValuePair < string, string > ("IOB", "Ioba"),
            new KeyValuePair < string, string > ("KAD", "Kadiogo"),
            new KeyValuePair < string, string > ("KEN", "Kenedougou"),
            new KeyValuePair < string, string > ("KMD", "Komondjari"),
            new KeyValuePair < string, string > ("KMP", "Kompienga"),
            new KeyValuePair < string, string > ("KOP", "Koulpelogo"),
            new KeyValuePair < string, string > ("KOS", "Kossi"),
            new KeyValuePair < string, string > ("KOT", "Kouritenga"),
            new KeyValuePair < string, string > ("KOW", "Kourweogo"),
            new KeyValuePair < string, string > ("LER", "Leraba"),
            new KeyValuePair < string, string > ("LOR", "Loroum"),
            new KeyValuePair < string, string > ("MOU", "Mouhoun"),
            new KeyValuePair < string, string > ("NAM", "Namentenga"),
            new KeyValuePair < string, string > ("NAO", "Nahouri"),
            new KeyValuePair < string, string > ("NAY", "Nayala"),
            new KeyValuePair < string, string > ("NOU", "Noumbiel"),
            new KeyValuePair < string, string > ("OUB", "Oubritenga"),
            new KeyValuePair < string, string > ("OUD", "Oudalan"),
            new KeyValuePair < string, string > ("PAS", "Passore"),
            new KeyValuePair < string, string > ("PON", "Poni"),
            new KeyValuePair < string, string > ("SEN", "Seno"),
            new KeyValuePair < string, string > ("SIS", "Sissili"),
            new KeyValuePair < string, string > ("SMT", "Sanmatenga"),
            new KeyValuePair < string, string > ("SNG", "Sanguie"),
            new KeyValuePair < string, string > ("SOM", "Soum"),
            new KeyValuePair < string, string > ("SOR", "Sourou"),
            new KeyValuePair < string, string > ("TAP", "Tapoa"),
            new KeyValuePair < string, string > ("TUI", "Tui"),
            new KeyValuePair < string, string > ("YAG", "Yagha"),
            new KeyValuePair < string, string > ("YAT", "Yatenga"),
            new KeyValuePair < string, string > ("ZIR", "Ziro"),
            new KeyValuePair < string, string > ("ZON", "Zondoma"),
            new KeyValuePair < string, string > ("ZOU", "Zoundweog")
        };
            public static List<KeyValuePair<string, string>> provincesBGR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Blagoevgrad"),
            new KeyValuePair < string, string > ("02", "Burgas"),
            new KeyValuePair < string, string > ("03", "Varna"),
            new KeyValuePair < string, string > ("04", "Veliko Tarnovo"),
            new KeyValuePair < string, string > ("05", "Vidin"),
            new KeyValuePair < string, string > ("06", "Vratsa"),
            new KeyValuePair < string, string > ("07", "Gabrovo"),
            new KeyValuePair < string, string > ("08", "Dobrich"),
            new KeyValuePair < string, string > ("09", "Kardzhali"),
            new KeyValuePair < string, string > ("10", "Kjustendil"),
            new KeyValuePair < string, string > ("11", "Lovech"),
            new KeyValuePair < string, string > ("12", "Montana"),
            new KeyValuePair < string, string > ("13", "Pazardzhik"),
            new KeyValuePair < string, string > ("14", "Pernik"),
            new KeyValuePair < string, string > ("15", "Pleven"),
            new KeyValuePair < string, string > ("16", "Plovdiv"),
            new KeyValuePair < string, string > ("17", "Razgrad"),
            new KeyValuePair < string, string > ("18", "Ruse"),
            new KeyValuePair < string, string > ("19", "Silistra"),
            new KeyValuePair < string, string > ("20", "Sliven"),
            new KeyValuePair < string, string > ("21", "Smolyan"),
            new KeyValuePair < string, string > ("22", "Sofija-Grad"),
            new KeyValuePair < string, string > ("23", "Sofia"),
            new KeyValuePair < string, string > ("24", "Stara Zagora"),
            new KeyValuePair < string, string > ("25", "Targovishte"),
            new KeyValuePair < string, string > ("26", "Haskovo"),
            new KeyValuePair < string, string > ("27", "Shumen"),
            new KeyValuePair < string, string > ("28", "Yambol")
        };
            public static List<KeyValuePair<string, string>> provincesBRN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BE", "Belait"),
            new KeyValuePair < string, string > ("BM", "Brunei-Muara"),
            new KeyValuePair < string, string > ("TE", "Temburong"),
            new KeyValuePair < string, string > ("TU", "Tutong")
        };
            public static List<KeyValuePair<string, string>> provincesBRA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AC", "Acre"),
            new KeyValuePair < string, string > ("AL", "Alagoas"),
            new KeyValuePair < string, string > ("AM", "Amazonas"),
            new KeyValuePair < string, string > ("AP", "Amapa"),
            new KeyValuePair < string, string > ("BA", "Bahia"),
            new KeyValuePair < string, string > ("CE", "Ceara"),
            new KeyValuePair < string, string > ("DF", "Distrito Federal"),
            new KeyValuePair < string, string > ("ES", "Espirito Santo"),
            new KeyValuePair < string, string > ("GO", "Goias"),
            new KeyValuePair < string, string > ("MA", "Maranhao"),
            new KeyValuePair < string, string > ("MG", "Minas Gerais"),
            new KeyValuePair < string, string > ("MS", "Mato Grosso do Sul"),
            new KeyValuePair < string, string > ("MT", "Mato Grosso"),
            new KeyValuePair < string, string > ("PA", "Para"),
            new KeyValuePair < string, string > ("PB", "Paraiba"),
            new KeyValuePair < string, string > ("PE", "Pernambuco"),
            new KeyValuePair < string, string > ("PI", "Piaui"),
            new KeyValuePair < string, string > ("PR", "Parana"),
            new KeyValuePair < string, string > ("RJ", "Rio de Janeiro"),
            new KeyValuePair < string, string > ("RN", "Rio Grande do Norte"),
            new KeyValuePair < string, string > ("RO", "Rond&#244;nia"),
            new KeyValuePair < string, string > ("RR", "Roraima"),
            new KeyValuePair < string, string > ("RS", "Rio Grande do Sul"),
            new KeyValuePair < string, string > ("SC", "Santa Catarina"),
            new KeyValuePair < string, string > ("SE", "Sergipe"),
            new KeyValuePair < string, string > ("SP", "Sao Paulo"),
            new KeyValuePair < string, string > ("TO", "Tocantins")
        };
            public static List<KeyValuePair<string, string>> provincesBWA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("CE", "Central"),
            new KeyValuePair < string, string > ("GH", "Ghanzi"),
            new KeyValuePair < string, string > ("KG", "Kgalagadi"),
            new KeyValuePair < string, string > ("KL", "Kgatleng"),
            new KeyValuePair < string, string > ("KW", "Kweneng"),
            new KeyValuePair < string, string > ("NE", "North-East"),
            new KeyValuePair < string, string > ("NW", "North-West"),
            new KeyValuePair < string, string > ("SE", "South-East"),
            new KeyValuePair < string, string > ("SO", "Southern")
        };
            public static List<KeyValuePair<string, string>> provincesBIH = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Unsko-Sanski Kanton"),
            new KeyValuePair < string, string > ("02", "Posavski Kanton"),
            new KeyValuePair < string, string > ("03", "Tuzlanski Kanton"),
            new KeyValuePair < string, string > ("04", "Zenicko-dobojski Kanton"),
            new KeyValuePair < string, string > ("05", "Bosansko-Podrinjski Kanton"),
            new KeyValuePair < string, string > ("06", "Srednjobosanski Kanton"),
            new KeyValuePair < string, string > ("07", "Hercegovacko-neretvanski Kanton"),
            new KeyValuePair < string, string > ("08", "Zapadnohercegovacki Kanton"),
            new KeyValuePair < string, string > ("09", "Kanton Sarajevo"),
            new KeyValuePair < string, string > ("10", "Kanton br. 10 (Livanjski kanton)"),
            new KeyValuePair < string, string > ("BRC", "Brcko Distrikt"),
            new KeyValuePair < string, string > ("BIH", "Federacija Bosne i Hercegovine"),
            new KeyValuePair < string, string > ("SRP", "Republika Srpska")
        };
            public static List<KeyValuePair<string, string>> provincesBES = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BO", "Boneiru"),
            new KeyValuePair < string, string > ("SA", "Saba"),
            new KeyValuePair < string, string > ("SE", "Sint Eustatius")
        };
            public static List<KeyValuePair<string, string>> provincesBTN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("11", "Paro"),
            new KeyValuePair < string, string > ("12", "Chhukha"),
            new KeyValuePair < string, string > ("13", "Ha"),
            new KeyValuePair < string, string > ("14", "Samtse"),
            new KeyValuePair < string, string > ("15", "Thimphu"),
            new KeyValuePair < string, string > ("21", "Tsirang"),
            new KeyValuePair < string, string > ("22", "Dagana"),
            new KeyValuePair < string, string > ("23", "Punakha"),
            new KeyValuePair < string, string > ("24", "Wangdue Phodrang"),
            new KeyValuePair < string, string > ("31", "Sarpang"),
            new KeyValuePair < string, string > ("32", "Trongsa"),
            new KeyValuePair < string, string > ("33", "Bumthang"),
            new KeyValuePair < string, string > ("34", "Zhemgang"),
            new KeyValuePair < string, string > ("41", "Trashigang"),
            new KeyValuePair < string, string > ("42", "Monggar"),
            new KeyValuePair < string, string > ("43", "Pemagatshel"),
            new KeyValuePair < string, string > ("44", "Lhuentse"),
            new KeyValuePair < string, string > ("45", "Samdrup Jongkha"),
            new KeyValuePair < string, string > ("GA", "Gasa"),
            new KeyValuePair < string, string > ("TY", "Trashi Yangtse")
        };
            public static List<KeyValuePair<string, string>> provincesBOL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("B", "El Beni"),
            new KeyValuePair < string, string > ("C", "Cochabamba"),
            new KeyValuePair < string, string > ("H", "Chuquisaca"),
            new KeyValuePair < string, string > ("L", "La Paz"),
            new KeyValuePair < string, string > ("N", "Pando"),
            new KeyValuePair < string, string > ("O", "Oruro"),
            new KeyValuePair < string, string > ("P", "Potosi"),
            new KeyValuePair < string, string > ("S", "Santa Cruz"),
            new KeyValuePair < string, string > ("T", "Tarija")
        };
            public static List<KeyValuePair<string, string>> provincesBEN = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AK", "Atakora"),
            new KeyValuePair < string, string > ("AL", "Alibori"),
            new KeyValuePair < string, string > ("AQ", "Atlantique"),
            new KeyValuePair < string, string > ("BO", "Borgou"),
            new KeyValuePair < string, string > ("CO", "Collines"),
            new KeyValuePair < string, string > ("DO", "Donga"),
            new KeyValuePair < string, string > ("KO", "Kouffo"),
            new KeyValuePair < string, string > ("LI", "Littoral"),
            new KeyValuePair < string, string > ("MO", "Mono"),
            new KeyValuePair < string, string > ("OU", "Oueme"),
            new KeyValuePair < string, string > ("PL", "Plateau"),
            new KeyValuePair < string, string > ("ZO", "Zou")
        };
            public static List<KeyValuePair<string, string>> provincesBLZ = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BZ", "Belize"),
            new KeyValuePair < string, string > ("CY", "Cayo"),
            new KeyValuePair < string, string > ("CZL", "Corozal"),
            new KeyValuePair < string, string > ("OW", "Orange Walk"),
            new KeyValuePair < string, string > ("SC", "Stann Creek"),
            new KeyValuePair < string, string > ("TOL", "Toledo")
        };
            public static List<KeyValuePair<string, string>> provincesBEL = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BRU", "Bruxelles-Capitale"),
            new KeyValuePair < string, string > ("VAN", "Antwerpen"),
            new KeyValuePair < string, string > ("VBR", "Vlaams Brabant"),
            new KeyValuePair < string, string > ("VLG", "Vlaamse Gewest"),
            new KeyValuePair < string, string > ("VLI", "Limburg"),
            new KeyValuePair < string, string > ("VOV", "Oost-Vlaanderen"),
            new KeyValuePair < string, string > ("VWV", "West-Vlaanderen"),
            new KeyValuePair < string, string > ("WAL", "Wallonne"),
            new KeyValuePair < string, string > ("WBR", "Brabant Wallon"),
            new KeyValuePair < string, string > ("WHT", "Hainaut"),
            new KeyValuePair < string, string > ("WLG", "Liege"),
            new KeyValuePair < string, string > ("WLX", "Luxembourg"),
            new KeyValuePair < string, string > ("WNA", "Namur")
        };
            public static List<KeyValuePair<string, string>> provincesBLR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("HM", "Horad Minsk"),
            new KeyValuePair < string, string > ("BR", "Brestskaya voblasts"),
            new KeyValuePair < string, string > ("HO", "Homyel'skaya voblasts"),
            new KeyValuePair < string, string > ("HR", "Hrodzenskaya voblasts"),
            new KeyValuePair < string, string > ("MA", "Mahilyowskaya voblasts"),
            new KeyValuePair < string, string > ("MI", "Minskaya voblasts"),
            new KeyValuePair < string, string > ("VI", "Vitsyebskaya voblasts")
        };
            public static List<KeyValuePair<string, string>> provincesBRB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Christ Church"),
            new KeyValuePair < string, string > ("02", "Saint Andrew"),
            new KeyValuePair < string, string > ("03", "Saint George"),
            new KeyValuePair < string, string > ("04", "Saint James"),
            new KeyValuePair < string, string > ("05", "Saint John"),
            new KeyValuePair < string, string > ("06", "Saint Joseph"),
            new KeyValuePair < string, string > ("07", "Saint Lucy"),
            new KeyValuePair < string, string > ("08", "Saint Michael"),
            new KeyValuePair < string, string > ("09", "Saint Peter"),
            new KeyValuePair < string, string > ("10", "Saint Philip"),
            new KeyValuePair < string, string > ("11", "Saint Thomas")
         };
            public static List<KeyValuePair<string, string>> provincesBGD = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Bandarban"),
            new KeyValuePair < string, string > ("02", "Barguna"),
            new KeyValuePair < string, string > ("03", "Bogra"),
            new KeyValuePair < string, string > ("04", "Brahmanbaria"),
            new KeyValuePair < string, string > ("05", "Bagerhat"),
            new KeyValuePair < string, string > ("06", "Barisal"),
            new KeyValuePair < string, string > ("07", "Bhola"),
            new KeyValuePair < string, string > ("08", "Comilla"),
            new KeyValuePair < string, string > ("09", "Chandpur"),
            new KeyValuePair < string, string > ("10", "Chittagong"),
            new KeyValuePair < string, string > ("11", "Cox's Bazar"),
            new KeyValuePair < string, string > ("12", "Chuadanga"),
            new KeyValuePair < string, string > ("13", "Dhaka"),
            new KeyValuePair < string, string > ("14", "Dinajpur"),
            new KeyValuePair < string, string > ("15", "Faridpur"),
            new KeyValuePair < string, string > ("16", "Feni"),
            new KeyValuePair < string, string > ("17", "Gopalganj"),
            new KeyValuePair < string, string > ("18", "Gazipur"),
            new KeyValuePair < string, string > ("19", "Gaibandha"),
            new KeyValuePair < string, string > ("20", "Habiganj"),
            new KeyValuePair < string, string > ("21", "Jamalpur"),
            new KeyValuePair < string, string > ("22", "Jessore"),
            new KeyValuePair < string, string > ("23", "Jhenaidah"),
            new KeyValuePair < string, string > ("24", "Jaipurhat"),
            new KeyValuePair < string, string > ("25", "Jhalakati"),
            new KeyValuePair < string, string > ("26", "Kishoreganj"),
            new KeyValuePair < string, string > ("27", "Khulna"),
            new KeyValuePair < string, string > ("28", "Kurigram"),
            new KeyValuePair < string, string > ("29", "Khagrachari"),
            new KeyValuePair < string, string > ("30", "Kushtia"),
            new KeyValuePair < string, string > ("31", "Lakshmipur"),
            new KeyValuePair < string, string > ("32", "Lalmonirhat"),
            new KeyValuePair < string, string > ("33", "Manikganj"),
            new KeyValuePair < string, string > ("34", "Mymensingh"),
            new KeyValuePair < string, string > ("35", "Munshiganj"),
            new KeyValuePair < string, string > ("36", "Madaripur"),
            new KeyValuePair < string, string > ("37", "Magura"),
            new KeyValuePair < string, string > ("38", "Moulvibazar"),
            new KeyValuePair < string, string > ("39", "Meherpur"),
            new KeyValuePair < string, string > ("40", "Narayanganj"),
            new KeyValuePair < string, string > ("41", "Netrakona"),
            new KeyValuePair < string, string > ("42", "Narsingdi"),
            new KeyValuePair < string, string > ("43", "Narail"),
            new KeyValuePair < string, string > ("44", "Natore"),
            new KeyValuePair < string, string > ("45", "Nawabganj"),
            new KeyValuePair < string, string > ("46", "Nilphamari"),
            new KeyValuePair < string, string > ("47", "Noakhali"),
            new KeyValuePair < string, string > ("48", "Naogaon"),
            new KeyValuePair < string, string > ("49", "Pabna"),
            new KeyValuePair < string, string > ("50", "Pirojpur"),
            new KeyValuePair < string, string > ("51", "Patuakhali"),
            new KeyValuePair < string, string > ("52", "Panchagarh"),
            new KeyValuePair < string, string > ("53", "Rajbari"),
            new KeyValuePair < string, string > ("54", "Rajshahi"),
            new KeyValuePair < string, string > ("55", "Rangpur"),
            new KeyValuePair < string, string > ("56", "Rangamati"),
            new KeyValuePair < string, string > ("57", "Sherpur"),
            new KeyValuePair < string, string > ("58", "Satkhira"),
            new KeyValuePair < string, string > ("59", "Sirajganj"),
            new KeyValuePair < string, string > ("60", "Sylhet"),
            new KeyValuePair < string, string > ("61", "Sunamganj"),
            new KeyValuePair < string, string > ("62", "Shariatpur"),
            new KeyValuePair < string, string > ("63", "Tangail"),
            new KeyValuePair < string, string > ("64", "Thakurgaon")
        };
            public static List<KeyValuePair<string, string>> provincesBHR = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("13", "Al Manamah"),
            new KeyValuePair < string, string > ("14", "Al Janubiyah"),
            new KeyValuePair < string, string > ("15", "Al Muḩarraq"),
            new KeyValuePair < string, string > ("16", "Al Wusta"),
            new KeyValuePair < string, string > ("17", "Ash Shamaliyah")
        };
            public static List<KeyValuePair<string, string>> provincesBHS = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AK", "Acklins"),
            new KeyValuePair < string, string > ("BI", "Bimini"),
            new KeyValuePair < string, string > ("BP", "Black Point"),
            new KeyValuePair < string, string > ("BY", "Berry Islands"),
            new KeyValuePair < string, string > ("CE", "Central Eleuthera"),
            new KeyValuePair < string, string > ("CI", "Cat Island"),
            new KeyValuePair < string, string > ("CK", "Crooked Island and Long Cay"),
            new KeyValuePair < string, string > ("CO", "Central Abaco"),
            new KeyValuePair < string, string > ("CS", "Central Andros"),
            new KeyValuePair < string, string > ("EG", "East Grand Bahama"),
            new KeyValuePair < string, string > ("EX", "Exuma"),
            new KeyValuePair < string, string > ("FC", "Fresh Creek"),
            new KeyValuePair < string, string > ("FP", "City of Freeport"),
            new KeyValuePair < string, string > ("GC", "Grand Cay"),
            new KeyValuePair < string, string > ("HI", "Harbour Island"),
            new KeyValuePair < string, string > ("HT", "Hope Town"),
            new KeyValuePair < string, string > ("IN", "Inagua"),
            new KeyValuePair < string, string > ("LI", "Long Island"),
            new KeyValuePair < string, string > ("MC", "Mangrove Cay"),
            new KeyValuePair < string, string > ("MG", "Mayaguana"),
            new KeyValuePair < string, string > ("MI", "Moores Island"),
            new KeyValuePair < string, string > ("NE", "North Eleuthera"),
            new KeyValuePair < string, string > ("NO", "North Abaco"),
            new KeyValuePair < string, string > ("NS", "North Andros"),
            new KeyValuePair < string, string > ("RC", "Rum Cay"),
            new KeyValuePair < string, string > ("RI", "Ragged Island"),
            new KeyValuePair < string, string > ("SA", "South Andros"),
            new KeyValuePair < string, string > ("SE", "South Eleuthera"),
            new KeyValuePair < string, string > ("SO", "South Abaco"),
            new KeyValuePair < string, string > ("SS", "San Salvador"),
            new KeyValuePair < string, string > ("SW", "Spanish Wells"),
            new KeyValuePair < string, string > ("WG", "West Grand Bahama")
        };
            public static List<KeyValuePair<string, string>> provincesAZE = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("NX", "Naxcivan"),
            new KeyValuePair < string, string > ("BA", "Baki"),
            new KeyValuePair < string, string > ("GA", "Gence"),
            new KeyValuePair < string, string > ("LA", "Lenkeran"),
            new KeyValuePair < string, string > ("MI", "Mingecevir"),
            new KeyValuePair < string, string > ("NA", "Naftalan"),
            new KeyValuePair < string, string > ("NV", "Naxcivan"),
            new KeyValuePair < string, string > ("SA", "seki"),
            new KeyValuePair < string, string > ("SM", "Sumqayit"),
            new KeyValuePair < string, string > ("SR", "sirvan"),
            new KeyValuePair < string, string > ("XA", "Xankendi"),
            new KeyValuePair < string, string > ("YE", "Yevlax"),
            new KeyValuePair < string, string > ("ABS", "Abseron"),
            new KeyValuePair < string, string > ("AGA", "Agstafa"),
            new KeyValuePair < string, string > ("AGC", "Agcabedi"),
            new KeyValuePair < string, string > ("AGM", "Agdam"),
            new KeyValuePair < string, string > ("AGS", "Agdas"),
            new KeyValuePair < string, string > ("AGU", "Agsu"),
            new KeyValuePair < string, string > ("AST", "Astara"),
            new KeyValuePair < string, string > ("BAB", "Babek"),
            new KeyValuePair < string, string > ("BAL", "Balaken"),
            new KeyValuePair < string, string > ("BAR", "Berde"),
            new KeyValuePair < string, string > ("BEY", "Beyleqan"),
            new KeyValuePair < string, string > ("BIL", "Bilesuvar"),
            new KeyValuePair < string, string > ("CAB", "Cebrayil"),
            new KeyValuePair < string, string > ("CAL", "Celilabad"),
            new KeyValuePair < string, string > ("CUL", "Culfa"),
            new KeyValuePair < string, string > ("DAS", "Daskesen"),
            new KeyValuePair < string, string > ("FUZ", "Fuzuli"),
            new KeyValuePair < string, string > ("GAD", "Gedebey"),
            new KeyValuePair < string, string > ("GOR", "Goranboy"),
            new KeyValuePair < string, string > ("GOY", "Goycay"),
            new KeyValuePair < string, string > ("GYG", "Göygöl"),
            new KeyValuePair < string, string > ("HAC", "Haciqabul"),
            new KeyValuePair < string, string > ("IMI", "İmisli"),
            new KeyValuePair < string, string > ("ISM", "İsmayilli"),
            new KeyValuePair < string, string > ("KAL", "Kelbecer"),
            new KeyValuePair < string, string > ("KAN", "Kengerli"),
            new KeyValuePair < string, string > ("KUR", "Kurdemir"),
            new KeyValuePair < string, string > ("LAC", "Lacin"),
            new KeyValuePair < string, string > ("LAN", "Lenkeran"),
            new KeyValuePair < string, string > ("LER", "Lerik"),
            new KeyValuePair < string, string > ("MAS", "Masalli"),
            new KeyValuePair < string, string > ("NEF", "Neftcala"),
            new KeyValuePair < string, string > ("OGU", "Oguz"),
            new KeyValuePair < string, string > ("ORD", "Ordubad"),
            new KeyValuePair < string, string > ("QAB", "Qebele"),
            new KeyValuePair < string, string > ("QAX", "Qax"),
            new KeyValuePair < string, string > ("QAZ", "Qazax"),
            new KeyValuePair < string, string > ("QBA", "Quba"),
            new KeyValuePair < string, string > ("QBI", "Qubadli"),
            new KeyValuePair < string, string > ("QOB", "Qobustan"),
            new KeyValuePair < string, string > ("QUS", "Qusar"),
            new KeyValuePair < string, string > ("SAB", "Sabirabad"),
            new KeyValuePair < string, string > ("SAD", "Sederek"),
            new KeyValuePair < string, string > ("SAH", "Sahbuz"),
            new KeyValuePair < string, string > ("SAK", "Seki"),
            new KeyValuePair < string, string > ("SAL", "Salyan"),
            new KeyValuePair < string, string > ("SAR", "Serur"),
            new KeyValuePair < string, string > ("SAT", "Saatli"),
            new KeyValuePair < string, string > ("SBN", "Sabran"),
            new KeyValuePair < string, string > ("SIY", "Siyezen"),
            new KeyValuePair < string, string > ("SKR", "Semkir"),
            new KeyValuePair < string, string > ("SMI", "Samaxi"),
            new KeyValuePair < string, string > ("SMX", "Samux"),
            new KeyValuePair < string, string > ("SUS", "Susa"),
            new KeyValuePair < string, string > ("TAR", "Terter"),
            new KeyValuePair < string, string > ("TOV", "Tovuz"),
            new KeyValuePair < string, string > ("UCA", "Ucar"),
            new KeyValuePair < string, string > ("XAC", "Xacmaz"),
            new KeyValuePair < string, string > ("XCI", "Xocali"),
            new KeyValuePair < string, string > ("XIZ", "Xizi"),
            new KeyValuePair < string, string > ("XVD", "Xocavend"),
            new KeyValuePair < string, string > ("YAR", "Yardimli"),
            new KeyValuePair < string, string > ("YEV", "Yevlax"),
            new KeyValuePair < string, string > ("ZAN", "Zengilan"),
            new KeyValuePair < string, string > ("ZAQ", "Zaqatala"),
            new KeyValuePair < string, string > ("ZAR", "Zerdab")
        };
            public static List<KeyValuePair<string, string>> provincesAUT = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("1", "Burgenland"),
            new KeyValuePair < string, string > ("2", "Karnten"),
            new KeyValuePair < string, string > ("3", "Niederosterreich"),
            new KeyValuePair < string, string > ("4", "Oberosterreich"),
            new KeyValuePair < string, string > ("5", "Salzburg"),
            new KeyValuePair < string, string > ("6", "Steiermark"),
            new KeyValuePair < string, string > ("7", "Tirol"),
            new KeyValuePair < string, string > ("8", "Vorarlberg"),
            new KeyValuePair < string, string > ("9", "Wien")
        };
            public static List<KeyValuePair<string, string>> provincesAUS = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("ACT", "Australian Capital Territory"),
            new KeyValuePair < string, string > ("NSW", "New South Wales"),
            new KeyValuePair < string, string > ("NT", "Northern Territory"),
            new KeyValuePair < string, string > ("QLD", "Queensland"),
            new KeyValuePair < string, string > ("SA", "South Australia"),
            new KeyValuePair < string, string > ("TAS", "Tasmania"),
            new KeyValuePair < string, string > ("VIC", "Victoria"),
            new KeyValuePair < string, string > ("WA", "Western Australia")
        };
            public static List<KeyValuePair<string, string>> provincesARM = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AG", "Aragatsotn"),
            new KeyValuePair < string, string > ("AR", "Ararat"),
            new KeyValuePair < string, string > ("AV", "Armavir"),
            new KeyValuePair < string, string > ("ER", "Erevan"),
            new KeyValuePair < string, string > ("GR", "Gegark'unik'"),
            new KeyValuePair < string, string > ("KT", "Kotayk'"),
            new KeyValuePair < string, string > ("LO", "Lory"),
            new KeyValuePair < string, string > ("SH", "Sirak"),
            new KeyValuePair < string, string > ("SU", "Syunik'"),
            new KeyValuePair < string, string > ("TV", "Tavus"),
            new KeyValuePair < string, string > ("VD", "Vayoc Jor")
        };
            public static List<KeyValuePair<string, string>> provincesARG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("A", "Salta"),
            new KeyValuePair < string, string > ("B", "Buenos Aires"),
            new KeyValuePair < string, string > ("C", "Ciudad Autonoma de Buenos Aires"),
            new KeyValuePair < string, string > ("D", "San Luis"),
            new KeyValuePair < string, string > ("E", "Entre Rios"),
            new KeyValuePair < string, string > ("F", "La Rioja"),
            new KeyValuePair < string, string > ("G", "Santiago del Estero"),
            new KeyValuePair < string, string > ("H", "Chaco"),
            new KeyValuePair < string, string > ("J", "San Juan"),
            new KeyValuePair < string, string > ("K", "Catamarca"),
            new KeyValuePair < string, string > ("L", "La Pampa"),
            new KeyValuePair < string, string > ("M", "Mendoza"),
            new KeyValuePair < string, string > ("N", "Misiones"),
            new KeyValuePair < string, string > ("P", "Formosa"),
            new KeyValuePair < string, string > ("Q", "Neuquen"),
            new KeyValuePair < string, string > ("R", "Rio Negro"),
            new KeyValuePair < string, string > ("S", "Santa Fe"),
            new KeyValuePair < string, string > ("T", "Tucuman"),
            new KeyValuePair < string, string > ("U", "Chubut"),
            new KeyValuePair < string, string > ("V", "Tierra del Fuego"),
            new KeyValuePair < string, string > ("W", "Corrientes"),
            new KeyValuePair < string, string > ("X", "Cordoba"),
            new KeyValuePair < string, string > ("Y", "Jujuy"),
            new KeyValuePair < string, string > ("Z", "Santa Cruz")
        };
            public static List<KeyValuePair<string, string>> provincesATG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("03", "Saint George"),
            new KeyValuePair < string, string > ("04", "Saint John's"),
            new KeyValuePair < string, string > ("05", "Saint Mary"),
            new KeyValuePair < string, string > ("06", "Saint Paul"),
            new KeyValuePair < string, string > ("07", "Saint Peter"),
            new KeyValuePair < string, string > ("08", "Saint Philip"),
            new KeyValuePair < string, string > ("10", "Barbuda"),
            new KeyValuePair < string, string > ("11", "Redonda")
        };
            public static List<KeyValuePair<string, string>> provincesAGO = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BGO", "Bengo"),
            new KeyValuePair < string, string > ("BGU", "Benguela"),
            new KeyValuePair < string, string > ("BIE", "Bie"),
            new KeyValuePair < string, string > ("CAB", "Cabinda"),
            new KeyValuePair < string, string > ("CCU", "Cuando-Cubango"),
            new KeyValuePair < string, string > ("CNN", "Cunene"),
            new KeyValuePair < string, string > ("CNO", "Cuanza Norte"),
            new KeyValuePair < string, string > ("CUS", "Cuanza Sul"),
            new KeyValuePair < string, string > ("HUA", "Huambo"),
            new KeyValuePair < string, string > ("HUI", "Huila"),
            new KeyValuePair < string, string > ("LNO", "Lunda Norte"),
            new KeyValuePair < string, string > ("LSU", "Lunda Sul"),
            new KeyValuePair < string, string > ("LUA", "Luanda"),
            new KeyValuePair < string, string > ("MAL", "Malange"),
            new KeyValuePair < string, string > ("MOX", "Moxico"),
            new KeyValuePair < string, string > ("NAM", "Namibe"),
            new KeyValuePair < string, string > ("UIG", "Uige"),
            new KeyValuePair < string, string > ("ZAI", "Zaire")
        };
            public static List<KeyValuePair<string, string>> provincesAND = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("02", "Canillo"),
            new KeyValuePair < string, string > ("03", "Encamp"),
            new KeyValuePair < string, string > ("04", "La Massana"),
            new KeyValuePair < string, string > ("05", "Ordino"),
            new KeyValuePair < string, string > ("06", "Sant Julia de Loria"),
            new KeyValuePair < string, string > ("07", "Andorra la Vella"),
            new KeyValuePair < string, string > ("08", "Escaldes-Engordany")
        };
            public static List<KeyValuePair<string, string>> provincesDZA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("01", "Adrar"),
            new KeyValuePair < string, string > ("02", "Chlef"),
            new KeyValuePair < string, string > ("03", "Laghouat"),
            new KeyValuePair < string, string > ("04", "Oum el Bouaghi"),
            new KeyValuePair < string, string > ("05", "Batna"),
            new KeyValuePair < string, string > ("06", "Bejaia"),
            new KeyValuePair < string, string > ("07", "Biskra"),
            new KeyValuePair < string, string > ("08", "Bechar"),
            new KeyValuePair < string, string > ("09", "Blida"),
            new KeyValuePair < string, string > ("10", "Bouira"),
            new KeyValuePair < string, string > ("11", "Tamanghasset"),
            new KeyValuePair < string, string > ("12", "Tebessa"),
            new KeyValuePair < string, string > ("13", "Tlemcen"),
            new KeyValuePair < string, string > ("14", "Tiaret"),
            new KeyValuePair < string, string > ("15", "Tizi Ouzou"),
            new KeyValuePair < string, string > ("16", "Alger"),
            new KeyValuePair < string, string > ("17", "Djelfa"),
            new KeyValuePair < string, string > ("18", "Jijel"),
            new KeyValuePair < string, string > ("19", "Setif"),
            new KeyValuePair < string, string > ("20", "Saida"),
            new KeyValuePair < string, string > ("21", "Skikda"),
            new KeyValuePair < string, string > ("22", "Sidi Bel Abbes"),
            new KeyValuePair < string, string > ("23", "Annaba"),
            new KeyValuePair < string, string > ("24", "Guelma"),
            new KeyValuePair < string, string > ("25", "Constantine"),
            new KeyValuePair < string, string > ("26", "Medea"),
            new KeyValuePair < string, string > ("27", "Mostaganem"),
            new KeyValuePair < string, string > ("28", "Msila"),
            new KeyValuePair < string, string > ("29", "Mascara"),
            new KeyValuePair < string, string > ("30", "Ouargla"),
            new KeyValuePair < string, string > ("31", "Oran"),
            new KeyValuePair < string, string > ("32", "El Bayadh"),
            new KeyValuePair < string, string > ("33", "Illizi"),
            new KeyValuePair < string, string > ("34", "Bordj Bou Arreridj"),
            new KeyValuePair < string, string > ("35", "Boumerdes"),
            new KeyValuePair < string, string > ("36", "El Tarf"),
            new KeyValuePair < string, string > ("37", "Tindouf"),
            new KeyValuePair < string, string > ("38", "Tissemsilt"),
            new KeyValuePair < string, string > ("39", "El Oued"),
            new KeyValuePair < string, string > ("40", "Khenchela"),
            new KeyValuePair < string, string > ("41", "Souk Ahras"),
            new KeyValuePair < string, string > ("42", "Tipaza"),
            new KeyValuePair < string, string > ("43", "Mila"),
            new KeyValuePair < string, string > ("44", "Ain Defla"),
            new KeyValuePair < string, string > ("45", "Naama"),
            new KeyValuePair < string, string > ("46", "Ain Temouchent"),
            new KeyValuePair < string, string > ("47", "Ghardaia"),
            new KeyValuePair < string, string > ("48", "Relizane")
        };
            public static List<KeyValuePair<string, string>> provincesALB = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BR", "Berat"),
            new KeyValuePair < string, string > ("BU", "Bulqize"),
            new KeyValuePair < string, string > ("DI", "Diber"),
            new KeyValuePair < string, string > ("DL", "Delvine"),
            new KeyValuePair < string, string > ("DR", "Durres"),
            new KeyValuePair < string, string > ("DV", "Devoll"),
            new KeyValuePair < string, string > ("EL", "Elbasan"),
            new KeyValuePair < string, string > ("ER", "Kolonje"),
            new KeyValuePair < string, string > ("FR", "Fier"),
            new KeyValuePair < string, string > ("GJ", "Gjirokaster"),
            new KeyValuePair < string, string > ("GR", "Gramsh"),
            new KeyValuePair < string, string > ("HA", "Has"),
            new KeyValuePair < string, string > ("KA", "Kavaje"),
            new KeyValuePair < string, string > ("KB", "Kurbin"),
            new KeyValuePair < string, string > ("KC", "Kucove"),
            new KeyValuePair < string, string > ("KO", "Korce"),
            new KeyValuePair < string, string > ("KR", "Kruje"),
            new KeyValuePair < string, string > ("KU", "Kukes"),
            new KeyValuePair < string, string > ("LB", "Librazhd"),
            new KeyValuePair < string, string > ("LE", "Lezhe"),
            new KeyValuePair < string, string > ("LU", "Lushnje"),
            new KeyValuePair < string, string > ("MK", "Mallakaster"),
            new KeyValuePair < string, string > ("MM", "Malesi e Madhe"),
            new KeyValuePair < string, string > ("MR", "Mirdite"),
            new KeyValuePair < string, string > ("MT", "Mat"),
            new KeyValuePair < string, string > ("PG", "Pogradec"),
            new KeyValuePair < string, string > ("PQ", "Peqin"),
            new KeyValuePair < string, string > ("PR", "Permet"),
            new KeyValuePair < string, string > ("PU", "Puke"),
            new KeyValuePair < string, string > ("SH", "Shkoder"),
            new KeyValuePair < string, string > ("SK", "Skrapar"),
            new KeyValuePair < string, string > ("SR", "Sarande"),
            new KeyValuePair < string, string > ("TE", "Tepelene"),
            new KeyValuePair < string, string > ("TP", "Tropoje"),
            new KeyValuePair < string, string > ("TR", "Tirane"),
            new KeyValuePair < string, string > ("VL", "Vlore")
        };
            public static List<KeyValuePair<string, string>> provincesAFG = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("BAL", "Balkh"),
            new KeyValuePair < string, string > ("BAM", "Bāmyān"),
            new KeyValuePair < string, string > ("BDG", "Bādghīs"),
            new KeyValuePair < string, string > ("BDS", "Badakhshān"),
            new KeyValuePair < string, string > ("BGL", "Baghlān"),
            new KeyValuePair < string, string > ("DAY", "Dāykundī"),
            new KeyValuePair < string, string > ("FRA", "Farāh"),
            new KeyValuePair < string, string > ("FYB", "Fāryāb"),
            new KeyValuePair < string, string > ("GHA", "Ghaznī"),
            new KeyValuePair < string, string > ("GHO", "Ghōr"),
            new KeyValuePair < string, string > ("HEL", "Helmand"),
            new KeyValuePair < string, string > ("HER", "Herāt"),
            new KeyValuePair < string, string > ("JOW", "Jowzjān"),
            new KeyValuePair < string, string > ("KAB", "Kābul"),
            new KeyValuePair < string, string > ("KAN", "Kandahār"),
            new KeyValuePair < string, string > ("KAP", "Kāpīsā"),
            new KeyValuePair < string, string > ("KDZ", "Kunduz"),
            new KeyValuePair < string, string > ("KHO", "Khōst"),
            new KeyValuePair < string, string > ("KNR", "Kunar"),
            new KeyValuePair < string, string > ("LAG", "Laghmān"),
            new KeyValuePair < string, string > ("LOG", "Lōgar"),
            new KeyValuePair < string, string > ("NAN", "Nangarhār"),
            new KeyValuePair < string, string > ("NIM", "Nīmrōz"),
            new KeyValuePair < string, string > ("NUR", "Nuristān"),
            new KeyValuePair < string, string > ("PAN", "Panjshayr"),
            new KeyValuePair < string, string > ("PAR", "Parwān"),
            new KeyValuePair < string, string > ("PIA", "Paktīā"),
            new KeyValuePair < string, string > ("PKA", "Paktīkā"),
            new KeyValuePair < string, string > ("SAM", "Samangān"),
            new KeyValuePair < string, string > ("SAR", "Sar-e Pul"),
            new KeyValuePair < string, string > ("TAK", "Takhār"),
            new KeyValuePair < string, string > ("URU", "Uruzgān"),
            new KeyValuePair < string, string > ("WAR", "Wardak"),
            new KeyValuePair < string, string > ("ZAB", "Zābul")
        };
            public static List<KeyValuePair<string, string>> provincesITA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("---", "- none -"),
            new KeyValuePair < string, string > ("AG", "Agrigento"),
            new KeyValuePair < string, string > ("AL", "Alessandria"),
            new KeyValuePair < string, string > ("AN", "Ancona"),
            new KeyValuePair < string, string > ("AO", "Aosta"),
            new KeyValuePair < string, string > ("AP", "Ascoli Piceno"),
            new KeyValuePair < string, string > ("AQ", "L'Aquila"),
            new KeyValuePair < string, string > ("AR", "Arezzo"),
            new KeyValuePair < string, string > ("AT", "Asti"),
            new KeyValuePair < string, string > ("AV", "Avellino"),
            new KeyValuePair < string, string > ("BA", "Bari"),
            new KeyValuePair < string, string > ("BG", "Bergamo"),
            new KeyValuePair < string, string > ("BI", "Biella"),
            new KeyValuePair < string, string > ("BL", "Belluno"),
            new KeyValuePair < string, string > ("BN", "Benevento"),
            new KeyValuePair < string, string > ("BO", "Bologna"),
            new KeyValuePair < string, string > ("BR", "Brindisi"),
            new KeyValuePair < string, string > ("BS", "Brescia"),
            new KeyValuePair < string, string > ("BT", "Barletta-Andria-Trani"),
            new KeyValuePair < string, string > ("BZ", "Bolzano"),
            new KeyValuePair < string, string > ("CA", "Cagliari"),
            new KeyValuePair < string, string > ("CB", "Campobasso"),
            new KeyValuePair < string, string > ("CE", "Caserta"),
            new KeyValuePair < string, string > ("CH", "Chieti"),
            new KeyValuePair < string, string > ("CI", "Carbonia-Iglesias"),
            new KeyValuePair < string, string > ("CL", "Caltanissetta"),
            new KeyValuePair < string, string > ("CN", "Cuneo"),
            new KeyValuePair < string, string > ("CO", "Como"),
            new KeyValuePair < string, string > ("CR", "Cremona"),
            new KeyValuePair < string, string > ("CS", "Cosenza"),
            new KeyValuePair < string, string > ("CT", "Catania"),
            new KeyValuePair < string, string > ("CZ", "Catanzaro"),
            new KeyValuePair < string, string > ("EN", "Enna"),
            new KeyValuePair < string, string > ("FC", "Forl&#236;-Cesena"),
            new KeyValuePair < string, string > ("FE", "Ferrara"),
            new KeyValuePair < string, string > ("FG", "Foggia"),
            new KeyValuePair < string, string > ("FI", "Firenze"),
            new KeyValuePair < string, string > ("FM", "Fermo"),
            new KeyValuePair < string, string > ("FR", "Frosinone"),
            new KeyValuePair < string, string > ("GE", "Genova"),
            new KeyValuePair < string, string > ("GO", "Gorizia"),
            new KeyValuePair < string, string > ("GR", "Grosseto"),
            new KeyValuePair < string, string > ("IM", "Imperia"),
            new KeyValuePair < string, string > ("IS", "Isernia"),
            new KeyValuePair < string, string > ("KR", "Crotone"),
            new KeyValuePair < string, string > ("LC", "Lecco"),
            new KeyValuePair < string, string > ("LE", "Lecce"),
            new KeyValuePair < string, string > ("LI", "Livorno"),
            new KeyValuePair < string, string > ("LO", "Lodi"),
            new KeyValuePair < string, string > ("LT", "Latina"),
            new KeyValuePair < string, string > ("LU", "Lucca"),
            new KeyValuePair < string, string > ("MB", "Monza e Brianza"),
            new KeyValuePair < string, string > ("MC", "Macerata"),
            new KeyValuePair < string, string > ("ME", "Messina"),
            new KeyValuePair < string, string > ("MI", "Milano"),
            new KeyValuePair < string, string > ("MN", "Mantova"),
            new KeyValuePair < string, string > ("MO", "Modena"),
            new KeyValuePair < string, string > ("MS", "Massa-Carrara"),
            new KeyValuePair < string, string > ("MT", "Matera"),
            new KeyValuePair < string, string > ("NA", "Napoli"),
            new KeyValuePair < string, string > ("NO", "Novara"),
            new KeyValuePair < string, string > ("NU", "Nuoro"),
            new KeyValuePair < string, string > ("OG", "Ogliastra"),
            new KeyValuePair < string, string > ("OR", "Oristano"),
            new KeyValuePair < string, string > ("OT", "Olbia-Tempio"),
            new KeyValuePair < string, string > ("PA", "Palermo"),
            new KeyValuePair < string, string > ("PC", "Piacenza"),
            new KeyValuePair < string, string > ("PD", "Padova"),
            new KeyValuePair < string, string > ("PE", "Pescara"),
            new KeyValuePair < string, string > ("PG", "Perugia"),
            new KeyValuePair < string, string > ("PI", "Pisa"),
            new KeyValuePair < string, string > ("PN", "Pordenone"),
            new KeyValuePair < string, string > ("PO", "Prato"),
            new KeyValuePair < string, string > ("PR", "Parma"),
            new KeyValuePair < string, string > ("PT", "Pistoia"),
            new KeyValuePair < string, string > ("PU", "Pesaro e Urbino"),
            new KeyValuePair < string, string > ("PV", "Pavia"),
            new KeyValuePair < string, string > ("PZ", "Potenza"),
            new KeyValuePair < string, string > ("RA", "Ravenna"),
            new KeyValuePair < string, string > ("RC", "Reggio Calabria"),
            new KeyValuePair < string, string > ("RE", "Reggio Emilia"),
            new KeyValuePair < string, string > ("RG", "Ragusa"),
            new KeyValuePair < string, string > ("RI", "Rieti"),
            new KeyValuePair < string, string > ("RM", "Roma"),
            new KeyValuePair < string, string > ("RN", "Rimini"),
            new KeyValuePair < string, string > ("RO", "Rovigo"),
            new KeyValuePair < string, string > ("SA", "Salerno"),
            new KeyValuePair < string, string > ("SI", "Siena"),
            new KeyValuePair < string, string > ("SO", "Sondrio"),
            new KeyValuePair < string, string > ("SP", "La Spezia"),
            new KeyValuePair < string, string > ("SR", "Siracusa"),
            new KeyValuePair < string, string > ("SS", "Sassari"),
            new KeyValuePair < string, string > ("SV", "Savona"),
            new KeyValuePair < string, string > ("TA", "Taranto"),
            new KeyValuePair < string, string > ("TE", "Teramo"),
            new KeyValuePair < string, string > ("TN", "Trento"),
            new KeyValuePair < string, string > ("TO", "Torino"),
            new KeyValuePair < string, string > ("TP", "Trapani"),
            new KeyValuePair < string, string > ("TR", "Terni"),
            new KeyValuePair < string, string > ("TS", "Trieste"),
            new KeyValuePair < string, string > ("TV", "Treviso"),
            new KeyValuePair < string, string > ("UD", "Udine"),
            new KeyValuePair < string, string > ("VA", "Varese"),
            new KeyValuePair < string, string > ("VB", "Verbano-Cusio-Ossola"),
            new KeyValuePair < string, string > ("VC", "Vercelli"),
            new KeyValuePair < string, string > ("VE", "Venezia"),
            new KeyValuePair < string, string > ("VI", "Vicenza"),
            new KeyValuePair < string, string > ("VR", "Verona"),
            new KeyValuePair < string, string > ("VS", "Medio Campidano"),
            new KeyValuePair < string, string > ("VT", "Viterbo"),
            new KeyValuePair < string, string > ("VV", "Vibo Valentia")
        };
            public static List<KeyValuePair<string, string>> continentsCountries = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair < string, string > ("AS", "AFG"),
            new KeyValuePair < string, string > ("EU", "ALB"),
            new KeyValuePair < string, string > ("AN", "ATA"),
            new KeyValuePair < string, string > ("AF", "DZA"),
            new KeyValuePair < string, string > ("OC", "ASM"),
            new KeyValuePair < string, string > ("EU", "AND"),
            new KeyValuePair < string, string > ("AF", "AGO"),
            new KeyValuePair < string, string > ("NA", "ATG"),
            new KeyValuePair < string, string > ("AS", "AZE"),
            new KeyValuePair < string, string > ("EU", "AZE"),
            new KeyValuePair < string, string > ("SA", "ARG"),
            new KeyValuePair < string, string > ("OC", "AUS"),
            new KeyValuePair < string, string > ("EU", "AUT"),
            new KeyValuePair < string, string > ("NA", "BHS"),
            new KeyValuePair < string, string > ("AS", "BHR"),
            new KeyValuePair < string, string > ("AS", "BGD"),
            new KeyValuePair < string, string > ("AS", "ARM"),
            new KeyValuePair < string, string > ("EU", "ARM"),
            new KeyValuePair < string, string > ("NA", "BRB"),
            new KeyValuePair < string, string > ("EU", "BEL"),
            new KeyValuePair < string, string > ("NA", "BMU"),
            new KeyValuePair < string, string > ("AS", "BTN"),
            new KeyValuePair < string, string > ("SA", "BOL"),
            new KeyValuePair < string, string > ("EU", "BIH"),
            new KeyValuePair < string, string > ("AF", "BWA"),
            new KeyValuePair < string, string > ("AN", "BVT"),
            new KeyValuePair < string, string > ("SA", "BRA"),
            new KeyValuePair < string, string > ("NA", "BLZ"),
            new KeyValuePair < string, string > ("AS", "IOT"),
            new KeyValuePair < string, string > ("OC", "SLB"),
            new KeyValuePair < string, string > ("NA", "VGB"),
            new KeyValuePair < string, string > ("AS", "BRN"),
            new KeyValuePair < string, string > ("EU", "BGR"),
            new KeyValuePair < string, string > ("AS", "MMR"),
            new KeyValuePair < string, string > ("AF", "BDI"),
            new KeyValuePair < string, string > ("EU", "BLR"),
            new KeyValuePair < string, string > ("AS", "KHM"),
            new KeyValuePair < string, string > ("AF", "CMR"),
            new KeyValuePair < string, string > ("NA", "CAN"),
            new KeyValuePair < string, string > ("AF", "CPV"),
            new KeyValuePair < string, string > ("NA", "CYM"),
            new KeyValuePair < string, string > ("AF", "CAF"),
            new KeyValuePair < string, string > ("AS", "LKA"),
            new KeyValuePair < string, string > ("AF", "TCD"),
            new KeyValuePair < string, string > ("SA", "CHL"),
            new KeyValuePair < string, string > ("AS", "CHN"),
            new KeyValuePair < string, string > ("AS", "TWN"),
            new KeyValuePair < string, string > ("AS", "CXR"),
            new KeyValuePair < string, string > ("AS", "CCK"),
            new KeyValuePair < string, string > ("SA", "COL"),
            new KeyValuePair < string, string > ("AF", "COM"),
            new KeyValuePair < string, string > ("AF", "MYT"),
            new KeyValuePair < string, string > ("AF", "COG"),
            new KeyValuePair < string, string > ("AF", "COD"),
            new KeyValuePair < string, string > ("OC", "COK"),
            new KeyValuePair < string, string > ("NA", "CRI"),
            new KeyValuePair < string, string > ("EU", "HRV"),
            new KeyValuePair < string, string > ("NA", "CUB"),
            new KeyValuePair < string, string > ("AS", "CYP"),
            new KeyValuePair < string, string > ("EU", "CYP"),
            new KeyValuePair < string, string > ("EU", "CZE"),
            new KeyValuePair < string, string > ("AF", "BEN"),
            new KeyValuePair < string, string > ("EU", "DNK"),
            new KeyValuePair < string, string > ("NA", "DMA"),
            new KeyValuePair < string, string > ("NA", "DOM"),
            new KeyValuePair < string, string > ("SA", "ECU"),
            new KeyValuePair < string, string > ("NA", "SLV"),
            new KeyValuePair < string, string > ("AF", "GNQ"),
            new KeyValuePair < string, string > ("AF", "ETH"),
            new KeyValuePair < string, string > ("AF", "ERI"),
            new KeyValuePair < string, string > ("EU", "EST"),
            new KeyValuePair < string, string > ("EU", "FRO"),
            new KeyValuePair < string, string > ("SA", "FLK"),
            new KeyValuePair < string, string > ("AN", "SGS"),
            new KeyValuePair < string, string > ("OC", "FJI"),
            new KeyValuePair < string, string > ("EU", "FIN"),
            new KeyValuePair < string, string > ("EU", "ALA"),
            new KeyValuePair < string, string > ("EU", "FRA"),
            new KeyValuePair < string, string > ("SA", "GUF"),
            new KeyValuePair < string, string > ("OC", "PYF"),
            new KeyValuePair < string, string > ("AN", "ATF"),
            new KeyValuePair < string, string > ("AF", "DJI"),
            new KeyValuePair < string, string > ("AF", "GAB"),
            new KeyValuePair < string, string > ("AS", "GEO"),
            new KeyValuePair < string, string > ("EU", "GEO"),
            new KeyValuePair < string, string > ("AF", "GMB"),
            new KeyValuePair < string, string > ("EU", "DEU"),
            new KeyValuePair < string, string > ("AF", "GHA"),
            new KeyValuePair < string, string > ("EU", "GIB"),
            new KeyValuePair < string, string > ("OC", "KIR"),
            new KeyValuePair < string, string > ("EU", "GRC"),
            new KeyValuePair < string, string > ("NA", "GRL"),
            new KeyValuePair < string, string > ("NA", "GRD"),
            new KeyValuePair < string, string > ("NA", "GLP"),
            new KeyValuePair < string, string > ("OC", "GUM"),
            new KeyValuePair < string, string > ("NA", "GTM"),
            new KeyValuePair < string, string > ("AF", "GIN"),
            new KeyValuePair < string, string > ("SA", "GUY"),
            new KeyValuePair < string, string > ("NA", "HTI"),
            new KeyValuePair < string, string > ("AN", "HMD"),
            new KeyValuePair < string, string > ("EU", "VAT"),
            new KeyValuePair < string, string > ("NA", "HND"),
            new KeyValuePair < string, string > ("AS", "HKG"),
            new KeyValuePair < string, string > ("EU", "HUN"),
            new KeyValuePair < string, string > ("EU", "ISL"),
            new KeyValuePair < string, string > ("AS", "IND"),
            new KeyValuePair < string, string > ("AS", "IDN"),
            new KeyValuePair < string, string > ("AS", "IRN"),
            new KeyValuePair < string, string > ("AS", "IRQ"),
            new KeyValuePair < string, string > ("EU", "IRL"),
            new KeyValuePair < string, string > ("AS", "ISR"),
            new KeyValuePair < string, string > ("EU", "ITA"),
            new KeyValuePair < string, string > ("AF", "CIV"),
            new KeyValuePair < string, string > ("NA", "JAM"),
            new KeyValuePair < string, string > ("AS", "JPN"),
            new KeyValuePair < string, string > ("AS", "KAZ"),
            new KeyValuePair < string, string > ("EU", "KAZ"),
            new KeyValuePair < string, string > ("AS", "JOR"),
            new KeyValuePair < string, string > ("AF", "KEN"),
            new KeyValuePair < string, string > ("AS", "PRK"),
            new KeyValuePair < string, string > ("AS", "KOR"),
            new KeyValuePair < string, string > ("AS", "KWT"),
            new KeyValuePair < string, string > ("AS", "KGZ"),
            new KeyValuePair < string, string > ("AS", "LAO"),
            new KeyValuePair < string, string > ("AS", "LBN"),
            new KeyValuePair < string, string > ("AF", "LSO"),
            new KeyValuePair < string, string > ("EU", "LVA"),
            new KeyValuePair < string, string > ("AF", "LBR"),
            new KeyValuePair < string, string > ("AF", "LBY"),
            new KeyValuePair < string, string > ("EU", "LIE"),
            new KeyValuePair < string, string > ("EU", "LTU"),
            new KeyValuePair < string, string > ("EU", "LUX"),
            new KeyValuePair < string, string > ("AS", "MAC"),
            new KeyValuePair < string, string > ("AF", "MDG"),
            new KeyValuePair < string, string > ("AF", "MWI"),
            new KeyValuePair < string, string > ("AS", "MYS"),
            new KeyValuePair < string, string > ("AS", "MDV"),
            new KeyValuePair < string, string > ("AF", "MLI"),
            new KeyValuePair < string, string > ("EU", "MLT"),
            new KeyValuePair < string, string > ("NA", "MTQ"),
            new KeyValuePair < string, string > ("AF", "MRT"),
            new KeyValuePair < string, string > ("AF", "MUS"),
            new KeyValuePair < string, string > ("NA", "MEX"),
            new KeyValuePair < string, string > ("EU", "MCO"),
            new KeyValuePair < string, string > ("AS", "MNG"),
            new KeyValuePair < string, string > ("EU", "MDA"),
            new KeyValuePair < string, string > ("EU", "MNE"),
            new KeyValuePair < string, string > ("NA", "MSR"),
            new KeyValuePair < string, string > ("AF", "MAR"),
            new KeyValuePair < string, string > ("AF", "MOZ"),
            new KeyValuePair < string, string > ("AS", "OMN"),
            new KeyValuePair < string, string > ("AF", "NAM"),
            new KeyValuePair < string, string > ("OC", "NRU"),
            new KeyValuePair < string, string > ("AS", "NPL"),
            new KeyValuePair < string, string > ("EU", "NLD"),
            new KeyValuePair < string, string > ("NA", "ANT"),
            new KeyValuePair < string, string > ("NA", "CUW"),
            new KeyValuePair < string, string > ("NA", "ABW"),
            new KeyValuePair < string, string > ("NA", "SXM"),
            new KeyValuePair < string, string > ("NA", "BES"),
            new KeyValuePair < string, string > ("OC", "NCL"),
            new KeyValuePair < string, string > ("OC", "VUT"),
            new KeyValuePair < string, string > ("OC", "NZL"),
            new KeyValuePair < string, string > ("NA", "NIC"),
            new KeyValuePair < string, string > ("AF", "NER"),
            new KeyValuePair < string, string > ("AF", "NGA"),
            new KeyValuePair < string, string > ("OC", "NIU"),
            new KeyValuePair < string, string > ("OC", "NFK"),
            new KeyValuePair < string, string > ("EU", "NOR"),
            new KeyValuePair < string, string > ("OC", "MNP"),
            new KeyValuePair < string, string > ("NA", "UMI"),
            new KeyValuePair < string, string > ("OC", "UMI"),
            new KeyValuePair < string, string > ("OC", "FSM"),
            new KeyValuePair < string, string > ("OC", "MHL"),
            new KeyValuePair < string, string > ("OC", "PLW"),
            new KeyValuePair < string, string > ("AS", "PAK"),
            new KeyValuePair < string, string > ("AS", "PSE"),
            new KeyValuePair < string, string > ("NA", "PAN"),
            new KeyValuePair < string, string > ("OC", "PNG"),
            new KeyValuePair < string, string > ("SA", "PRY"),
            new KeyValuePair < string, string > ("SA", "PER"),
            new KeyValuePair < string, string > ("AS", "PHL"),
            new KeyValuePair < string, string > ("OC", "PCN"),
            new KeyValuePair < string, string > ("EU", "POL"),
            new KeyValuePair < string, string > ("EU", "PRT"),
            new KeyValuePair < string, string > ("AF", "GNB"),
            new KeyValuePair < string, string > ("AS", "TLS"),
            new KeyValuePair < string, string > ("NA", "PRI"),
            new KeyValuePair < string, string > ("AS", "QAT"),
            new KeyValuePair < string, string > ("AF", "REU"),
            new KeyValuePair < string, string > ("EU", "ROU"),
            new KeyValuePair < string, string > ("AS", "RUS"),
            new KeyValuePair < string, string > ("EU", "RUS"),
            new KeyValuePair < string, string > ("AF", "RWA"),
            new KeyValuePair < string, string > ("NA", "BLM"),
            new KeyValuePair < string, string > ("AF", "SHN"),
            new KeyValuePair < string, string > ("NA", "KNA"),
            new KeyValuePair < string, string > ("NA", "AIA"),
            new KeyValuePair < string, string > ("NA", "LCA"),
            new KeyValuePair < string, string > ("NA", "MAF"),
            new KeyValuePair < string, string > ("NA", "SPM"),
            new KeyValuePair < string, string > ("NA", "VCT"),
            new KeyValuePair < string, string > ("EU", "SMR"),
            new KeyValuePair < string, string > ("AF", "STP"),
            new KeyValuePair < string, string > ("AS", "SAU"),
            new KeyValuePair < string, string > ("AF", "SEN"),
            new KeyValuePair < string, string > ("EU", "SRB"),
            new KeyValuePair < string, string > ("AF", "SYC"),
            new KeyValuePair < string, string > ("AF", "SLE"),
            new KeyValuePair < string, string > ("AS", "SGP"),
            new KeyValuePair < string, string > ("EU", "SVK"),
            new KeyValuePair < string, string > ("AS", "VNM"),
            new KeyValuePair < string, string > ("EU", "SVN"),
            new KeyValuePair < string, string > ("AF", "SOM"),
            new KeyValuePair < string, string > ("AF", "ZAF"),
            new KeyValuePair < string, string > ("AF", "ZWE"),
            new KeyValuePair < string, string > ("EU", "ESP"),
            new KeyValuePair < string, string > ("AF", "SSD"),
            new KeyValuePair < string, string > ("AF", "SDN"),
            new KeyValuePair < string, string > ("AF", "ESH"),
            new KeyValuePair < string, string > ("SA", "SUR"),
            new KeyValuePair < string, string > ("EU", "SJM"),
            new KeyValuePair < string, string > ("AF", "SWZ"),
            new KeyValuePair < string, string > ("EU", "SWE"),
            new KeyValuePair < string, string > ("EU", "CHE"),
            new KeyValuePair < string, string > ("AS", "SYR"),
            new KeyValuePair < string, string > ("AS", "TJK"),
            new KeyValuePair < string, string > ("AS", "THA"),
            new KeyValuePair < string, string > ("AF", "TGO"),
            new KeyValuePair < string, string > ("OC", "TKL"),
            new KeyValuePair < string, string > ("OC", "TON"),
            new KeyValuePair < string, string > ("NA", "TTO"),
            new KeyValuePair < string, string > ("AS", "ARE"),
            new KeyValuePair < string, string > ("AF", "TUN"),
            new KeyValuePair < string, string > ("AS", "TUR"),
            new KeyValuePair < string, string > ("EU", "TUR"),
            new KeyValuePair < string, string > ("AS", "TKM"),
            new KeyValuePair < string, string > ("NA", "TCA"),
            new KeyValuePair < string, string > ("OC", "TUV"),
            new KeyValuePair < string, string > ("AF", "UGA"),
            new KeyValuePair < string, string > ("EU", "UKR"),
            new KeyValuePair < string, string > ("EU", "MKD"),
            new KeyValuePair < string, string > ("AF", "EGY"),
            new KeyValuePair < string, string > ("EU", "GBR"),
            new KeyValuePair < string, string > ("EU", "GGY"),
            new KeyValuePair < string, string > ("EU", "JEY"),
            new KeyValuePair < string, string > ("EU", "IMN"),
            new KeyValuePair < string, string > ("AF", "TZA"),
            new KeyValuePair < string, string > ("NA", "USA"),
            new KeyValuePair < string, string > ("NA", "VIR"),
            new KeyValuePair < string, string > ("AF", "BFA"),
            new KeyValuePair < string, string > ("SA", "URY"),
            new KeyValuePair < string, string > ("AS", "UZB"),
            new KeyValuePair < string, string > ("SA", "VEN"),
            new KeyValuePair < string, string > ("OC", "WLF"),
            new KeyValuePair < string, string > ("OC", "WSM"),
            new KeyValuePair < string, string > ("AS", "YEM"),
            new KeyValuePair < string, string > ("AF", "ZMB"),
            new KeyValuePair < string, string > ("OC", "---"),
            new KeyValuePair < string, string > ("AS", "---"),
            new KeyValuePair < string, string > ("AF", "---"),
            new KeyValuePair < string, string > ("NA", "---"),
            new KeyValuePair < string, string > ("AN", "---"),
            new KeyValuePair < string, string > ("SA", "---"),
            new KeyValuePair < string, string > ("EU", "---"),
            new KeyValuePair < string, string > ("--", "---")
        };
        }
    }
}
