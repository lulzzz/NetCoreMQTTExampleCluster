﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PublishMessage.cs" company="Haemmer Electronics">
//   Copyright (c) 2020 All rights reserved.
// </copyright>
// <summary>
//   The publish message class. It contains all published messages.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetCoreMQTTExampleCluster.Storage.Data
{
    using System;

    using MQTTnet.Protocol;

    /// <summary>
    /// The publish message class. It contains all published messages.
    /// </summary>
    public class PublishMessage
    {
        /// <summary>
        /// Gets or sets the primary key.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        public PublishedMessagePayload Payload { get; set; }

        /// <summary>
        /// Gets or sets the quality of service level.
        /// </summary>
        public MqttQualityOfServiceLevel? QoS { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the message was retained or not.
        /// </summary>
        public bool? Retain { get; set; }

        /// <summary>
        /// Gets or sets the created at timestamp.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Returns a <see cref="string"></see> representation of the <see cref="PublishMessage"/> class.
        /// </summary>
        /// <returns>A <see cref="string"></see> representation of the <see cref="PublishMessage"/> class.</returns>
        public override string ToString()
        {
            return $"{{{nameof(this.Id)}: {this.Id}, {nameof(this.ClientId)}: {this.ClientId}, {nameof(this.Topic)}: {this.Topic}, {nameof(this.Payload)}: {this.Payload}, {nameof(this.QoS)}: {this.QoS}, {nameof(this.Retain)}: {this.Retain}, {nameof(this.CreatedAt)}: {this.CreatedAt}}}";
        }
    }
}
