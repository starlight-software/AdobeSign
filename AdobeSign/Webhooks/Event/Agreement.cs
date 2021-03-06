﻿using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{

    public class Agreement
    {
        /// <summary>
        /// The unique identifier of agreement that can be used to query status and download signed documents.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the agreement that will be used to identify it, in emails and on the website.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        /// <summary>
        /// The current status of the agreement. (OUT_FOR_SIGNATURE, SIGNED, APPROVED, ACCEPTED, DELIVERED, FORM_FILLED, ABORTED, EXPIRED, OUT_FOR_APPROVAL, OUT_FOR_ACCEPTANCE, OUT_FOR_DELIVERY, OUT_FOR_FORM_FILLING, or CANCELLED)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ccs")]
        public Cc[] Ccs { get; set; }

        [JsonProperty("deviceInfo")]
        public DeviceInfo DeviceInfo { get; set; }

        [JsonProperty("documentVisibilityEnabled")]
        public bool? DocumentVisibilityEnabled { get; set; }

        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }


        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        [JsonProperty("externalId")]
        public ExternalId ExternalId { get; set; }

        [JsonProperty("postSignOption")]
        public PostSignOption PostSignOption { get; set; }

        [JsonProperty("firstReminderDelay")]
        public string FirstReminderDelay { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("reminderFrequency")]
        public string ReminderFrequency { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("vaultingInfo")]
        public VaultingInfo VaultingInfo { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("participantSetsInfo")]
        public ParticipantSetsInfo ParticipantSetsInfo { get; set; }

        [JsonProperty("documentsInfo")]
        public DocumentsInfo DocumentsInfo { get; set; }

        [JsonProperty("signedDocumentInfo")]
        public SignedDocumentInfo SignedDocumentInfo { get; set; }
    }
   
   
}
