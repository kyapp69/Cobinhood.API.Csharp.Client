﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobinhood.API.Csharp.Client.Models.Enums
{
    public enum WithdrawalStatus
    {
        [Description("tx_pending_two_factor_auth")]
        PendingTwoFactorAuth,
        [Description("tx_pending_email_auth")]
        PendingEmailAuth,
        [Description("tx_pending_approval")]
        PendingApproval,
        [Description("tx_approved")]
        Approved,
        [Description("tx_processing")]
        Processing,
        [Description("tx_sent")]
        Sent,
        [Description("tx_pending")]
        Pending,
        [Description("tx_confirmed")]
        Confirmed,
        [Description("tx_timeout")]
        Timeout,
        [Description("tx_invalid")]
        Invalid,
        [Description("tx_cancelled")]
        Cancelled,
        [Description("tx_rejected")]
        Rejected
    }
}
