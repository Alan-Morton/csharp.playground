using System;
using Push.Console.DomainModels.Enum;
namespace Push.Console.DomainModels
{
    public class OutputStream
    {
        public int OutputStreamPk { get; set; }
        public int EventChannelFk { get; set; }
        public  int ChannelPlayFk { get; set; }
        public status status { get; set; }
        public outputType type { get; set; }
        public bool Countdown { get; set; }
        public string ErrorMessage { get; set; } // bloody JSON in the database 
        public int EventChannelOutputFk { get; set; }
        public awsRegion Region { get; set; }
        public string PrimaryInstanceId { get; set; }
        public string PrimaryZone { get; set; }
        public string BackupInstanceId { get; set; }
        public string BackupZone { get; set; }
        public bool BackupEnabled { get; set; }
        public DateTime DateLoad { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
