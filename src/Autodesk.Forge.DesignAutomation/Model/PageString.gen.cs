/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// PageString
    /// </summary>
    [DataContract]
    public partial class PageString 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageString" /> class.
        /// </summary>
        public PageString()
        {
        }
        
        /// <summary>
        /// Gets or Sets PaginationToken
        /// </summary>
        [DataMember(Name="paginationToken", EmitDefaultValue=false)]
        public string PaginationToken { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<string> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}