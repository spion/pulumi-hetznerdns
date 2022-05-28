// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Hetznerdns
{
    /// <summary>
    /// ## # hetznerdns.Zone Resource
    /// 
    /// Provides a Hetzner DNS Zone resource to create, update and delete DNS Zones.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Hetznerdns = Pulumi.Hetznerdns;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var zone1 = new Hetznerdns.Zone("zone1", new Hetznerdns.ZoneArgs
    ///         {
    ///             Ttl = 3600,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// A Zone can be imported using its `id`. Log in to the Hetzner DNS web frontend, navigate to the zone you want to import, and copy the id from the URL in your browser.
    /// 
    /// ```sh
    ///  $ pulumi import hetznerdns:index/zone:Zone zone1 rMu2waTJPbHr4
    /// ```
    /// </summary>
    [HetznerdnsResourceType("hetznerdns:index/zone:Zone")]
    public partial class Zone : Pulumi.CustomResource
    {
        /// <summary>
        /// Name of the DNS zone to create. Must be a valid
        /// domain with top level domain. Meaning `&lt;domain&gt;.de` or `&lt;domain&gt;.io`. Don't
        /// include sub domains on this level. So, no `sub.&lt;domain&gt;.io`. The Hetzner API
        /// rejects attempts to create a zone with a sub domain name. Use a record to
        /// create the sub domain.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Time to live of this zone.
        /// </summary>
        [Output("ttl")]
        public Output<int> Ttl { get; private set; } = null!;


        /// <summary>
        /// Create a Zone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Zone(string name, ZoneArgs args, CustomResourceOptions? options = null)
            : base("hetznerdns:index/zone:Zone", name, args ?? new ZoneArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Zone(string name, Input<string> id, ZoneState? state = null, CustomResourceOptions? options = null)
            : base("hetznerdns:index/zone:Zone", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Zone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Zone Get(string name, Input<string> id, ZoneState? state = null, CustomResourceOptions? options = null)
        {
            return new Zone(name, id, state, options);
        }
    }

    public sealed class ZoneArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the DNS zone to create. Must be a valid
        /// domain with top level domain. Meaning `&lt;domain&gt;.de` or `&lt;domain&gt;.io`. Don't
        /// include sub domains on this level. So, no `sub.&lt;domain&gt;.io`. The Hetzner API
        /// rejects attempts to create a zone with a sub domain name. Use a record to
        /// create the sub domain.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Time to live of this zone.
        /// </summary>
        [Input("ttl", required: true)]
        public Input<int> Ttl { get; set; } = null!;

        public ZoneArgs()
        {
        }
    }

    public sealed class ZoneState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the DNS zone to create. Must be a valid
        /// domain with top level domain. Meaning `&lt;domain&gt;.de` or `&lt;domain&gt;.io`. Don't
        /// include sub domains on this level. So, no `sub.&lt;domain&gt;.io`. The Hetzner API
        /// rejects attempts to create a zone with a sub domain name. Use a record to
        /// create the sub domain.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Time to live of this zone.
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        public ZoneState()
        {
        }
    }
}