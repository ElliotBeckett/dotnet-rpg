namespace dotnet_rpg.Controllers.DTOs.Weapon
{
    public class AddWeaponDTO
    {
        public string Name { get; set; }    
        public int Damage { get; set; }
        public int CharacterID { get; set; }
    }
}