using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataLayer {

    public class Medication {
        [JsonProperty("medicationId")]
        public int MedicationId { get; set; }
        [JsonProperty("humanReadableName")]
        public string HumanReadableName { get; set; }
        [JsonProperty("medicalName")]
        public string MedicalName { get; set; }

        // in mg, most likely
        [JsonProperty("perscribedDose")]
        public int PerscribedDosage { get; set; }
        // in minutes
        [JsonProperty("timeBetweenDoses")]
        public int TimeBetweenDoses { get; set; }

        [JsonProperty("maxNumberOfDoses")]
        public int MaximumNumberOfDoses { get; set; }

        [JsonProperty("initialDoseTime")]
        public DateTime InitialDoseTime { get; set; }

        // contains a list of calculated times
        [JsonProperty("calculatesDoseTimes")]
        public ICollection<DateTime> CalculatedDoseTime { get; set; }
        // times are moved from the above into here, once actioned
        [JsonProperty("actionedDoseTimes")]
        public ICollection<DateTime> ActionedDoseTimes { get; set; }

        [JsonProperty("medicationAddedDate")]
        public DateTime MedicationAddedDate { get; set; }
        [JsonProperty("medicationNoLongerActiveDate")]
        public DateTime MedicationNoLongerActiveDate { get; set; }
        
        [JsonProperty("medicationActive")]
        public bool MedicationActive { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

    }
}