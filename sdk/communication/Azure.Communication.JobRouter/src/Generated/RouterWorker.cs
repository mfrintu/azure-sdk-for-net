// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> An entity for jobs to be routed to. </summary>
    public partial class RouterWorker
    {
        /// <summary> Initializes a new instance of RouterWorker. </summary>
        internal RouterWorker()
        {
            Queues = new ChangeTrackingList<string>();
            _labels = new ChangeTrackingDictionary<string, BinaryData>();
            _tags = new ChangeTrackingDictionary<string, BinaryData>();
            Channels = new ChangeTrackingList<RouterChannel>();
            Offers = new ChangeTrackingList<RouterJobOffer>();
            AssignedJobs = new ChangeTrackingList<RouterWorkerAssignment>();
        }

        /// <summary> Initializes a new instance of RouterWorker. </summary>
        /// <param name="etag"> Concurrency Token. </param>
        /// <param name="id"> Id of the worker. </param>
        /// <param name="state"> The current state of the worker. </param>
        /// <param name="queues"> The queue(s) that this worker can receive work from. </param>
        /// <param name="capacity"> The total capacity score this worker has to manage multiple concurrent jobs. </param>
        /// <param name="labels">
        /// A set of key/value pairs that are identifying attributes used by the rules
        /// engines to make decisions.
        /// </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this worker. </param>
        /// <param name="channels"> The channel(s) this worker can handle and their impact on the workers capacity. </param>
        /// <param name="offers"> A list of active offers issued to this worker. </param>
        /// <param name="assignedJobs"> A list of assigned jobs attached to this worker. </param>
        /// <param name="loadRatio">
        /// A value indicating the workers capacity. A value of '1' means all capacity is
        /// consumed. A value of '0' means no capacity is currently consumed.
        /// </param>
        /// <param name="availableForOffers"> A flag indicating this worker is open to receive offers or not. </param>
        internal RouterWorker(string etag, string id, RouterWorkerState? state, IList<string> queues, int? capacity, IDictionary<string, BinaryData> labels, IDictionary<string, BinaryData> tags, IList<RouterChannel> channels, IReadOnlyList<RouterJobOffer> offers, IReadOnlyList<RouterWorkerAssignment> assignedJobs, double? loadRatio, bool? availableForOffers)
        {
            _etag = etag;
            Id = id;
            State = state;
            Queues = queues;
            Capacity = capacity;
            _labels = labels;
            _tags = tags;
            Channels = channels;
            Offers = offers;
            AssignedJobs = assignedJobs;
            LoadRatio = loadRatio;
            AvailableForOffers = availableForOffers;
        }
        /// <summary> Id of the worker. </summary>
        public string Id { get; }
        /// <summary> The current state of the worker. </summary>
        public RouterWorkerState? State { get; }
        /// <summary> A list of active offers issued to this worker. </summary>
        public IReadOnlyList<RouterJobOffer> Offers { get; }
        /// <summary> A list of assigned jobs attached to this worker. </summary>
        public IReadOnlyList<RouterWorkerAssignment> AssignedJobs { get; }
        /// <summary>
        /// A value indicating the workers capacity. A value of '1' means all capacity is
        /// consumed. A value of '0' means no capacity is currently consumed.
        /// </summary>
        public double? LoadRatio { get; }
    }
}
