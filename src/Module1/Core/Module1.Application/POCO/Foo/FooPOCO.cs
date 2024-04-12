using Shared.Core;

namespace Module1.Application.POCO.Foo;

public class FooPOCO : IBasePOCO
{
    public long Id { get; set; }
    public required string Value { get; set; }
}
