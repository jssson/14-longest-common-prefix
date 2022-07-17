namespace test;
using Solution;

public class UnitTest1
{
    [Fact]
    public void GivenStrings_WhenNoCommon_ThenReturnEmptyString()
    {
        // Arrange
        Solution solution = new Solution();
        string[] strs = {"dog","racecar","car"};
        // Act
    
        // Assert
        assert.equal(solution.LongestCommonPrefix(strs),"");
    }
}