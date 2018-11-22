﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;

namespace Microsoft.Bot.Builder.Dialogs.Flow
{
    /// <summary>
    /// end the current dialog 
    /// </summary>
    public class EndDialog : IFlowCommand
    {
        public EndDialog() { }

        public async Task<DialogTurnResult> Execute(DialogContext dialogContext, object options, DialogTurnResult result, CancellationToken cancellationToken)
        {
            return await dialogContext.EndDialogAsync(result.Result, cancellationToken);
        }
    }
}