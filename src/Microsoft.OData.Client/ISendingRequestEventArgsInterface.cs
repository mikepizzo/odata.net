//---------------------------------------------------------------------
// <copyright file="ISendingRequestEventArgsInterface.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Client
{
    internal interface ISendingRequestEventArgsInterface
    {
        void BeforeSendingRequest2Event();
        void AfterSendingRequest2Event();
    }
}
