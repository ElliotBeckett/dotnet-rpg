using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Controllers.DTOs.Fight;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDTO>> WeaponAttack(WeaponAttackDTO request);
        Task<ServiceResponse<AttackResultDTO>> SkillAttack(SkillsAttackDTO request);
        Task<ServiceResponse<FightResultDTO>> Fight(FightRequestDTO request);
        Task<ServiceResponse<List<HighScoreDTO>>> GetHighScore();

    }
}