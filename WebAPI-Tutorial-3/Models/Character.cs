namespace WebAPI_Tutorial_3.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
 /*****  1:1 Relationship  *****
  *      Only one model can have second model's Id (CharacterId) in order to determine which is the principal (main) table.
  *      Inside the migration class (20240110130040_InitialCreate.cs) is onDelete set to ReferentialAction.Cascade,
  *      meaning if the Character is removed, it's Backpack is removed aswell */
        public Backpack Backpack { get; set; }

 /*****  1:M Relationship  *****
  *        If a character is removed, then every character's weapon is removed aswell  */
        public List<Weapon> Weapons { get; set; }

        /*****  M:N Relationship  *****
*        Junction table is created automatically by EF since EF 5.0 
*        Now OnDelete is set as "or". If Character is Deleted or Faction is deleted then the entry in juntion
         table is also deleted */
        public List<Faction> Factions { get; set; }
    }
}
