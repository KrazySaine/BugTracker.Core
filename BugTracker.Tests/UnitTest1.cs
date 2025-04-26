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
            Assert.Equal(1, bug.BugId);
            Assert.Equal("Login fails", bug.Title);
            Assert.Equal("Fails with correct credentials", bug.Description);
            Assert.Equal(BugStatus.Open, bug.Status);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_ThrowsArgumentException_WhenTitleIsInvalid(string invalidTitle)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Bug(invalidTitle, "Some description"));
        }

        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange & Act
            var bug = new Bug("Login fails", "Steps to reproduce the issue");

            // Assert
            Assert.Equal("Login fails", bug.Title);
            Assert.Equal("Steps to reproduce the issue", bug.Description);
            Assert.Equal(BugStatus.Open, bug.Status);
        }

        [Fact]
        public void UpdateStatus_ChangesStatusCorrectly()
        {
            // Arrange
            var bug = new Bug("Issue", "Details");

            // Act
            bug.UpdateStatus(BugStatus.InProgress);

            // Assert
            Assert.Equal(BugStatus.InProgress, bug.Status);
        }

        [Fact]
        public void UpdateStatus_DoesNotChangeToSameStatus()
        {
            // Arrange
            var bug = new Bug("Issue", "Details");

            // Act
            bug.UpdateStatus(BugStatus.Open);

            // Assert
            Assert.Equal(BugStatus.Open, bug.Status); // No change
        }


    }
}
