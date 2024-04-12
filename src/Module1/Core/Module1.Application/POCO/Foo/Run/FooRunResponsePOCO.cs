using Shared.Core;

namespace Module1.Application.POCO.Foo.Run;

public class FooRunResponsePOCO : IBasePOCO
{
    public long Id { get; set; }
    public required string Value { get; set; }
}
