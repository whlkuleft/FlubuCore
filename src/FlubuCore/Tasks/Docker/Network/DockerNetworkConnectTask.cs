
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Network
{
     public partial class DockerNetworkConnectTask : ExternalProcessTaskBase<int, DockerNetworkConnectTask>
     {
        private string _network;
private string _container;

        
        public DockerNetworkConnectTask(string network,  string container)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_network = network;
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add network-scoped alias for the container
        /// </summary>
        [ArgKey("alias")]
        public DockerNetworkConnectTask Alias(string alias)
        {
            WithArgumentsKeyFromAttribute(alias.ToString());
            return this;
        }

        /// <summary>
        /// driver options for the network
        /// </summary>
        [ArgKey("driver-opt")]
        public DockerNetworkConnectTask DriverOpt(string driverOpt)
        {
            WithArgumentsKeyFromAttribute(driverOpt.ToString());
            return this;
        }

        /// <summary>
        /// IPv4 address (e.g., 172.30.100.104)
        /// </summary>
        [ArgKey("ip")]
        public DockerNetworkConnectTask Ip(string ip)
        {
            WithArgumentsKeyFromAttribute(ip.ToString());
            return this;
        }

        /// <summary>
        /// IPv6 address (e.g., 2001:db8::33)
        /// </summary>
        [ArgKey("ip6")]
        public DockerNetworkConnectTask Ip6(string ip6)
        {
            WithArgumentsKeyFromAttribute(ip6.ToString());
            return this;
        }

        /// <summary>
        /// Add link to another container
        /// </summary>
        [ArgKey("link")]
        public DockerNetworkConnectTask Link(string link)
        {
            WithArgumentsKeyFromAttribute(link.ToString());
            return this;
        }

        /// <summary>
        /// Add a link-local address for the container
        /// </summary>
        [ArgKey("link-local-ip")]
        public DockerNetworkConnectTask LinkLocalIp(string linkLocalIp)
        {
            WithArgumentsKeyFromAttribute(linkLocalIp.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_network);
 WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}