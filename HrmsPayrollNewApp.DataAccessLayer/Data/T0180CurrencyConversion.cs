﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0180CurrencyConversion
{
    public decimal CurrConvId { get; set; }

    public decimal CmpId { get; set; }

    public decimal CurrId { get; set; }

    public DateTime ForDate { get; set; }

    public decimal CurrRate { get; set; }
}