using System;
using FMScoutFramework.Core.Managers;
using FMScoutFramework.Core.Offsets;
using FMScoutFramework.Core.Entities.GameVersions;
using FMScoutFramework.Core.Entities.InGame.Interfaces;

namespace FMScoutFramework.Core.Entities.InGame
{
	public class Human : Person, IHuman
    {
		private HumanOffsets HumanOffsets;
		public Human(int memoryAddress, IVersion version) 
			: base(memoryAddress, version)
		{	
			this.HumanOffsets = new HumanOffsets(version);
		}
		public Human(int memoryAddress, ArraySegment<byte> originalBytes, IVersion version) 
			: base(memoryAddress, originalBytes, version)
		{	
			this.HumanOffsets = new HumanOffsets(version);
		}

		protected override int PersonAddress {
			get {
				return HumanAddress + HumanOffsets.PersonAddress;
			}
		}

		public int HumanAddress {
			get {
				return MemoryAddress + Version.PersonOffsets.HumanManager;
			}
		}

        public Int32 ID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(HumanOffsets.ID, OriginalBytes, HumanAddress, DatabaseMode);
            }
        }

        public Int32 RowID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(HumanOffsets.RowID, OriginalBytes, HumanAddress, DatabaseMode);
            }
        }


        public short HomeReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(HumanOffsets.HomeReputation, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(HumanOffsets.HomeReputation, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public short CurrentReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(HumanOffsets.CurrentReputation, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(HumanOffsets.CurrentReputation, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public short WorldReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(HumanOffsets.WorldReputation, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(HumanOffsets.WorldReputation, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public short CurrentAbility
        {
            get
            {
                return PropertyInvoker.Get<short>(HumanOffsets.CurrentAbility, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(HumanOffsets.CurrentAbility, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public short PotentialAbility
        {
            get
            {
                return PropertyInvoker.Get<short>(HumanOffsets.PotentialAbility, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(HumanOffsets.PotentialAbility, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public new DateTime DateOfBirth
        {
            get
            {
                return PropertyInvoker.Get<DateTime>(HumanOffsets.DateOfBirth, OriginalBytes, HumanAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<DateTime>(HumanOffsets.DateOfBirth, OriginalBytes, HumanAddress, DatabaseMode, value);
            }
        }

        public new string Firstname
        {
            get
            {
                return PropertyInvoker.GetString(HumanOffsets.FirstName, Version.MemoryAddresses.StringOffset, OriginalBytes, HumanAddress, DatabaseMode);
            }
        }

        public new string Lastname
        {
            get
            {
                return PropertyInvoker.GetString(HumanOffsets.LastName, Version.MemoryAddresses.StringOffset, OriginalBytes, HumanAddress, DatabaseMode);
            }
        }

        public new Nation Nationality
        {
            get
            {
                return PropertyInvoker.GetPointer<Nation>(HumanOffsets.Nationality, OriginalBytes, HumanAddress, DatabaseMode, Version);
            }
        }

        public HumanAttributes HumanAttributes
        {
            get
            {
                int startAddress = HumanAddress + HumanOffsets.HumanAttributes;
                return new HumanAttributes(startAddress, Version);
            }
        }

        public new Contract Contract
        {
            get
            {
                return PropertyInvoker.GetPointer<Contract>(HumanOffsets.Contract, OriginalBytes, PersonAddress, DatabaseMode, Version);
            }
        }

        public Int32 ClubID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(HumanOffsets.ClubID, OriginalBytes, HumanAddress, DatabaseMode);
            }
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}

