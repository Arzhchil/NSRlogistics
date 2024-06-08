using backend.DTOs;

namespace backend.Interfaces
{
    public interface IFileParser
    {
        public Task<int[,]> FileParser(ParserDTO parser);
    }
}
