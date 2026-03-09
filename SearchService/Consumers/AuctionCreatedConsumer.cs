using AutoMapper;
using Contracts;
using MassTransit;

namespace SearchService.Consumers
{
    //private readonly IMapper.
    public class AuctionCreatedConsumer : IConsumer<AuctionCreated>
    {
        public Task Consume(ConsumeContext<AuctionCreated> context)
        {
            throw new NotImplementedException();
        }

        //IMapper
        //public async Task Consume(ConsumeContext<AuctionCreated> context)
        //{
        //    Console.WriteLine("---> Consuming auction created" + context.Message.Id);

        //    var item = _mapper.Map<item>(context.Message);

        //    await item.SaveAsync();
        //}
    }
}
