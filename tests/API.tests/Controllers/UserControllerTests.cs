public class UsersControllerTests
{
    private readonly Mock _mockUserService;
    private readonly UsersController _controller;

    public UsersControllerTests()
    {
        _mockUserService = new Mock();
        _controller = new UsersController(_mockUserService.Object);
    }

    [Fact]
    public async Task GetUsers_ReturnsOkResult_WithListOfUsers()
    {
        // Arrange
        var users = new List { new UserDto { Id = 1, Username = "test" } };
        _mockUserService.Setup(x => x.GetUsersAsync()).ReturnsAsync(users);

        // Act
        var result = await _controller.GetUsers();

        // Assert
        var okResult = Assert.IsType(result.Result);
        var returnedUsers = Assert.IsAssignableFrom<List>(okResult.Value);
        Assert.Single(returnedUsers);
    }
}
