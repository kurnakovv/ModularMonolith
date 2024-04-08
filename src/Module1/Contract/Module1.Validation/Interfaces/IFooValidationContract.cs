using Module1.Validation.DTO.Foo.Validate;

namespace Module1.Validation.Interfaces;

public interface IFooValidationContract
{
    Task<FooValidateResponseDTO> ValidateAsync(
        FooValidateRequestDTO model,
        CancellationToken cancellationToken
    );
}
