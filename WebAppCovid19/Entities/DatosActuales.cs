using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCovid19.Entities
{
    public partial class DatosActuales
    {
        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Global")]
        public Global Global { get; set; }

        [JsonProperty("Countries")]
        public Country[] Countries { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }
    }

    public partial class Country
    {
        [JsonProperty("Country")]
        public string CountryCountry { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("Slug")]
        public string Slug { get; set; }

        [JsonProperty("NewConfirmed")]
        public long NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public long NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public long NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public long TotalRecovered { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("Premium")]
        public Premium Premium { get; set; }

        //public override string ToString()
        //{
        //    return $"{CountryCountry} Infectados:{TotalConfirmed} fallecidos:{TotalDeaths} Recuperados:{TotalRecovered}";
        //}
    }

    public partial class Premium
    {
    }

    public partial class Global
    {
        [JsonProperty("NewConfirmed")]
        public long NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public long NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public long NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public long TotalRecovered { get; set; }
    }
}
