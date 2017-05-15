using Effuse.Models;

namespace Effuse.Services.Tests.TestObjects
{
    internal static class TestUsers
    {
        internal static User NewUser => new User {Id= 1,UserName = "New"};
        internal static User ExistingUser => new User {Id = 2, UserName = "Existing" };
    }
}
