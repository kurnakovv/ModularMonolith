using Module1.Application.POCO.Foo.Run;

namespace Module1.Application.Interfaces.Services;

public interface IFooService
{
    Task<FooRunResponsePOCO> RunAsync(
        FooRunRequestPOCO model,
        CancellationToken token
    );
}
