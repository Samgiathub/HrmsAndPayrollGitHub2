﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0095EmployeeGoalSettingEvaluation
{
    public decimal CmpId { get; set; }

    public decimal EmpGoalSettingReviewId { get; set; }

    public decimal EmpId { get; set; }

    public int FinYear { get; set; }

    public int ReviewType { get; set; }

    public decimal ReviewStatus { get; set; }

    public string? EmpComments { get; set; }

    public string? ManagerComments { get; set; }

    public string? AdditionalAchievement { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public string? EmpFullName { get; set; }

    public string? AlphaEmpCode { get; set; }

    public string? EmployeeName { get; set; }

    public decimal? DeptId { get; set; }

    public decimal? DesigId { get; set; }

    public string? DeptName { get; set; }

    public string? DesigName { get; set; }
}
