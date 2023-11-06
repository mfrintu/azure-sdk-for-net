// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// A rule of one of the following types:
    ///
    /// StaticRule:  A rule
    /// providing static rules that always return the same result, regardless of
    /// input.
    /// DirectMapRule:  A rule that return the same labels as the input
    /// labels.
    /// ExpressionRule: A rule providing inline expression
    /// rules.
    /// FunctionRule: A rule providing a binding to an HTTP Triggered Azure
    /// Function.
    /// WebhookRule: A rule providing a binding to a webserver following
    /// OAuth2.0 authentication protocol.
    /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
    /// </summary>
    public abstract partial class RouterRule
    {
        /// <summary> Initializes a new instance of RouterRule. </summary>
        protected RouterRule()
        {
        }

        /// <summary> Initializes a new instance of RouterRule. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of RouterRule. </param>
        internal RouterRule(string kind)
        {
            Kind = kind;
        }
    }
}
