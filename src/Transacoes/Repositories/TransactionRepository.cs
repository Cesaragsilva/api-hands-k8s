using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transacao.API.Entities;
using Transacao.API.Repositories.Interfaces;

namespace Transacao.API.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private static List<Transaction> TransactionForTests;

        public TransactionRepository()
        {
            PopularDados();
        }

        public async Task<IEnumerable<Transaction>> GetTransactions() =>
            await Task.FromResult(TransactionForTests.Where(p => true).ToList());

        public async Task<Transaction> GetTransaction(string id) =>
             await Task.FromResult(TransactionForTests.FirstOrDefault(p => p.Id == id));

        public async Task CreateTransaction(Transaction product) =>
             await Task.Run(()=>TransactionForTests.Add(product));

        public async Task<bool> DeleteTransaction(string id)
        {
            var transacaoIndex = TransactionForTests.Where(p => p.Id == id).FirstOrDefault();
            if (transacaoIndex != null)
            {
                TransactionForTests.Remove(transacaoIndex);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        private void PopularDados()
        {
            if (TransactionForTests == null)
            {
                TransactionForTests = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Card = "3441",
                        Date = DateTime.UtcNow,
                        Description = "Transação efetuada para Joao LTDA",
                        Price = 980,
                        Category = "Alimentacao"
                    },
                    new Transaction()
                    {
                        Card = "4957",
                        Date = DateTime.UtcNow.AddDays(-1),
                        Description = "Transação efetuada para Osvaldo Esportes ME",
                        Price = 130,
                        Category = "Lazer"
                    },
                    new Transaction()
                    {
                        Card = "5575",
                        Date = DateTime.UtcNow,
                        Description = "Transação efetuada para Vanessa e Eloá Padaria ME",
                        Price = 220,
                        Category = "Alimentacao"
                    },
                    new Transaction()
                    {
                        Card = "5526",
                        Date = DateTime.UtcNow.AddDays(-2),
                        Description = "Transação efetuada para Joao LTDA",
                        Price = 200,
                        Category = "Estudos"
                    },
                    new Transaction()
                    {
                        Card = "3177",
                        Date = DateTime.UtcNow,
                        Description = "Transação efetuada para Pães e Doces ME",
                        Price = 10,
                        Category = "Alimentacao"
                    },
                    new Transaction()
                    {
                        Card = "5575",
                        Date = DateTime.UtcNow.AddDays(-3),
                        Description = "Transação efetuada para Edson Ferragens MEA",
                        Price = 300,
                        Category = "Outros"
                    }
                };
            }
        }
    }
}
