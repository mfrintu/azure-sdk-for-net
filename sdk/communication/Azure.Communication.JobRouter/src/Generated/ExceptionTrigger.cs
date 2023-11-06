// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// The trigger for this exception rule
    /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
    /// </summary>
    public abstract partial class ExceptionTrigger
    {
        /// <summary> Initializes a new instance of ExceptionTrigger. </summary>
        protected ExceptionTrigger()
        {
        }

        /// <summary> Initializes a new instance of ExceptionTrigger. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionTrigger. </param>
        internal ExceptionTrigger(string kind)
        {
            Kind = kind;
        }
    }
}
