using backend.DTOs;

namespace backend.Interfaces
{
    public interface IFileParser
    {
        public Task<double[,]> FileParser(ParserDTO parser);
    }
}
