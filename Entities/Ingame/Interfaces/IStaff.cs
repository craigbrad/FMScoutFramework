﻿using System;

namespace FMScoutFramework.Core.Entities.InGame.Interfaces
{
    public interface IStaff
    {
        int ID { get; }
        StaffAttributes StaffAttributes { get; }
        short HomeReputation { get; }
        short CurrentReputation { get; }
        short WorldReputation { get; }
        DateTime DateOfBirth { get; }
        string Fullname { get; }
        string Lastname { get; }
        short CurrentAbility { get; }
        short PotentialAbility { get; }
        Nation Nationality { get; }
        int ClubID { get; }
    }
}