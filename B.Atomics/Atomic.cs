using System;
using System.Threading;

namespace B.Atomics;

public static class Atomic
{
    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref int variable, int replaceWithValue, int testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref uint variable, uint replaceWithValue, uint testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref Int64 variable, Int64 replaceWithValue, Int64 testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref UInt64 variable, UInt64 replaceWithValue, UInt64 testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref float variable, float replaceWithValue, float testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref double variable, double replaceWithValue, double testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    /// <summary>
    /// If variable and testforvalue are equal,
    ///  - replaces variable with replaceWithValue AND
    ///  - returns true
    /// otherwise
    ///  - does not change the value of variable AND
    ///  - returns false
    ///  Implemented as an atomic operation.
    /// </summary>
    /// <param name="variable">Variable to test and possibly change.</param>
    /// <param name="replaceWithValue">Value to assign to variable in case the first two arguments were equal.</param>
    /// <param name="testForValue">Value to compare against the variable.</param>
    /// <returns>
    /// True, if variable and testForValue were equal before the operation,
    /// false otherwise.
    /// </returns>
    public static bool TestAndSet(
        ref IntPtr variable, IntPtr replaceWithValue, IntPtr testForValue)
    {
        return testForValue == Interlocked.CompareExchange(ref variable, replaceWithValue, testForValue);
    }

    // Developer note:
    // Not implementing the overload for object? and T as Interlocked.CompareExchange()
    // implements them using reference equality, which I believe is not helpful.
}
