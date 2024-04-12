using Shared.Core;

namespace Module1.Application.POCO.Foo.Run;

public class FooRunRequestPOCO : IBasePOCO
{
    public required string Value { get; set; }
}
