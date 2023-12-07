namespace Push.Analytics.DomainModels.Enum
{
    public enum frequency
    {
        //1 5 10 30 60 240 (4 hours) 1440 (1day) 10080 (7days) weekends only weekdays only
        oneMinute = 0,
        fiveMinutes = 1,
        tenMinutes = 2,
        oneHour = 3,
        fourHours = 4,
        oneDay = 5,
        sevenDays = 6,
        weekendsOnly = 7,
        weekdaysOnly = 8,        
    }
}
