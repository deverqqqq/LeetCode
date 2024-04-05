using System.Linq;
using FluentAssertions;
using LeetCode.Easy._1_TwoSum.Solutions;
using Xunit.Categories;

namespace LeetCode.Easy._1_TwoSum;

[UnitTest("Two Sum")]
public class UnitTest
{
    private readonly Solution _solution = new Solution();

    [Fact]
    public void TwoSum_BruteForce_1()
    {
        // arrqnge
        int[] nums = [2, 7, 11, 15];
        const int target = 9;
        const int expectedIndex1 = 0;
        const int expectedIndex2 = 1;

        // act
        var actual = this._solution.TwoSum_BruteForce(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }

    [Fact]
    public void TwoSum_BruteForce_2()
    {
        // arrange
        int[] nums = [3, 2, 4];
        const int target = 6;
        const int expectedIndex1 = 1;
        const int expectedIndex2 = 2;

        // act
        var actual = this._solution.TwoSum_BruteForce(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }

    [Fact]
    public void TwoSum_BruteForce_3()
    {
        // arrange
        int[] nums = [3, 3];
        const int target = 6;
        const int expectedIndex1 = 0;
        const int expectedIndex2 = 1;

        // act
        var actual = this._solution.TwoSum_BruteForce(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }

    [Fact]
    public void TwoSum_Hash_1()
    {
        int[] nums = [2, 7, 11, 15];
        const int target = 9;
        const int expectedIndex1 = 0;
        const int expectedIndex2 = 1;

        // act
        var actual = this._solution.TwoSum_Hash(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }

    [Fact]
    public void TwoSum_Hash_2()
    {
        // arrange
        int[] nums = [3, 2, 4];
        const int target = 6;
        const int expectedIndex1 = 1;
        const int expectedIndex2 = 2;

        // act
        var actual = this._solution.TwoSum_Hash(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }

    [Fact]
    public void TwoSum_Hash_3()
    {
        // arrange
        int[] nums = [3, 3];
        const int target = 6;
        const int expectedIndex1 = 0;
        const int expectedIndex2 = 1;

        // act
        var actual = this._solution.TwoSum_Hash(nums, target);

        // assert
        actual.Should().HaveCount(2);
        actual.Any(x => x == expectedIndex1).Should().BeTrue();
        actual.Any(x => x == expectedIndex2).Should().BeTrue();
    }
}