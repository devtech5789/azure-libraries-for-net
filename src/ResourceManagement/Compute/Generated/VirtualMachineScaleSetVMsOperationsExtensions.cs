// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineScaleSetVMsOperations.
    /// </summary>
    public static partial class VirtualMachineScaleSetVMsOperationsExtensions
    {
            /// <summary>
            /// Reimages (upgrade the operating system) a specific virtual machine in a VM
            /// scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='tempDisk'>
            /// Specifies whether to reimage temp disk. Default value: false. Note: This
            /// temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS
            /// disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReimageAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, bool? tempDisk = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, tempDisk, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Allows you to re-image all the disks ( including data disks ) in the a VM
            /// scale set instance. This operation is only supported for managed disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReimageAllAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deallocates a specific virtual machine in a VM scale set. Shuts down the
            /// virtual machine and releases the compute resources it uses. You are not
            /// billed for the compute resources of this virtual machine once it is
            /// deallocated.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeallocateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a virtual machine of a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update Virtual Machine Scale Sets VM operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVMInner> UpdateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, VirtualMachineScaleSetVMInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual machine from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a virtual machine from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'instanceView'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVMInner> GetAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, InstanceViewTypes? expand = default(InstanceViewTypes?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the status of a virtual machine from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVMInstanceView> GetInstanceViewAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInstanceViewWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all virtual machines in a VM scale sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualMachineScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// The list parameters. Allowed values are 'instanceView',
            /// 'instanceView/statuses'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineScaleSetVMInner>> ListAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVMInner> odataQuery = default(ODataQuery<VirtualMachineScaleSetVMInner>), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, odataQuery, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Power off (stop) a virtual machine in a VM scale set. Note that resources
            /// are still attached and you are getting charged for the resources. Instead,
            /// use deallocate to release resources and avoid charges.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='skipShutdown'>
            /// The parameter to request non-graceful VM shutdown. True value for this flag
            /// indicates non-graceful shutdown whereas false indicates otherwise. Default
            /// value for this flag is false if not specified
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PowerOffAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, bool? skipShutdown = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, skipShutdown, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restarts a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Shuts down the virtual machine in the virtual machine scale set, moves it
            /// to a new node, and powers it back on.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RedeployAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RedeployWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to retrieve SAS URIs of boot diagnostic logs for a virtual
            /// machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='sasUriExpirationTimeInMinutes'>
            /// Expiration duration in minutes for the SAS URIs with a value between 1 to
            /// 1440 minutes. &lt;br&gt;&lt;br&gt;NOTE: If not specified, SAS URIs will be
            /// generated with a default expiration duration of 120 minutes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RetrieveBootDiagnosticsDataResultInner> RetrieveBootDiagnosticsDataAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, int? sasUriExpirationTimeInMinutes = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetrieveBootDiagnosticsDataWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, sasUriExpirationTimeInMinutes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Performs maintenance on a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PerformMaintenanceAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PerformMaintenanceWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to simulate the eviction of spot virtual machine in a VM
            /// scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SimulateEvictionAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SimulateEvictionWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Run command on a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Run command operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RunCommandResultInner> RunCommandAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, RunCommandInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RunCommandWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Reimages (upgrade the operating system) a specific virtual machine in a VM
            /// scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='tempDisk'>
            /// Specifies whether to reimage temp disk. Default value: false. Note: This
            /// temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS
            /// disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginReimageAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, bool? tempDisk = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, tempDisk, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Allows you to re-image all the disks ( including data disks ) in the a VM
            /// scale set instance. This operation is only supported for managed disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginReimageAllAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deallocates a specific virtual machine in a VM scale set. Shuts down the
            /// virtual machine and releases the compute resources it uses. You are not
            /// billed for the compute resources of this virtual machine once it is
            /// deallocated.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeallocateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a virtual machine of a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update Virtual Machine Scale Sets VM operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineScaleSetVMInner> BeginUpdateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, VirtualMachineScaleSetVMInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual machine from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Power off (stop) a virtual machine in a VM scale set. Note that resources
            /// are still attached and you are getting charged for the resources. Instead,
            /// use deallocate to release resources and avoid charges.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='skipShutdown'>
            /// The parameter to request non-graceful VM shutdown. True value for this flag
            /// indicates non-graceful shutdown whereas false indicates otherwise. Default
            /// value for this flag is false if not specified
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPowerOffAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, bool? skipShutdown = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, skipShutdown, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restarts a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Shuts down the virtual machine in the virtual machine scale set, moves it
            /// to a new node, and powers it back on.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRedeployAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRedeployWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Performs maintenance on a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPerformMaintenanceAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPerformMaintenanceWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Run command on a virtual machine in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set.
            /// </param>
            /// <param name='instanceId'>
            /// The instance ID of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Run command operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RunCommandResultInner> BeginRunCommandAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, RunCommandInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRunCommandWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all virtual machines in a VM scale sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineScaleSetVMInner>> ListNextAsync(this IVirtualMachineScaleSetVMsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}