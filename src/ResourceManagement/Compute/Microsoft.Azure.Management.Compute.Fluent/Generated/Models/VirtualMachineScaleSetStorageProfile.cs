// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    public partial class VirtualMachineScaleSetStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        public VirtualMachineScaleSetStorageProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        /// <param name="imageReference">the image reference.</param>
        /// <param name="osDisk">the OS disk.</param>
        public VirtualMachineScaleSetStorageProfile(ImageReference imageReference = default(ImageReference), VirtualMachineScaleSetOSDisk osDisk = default(VirtualMachineScaleSetOSDisk))
        {
            ImageReference = imageReference;
            OsDisk = osDisk;
        }

        /// <summary>
        /// Gets or sets the image reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the OS disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osDisk")]
        public VirtualMachineScaleSetOSDisk OsDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.OsDisk != null)
            {
                this.OsDisk.Validate();
            }
        }
    }
}