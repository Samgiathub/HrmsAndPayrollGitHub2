﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0120TravelApproval
{
    public string? AlphaEmpCode { get; set; }

    public decimal TravelApprovalId { get; set; }

    public decimal CmpId { get; set; }

    public decimal EmpId { get; set; }

    public string ApplicationCode { get; set; } = null!;

    public DateTime ApplicationDate { get; set; }

    public string? Supervisor { get; set; }

    public string? EmpFullName { get; set; }

    public DateTime ApprovalDate { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public string? ApprovalComments { get; set; }

    public decimal TravelApplicationId { get; set; }

    public string ApplicationStatus { get; set; } = null!;

    public string? BranchName { get; set; }

    public decimal BranchId { get; set; }

    public decimal TravelSetApplicationId { get; set; }

    public decimal? VerticalId { get; set; }

    public decimal? SubVerticalId { get; set; }

    public decimal? DeptId { get; set; }

    public string Status { get; set; } = null!;

    public string ReasonName { get; set; } = null!;
}
