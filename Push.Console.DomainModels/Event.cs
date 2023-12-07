using System;
using System.Collections.Generic;
using System.Text;
using Push.Console.DomainModels.Enum;

namespace Push.Console.DomainModels
{
    public class Event
    {
        public int EventPk { get; set; }
        public int LocalFk { get; set; }
        public int ProjectFk { get; set; }
        public int SkinFk { get; set; }
        public int AccountFk { get; set; }
        public int TemplateFk { get; set; }
        public int KeyGroupFk { get; set; }
        public eventStatus eventStatus { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Timezone { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
