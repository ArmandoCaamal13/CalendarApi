﻿namespace CalendarApi.Models
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string UserCollectionName { get; set; }
        public string RoleCollectionName { get; set; }
    }
}
