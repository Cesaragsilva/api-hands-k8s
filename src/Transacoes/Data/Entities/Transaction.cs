using System;

namespace Transacao.API.Entities
{
    public class Transaction
    {
        public Transaction()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Card { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
