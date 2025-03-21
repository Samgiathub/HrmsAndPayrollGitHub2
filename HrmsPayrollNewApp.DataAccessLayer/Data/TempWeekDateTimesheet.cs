﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class TempWeekDateTimesheet
{
    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateOnly? WeekStartDate { get; set; }

    public DateOnly? WeekEndDate { get; set; }

    public DateOnly? MondayDate { get; set; }

    public DateOnly? TuesdayDate { get; set; }

    public DateOnly? WednesdayDate { get; set; }

    public DateOnly? ThursdayDate { get; set; }

    public DateOnly? FridayDate { get; set; }

    public DateOnly? SaturdayDate { get; set; }

    public DateOnly? SundayDate { get; set; }

    public decimal TimesheetId { get; set; }

    public decimal TimesheetDetailId { get; set; }

    public decimal? CmpId { get; set; }

    public decimal? EmployeeId { get; set; }

    public string? TimesheetPeriod { get; set; }

    public string? Mon { get; set; }

    public string? Tue { get; set; }

    public string? Wed { get; set; }

    public string? Thu { get; set; }

    public string? Fri { get; set; }

    public string? Sat { get; set; }

    public string? Sun { get; set; }

    public decimal? ProjectStatusId { get; set; }
}
