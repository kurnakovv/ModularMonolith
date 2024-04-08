using Module1.Validation.DTO.Foo.Validate;
using Module1.Validation.Interfaces;

namespace Module1.Validation.Implementations;

public class FooValidationContract : IFooValidationContract
{
    public async Task<FooValidateResponseDTO> ValidateAsync(
        FooValidateRequestDTO model,
        CancellationToken cancellationToken
    )
    {
        throw new NotImplementedException();
    }
}
