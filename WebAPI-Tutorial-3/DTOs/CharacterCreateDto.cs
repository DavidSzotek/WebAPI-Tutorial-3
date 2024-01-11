using WebAPI_Tutorial_3.Models;

namespace WebAPI_Tutorial_3.DTOs
{
    public record struct CharacterCreateDto
        (
        string Name,
        BackpackCreateDto Backpack,
        List<WeaponCreateDto> Weapons,
        List<FactionCreateDto> Factions
        );
}
