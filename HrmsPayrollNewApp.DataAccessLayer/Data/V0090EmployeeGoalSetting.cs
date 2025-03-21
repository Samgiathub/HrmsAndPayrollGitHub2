﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0090EmployeeGoalSetting
{
    public decimal EmpGoalSettingId { get; set; }

    public decimal CmpId { get; set; }

    public decimal EmpId { get; set; }

    public decimal EgsStatus { get; set; }

    public int FinYear { get; set; }

    public string? EmpFullName { get; set; }

    public string? AlphaEmpCode { get; set; }

    public string? EmployeeName { get; set; }

    public decimal? DeptId { get; set; }

    public decimal? DesigId { get; set; }

    public string? DesigName { get; set; }

    public string? DeptName { get; set; }

    public string? EmpComment { get; set; }

    public string? ManagerComment { get; set; }
}
