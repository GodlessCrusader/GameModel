using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public class MediaFile
    {
        public int Id { get; set; }

        public string Uri { get; set; }

        public string UserDisplayName { get; set; }

        public long Size { get; set; }

        public MediaType Type { get; set; }
    }
    public enum MediaType
    {
        Image = 1,
        Audio = 2

    }

}
