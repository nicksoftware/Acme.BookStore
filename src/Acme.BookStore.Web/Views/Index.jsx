export default function IndexPage(props) {
    var l = abp.localization.getResource('BookStore');
    return (
        <article className="card">
            <div className="card-header">
                <h1>{l('Welcome')}</h1>
            </div>
            <div className="card-body">
                <p className="text">{l('LongWelcomeMessage')}</p>
                <code>Dotnet Version : {props.runtime}</code>
            </div>
        </article>
    );
}
