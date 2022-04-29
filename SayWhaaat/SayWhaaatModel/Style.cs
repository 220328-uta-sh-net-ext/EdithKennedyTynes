using System;
using System.Collections.Generic;

namespace SayWhaaatModel
{
    public class Style


    {
        /*Themes: food & menu, (casual dining; american/traditional, diner foods, soul foods, comfort foods, Seafood,
        * Ethnic: Italian, Mexican, African, Indian Middle Eastern, Chinese, Japanese*/
        
        public string Name { get; set; }
        public string Theme { get; set; }

        //most/Least expensive
        public string Pricing { get; set; }

        public string EthnicCategory { get; set; }
        public string StyleType { get; set; }
        public string StyleTheme { get; set; }




        //style: eccentric, modern, contemporary, industrial, classic, traditional, rustic,
        //dark/night life, natural/eco-friendly, Cozy, Underwater

        private string _styleType;
        public string _StyleType
        {
            get { return StyleType; }
            set
            {
                if (value.Length == 1)
                    StyleType = value;
                else
                    throw new Exception("Restaurants cannot hold more than one Standard");
            }


        }



        public List<Standard> Standards { get; set; }


        public Style(string Name, string Pricing, string EthicCategory, string StyleType, string StyleTheme)
        {
            Name = "Panera";           
            Pricing = "//$$$$$";
            EthnicCategory = "WIFI";
            StyleType = "Modern";
            StyleTheme = "Comfort Foods";
            
        }
        public Style()
        {

        }
        public override string ToString()
        {
            return $"Name: {Name}\nPricing: {Pricing}\nEthnicCategory: {EthnicCategory}\nStyleType: {StyleType}\nStyleTheme: {StyleTheme}";
        }
    }
}
