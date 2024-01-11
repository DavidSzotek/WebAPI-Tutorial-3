using System.Text.Json.Serialization;

namespace WebAPI_Tutorial_3.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CharacterId { get; set; }

        /*****  1:M Relationship  *****
 *        If a character is removed, then every character's weapon is removed aswell  */
        [JsonIgnore]
        public Character Character { get; set; }
    }
}
