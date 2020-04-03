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

namespace FlubuCore.Tasks.Docker.Stack
{
    public partial class DockerStackLsTask : ExternalProcessTaskBase<int, DockerStackLsTask>
    {
        public DockerStackLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("stack ls");
        }

        protected override string Description { get; set; }

        /// <summary>
        /// List stacks from all Kubernetes namespaces
        /// </summary>
        [ArgKey("--all-namespaces")]
        public DockerStackLsTask AllNamespaces()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Pretty-print stacks using a Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerStackLsTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Kubernetes namespaces to use
        /// </summary>
        [ArgKey("--namespace")]
        public DockerStackLsTask Namespace(string @namespace)
        {
            WithArgumentsKeyFromAttribute(@namespace.ToString());
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            return base.DoExecute(context);
        }
    }
}