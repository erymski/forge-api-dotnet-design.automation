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
    /// Defines an Activity, a type of work, a function: input/outputs, instructions. An Activity is an action that can be executed within an engine. For example, for AutoCAD engine this might be plotting a DWG to PDF or update the CAD standards in a drawing file.
    /// </summary>
    [DataContract]
    public partial class Activity 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        public Activity()
        {
        }
        
        /// <summary>
        /// Path to Engine executable with arguments.
        /// </summary>
        /// <value>Path to Engine executable with arguments.</value>
        [DataMember(Name="commandLine", EmitDefaultValue=false)]
        public List<string> CommandLine { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public string Engine { get; set; }

        /// <summary>
        /// Gets or Sets Appbundles
        /// </summary>
        [DataMember(Name="appbundles", EmitDefaultValue=false)]
        public List<string> Appbundles { get; set; }

        /// <summary>
        /// The url/string Settings for a given set of AppBundles.
        /// </summary>
        /// <value>The url/string Settings for a given set of AppBundles.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, ISetting> Settings { get; set; }

        /// <summary>
        /// Human readable description of the object.
        /// </summary>
        /// <value>Human readable description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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