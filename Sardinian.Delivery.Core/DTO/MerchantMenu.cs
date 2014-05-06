using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
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
        public object Price { get; set; }

        [JsonProperty("max_price")]
        public object MaxPrice { get; set; }

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
        public object Description { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("max_price")]
        public object MaxPrice { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child4[] Children { get; set; }

        [JsonProperty("min_qty")]
        public string MinQty { get; set; }

        [JsonProperty("max_qty")]
        public string MaxQty { get; set; }

        [JsonProperty("increment")]
        public string Increment { get; set; }
    }

    public class Child2
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child3[] Children { get; set; }

        [JsonProperty("min_selection")]
        public string MinSelection { get; set; }

        [JsonProperty("max_selection")]
        public string MaxSelection { get; set; }

        [JsonProperty("sel_dep")]
        public int? SelDep { get; set; }
    }

    public class Child
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("schedule")]
        public int[] Schedule { get; set; }

        [JsonProperty("min_qty")]
        public string MinQty { get; set; }

        [JsonProperty("max_qty")]
        public string MaxQty { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("max_price")]
        public string MaxPrice { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child2[] Children { get; set; }

        [JsonProperty("increments")]
        public double? Increments { get; set; }

        [JsonProperty("qty_name_singular")]
        public string QtyNameSingular { get; set; }

        [JsonProperty("qty_name_plural")]
        public string QtyNamePlural { get; set; }
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

    public class GetMerchantMenuResponse
    {

        [JsonProperty("schedule")]
        public Schedule[] Schedule { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }

        [JsonProperty("menu")]
        public Menu[] Menu { get; set; }
    }

}
