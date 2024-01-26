// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Plan data of NewRelic Monitor resource. </summary>
    public partial class NewRelicPlanDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDetails"/>. </summary>
        public NewRelicPlanDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDetails"/>. </summary>
        /// <param name="usageType"> Different usage type like PAYG/COMMITTED. this could be enum. </param>
        /// <param name="billingCycle"> Different billing cycles like MONTHLY/WEEKLY. this could be enum. </param>
        /// <param name="planDetails"> plan id as published by NewRelic. </param>
        /// <param name="effectiveOn"> date when plan was applied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicPlanDetails(NewRelicObservabilityUsageType? usageType, NewRelicObservabilityBillingCycle? billingCycle, string planDetails, DateTimeOffset? effectiveOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UsageType = usageType;
            BillingCycle = billingCycle;
            PlanDetails = planDetails;
            EffectiveOn = effectiveOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Different usage type like PAYG/COMMITTED. this could be enum. </summary>
        public NewRelicObservabilityUsageType? UsageType { get; set; }
        /// <summary> Different billing cycles like MONTHLY/WEEKLY. this could be enum. </summary>
        public NewRelicObservabilityBillingCycle? BillingCycle { get; set; }
        /// <summary> plan id as published by NewRelic. </summary>
        public string PlanDetails { get; set; }
        /// <summary> date when plan was applied. </summary>
        public DateTimeOffset? EffectiveOn { get; set; }
    }
}
