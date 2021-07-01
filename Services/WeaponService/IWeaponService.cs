using System.Threading.Tasks;
using dotnet_rpg.Controllers.DTOs.Character;
using dotnet_rpg.Controllers.DTOs.Weapon;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDTO>> AddWeapon(AddWeaponDTO newWeapon);
    }
}