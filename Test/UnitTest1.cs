namespace test;
using Zolution;

public class UnitTest1
{
    [Theory]
    [InlineData("reflower","flow","flight")]
    public void GivenStrings_WhenNoCommonStart_ThenReturnEmptyString(params string[] strs)
    {
        // Arrange
        Solution solution = new Solution();
        
        string result = "";
        // Act
    
        // Assert
        Assert.Equal(solution.LongestCommonPrefix(strs),result);
    }  

    [Theory]
    [InlineData("dog","racecar","car")]
    public void GivenStrings_WhenNoCommon_ThenReturnEmptyString(params string[] strs)
    {
        // Arrange
        Solution solution = new Solution();
        
        string result = "";
        // Act
    
        // Assert
        Assert.Equal(solution.LongestCommonPrefix(strs),result);
    }    
    
    [Fact]
    public void GivenString_WhenNoCommon_ThenReturnString()
    {
        // Arrange
        Solution solution = new Solution();
        string[] strs = {"a"};
        string result = "a";
        // Act
    
        // Assert
        Assert.Equal(solution.LongestCommonPrefix(strs),result);
    }    

    [Fact]
    public void GivenStrings_WhenCommon_ThenReturnCommonPart()
    {
        // Arrange
        Solution solution = new Solution();
        string[] strs = {"flower","flow","flight"};
        string result = "fl";
        // Act
    
        // Assert
        Assert.Equal(solution.LongestCommonPrefix(strs),result);
    }
}