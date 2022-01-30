using System.Collections.Generic;
using Transacao.API.Entities;

namespace Transacao.API.Data.Interfaces
{
    public interface ITransactionContext
    {
        IList<Transaction> Transactions { get; }
    }
}
