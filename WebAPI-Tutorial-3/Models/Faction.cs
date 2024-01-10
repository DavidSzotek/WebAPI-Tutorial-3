namespace WebAPI_Tutorial_3.Models
{
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /*****  M:N Relationship  *****
*        Junction table is created automatically by EF since EF 5.0 
*        Now OnDelete is set as "or". If Character is Deleted or Faction is deleted then the entry in juntion
         table is also deleted */
        public List<Character> Characters { get; set; }
    }
}
