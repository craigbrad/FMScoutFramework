using FMScoutFramework.Core.Entities.GameVersions;
using System;

namespace FMScoutFramework.Core.Offsets
{
	public sealed class ContractOffsets
	{
        public IVersion Version;

        public ContractOffsets(IVersion Version)
        {
            this.Version = Version;
        }

        public const short Person = 0x4;
        public const short Team = 0x8;
 		public const short Wage = 0xC;

		public const short JobType = 0x18; // ????
		public const short SquadStatus = 0x30; //???

        public const short TeamStatus = 0x34;
        public const short Happiness = 0x37;
        public const short Clauses = 0x3C;
		public const short Bonuses = 0x48;
		public const short Type = 0x5D;

        public short SquadNumber
        {
            get
            {
                if (Version.GetType() == typeof(Steam_16_3_0_Windows) ||
                    Version.GetType() == typeof(Steam_16_3_1_Windows) ||
                    Version.GetType() == typeof(Steam_16_3_2_Windows))
                {
                    return 0x39;
                }

                return 0x35;
            }
        }

        public short DateStarted
        {
            get
            {
                if (Version.GetType() == typeof(Steam_16_3_1_Windows) ||
                    Version.GetType() == typeof(Steam_16_3_2_Windows))
                {
                    return 0x24;
                }

                return 0x20;
            }
        }

        public short DateExpires
        {
            get
            {
                if (Version.GetType() == typeof(Steam_16_3_1_Windows) ||
                    Version.GetType() == typeof(Steam_16_3_2_Windows))
                {
                    return 0x28;
                }

                return 0x24;
            }
        }

        public short TransferStatus
        {
            get
            {
                if (Version.GetType() == typeof(Steam_16_3_1_Windows) ||
                    Version.GetType() == typeof(Steam_16_3_2_Windows))
                {
                    return 0x36;
                }

                return 0x32;
            }
        }
	}
}

