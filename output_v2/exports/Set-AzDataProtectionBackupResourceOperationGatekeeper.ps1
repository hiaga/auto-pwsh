
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
Creates or updates a ResourceOperationGatekeeper resource belonging to a resource group.
.Description
Creates or updates a ResourceOperationGatekeeper resource belonging to a resource group.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IResourceOperationGateKeeperResource
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IResourceOperationGateKeeperResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PARAMETER <IResourceOperationGateKeeperResource>: ResourceOperationGateKeeper Resource
  [ETag <String>]: Optional ETag.
  [IdentityType <String>]: The identityType which can be either SystemAssigned or None
  [Location <String>]: Resource location.
  [Tag <IDppTrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.dataprotectionbackup/set-azdataprotectionbackupresourceoperationgatekeeper
#>
function Set-AzDataProtectionBackupResourceOperationGatekeeper {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IResourceOperationGateKeeperResource])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [System.String]
    # The name of the resource group where the backup vault is present.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Alias('ResourceOperationGateKeepersName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [System.String]
    # The name of ResourceOperationGatekeeper
    ${SName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription Id.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IResourceOperationGateKeeperResource]
    # ResourceOperationGateKeeper Resource
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='PutExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [System.String]
    # Optional ETag.
    ${ETag},

    [Parameter(ParameterSetName='PutExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [System.String]
    # The identityType which can be either SystemAssigned or None
    ${IdentityType},

    [Parameter(ParameterSetName='PutExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter(ParameterSetName='PutExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Models.Api202001.IDppTrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataProtectionBackup.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

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
            Put = 'Az.DataProtectionBackup.private\Set-AzDataProtectionBackupResourceOperationGatekeeper_Put';
            PutExpanded = 'Az.DataProtectionBackup.private\Set-AzDataProtectionBackupResourceOperationGatekeeper_PutExpanded';
        }
        if (('Put', 'PutExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
