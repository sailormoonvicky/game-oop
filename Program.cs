// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Dynamic;
using game.GameManagement;

var marioParty = new Game
{
    Name = "Mario Party"
};

var user1 = new User 
{
    Id = 1,
    UserName = "vicky1234",
    Password = "12345",
};

var user2 = new User 
{
    Id = 2,
    UserName = "wai1234",
    Password = "12345",
};

marioParty.Users.Add(user1);
marioParty.Users.Add(user2);

Console.WriteLine($"Hello {user1.UserName}, welcome to {marioParty.Name}.");
Console.WriteLine($"Your current level: {user1.CurrentLevel.ID} {user1.CurrentLevel.Name}, high score {user1.CurrentLevel.HighstScore}.");
user1.AdvanceLevel(230);
user1.AdvanceLevel(130);
user1.AdvanceLevel(150);
user2.AdvanceLevel(260);

foreach(var user in marioParty.Users)
{
    Console.WriteLine($"{user.UserName}: {user.CurrentLevel.Name}, high score {user.CurrentLevel.HighstScore}");
}




