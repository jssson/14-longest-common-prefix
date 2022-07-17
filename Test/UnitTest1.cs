namespace test;
using Zolution;

public class UnitTest1
{
    [Fact]
    public void GivenStrings_WhenNoCommon_ThenReturnEmptyString()
    {
        // Arrange
        Solution solution = new Solution();
        string[] strs = {"dog","racecar","car"};
        string result = "";
        // Act
    
        // Assert
        Assert.Equal(solution.LongestCommonPrefix(strs),result);
    }
}