using Module1.Logic.DTO.Foo.Run;

namespace Module1.Logic.Interfaces;

public interface IFooContract
{
    Task<FooRunResponseDTO> RunAsync(
        FooRunRequestDTO model,
        CancellationToken token
    );
}
