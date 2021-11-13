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

        public int OverlappingDays(Budget budget)
        {
            var another = new Period(budget.FirstDay(), budget.LastDay());

            var firstDay = another.Start;
            var lastDay = another.End;
            var overlappingStart = Start > firstDay
                ? Start
                : firstDay;

            var overlappingEnd = End < lastDay
                ? End
                : lastDay;

            return (overlappingEnd - overlappingStart).Days + 1;
        }
    }
}