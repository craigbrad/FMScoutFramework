﻿namespace FMScoutFramework.Core.Entities.InGame.Interfaces
{
    public interface IPlayerStats
    {
        byte Acceleration { get; }
        byte AerialAbility { get; }
        byte Aggression { get; }
        byte Agility { get; }
        byte Anticipation { get; }
        byte AttackingMidfielderCenter { get; }
        byte AttackingMidfielderLeft { get; }
        byte AttackingMidfielderRight { get; }
        byte Balance { get; }
        byte Bravery { get; }
        byte CommandOfArea { get; }
        byte Communication { get; }
        byte Composure { get; }
        byte Concentration { get; }
        byte Consistency { get; }
        byte Corners { get; }
        byte Creativity { get; }
        byte Crossing { get; }
        byte Decisions { get; }
        byte DefenderCenter { get; }
        byte DefenderLeft { get; }
        byte DefenderRight { get; }
        byte DefensiveMidfielder { get; }
        byte Determination { get; }
        byte Dirtiness { get; }
        byte Dribbling { get; }
        byte Eccentricity { get; }
        byte Finishing { get; }
        byte FirstTouch { get; }
        byte Flair { get; }
        byte FreekickTaking { get; }
        byte Goalkeeper { get; }
        byte Handling { get; }
        byte Heading { get; }
        byte ImportantMatches { get; }
        byte Influence { get; }
        byte InjuryProneness { get; }
        byte Jumping { get; }
        byte Kicking { get; }
        byte LeftFoot { get; }
        byte LongShots { get; }
        byte LongThrows { get; }
        byte Marking { get; }
        byte MidfielderCenter { get; }
        byte MidfielderLeft { get; }
        byte MidfielderRight { get; }
        byte NaturalFitness { get; }
        byte OffTheBall { get; }
        byte OneOnOnes { get; }
        byte Pace { get; }
        byte Passing { get; }
        byte Penalties { get; }
        string Position { get; }
        byte Positioning { get; }
        byte Reflexes { get; }
        byte RightFoot { get; }
        byte RushingOut { get; }
        byte Stamina { get; }
        byte Strength { get; }
        byte Striker { get; }
        byte Sweeper { get; }
        byte Tackling { get; }
        byte Teamwork { get; }
        byte Technique { get; }
        byte TendencyToPunch { get; }
        byte Throwing { get; }
        byte Versatility { get; }
        byte WingbackLeft { get; }
        byte WingbackRight { get; }
        byte Workrate { get; }
    }
}