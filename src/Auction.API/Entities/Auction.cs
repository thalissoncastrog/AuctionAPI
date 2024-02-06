﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Auction.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction.API.Entities;
public class Auction
{
    public int Id {get; set;}
    public string Name {get; set;} = String.Empty;
    public DateTime Starts {get; set;}
    public DateTime Ends {get; set;}

    public List<Item> Items {get; set;} = [];
}
