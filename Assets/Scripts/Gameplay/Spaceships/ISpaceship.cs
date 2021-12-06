
using Gameplay.ShipSystems;

namespace Gameplay.Spaceships
{
    public interface ISpaceship
    {

        MovementSystem MovementSystem { get; }
        WeaponSystem WeaponSystem { get; }
        StrenghtSystem StrenghtSystem { get; }
        BonusSystem BonusSystem { get; }

    }
}
