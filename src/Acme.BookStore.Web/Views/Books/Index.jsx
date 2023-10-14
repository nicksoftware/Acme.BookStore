export default function BooksPage({ books }) {
    var l = abp.localization.getResource('BookStore');
    return (
        <div className="container-xl">
            <div className="card">
                <div className="card-header">
                    <h1 className="mb-0">{l('Books')}</h1>
                </div>
                <div className="card-body">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th scope="col">{l('Name')}</th>
                                <th scope="col">{l('Price')}</th>
                                <th scope="col">{l('Type')}</th>
                            </tr>
                        </thead>
                        <tbody>
                            {books.items.map((book) => (
                                <tr key={book.id}>
                                    <td> {book.name}</td>
                                    <td>R {book.price}</td>
                                    <td>{l(`Enum:BookType.${book.type}`)}</td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    );
}
