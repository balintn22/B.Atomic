using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B.Atomics.Tests;

[TestClass()]
public class AtomicTests
{
    [TestMethod()]
    public void TestAndSet_WhenValuesAreEqual()
    {
        int variable = 666;

        bool result = Atomic.TestAndSet(ref variable, 42, 666);

        result.Should().BeTrue();
        variable.Should().Be(42);
    }

    [TestMethod()]
    public void TestAndSet_WhenValuesAreNotEqual()
    {
        int variable = 666;

        bool result = Atomic.TestAndSet(ref variable, 42, 667);

        result.Should().BeFalse();
        variable.Should().Be(666);
    }
}