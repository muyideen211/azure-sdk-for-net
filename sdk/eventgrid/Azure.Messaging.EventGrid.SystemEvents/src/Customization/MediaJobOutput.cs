// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary>
    /// The event data for a Job output.
    /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaJobOutput
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutput"/>. </summary>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="state"> Gets the Job output state. </param>
        internal MediaJobOutput(long progress, MediaJobState state)
        {
            Progress = progress;
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutput"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="error"> Gets the Job output error. </param>
        /// <param name="label"> Gets the Job output label. </param>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="state"> Gets the Job output state. </param>
        internal MediaJobOutput(string odataType, MediaJobError error, string label, long progress, MediaJobState state)
        {
            OdataType = odataType;
            Error = error;
            Label = label;
            Progress = progress;
            State = state;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> Gets the Job output error. </summary>
        public MediaJobError Error { get; }
        /// <summary> Gets the Job output label. </summary>
        public string Label { get; }
        /// <summary> Gets the Job output progress. </summary>
        public long Progress { get; }
        /// <summary> Gets the Job output state. </summary>
        public MediaJobState State { get; }
    }
}
