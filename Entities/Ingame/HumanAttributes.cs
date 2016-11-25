using System;
using FMScoutFramework.Core.Managers;
using FMScoutFramework.Core.Offsets;
using FMScoutFramework.Core.Entities.GameVersions;
using FMScoutFramework.Core.Entities.InGame.Interfaces;

namespace FMScoutFramework.Core.Entities.InGame
{
    public class HumanAttributes : BaseObject, IHumanAttributes
    {
        public HumanAttributes(int memoryAddress, IVersion version)
            : base(memoryAddress, version)
        { }
        public HumanAttributes(int memoryAddress, ArraySegment<byte> originalBytes, IVersion version)
            : base(memoryAddress, originalBytes, version)
        { }

        public byte Attacking
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Attacking, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Attacking, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Defending
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Defending, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Defending, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Fitness
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Fitness, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Fitness, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Goalkeepers
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Goalkeepers, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Goalkeepers, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Mental
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Mental, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Mental, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Player
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Player, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Player, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Tactical
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Tactical, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Tactical, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Technical
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Technical, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Technical, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte ManManagement
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.ManManagement, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.ManManagement, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte WorkingWithYoungsters
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.WorkingWithYoungsters, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.WorkingWithYoungsters, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Determination
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Determination, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Determination, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte PlayerKnowledge
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.PlayerKnowledge, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.PlayerKnowledge, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte YoungsterKnowledge
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.YoungsterKnowledge, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.YoungsterKnowledge, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte LevelOfDiscipline
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.LevelOfDiscipline, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.LevelOfDiscipline, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Motivating
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.Motivating, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.Motivating, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte FinancialControl
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.FinancialControl, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.FinancialControl, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte SquadDiscipline
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.SquadDiscipline, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.SquadDiscipline, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte ClubPlayerLoyalty
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.ClubPlayerLoyalty, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.ClubPlayerLoyalty, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte TacticalConsistency
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.TacticalConsistency, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.TacticalConsistency, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte DomesticPlayerBias
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.DomesticPlayerBias, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.DomesticPlayerBias, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte HandsOnApproach
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.HandsOnApproach, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.HandsOnApproach, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte MediaHandling
        {
            get
            {
                return PropertyInvoker.Get<byte>(HumanAttributesOffsets.MediaHandling, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(HumanAttributesOffsets.MediaHandling, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

    }
}
