
using PartsUnlimited.Web;
using Xunit;

namespace PartsUnlimited.Tests;

public class ProjectInfoTests
{
    [Fact]
    public void ProjectTitle_ShouldBePartsUnlimited()
    {
        Assert.Equal("Parts Unlimited", ProjectInfo.GetTitle());
    }

    [Fact]
    public void ProjectTitle_ShouldNotBeEmpty()
    {
        Assert.False(string.IsNullOrWhiteSpace(
            ProjectInfo.GetTitle()));
    }
}
