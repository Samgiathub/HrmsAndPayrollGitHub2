﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0115TravelApprovalDetailLevel
{
    public decimal RowId { get; set; }

    public decimal TranId { get; set; }

    public decimal TravelApplicationId { get; set; }

    public decimal CmpId { get; set; }

    public string PlaceOfVisit { get; set; } = null!;

    public string TravelPurpose { get; set; } = null!;

    public decimal? InstructEmpId { get; set; }

    public decimal TravelModeId { get; set; }

    public DateTime FromDate { get; set; }

    public decimal Period { get; set; }

    public DateTime ToDate { get; set; }

    public string? Remarks { get; set; }

    public decimal LeaveApprovalId { get; set; }

    public decimal LeaveId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public decimal? LocId { get; set; }

    public decimal? ProjectId { get; set; }

    public DateTime? HalfLeaveDate { get; set; }

    public string? LeaveType { get; set; }

    public decimal NightDay { get; set; }

    public int? FromStateId { get; set; }

    public int? FromCityId { get; set; }

    public int ReasonId { get; set; }

    public virtual T0010CompanyMaster Cmp { get; set; } = null!;

    public virtual T0080EmpMaster? InstructEmp { get; set; }

    public virtual T0115TravelLevelApproval Tran { get; set; } = null!;
}
