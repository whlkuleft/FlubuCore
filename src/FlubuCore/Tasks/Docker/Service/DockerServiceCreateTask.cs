
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Service
{
     public partial class DockerServiceCreateTask : ExternalProcessTaskBase<int, DockerServiceCreateTask>
     {
        private string _image;
private string _command;
private string[] _arg;

        
        public DockerServiceCreateTask(string image,  string command,  params string[] arg)
        {
            ExecutablePath = "docker";
            WithArguments("service create");
_image = image;
_command = command;
_arg = arg;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify configurations to expose to the service
        /// </summary>
        public DockerServiceCreateTask Config(string config)
        {
            WithArgumentsValueRequired("config", config.ToString());
            return this;
        }

        /// <summary>
        /// Placement constraints
        /// </summary>
        public DockerServiceCreateTask Constraint(string constraint)
        {
            WithArgumentsValueRequired("constraint", constraint.ToString());
            return this;
        }

        /// <summary>
        /// Container labels
        /// </summary>
        public DockerServiceCreateTask ContainerLabel(string containerLabel)
        {
            WithArgumentsValueRequired("container-label", containerLabel.ToString());
            return this;
        }

        /// <summary>
        /// Credential spec for managed service account (Windows only)
        /// </summary>
        public DockerServiceCreateTask CredentialSpec(string credentialSpec)
        {
            WithArgumentsValueRequired("credential-spec", credentialSpec.ToString());
            return this;
        }

        /// <summary>
        /// Exit immediately instead of waiting for the service to converge

        /// </summary>
        public DockerServiceCreateTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Set custom DNS servers
        /// </summary>
        public DockerServiceCreateTask Dns(string dns)
        {
            WithArgumentsValueRequired("dns", dns.ToString());
            return this;
        }

        /// <summary>
        /// Set DNS options
        /// </summary>
        public DockerServiceCreateTask DnsOption(string dnsOption)
        {
            WithArgumentsValueRequired("dns-option", dnsOption.ToString());
            return this;
        }

        /// <summary>
        /// Set custom DNS search domains
        /// </summary>
        public DockerServiceCreateTask DnsSearch(string dnsSearch)
        {
            WithArgumentsValueRequired("dns-search", dnsSearch.ToString());
            return this;
        }

        /// <summary>
        /// Endpoint mode (vip or dnsrr)
        /// </summary>
        public DockerServiceCreateTask EndpointMode(string endpointMode)
        {
            WithArgumentsValueRequired("endpoint-mode", endpointMode.ToString());
            return this;
        }

        /// <summary>
        /// Overwrite the default ENTRYPOINT of the image
        /// </summary>
        public DockerServiceCreateTask Entrypoint(string entrypoint)
        {
            WithArgumentsValueRequired("entrypoint", entrypoint.ToString());
            return this;
        }

        /// <summary>
        /// Set environment variables
        /// </summary>
        public DockerServiceCreateTask Env(string env)
        {
            WithArgumentsValueRequired("env", env.ToString());
            return this;
        }

        /// <summary>
        /// Read in a file of environment variables
        /// </summary>
        public DockerServiceCreateTask EnvFile(string envFile)
        {
            WithArgumentsValueRequired("env-file", envFile.ToString());
            return this;
        }

        /// <summary>
        /// User defined resources
        /// </summary>
        public DockerServiceCreateTask GenericResource(string genericResource)
        {
            WithArgumentsValueRequired("generic-resource", genericResource.ToString());
            return this;
        }

        /// <summary>
        /// Set one or more supplementary user groups for the container
        /// </summary>
        public DockerServiceCreateTask Group(string group)
        {
            WithArgumentsValueRequired("group", group.ToString());
            return this;
        }

        /// <summary>
        /// Command to run to check health
        /// </summary>
        public DockerServiceCreateTask HealthCmd(string healthCmd)
        {
            WithArgumentsValueRequired("health-cmd", healthCmd.ToString());
            return this;
        }

        /// <summary>
        /// Time between running the check (ms|s|m|h)
        /// </summary>
        public DockerServiceCreateTask HealthInterval(string healthInterval)
        {
            WithArgumentsValueRequired("health-interval", healthInterval.ToString());
            return this;
        }

        /// <summary>
        /// Consecutive failures needed to report unhealthy
        /// </summary>
        public DockerServiceCreateTask HealthRetries(int healthRetries)
        {
            WithArgumentsValueRequired("health-retries", healthRetries.ToString());
            return this;
        }

        /// <summary>
        /// Start period for the container to initialize before counting retries towards unstable (ms|s|m|h)

        /// </summary>
        public DockerServiceCreateTask HealthStartPeriod(string healthStartPeriod)
        {
            WithArgumentsValueRequired("health-start-period", healthStartPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Maximum time to allow one check to run (ms|s|m|h)
        /// </summary>
        public DockerServiceCreateTask HealthTimeout(string healthTimeout)
        {
            WithArgumentsValueRequired("health-timeout", healthTimeout.ToString());
            return this;
        }

        /// <summary>
        /// Set one or more custom host-to-IP mappings (host:ip)
        /// </summary>
        public DockerServiceCreateTask Host(string host)
        {
            WithArgumentsValueRequired("host", host.ToString());
            return this;
        }

        /// <summary>
        /// Container hostname
        /// </summary>
        public DockerServiceCreateTask Hostname(string hostname)
        {
            WithArgumentsValueRequired("hostname", hostname.ToString());
            return this;
        }

        /// <summary>
        /// Service container isolation mode
        /// </summary>
        public DockerServiceCreateTask Isolation(string isolation)
        {
            WithArgumentsValueRequired("isolation", isolation.ToString());
            return this;
        }

        /// <summary>
        /// Service labels
        /// </summary>
        public DockerServiceCreateTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPUs
        /// </summary>
        public DockerServiceCreateTask LimitCpu(decimal limitCpu)
        {
            WithArgumentsValueRequired("limit-cpu", limitCpu.ToString());
            return this;
        }

        /// <summary>
        /// Limit Memory
        /// </summary>
        public DockerServiceCreateTask LimitMemory(string limitMemory)
        {
            WithArgumentsValueRequired("limit-memory", limitMemory.ToString());
            return this;
        }

        /// <summary>
        /// Logging driver for service
        /// </summary>
        public DockerServiceCreateTask LogDriver(string logDriver)
        {
            WithArgumentsValueRequired("log-driver", logDriver.ToString());
            return this;
        }

        /// <summary>
        /// Logging driver options
        /// </summary>
        public DockerServiceCreateTask LogOpt(string logOpt)
        {
            WithArgumentsValueRequired("log-opt", logOpt.ToString());
            return this;
        }

        /// <summary>
        /// Service mode (replicated or global)
        /// </summary>
        public DockerServiceCreateTask Mode(string mode)
        {
            WithArgumentsValueRequired("mode", mode.ToString());
            return this;
        }

        /// <summary>
        /// Attach a filesystem mount to the service
        /// </summary>
        public DockerServiceCreateTask Mount(string mount)
        {
            WithArgumentsValueRequired("mount", mount.ToString());
            return this;
        }

        /// <summary>
        /// Service name
        /// </summary>
        public DockerServiceCreateTask Name(string name)
        {
            WithArgumentsValueRequired("name", name.ToString());
            return this;
        }

        /// <summary>
        /// Network attachments
        /// </summary>
        public DockerServiceCreateTask Network(string network)
        {
            WithArgumentsValueRequired("network", network.ToString());
            return this;
        }

        /// <summary>
        /// Disable any container-specified HEALTHCHECK
        /// </summary>
        public DockerServiceCreateTask NoHealthcheck()
        {
            WithArguments("no-healthcheck");
            return this;
        }

        /// <summary>
        /// Do not query the registry to resolve image digest and supported platforms

        /// </summary>
        public DockerServiceCreateTask NoResolveImage()
        {
            WithArguments("no-resolve-image");
            return this;
        }

        /// <summary>
        /// Add a placement preference
        /// </summary>
        public DockerServiceCreateTask PlacementPref(string placementPref)
        {
            WithArgumentsValueRequired("placement-pref", placementPref.ToString());
            return this;
        }

        /// <summary>
        /// Publish a port as a node port
        /// </summary>
        public DockerServiceCreateTask Publish(string publish)
        {
            WithArgumentsValueRequired("publish", publish.ToString());
            return this;
        }

        /// <summary>
        /// Suppress progress output
        /// </summary>
        public DockerServiceCreateTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Mount the container's root filesystem as read only
        /// </summary>
        public DockerServiceCreateTask ReadOnly()
        {
            WithArguments("read-only");
            return this;
        }

        /// <summary>
        /// Number of tasks
        /// </summary>
        public DockerServiceCreateTask Replicas(uint replicas)
        {
            WithArgumentsValueRequired("replicas", replicas.ToString());
            return this;
        }

        /// <summary>
        /// Reserve CPUs
        /// </summary>
        public DockerServiceCreateTask ReserveCpu(decimal reserveCpu)
        {
            WithArgumentsValueRequired("reserve-cpu", reserveCpu.ToString());
            return this;
        }

        /// <summary>
        /// Reserve Memory
        /// </summary>
        public DockerServiceCreateTask ReserveMemory(string reserveMemory)
        {
            WithArgumentsValueRequired("reserve-memory", reserveMemory.ToString());
            return this;
        }

        /// <summary>
        /// Restart when condition is met ("none"|"on-failure"|"any") (default "any")

        /// </summary>
        public DockerServiceCreateTask RestartCondition(string restartCondition)
        {
            WithArgumentsValueRequired("restart-condition", restartCondition.ToString());
            return this;
        }

        /// <summary>
        /// Delay between restart attempts (ns|us|ms|s|m|h) (default 5s)
        /// </summary>
        public DockerServiceCreateTask RestartDelay(string restartDelay)
        {
            WithArgumentsValueRequired("restart-delay", restartDelay.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of restarts before giving up
        /// </summary>
        public DockerServiceCreateTask RestartMaxAttempts(uint restartMaxAttempts)
        {
            WithArgumentsValueRequired("restart-max-attempts", restartMaxAttempts.ToString());
            return this;
        }

        /// <summary>
        /// Window used to evaluate the restart policy (ns|us|ms|s|m|h)
        /// </summary>
        public DockerServiceCreateTask RestartWindow(string restartWindow)
        {
            WithArgumentsValueRequired("restart-window", restartWindow.ToString());
            return this;
        }

        /// <summary>
        /// Delay between task rollbacks (ns|us|ms|s|m|h) (default 0s)
        /// </summary>
        public DockerServiceCreateTask RollbackDelay(string rollbackDelay)
        {
            WithArgumentsValueRequired("rollback-delay", rollbackDelay.ToString());
            return this;
        }

        /// <summary>
        /// Action on rollback failure ("pause"|"continue") (default "pause")

        /// </summary>
        public DockerServiceCreateTask RollbackFailureAction(string rollbackFailureAction)
        {
            WithArgumentsValueRequired("rollback-failure-action", rollbackFailureAction.ToString());
            return this;
        }

        /// <summary>
        /// Failure rate to tolerate during a rollback (default 0)
        /// </summary>
        public DockerServiceCreateTask RollbackMaxFailureRatio(float rollbackMaxFailureRatio)
        {
            WithArgumentsValueRequired("rollback-max-failure-ratio", rollbackMaxFailureRatio.ToString());
            return this;
        }

        /// <summary>
        /// Duration after each task rollback to monitor for failure (ns|us|ms|s|m|h) (default 5s)

        /// </summary>
        public DockerServiceCreateTask RollbackMonitor(string rollbackMonitor)
        {
            WithArgumentsValueRequired("rollback-monitor", rollbackMonitor.ToString());
            return this;
        }

        /// <summary>
        /// Rollback order ("start-first"|"stop-first") (default "stop-first")

        /// </summary>
        public DockerServiceCreateTask RollbackOrder(string rollbackOrder)
        {
            WithArgumentsValueRequired("rollback-order", rollbackOrder.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of tasks rolled back simultaneously (0 to roll back all at once)

        /// </summary>
        public DockerServiceCreateTask RollbackParallelism(ulong rollbackParallelism)
        {
            WithArgumentsValueRequired("rollback-parallelism", rollbackParallelism.ToString());
            return this;
        }

        /// <summary>
        /// Specify secrets to expose to the service
        /// </summary>
        public DockerServiceCreateTask Secret(string secret)
        {
            WithArgumentsValueRequired("secret", secret.ToString());
            return this;
        }

        /// <summary>
        /// Time to wait before force killing a container (ns|us|ms|s|m|h) (default 10s)

        /// </summary>
        public DockerServiceCreateTask StopGracePeriod(string stopGracePeriod)
        {
            WithArgumentsValueRequired("stop-grace-period", stopGracePeriod.ToString());
            return this;
        }

        /// <summary>
        /// Signal to stop the container
        /// </summary>
        public DockerServiceCreateTask StopSignal(string stopSignal)
        {
            WithArgumentsValueRequired("stop-signal", stopSignal.ToString());
            return this;
        }

        /// <summary>
        /// Allocate a pseudo-TTY
        /// </summary>
        public DockerServiceCreateTask Tty()
        {
            WithArguments("tty");
            return this;
        }

        /// <summary>
        /// Delay between updates (ns|us|ms|s|m|h) (default 0s)
        /// </summary>
        public DockerServiceCreateTask UpdateDelay(string updateDelay)
        {
            WithArgumentsValueRequired("update-delay", updateDelay.ToString());
            return this;
        }

        /// <summary>
        /// Action on update failure ("pause"|"continue"|"rollback") (default "pause")

        /// </summary>
        public DockerServiceCreateTask UpdateFailureAction(string updateFailureAction)
        {
            WithArgumentsValueRequired("update-failure-action", updateFailureAction.ToString());
            return this;
        }

        /// <summary>
        /// Failure rate to tolerate during an update (default 0)
        /// </summary>
        public DockerServiceCreateTask UpdateMaxFailureRatio(float updateMaxFailureRatio)
        {
            WithArgumentsValueRequired("update-max-failure-ratio", updateMaxFailureRatio.ToString());
            return this;
        }

        /// <summary>
        /// Duration after each task update to monitor for failure (ns|us|ms|s|m|h) (default 5s)

        /// </summary>
        public DockerServiceCreateTask UpdateMonitor(string updateMonitor)
        {
            WithArgumentsValueRequired("update-monitor", updateMonitor.ToString());
            return this;
        }

        /// <summary>
        /// Update order ("start-first"|"stop-first") (default "stop-first")

        /// </summary>
        public DockerServiceCreateTask UpdateOrder(string updateOrder)
        {
            WithArgumentsValueRequired("update-order", updateOrder.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of tasks updated simultaneously (0 to update all at once)

        /// </summary>
        public DockerServiceCreateTask UpdateParallelism(ulong updateParallelism)
        {
            WithArgumentsValueRequired("update-parallelism", updateParallelism.ToString());
            return this;
        }

        /// <summary>
        /// Username or UID (format: <name|uid>[:<group|gid>])
        /// </summary>
        public DockerServiceCreateTask User(string user)
        {
            WithArgumentsValueRequired("user", user.ToString());
            return this;
        }

        /// <summary>
        /// Send registry authentication details to swarm agents
        /// </summary>
        public DockerServiceCreateTask WithRegistryAuth()
        {
            WithArguments("with-registry-auth");
            return this;
        }

        /// <summary>
        /// Working directory inside the container
        /// </summary>
        public DockerServiceCreateTask Workdir(string workdir)
        {
            WithArgumentsValueRequired("workdir", workdir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);
 WithArguments(_command);
 WithArguments(_arg);

            return base.DoExecute(context);
        }

     }
}