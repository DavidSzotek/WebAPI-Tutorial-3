using System.Text.Json.Serialization;

namespace WebAPI_Tutorial_3.Models
{
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; }



        /*
         *****  1:1 Relationship  *****
         *      Only one model can have second model's Id (CharacterId) in order to determine which is the principal (main) table.
         *      Inside the migration class (20240110130040_InitialCreate.cs) is onDelete set to ReferentialAction.Cascade,
         *      meaning if the Character is removed, it's Backpack is removed aswell
         */
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}
