using System;
using FMScoutFramework.Core.Managers;
using FMScoutFramework.Core.Offsets;
using FMScoutFramework.Core.Entities.GameVersions;
using FMScoutFramework.Core.Entities.InGame.Interfaces;

namespace FMScoutFramework.Core.Entities.InGame
{
	public class Staff : Person, IStaff
    {
		private StaffOffsets StaffOffsets;
		public Staff (int memoryAddress, IVersion version) 
			: base(memoryAddress, version)
		{	
			this.StaffOffsets = new StaffOffsets (version);
		}
		public Staff (int memoryAddress, ArraySegment<byte> originalBytes, IVersion version) 
			: base(memoryAddress, originalBytes, version)
		{	
			this.StaffOffsets = new StaffOffsets (version);
		}

		protected override int PersonAddress {
			get {
				return StaffAddress + StaffOffsets.PersonAddress;
			}
		}

		public int StaffAddress {
			get {
				return MemoryAddress + Version.PersonOffsets.Staff;
			}
		}

        public Int32 ID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(StaffOffsets.ID, OriginalBytes, StaffAddress, DatabaseMode);
            }
        }

        public Int32 RowID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(StaffOffsets.RowID, OriginalBytes, StaffAddress, DatabaseMode);
            }
        }


        public short HomeReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(StaffOffsets.HomeReputation, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(StaffOffsets.HomeReputation, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public short CurrentReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(StaffOffsets.CurrentReputation, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(StaffOffsets.CurrentReputation, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public short WorldReputation
        {
            get
            {
                return PropertyInvoker.Get<short>(StaffOffsets.WorldReputation, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(StaffOffsets.WorldReputation, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public short CurrentAbility
        {
            get
            {
                return PropertyInvoker.Get<short>(StaffOffsets.CurrentAbility, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(StaffOffsets.CurrentAbility, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public short PotentialAbility
        {
            get
            {
                return PropertyInvoker.Get<short>(StaffOffsets.PotentialAbility, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<short>(StaffOffsets.PotentialAbility, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public new DateTime DateOfBirth
        {
            get
            {
                return PropertyInvoker.Get<DateTime>(StaffOffsets.DateOfBirth, OriginalBytes, StaffAddress, DatabaseMode);
            }
            set
            {
                PropertyInvoker.Set<DateTime>(StaffOffsets.DateOfBirth, OriginalBytes, StaffAddress, DatabaseMode, value);
            }
        }

        public new string Firstname
        {
            get
            {
                return PropertyInvoker.GetString(StaffOffsets.FirstName, Version.MemoryAddresses.StringOffset, OriginalBytes, StaffAddress, DatabaseMode);
            }
        }

        public new string Lastname
        {
            get
            {
                return PropertyInvoker.GetString(StaffOffsets.LastName, Version.MemoryAddresses.StringOffset, OriginalBytes, StaffAddress, DatabaseMode);
            }
        }

        public new Nation Nationality
        {
            get
            {
                return PropertyInvoker.GetPointer<Nation>(StaffOffsets.Nationality, OriginalBytes, StaffAddress, DatabaseMode, Version);
            }
        }

        public StaffAttributes StaffAttributes
        {
            get
            {
                int startAddress = StaffAddress + StaffOffsets.StaffAttributes;
                return new StaffAttributes(startAddress, Version);
            }
        }

        public new Contract Contract
        {
            get
            {
                return PropertyInvoker.GetPointer<Contract>(StaffOffsets.Contract, OriginalBytes, PersonAddress, DatabaseMode, Version);
            }
        }

        public Int32 ClubID
        {
            get
            {
                return PropertyInvoker.Get<Int32>(StaffOffsets.ClubID, OriginalBytes, StaffAddress, DatabaseMode);
            }
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}

