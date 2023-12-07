using System;
using System.Collections.Generic;
using System.Text;

namespace Push.Console.DomainModels
{
    public class FacebookStream
    {
        public int OutputStreamFk { get; set; }
        public Int64 PageId { get; set; }
        public Int64 AccountId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Targeting { get; set; }
        public string CrosspostJSON { get; set; }
        public bool LiveOnly { get; set; }
        public DateTime DateSchedule { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
            
    }
}
