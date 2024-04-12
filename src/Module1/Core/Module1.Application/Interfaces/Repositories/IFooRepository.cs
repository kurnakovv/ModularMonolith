using Module1.Application.POCO.Foo;
using Module1.Application.POCO.Foo.Run;
using Shared.Core;

namespace Module1.Application.Interfaces.Repositories;

public interface IFooRepository : IRepository<FooPOCO>
{
    Task<FooRunResponsePOCO> RunAsync(
        FooRunRequestPOCO model,
        CancellationToken token
    );
}
