using System;
using System.Collections.Generic;
using System.Text;
using Push.Console.DomainModels.Enum;

namespace Push.Console.DomainModels
{
    public class EventChannel
    {
        public int EventChannelPk { get; set; }
        public int LocalFk { get; set; }
        public int KeyGroupFk { get; set; }
        public int EventFk { get; set; }
        public int ChannelFk { get; set; }
        public string Title { get; set; }
        public displayOrder displayOrder { get; set; }
        public int InstanceId { get; set; }
        public  awsInstanceType awsInstanceType { get; set; }
        public awsRegion region { get; set; }
        public DateTime DatePinged { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
