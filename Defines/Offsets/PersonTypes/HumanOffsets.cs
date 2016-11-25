using System;
using FMScoutFramework.Core.Entities.GameVersions;

namespace FMScoutFramework.Core.Offsets
{
    public sealed class HumanOffsets
    {

        public IVersion Version;

        public HumanOffsets(IVersion version)
        {
            this.Version = version;
        }

        public short PersonAddress
        {
            get
            {
                return 0x0;
            }
        }

        public short HumanAttributes
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x4;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x4;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x4;
                else
                    return 0x4;
            }
        }

        public short HomeReputation
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x68;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x70;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x74;
                else
                    return 0x0;
            }
        }

        public short CurrentReputation
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x6A;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x72;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x76;
                else
                    return 0x0;
            }
        }

        public short WorldReputation
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x6C;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x74;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x78;
                else
                    return 0x0;
            }
        }

        public short RolesAttributes
        {
            get
            {
                if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                {
                    return 0x310;
                }
                else
                {
                    return 0x0;
                }
            }
        }
        
        public short DateOfBirth
        {
            get
            {
                return 0x294;
            }
        }

        public short FirstName
        {
            get
            {
                return 0x2A0;
            }
        }

        public short LastName
        {
            get
            {
                return 0x2A4;
            }
        }

        public short Nationality
        {
            get
            {
                return 0x2B0;
            }
        }

        public short Contract
        {
            get
            {
                return 0x2DC;
            }
        }

        public short ClubID
        {
            get
            {
                return 0x60;
            }
        }

        public short CurrentAbility
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x6E;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x76;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x7A;
                else
                    return 0x0;
            }
        }

        public short PotentialAbility
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x70;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x78;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x7C;
                else
                    return 0x0;
            }
        }

        public short RowID
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x80;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x88;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x26C;
                else
                    return 0x0;
            }
        }

        public short ID
        {
            get
            {
                if (Version.GetType() == typeof(Steam_14_3_0_Linux) ||
                    Version.GetType() == typeof(Steam_14_3_0_Mac) ||
                    Version.GetType() == typeof(Steam_14_3_1_Linux))
                    return 0x84;
                else if (Version.GetType() == typeof(Steam_15_2_1_Windows) ||
                    Version.GetType() == typeof(Steam_15_3_2_Mac) ||
                    Version.GetType() == typeof(Steam_15_3_2_Windows))
                    return 0x8C;
                else if (Version.GetType() == typeof(Steam_16_3_2_Windows))
                    return 0x270;
                else
                    return 0x0;
            }
        }
    }
}

