using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public class Chat
    {
        public IEnumerable<TextMessage> Messages { get; set; } = new List<TextMessage>();
        public IEnumerable<Player> AreTyping { get; set; } = new List<Player>();
        public IEnumerable<Player> Players { get; set; } = new List<Player>();
        public DateTime LastModified { get; set; }
    }
}
