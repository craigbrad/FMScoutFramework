namespace FMScoutFramework.Core.Entities.InGame.Interfaces
{
    public interface IHumanAttributes
    {
        //Coaching
        byte Attacking { get; }
        byte Defending { get; }
        byte Fitness { get; }
        byte Goalkeepers { get; }
        byte Mental { get; }
        byte Player { get; }
        byte Tactical { get; }
        byte Technical { get; }
        byte ManManagement { get; }
        byte WorkingWithYoungsters { get; }

        //Mental
        byte Determination { get; }
        byte PlayerKnowledge { get; }
        byte YoungsterKnowledge { get; }
        byte LevelOfDiscipline { get; }
        byte Motivating { get; }

        //General
        byte FinancialControl { get; }
        byte SquadDiscipline { get; }
        byte ClubPlayerLoyalty { get; }
        byte TacticalConsistency { get; }
        byte DomesticPlayerBias { get; }
        byte HandsOnApproach { get; }
        byte MediaHandling { get; }
    }
}
