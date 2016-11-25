namespace FMScoutFramework.Core.Entities.InGame.Interfaces
{
    public interface IStaffAttributes
    {
        //Coaching
        byte Attacking { get; }
        byte Defending { get; }
        byte TechnicalAttacking { get; }
        byte Fitness { get; }
        byte Goalkeepers { get; }
        byte ManManagement { get; }
        byte Mental { get; }
        byte Tactical { get; }
        byte Technical { get; }
        byte WorkingWithYoungsters { get; }

        //Mental
        byte Adaptability { get; }
        byte Determination { get; }
        byte JudgingCA { get; }
        byte JudgingPA { get; }
        byte LevelOfDiscipline { get; }
        byte Motivating { get; }
        byte Physiotherapy { get; }
        byte TacticalKnowledge { get; }
    }
}
