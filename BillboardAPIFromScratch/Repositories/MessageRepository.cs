using BillboardAPIFromScratch.Abstract;

namespace BillboardAPIFromScratch.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public MessageRepository(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }
    }
}
