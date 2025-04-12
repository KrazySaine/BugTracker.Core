namespace BugTracker.Tests
{
    using BugTracker.Core;
    public class TestStatus
    {
        [Fact]
        public void ConstructorTest()
        {
            Bug bug = new Bug();
            Assert.IsType<Bug>(bug);
        }
        [Fact]
        public void UpdateStatusTestIsOpen()
        {
            Bug bug = new Bug();
            bug.UpdateStatus(BugStatus.Open);
            Assert.Equal(BugStatus.Open, bug.Status);


        }
        [Fact]
        public void UpdateStatusTestInProgress()
        {
            Bug bug = new Bug();
            bug.UpdateStatus(BugStatus.InProgress);
            Assert.Equal(BugStatus.InProgress, bug.Status);
            
            
        }
        [Fact]
        public void UpdateStatusTestIsResolved()
        {
            Bug bug = new Bug();
            bug.UpdateStatus(BugStatus.Resolved);
            Assert.Equal(BugStatus.Resolved, bug.Status);

        }
        [Fact]
        public void UpdateStatusTestIsClosed()
        {
            Bug bug = new Bug();
            bug.UpdateStatus(BugStatus.Closed);
            Assert.Equal(BugStatus.Closed, bug.Status);
        }
        
    }
}
