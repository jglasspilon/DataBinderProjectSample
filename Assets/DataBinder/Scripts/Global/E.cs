using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Collection of enums for global communication
/// Author: Julian
/// </summary>
public static class E 
{
    #region DataPlatform Enums
    public enum FinanceChartType
    {
        SingleChart = 0,
        CandlestickChart = 1,
        PerformanceChart = 2,
    }

    public enum SliderBinderType
    {
        JustValue = 0,
        ValueAndMax = 1,
        JustMax = 2,
    }

    public enum CandidateImageType
    {
        Headshots = 0,
        Cutouts = 1,
    }

    public enum ImageSource
    {
        Url = 0,
        Resources = 1,
        StreamingAssets = 2,
    }
    #endregion

    #region Elections Enums
    public enum ModuleID
    {
        Map = 0,
        Board = 1,
        WhatIf = 2,
        Demographics = 3,
        RaceGrid = 4,

        Test = 99,
    }

    public enum Office
    {
        President = 0,
        Senate = 1,
        House = 2,
        Governor = 3,
    }

    public enum DemographicsChartType
    {
        SimplePie = 0,
        SteppedDoublePie = 1,
        SameHeightDoublePie = 2,
        SimpleBarChart = 3,
        ComparisonBarChart = 4,
    }

    public enum RegionType
    {
        Nation = -1,
        State = 0,
        County = 1,
        District = 2,
        County2016 = 3,
        County2012 = 4,
        County2008 = 5,
        District2018 = 6,
        District2016 = 7,
        District2014 = 8,
        District2012 = 9,
        District2010 = 10,

        Senate = 25,
        WhatIf = 50,
        Unassigned = 99
    }

    public enum MapRequestContext
    {
        AtThisHour = 0,
        AtStake = 1,
        Historical = 2,
        YetToBeCalled = 3,
        AtStakeTonight = 4,
        SoFar = 5,
        AtStakeParty = 6,
        Outlook = 7,
    }

    public enum RegionVizualization
    {
        Map = 0,
        Tile = 1,
    }

    public enum BoardType
    {
        President = 0,
        Super = 1,
        AtThisHour = 2,
        CurrentMakeup = 3,
        SwitchedSeatsNumbers = 4,
        SwitchedSeats = 5,
        InPlay = 6,
        Final = 7,
        ToSwitchControl = 8,
        PresidentRawVote = 9,
        SuperRawVote =10,
    }

    public enum GridElementType
    {
        Race = 0,
        PollClose = 1,
        Empty = 2,
    }

    public enum RaceGridRequestContext
    {
        AtThisHour = 0,
        AtStake = 1,
        YetToBeCalled = 2,
        Winner = 3,
        PollClose = 4,
    }

    public enum RaceGridSorting
    {
        PollClose = 0,
        Difficulty = 1,
        Alpha = 2,
    }

    public enum RaceGridContent
    {
        ElectoralVotes = 0,
        VoteReporting = 1,
    }

    public enum RaceGridMode
    {
        RaceGrid = 0,
        Battlegrounds = 1,
    }

    public enum WhatIfTrend
    {
        None = -1,
        LeaningDem = 0,
        LeaningRep = 1,
        SafeDem = 2,
        SafeRep = 3,
        TossUp = 4,
        LikelyDem = 5,
        LikelyRep = 6,
    }

    public enum PopupType
    {
        Simple = 0,
        Info = 1,
        Absentee = 2,
    }
    #endregion
}
