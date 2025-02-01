using Fluidic.Tests.Extensions;

namespace Fluidic.Tests;

public sealed class SharedTests
{
    [Fact(DisplayName = "All shared code renders correctly")]
    public Task Case1()
    {
        var driver = """
            using Fluidic;

            internal static partial class Test
            {
                [StringTemplate("test")]
                public static partial void Test(this StringBuilder builder);
            }
            """.BuildDriver();
        return Verify(driver);
    }
}
