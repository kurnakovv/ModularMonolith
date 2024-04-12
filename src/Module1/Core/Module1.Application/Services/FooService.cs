using Module1.Application.Interfaces.Repositories;
using Module1.Application.Interfaces.Services;
using Module1.Application.POCO.Foo.Run;

namespace Module1.Application.Services;

public class FooService : IFooService
{
    private readonly IFooRepository _fooRepository;

    public FooService(
        IFooRepository fooRepository
    )
    {
        _fooRepository = fooRepository;
    }

    public async Task<FooRunResponsePOCO> RunAsync(
        FooRunRequestPOCO model,
        CancellationToken token
    )
    {
        FooRunResponsePOCO result = await _fooRepository.RunAsync(model, token);

        result.Value += $"Some changes in {nameof(FooService)}\n";

        return result;
    }
}
