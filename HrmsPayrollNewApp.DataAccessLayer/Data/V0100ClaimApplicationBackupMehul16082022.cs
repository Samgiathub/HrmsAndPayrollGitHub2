﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0100ClaimApplicationBackupMehul16082022
{
    public decimal ClaimAppId { get; set; }

    public decimal CmpId { get; set; }

    public decimal ClaimId { get; set; }

    public DateTime ClaimAppDate { get; set; }

    public string ClaimAppCode { get; set; } = null!;

    public DateTime? ForDate { get; set; }

    public decimal ClaimAppAmount { get; set; }

    public string ClaimAppDescription { get; set; } = null!;

    public string ClaimAppDoc { get; set; } = null!;

    public string? ClaimAppStatus { get; set; }

    public string? ClaimName { get; set; }

    public decimal EmpId { get; set; }

    public string? EmpFullName { get; set; }

    public decimal? ClaimMaxLimit { get; set; }

    public string? EmpFirstName { get; set; }

    public string? MobileNo { get; set; }

    public string? WorkEmail { get; set; }

    public string? OtherEmail { get; set; }

    public decimal BranchId { get; set; }

    public decimal? EmpCode { get; set; }

    public decimal? EmpSuperior { get; set; }

    public int REmpId { get; set; }

    public string? Supervisor { get; set; }

    public string? BranchName { get; set; }

    public string? DesigName { get; set; }

    public string? AlphaEmpCode { get; set; }

    public decimal ClaimApprovalId { get; set; }

    public decimal? DesigWiseLimit { get; set; }

    public decimal? DesigId { get; set; }

    public byte SubmitFlag { get; set; }

    public decimal GrdId { get; set; }

    public byte ClaimLimitType { get; set; }

    public DateTime? DateOfJoin { get; set; }

    public string DeptName { get; set; } = null!;

    public string? GradeName { get; set; }

    public bool TermsIsAccepted { get; set; }

    public string? ClaimTermsCondition { get; set; }
}
