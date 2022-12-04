// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Azure.Management.ContainerInstance.Fluent;

namespace Microsoft.Azure.Management.Samples.Common
{
    public static class Utilities
    {
        public static bool IsRunningMocked { get; set; }
        public static Action<string> LoggerMethod { get; set; }
        public static Func<string> PauseMethod { get; set; }

        public static string ProjectPath { get; set; }

        static Utilities()
        {
            LoggerMethod = Console.WriteLine;
            PauseMethod = Console.ReadLine;
            ProjectPath = ".";
        }

        public static void Log(string message)
        {
            LoggerMethod.Invoke(message);
        }

        public static void Log(object obj)
        {
            if (obj != null)
            {
                LoggerMethod.Invoke(obj.ToString());
            }
            else
            {
                LoggerMethod.Invoke("(null)");
            }
        }

        public static void Log()
        {
            Utilities.Log("");
        }


        public static void Print(IContainerGroup containerGroup)
        {
            StringBuilder info = new StringBuilder();

            info = new StringBuilder().Append("Container Group: ").Append(containerGroup.Id)
                .Append("Name: ").Append(containerGroup.Name)
                .Append("\n\tResource group: ").Append(containerGroup.ResourceGroupName)
                .Append("\n\tRegion: ").Append(containerGroup.RegionName)
                .Append("\n\tTags: ").Append(containerGroup.Tags)
                .Append("\n\tOS type: ").Append(containerGroup.OSType.Value);

            if (containerGroup.IPAddress != null)
            {
                info.Append("\n\tPublic IP address: ").Append(containerGroup.IPAddress);
                info.Append("\n\tExternal TCP ports:");
                foreach (int port in containerGroup.ExternalTcpPorts)
                {
                    info.Append(" ").Append(port);
                }
                info.Append("\n\tExternal UDP ports:");
                foreach (int port in containerGroup.ExternalUdpPorts)
                {
                    info.Append(" ").Append(port);
                }
            }
            if (containerGroup.ImageRegistryServers.Count > 0)
            {
                info.Append("\n\tPrivate Docker image registries:");
                foreach (string server in containerGroup.ImageRegistryServers)
                {
                    info.Append(" ").Append(server);
                }
            }
            if (containerGroup.Volumes.Count > 0)
            {
                info.Append("\n\tVolume mapping: ");
                foreach (var entry in containerGroup.Volumes)
                {
                    info.Append("\n\t\tName: ").Append(entry.Key).Append(" -> ").Append(entry.Value.AzureFile.ShareName);
                }
            }
            if (containerGroup.Containers.Count > 0)
            {
                info.Append("\n\tContainer instances: ");
                foreach (var entry in containerGroup.Containers)
                {
                    var container = entry.Value;
                    info.Append("\n\t\tName: ").Append(entry.Key).Append(" -> ").Append(container.Image);
                    info.Append("\n\t\t\tResources: ");
                    info.Append(container.Resources.Requests.Cpu).Append(" CPUs ");
                    info.Append(container.Resources.Requests.MemoryInGB).Append(" GB");
                    info.Append("\n\t\t\tPorts:");
                    foreach (var port in container.Ports)
                    {
                        info.Append(" ").Append(port.Port);
                    }
                    if (container.VolumeMounts != null)
                    {
                        info.Append("\n\t\t\tVolume mounts:");
                        foreach (var volumeMount in container.VolumeMounts)
                        {
                            info.Append(" ").Append(volumeMount.Name).Append("->").Append(volumeMount.MountPath);
                        }
                    }
                    if (container.Command != null)
                    {
                        info.Append("\n\t\t\tStart commands:");
                        foreach (var command in container.Command)
                        {
                            info.Append("\n\t\t\t\t").Append(command);
                        }
                    }
                    if (container.EnvironmentVariables != null)
                    {
                        info.Append("\n\t\t\tENV vars:");
                        foreach (var envVar in container.EnvironmentVariables)
                        {
                            info.Append("\n\t\t\t\t").Append(envVar.Name).Append("=").Append(envVar.Value);
                        }
                    }
                }
            }

            Log(info.ToString());
        }

    }
}