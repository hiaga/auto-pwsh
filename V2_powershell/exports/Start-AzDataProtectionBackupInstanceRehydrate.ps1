
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
rehydrate recovery point for restore for a BackupInstance
.Description
rehydrate recovery point for restore for a BackupInstance
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRehydrationRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.IDataProtectionBackupIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDataProtectionBackupIdentity>: Identity Parameter
  [BackupInstanceName <String>]: The name of the backup instance
  [BackupPolicyName <String>]: 
  [Id <String>]: Resource identity path
  [JobId <String>]: The Job ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000).
  [Location <String>]: The location in which uniqueness will be verified.
  [OperationId <String>]: 
  [RecoveryPointId <String>]: 
  [ResourceGroupName <String>]: The name of the resource group where the backup vault is present.
  [ResourceOperationGateKeepersName <String>]: The name of the ResourceOperationGateKeeper
  [SubscriptionId <String>]: The subscription Id.
  [VaultName <String>]: The name of the backup vault.

PARAMETER <IAzureBackupRehydrationRequest>: Azure Backup Rehydrate Request
  RecoveryPointId <String>: Id of the recovery point to be recovered
  RehydrationRetentionDuration <String>: Retention duration in ISO 8601 format i.e P10D .
  [RehydrationPriority <RehydrationPriority?>]: Priority to be used for rehydration. Values High or Standard
.Link
https://docs.microsoft.com/en-us/powershell/module/az.dataprotectionbackup/start-azdataprotectionbackupinstancerehydrate
#>
function Start-AzDataProtectionBackupInstanceRehydrate {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='TriggerExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Trigger', Mandatory)]
    [Parameter(ParameterSetName='TriggerExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [System.String]
    # .
    ${BackupInstanceName},

    [Parameter(ParameterSetName='Trigger', Mandatory)]
    [Parameter(ParameterSetName='TriggerExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [System.String]
    # The name of the resource group where the backup vault is present.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Trigger')]
    [Parameter(ParameterSetName='TriggerExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription Id.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Trigger', Mandatory)]
    [Parameter(ParameterSetName='TriggerExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [System.String]
    # The name of the backup vault.
    ${VaultName},

    [Parameter(ParameterSetName='TriggerViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='TriggerViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.IDataProtectionBackupIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Trigger', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='TriggerViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001Alpha.IAzureBackupRehydrationRequest]
    # Azure Backup Rehydrate Request
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='TriggerExpanded', Mandatory)]
    [Parameter(ParameterSetName='TriggerViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [System.String]
    # Id of the recovery point to be recovered
    ${RecoveryPointId},

    [Parameter(ParameterSetName='TriggerExpanded', Mandatory)]
    [Parameter(ParameterSetName='TriggerViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [System.String]
    # Retention duration in ISO 8601 format i.e P10D .
    ${RehydrationRetentionDuration},

    [Parameter(ParameterSetName='TriggerExpanded')]
    [Parameter(ParameterSetName='TriggerViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority])]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Support.RehydrationPriority]
    # Priority to be used for rehydration.
    # Values High or Standard
    ${RehydrationPriority},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Trigger = 'Az.DataProtectionBackup.private\Start-AzDataProtectionBackupInstanceRehydrate_Trigger';
            TriggerExpanded = 'Az.DataProtectionBackup.private\Start-AzDataProtectionBackupInstanceRehydrate_TriggerExpanded';
            TriggerViaIdentity = 'Az.DataProtectionBackup.private\Start-AzDataProtectionBackupInstanceRehydrate_TriggerViaIdentity';
            TriggerViaIdentityExpanded = 'Az.DataProtectionBackup.private\Start-AzDataProtectionBackupInstanceRehydrate_TriggerViaIdentityExpanded';
        }
        if (('Trigger', 'TriggerExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
