using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public class TextMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserDisplayName { get; set; }
        public string UserAvatarUrl { get; set; }
        public DateTime RecievingTime { get; set; }
        public string Text { get; set; }

    }
}
