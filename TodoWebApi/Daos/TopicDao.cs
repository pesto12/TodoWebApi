using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoWebApi.Daos {
    public class TopicDao {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public Guid? Uuid { get; set; }
    }
}