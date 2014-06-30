using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTO
{
    public class Time
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class Schedule
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("times")]
        public Time[] Times { get; set; }
    }

    public class Warning
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class Child5
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("max_price")]
        public double MaxPrice { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public object[] Children { get; set; }
    }

    public class Child4
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("min_selection")]
        public string MinSelection { get; set; }

        [JsonProperty("max_selection")]
        public string MaxSelection { get; set; }

        [JsonProperty("sel_dep")]
        public int SelDep { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child5[] Children { get; set; }
    }

    public class Child3
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("max_price")]
        public double MaxPrice { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public object[] Children { get; set; }
    }

    public class Child2
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("min_selection")]
        public int MinSelection { get; set; }

        [JsonProperty("max_selection")]
        public int MaxSelection { get; set; }

        [JsonProperty("sel_dep")]
        public int SelDep { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child3[] Children { get; set; }
    }

    public class MenuItemRequestObject
    {

        [JsonProperty("item_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("itm_qty")]
        public int MinQty { get; set; }

        [JsonProperty("max_qty")]
        public int MaxQty { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("max_price")]
        public double MaxPrice { get; set; }

        [JsonProperty("increment")]
        public int Increment { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child2[] Children { get; set; }
    }

    public class Child
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("min_qty")]
        public int MinQty { get; set; }

        [JsonProperty("max_qty")]
        public int MaxQty { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("max_price")]
        public double MaxPrice { get; set; }

        public string FormattedPrice
        {
            get
            {
                if (MaxPrice == 0)
                    return "";
                return MaxPrice.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        public string FormattedNameWithPrice
        {
            get
            {
                return String.Format("{0}   {1}", Name, FormattedPrice);
            }
        }

        [JsonProperty("increment")]
        public int Increment { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child2[] Children { get; set; }
    }

    

    public class Menu
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child[] Children { get; set; }
    }

    public class GetMerchantMenuItemResponse
    {

        [JsonProperty("schedule")]
        public Schedule[] Schedule { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }

        [JsonProperty("item")]
        public Item[] Item { get; set; }
    }

    public class GetMerchantMenuResponse
    {

        [JsonProperty("schedule")]
        public ObservableCollection<Schedule> Schedule { get; set; }

        [JsonProperty("warnings")]
        public ObservableCollection<Warning> Warnings { get; set; }

        [JsonProperty("menu")]
        public ObservableCollection<Menu> Menu { get; set; }
    }

}
