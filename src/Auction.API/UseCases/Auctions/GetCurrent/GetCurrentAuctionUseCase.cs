namespace Auction.API.UseCases.Auctions.GetCurrent;

using Auction.API.Entities;
using Auction.API.Repositories;
using Microsoft.EntityFrameworkCore;

public class GetCurrentAuctionUseCase{
    public Auction? Execute(){

        var repository = new AuctionDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
