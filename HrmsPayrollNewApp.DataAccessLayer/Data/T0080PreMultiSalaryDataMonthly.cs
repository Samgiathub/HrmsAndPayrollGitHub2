﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0080PreMultiSalaryDataMonthly
{
    public string? Type { get; set; }

    public string? MSalTranId { get; set; }

    public decimal? EmpId { get; set; }

    public decimal? CmpId { get; set; }

    public string? SalGenerateDate { get; set; }

    public string? MonthStDate { get; set; }

    public string? MonthEndDate { get; set; }

    public decimal? MOtHours { get; set; }

    public decimal? AreasAmount { get; set; }

    public decimal? MItTax { get; set; }

    public decimal? OtherDedu { get; set; }

    public decimal? MLoanAmount { get; set; }

    public decimal? MAdvAmount { get; set; }

    public decimal? IsLoanDedu { get; set; }

    public decimal? LoginId { get; set; }

    public string? ErrRaise { get; set; }

    public string? IsNegetive { get; set; }

    public string? Status { get; set; }

    public decimal? ItMEdCessAmount { get; set; }

    public decimal? ItMSurchargeAmount { get; set; }

    public decimal? AlloOnLeave { get; set; }

    public decimal? WOtHours { get; set; }

    public decimal? HOtHours { get; set; }

    public decimal? UserId { get; set; }

    public string? IpAddress { get; set; }

    public bool? IsBondDedu { get; set; }

    public string? SalaryParameter { get; set; }

    public byte? IsManual { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Id { get; set; }

    public byte? BackEndSalary { get; set; }

    public byte? Processed { get; set; }

    public DateTime? StartTime { get; set; }
}
