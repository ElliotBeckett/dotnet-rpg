using AutoMapper;
using dotnet_rpg.Controllers.DTOs.Character;
using dotnet_rpg.Controllers.DTOs.Fight;
using dotnet_rpg.Controllers.DTOs.Skill;
using dotnet_rpg.Controllers.DTOs.Weapon;
using dotnet_rpg.Models;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
            CreateMap<Weapon, GetWeaponDTO>();
            CreateMap<Skill, GetSkillDTO>();
            CreateMap<Character, HighScoreDTO>();
        }
    }
}