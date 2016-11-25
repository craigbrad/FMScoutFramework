using System;
using FMScoutFramework.Core.Managers;
using FMScoutFramework.Core.Offsets;
using FMScoutFramework.Core.Entities.GameVersions;
using FMScoutFramework.Core.Entities.InGame.Interfaces;

namespace FMScoutFramework.Core.Entities.InGame
{
    public class StaffAttributes : BaseObject, IStaffAttributes
    {
        public StaffAttributes(int memoryAddress, IVersion version) 
			: base(memoryAddress, version)
		{ }
        public StaffAttributes(int memoryAddress, ArraySegment<byte> originalBytes, IVersion version) 
			: base(memoryAddress, originalBytes, version)
		{ }

        public byte Attacking
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Attacking, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Attacking, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Defending
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Defending, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Defending, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Fitness
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Fitness, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Fitness, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Goalkeepers
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Goalkeepers, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Goalkeepers, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte ManManagement
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.ManManagement, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.ManManagement, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Mental
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Mental, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Mental, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Tactical
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Tactical, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Tactical, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Technical
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Technical, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Technical, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte WorkingWithYoungsters
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.WorkingWithYoungsters, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.WorkingWithYoungsters, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Adaptability
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Adaptability, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Adaptability, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Determination
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Determination, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Determination, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte JudgingCA
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.JudgingCA, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.JudgingCA, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte JudgingPA
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.JudgingPA, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.JudgingPA, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte LevelOfDiscipline
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.LevelOfDiscipline, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.LevelOfDiscipline, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Motivating
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Motivating, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Motivating, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte Physiotherapy
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.Physiotherapy, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.Physiotherapy, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte TacticalKnowledge
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.TacticalKnowledge, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.TacticalKnowledge, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }

        public byte TechnicalAttacking
        {
            get
            {
                return PropertyInvoker.Get<byte>(StaffAttributesOffsets.TechnicalAttacking, OriginalBytes, MemoryAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<byte>(StaffAttributesOffsets.TechnicalAttacking, OriginalBytes, MemoryAddress, DatabaseMode, value);
            }
        }
    }
}
