

namespace GameModel
{
    public class Player
    {
        public Player()
        {

        }
        public Player(string username, string displayName, Role role)
        {
            Username = username;
            DisplayName = displayName;
            Role = role;
        }

        public string Username { get; set; }
        public string DisplayName { get; set; }
        public Role Role { get; set; }
        public List<Token>? ControlledTokens { get; set; }
        public bool IsOnline { get; set; }
    }
    public enum Role
    {
        Owner = 0,
        GameMaster = 1,
        Player = 2,
        Spectator = 3
    }
}

