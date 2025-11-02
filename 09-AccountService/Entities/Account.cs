namespace BestBank.AccountService.Entities{
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
    public class Account
    {
         [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id {get;set;}
        public string ?FirstName {get;set;}
        public string ?LastName {get;set;}
        public decimal Balance {get;set;}
        public DateTimeOffset CreatedDate {get;set;}
    } 
}