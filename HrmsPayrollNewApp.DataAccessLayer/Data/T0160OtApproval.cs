﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0160OtApproval
{
    public decimal TranId { get; set; }

    public decimal EmpId { get; set; }

    public decimal CmpId { get; set; }

    public DateTime ForDate { get; set; }

    public decimal WorkingSec { get; set; }

    public decimal OtSec { get; set; }

    public byte IsApproved { get; set; }

    public decimal ApprovedOtSec { get; set; }

    public string Comments { get; set; } = null!;

    public decimal LoginId { get; set; }

    public DateTime SystemDate { get; set; }

    public string? ApprovedOtHours { get; set; }

    public decimal? PDaysCount { get; set; }

    public byte? IsMonthWise { get; set; }

    public decimal? WeekoffOtSec { get; set; }

    public decimal? ApprovedWoOtSec { get; set; }

    public string? ApprovedWoOtHours { get; set; }

    public decimal? HolidayOtSec { get; set; }

    public decimal? ApprovedHoOtSec { get; set; }

    public string? ApprovedHoOtHours { get; set; }

    public string? Remark { get; set; }

    public virtual T0010CompanyMaster Cmp { get; set; } = null!;

    public virtual T0080EmpMaster Emp { get; set; } = null!;
}