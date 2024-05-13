using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ItemsDetails.Models
{
    [BsonIgnoreExtraElements]
    public class Items
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("client_code")]
        public string Client_Code { get; set; }
        [BsonElement("item_number")]
        public string Item_Number { get; set; }
        [BsonElement("display_item_number")]
        public string Display_Item_Number { get; set; }
        [BsonElement("description")]
        public string? Description { get; set; }
        [BsonElement("uom")]
        public string Uom { get; set; }
        [BsonElement("cost")]
        public int Price { get; set; }
        [BsonElement("high_value_indicator")]
        public string High_Value_Indicator { get; set; }

    }
}

//{
//    "_id": {
//        "$oid": "663b7fb8904e7076a26b815b"
//    },
//  "items": {
//        "client_code": "ARGOS",
//    "item_number": "178b8pqf-1",
//    "display_item_number": "6316523",
//    "description": "Harry Potter Deathly Hallows Black Faux Leather Strap Watch",
//    "uom": "EA",
//    "unit_weight": 0.019958064,
//    "unit_volume": 0.1730474,
//    "high_value_indicator": "N"
//  }
//}
