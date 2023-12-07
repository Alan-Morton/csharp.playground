using System;
using System.Collections.Generic;
using System.Text;
using Push.Console.DomainModels.Enum;

namespace Push.Console.DomainModels
{
    public class Project
    {
        public int ProjectPk { get; set; }
        public int AccountFk { get; set; }
        public int KeyGroupFk { get; set; }
        public fps FPS { get; set; }
        bool Archive { get; set; }
        public videoType VideoType { get; set; }
        public videoScale VideoScale { get; set; }
        public bool VideoVR { get; set; }
        public videoAspect VideoAspect { get; set; }
        public string Title { get; set; }
        public string InstanceType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
