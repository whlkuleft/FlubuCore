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

namespace FlubuCore.Tasks.Docker.Container
{
    public partial class DockerContainerLsTask : ExternalProcessTaskBase<int, DockerContainerLsTask>
    {
        public DockerContainerLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("container ls");
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        [ArgKey("--all")]
        public DockerContainerLsTask All()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        [ArgKey("--filter")]
        public DockerContainerLsTask Filter(string filter)
        {
            WithArgumentsKeyFromAttribute(filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print containers using a Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerContainerLsTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Show n last created containers (includes all states)
        /// </summary>
        [ArgKey("--last")]
        public DockerContainerLsTask Last(int last)
        {
            WithArgumentsKeyFromAttribute(last.ToString());
            return this;
        }

        /// <summary>
        /// Show the latest created container (includes all states)
        /// </summary>
        [ArgKey("--latest")]
        public DockerContainerLsTask Latest()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        [ArgKey("--no-trunc")]
        public DockerContainerLsTask NoTrunc()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Only display numeric IDs
        /// </summary>
        [ArgKey("--quiet")]
        public DockerContainerLsTask Quiet()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Display total file sizes
        /// </summary>
        [ArgKey("--size")]
        public DockerContainerLsTask Size()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            return base.DoExecute(context);
        }
    }
}