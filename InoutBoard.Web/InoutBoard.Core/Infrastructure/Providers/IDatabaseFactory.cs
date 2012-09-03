using System.Data.Common;

namespace InoutBoard.Core.Infrastructure.Providers
{
    public interface IDatabaseFactory
    {
        InoutContext Get();
    }
}
