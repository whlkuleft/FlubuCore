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

namespace FlubuCore.Tasks.Docker.Node
{
    public partial class DockerNodeInspectTask : ExternalProcessTaskBase<int, DockerNodeInspectTask>
    {
        private string _self;
        private string[] _node;


        public DockerNodeInspectTask(string self, params string[] node)
        {
            ExecutablePath = "docker";
            WithArguments("node inspect");
            _self = self;
            _node = node;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerNodeInspectTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        [ArgKey("--pretty")]
        public DockerNodeInspectTask Pretty()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_self);
            WithArguments(_node);

            return base.DoExecute(context);
        }
    }
}