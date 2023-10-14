using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; } = String.Empty;
    public BookType Type { get; set; }
    public DateTime PublishedDate { get; set; }
    public float Price { get; set; }
}
