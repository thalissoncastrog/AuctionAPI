using Auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.Repositories;

public class AuctionDbContext : DbContext
{
    public DbSet<Entities.Auction> Auctions {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source =/home/thalissoncastrog/Documents/leilaoDbNLW.db");
    }
}
