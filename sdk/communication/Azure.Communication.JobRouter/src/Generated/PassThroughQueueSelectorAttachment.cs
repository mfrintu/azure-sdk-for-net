// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Attaches a queue selector where the value is passed through from the job label
    /// with the same key
    /// </summary>
    public partial class PassThroughQueueSelectorAttachment : QueueSelectorAttachment
    {
        /// <summary> Initializes a new instance of PassThroughQueueSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        internal PassThroughQueueSelectorAttachment(string kind, string key, LabelOperator labelOperator) : base(kind)
        {
            Key = key;
            LabelOperator = labelOperator;
        }

        /// <summary> The label key to query against. </summary>
        public string Key { get; }
    }
}
