using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp9
{
    public record Beers(string name, decimal alcohol, List<string> taste, string origin,
        List<string> type, string manufacturer, string consumption, ushort price,
        decimal quality, List<string> acquisition, decimal packformat);

    public class BeerPOJO
    {
        public string name { get; set; }

        public decimal alcohol { get; set; }

        public List<string> taste { get; set; }

        public string origin { get; set; }

        public List<string> type { get; set; }

        public string manufacturer;

        public string consumption;

        public ushort price;

        public decimal quality;

        public List<string> acquisition;

        public decimal packformat;

        public BeerPOJO() { }

        public BeerPOJO(string aname, decimal aalcohol, List<string> ataste, string aorigin, List<string> atype,
            string amanufacturer, string aconsumption, ushort aprice, decimal aquality, List<string> aacquistion, decimal apackformat)
        {
            name = aname;
            alcohol = aalcohol;
            taste = ataste;
            origin = aorigin;
            type = atype;
            manufacturer = amanufacturer;
            consumption = aconsumption;
            price = aprice;
            quality = aquality;
            acquisition = aacquistion;
            packformat = apackformat;
        }

        public override string ToString()
        {
            return $"name: {name}, minőség: {quality} ";
        }
    }
}
