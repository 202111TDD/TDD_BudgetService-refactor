﻿#region

using System;

#endregion

namespace BudgetSystem
{
    public class Period
    {
        public Period(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        private DateTime End { get; }
        private DateTime Start { get; }

        public int OverlappingDays(Period another)
        {
            if (Start > End)
            {
                return 0;
            }

            if (End < another.Start || Start > another.End)
            {
                return 0;
            }

            var overlappingStart = Start > another.Start
                ? Start
                : another.Start;

            var overlappingEnd = End < another.End
                ? End
                : another.End;

            return (overlappingEnd - overlappingStart).Days + 1;
        }
    }
}