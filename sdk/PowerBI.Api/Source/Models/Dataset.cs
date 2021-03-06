// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A Power BI Dataset
    /// </summary>
    public partial class Dataset
    {
        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        public Dataset() { }

        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        public Dataset(string name, IList<Table> tables, string id = default(string), string defaultRetentionPolicy = default(string), string webUrl = default(string), IList<Datasource> datasources = default(IList<Datasource>))
        {
            Id = id;
            Name = name;
            DefaultRetentionPolicy = defaultRetentionPolicy;
            Tables = tables;
            WebUrl = webUrl;
            Datasources = datasources;
        }

        /// <summary>
        /// The dataset id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The dataset default data retention policy
        /// </summary>
        [JsonProperty(PropertyName = "defaultRetentionPolicy")]
        public string DefaultRetentionPolicy { get; set; }

        /// <summary>
        /// The dataset tables
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// The dataset web url
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// The datasources associated with this dataset
        /// </summary>
        [JsonProperty(PropertyName = "datasources")]
        public IList<Datasource> Datasources { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Tables == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tables");
            }
            if (this.Tables != null)
            {
                foreach (var element in this.Tables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
