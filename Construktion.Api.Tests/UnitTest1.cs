using System;
using Xunit;

namespace Construktion.Api.Tests
{
    using Shouldly;

    public class UnitTest1
    {
        [Fact]
        public void TestOne()
        {
            "true".ShouldBe("true");
        }

        [Fact]
        public void TestTwo()
        {
            "false".ShouldBe("false");
        }
    }
}
