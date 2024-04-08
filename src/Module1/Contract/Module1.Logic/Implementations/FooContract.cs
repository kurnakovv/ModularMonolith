using Module1.Logic.DTO.Foo.Run;
using Module1.Logic.Interfaces;

namespace Module1.Logic.Implementations;

public class FooContract : IFooContract
{
    public async Task<FooRunResponseDTO> RunAsync(
        FooRunRequestDTO model,
        CancellationToken token
    )
    {
        throw new NotImplementedException();
    }
}
