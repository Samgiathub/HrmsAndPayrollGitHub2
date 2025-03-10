﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0210MonthlyAdDetail
{
    public decimal MAdTranId { get; set; }

    public decimal? SalTranId { get; set; }

    public decimal? SSalTranId { get; set; }

    public decimal? LSalTranId { get; set; }

    public decimal EmpId { get; set; }

    public decimal CmpId { get; set; }

    public decimal AdId { get; set; }

    public DateTime ForDate { get; set; }

    public decimal? MAdPercentage { get; set; }

    public decimal MAdAmount { get; set; }

    public string MAdFlag { get; set; } = null!;

    public decimal MAdActualPerAmount { get; set; }

    public decimal MAdCalculatedAmount { get; set; }

    public decimal? TempSalTranId { get; set; }

    public decimal? MAdNotEffectOnPt { get; set; }

    public decimal? MAdNotEffectSalary { get; set; }

    public decimal? MAdEffectOnOt { get; set; }

    public decimal? MAdEffectOnExtraDay { get; set; }

    public int? SalType { get; set; }

    public DateTime? MAdEffectDate { get; set; }

    public byte? MAdEffectOnLate { get; set; }

    public decimal? MArearAmount { get; set; }

    public byte ForFnf { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal SplitShiftCount { get; set; }

    public string? SplitShiftDate { get; set; }

    public byte? ReimShow { get; set; }

    public decimal? ReimAmount { get; set; }

    public decimal MArearAmountCutoff { get; set; }

    public virtual T0050AdMaster Ad { get; set; } = null!;

    public virtual T0010CompanyMaster Cmp { get; set; } = null!;

    public virtual T0080EmpMaster Emp { get; set; } = null!;

    public virtual T0200MonthlySalaryLeave? LSalTran { get; set; }

    public virtual T0201MonthlySalarySett? SSalTran { get; set; }

    public virtual T0200MonthlySalary? SalTran { get; set; }
}
