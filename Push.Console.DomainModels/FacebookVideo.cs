using System;
using System.Collections.Generic;
using System.Text;
using Push.Console.DomainModels.Enum;

namespace Push.Console.DomainModels
{
    public class FacebookVideo
    {
        public int FacebookVideoPk { get; set; }
        public int OutputStreamFk { get; set; }
        public Int64 LiveId { get; set; }
        public Int64 VideoId { get; set; }
        public facebookVideoStatus status { get; set; }
        public string RtmpUrl { get; set; }
        public string RtmpUrl2 { get; set; }
        public DateTime DateLoad { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
