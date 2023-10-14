using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books;

public class Book : AuditedAggregateRoot<Guid>
{

    public string Name { get; set; } = string.Empty;
    public BookType Type { get; set; }
    public DateTime PublishedDate { get; set; }
    public float Price { get; set; }

}
