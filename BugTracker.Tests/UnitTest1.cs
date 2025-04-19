namespace BugTracker.Tests
{
    using BugTracker.Core;
    public class BugTests
    {
        [Fact]
        public void Constructor_ValidInput_InitializesCorrectly()
        {
            // Arrange & Act
            var bug = new Bug(1, "Login fails", "Fails with correct credentials");

            // Assert
            Assert.Equal(1, bug.Id);
            Assert.Equal("Login fails", bug.Title);
            Assert.Equal("Fails with correct credentials", bug.Description);
            Assert.Equal(BugStatus.Open, bug.Status);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_InvalidTitle_ThrowsArgumentException(string invalidTitle)
        {
            
            
             var ex = Assert.Throws<ArgumentException>(() => new Bug(1, invalidTitle, "desc"));
             Assert.Equal("Title cannot be null, empty, or whitespace.", ex.Message);
        }

        [Fact]
        public void UpdateStatus_ChangesStatus()
        {
            // Arrange
            var bug = new Bug(2, "Icon missing", "Settings icon not visible");

            // Act
            bug.UpdateStatus(BugStatus.Resolved);

            // Assert
            Assert.Equal(BugStatus.Resolved, bug.Status);
        }


    }
}
