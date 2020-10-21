---
external help file:
Module Name: Az.RecoveryServicesBackup
online version: https://docs.microsoft.com/en-us/powershell/module/az.recoveryservicesbackup/new-azrecoveryservicesbackupprotectionpolicy
schema: 2.0.0
---

# New-AzRecoveryServicesBackupProtectionPolicy

## SYNOPSIS
Creates or modifies a backup policy.
This is an asynchronous operation.
Status of the operation can be fetched\r\nusing GetPolicyOperationResult API.

## SYNTAX

### CreateExpanded (Default)
```
New-AzRecoveryServicesBackupProtectionPolicy -PolicyName <String> -ResourceGroupName <String>
 -VaultName <String> [-SubscriptionId <String>] [-BackupManagementType <String>] [-ETag <String>]
 [-Location <String>] [-ProtectedItemsCount <Int32>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-AzRecoveryServicesBackupProtectionPolicy -PolicyName <String> -ResourceGroupName <String>
 -VaultName <String> -Parameter <IProtectionPolicyResource> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzRecoveryServicesBackupProtectionPolicy -InputObject <IRecoveryServicesBackupIdentity>
 -Parameter <IProtectionPolicyResource> [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzRecoveryServicesBackupProtectionPolicy -InputObject <IRecoveryServicesBackupIdentity>
 [-BackupManagementType <String>] [-ETag <String>] [-Location <String>] [-ProtectedItemsCount <Int32>]
 [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or modifies a backup policy.
This is an asynchronous operation.
Status of the operation can be fetched\r\nusing GetPolicyOperationResult API.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BackupManagementType
This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ETag
Optional ETag.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
Base class for backup policy.
Workload-specific backup policies are derived from this class.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IProtectionPolicyResource
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyName
Backup policy to be created.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectedItemsCount
Number of items associated with this policy.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group where the recovery services vault is present.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription Id.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VaultName
The name of the recovery services vault.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IProtectionPolicyResource

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IProtectionPolicyResource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IRecoveryServicesBackupIdentity>: Identity Parameter
  - `[ContainerName <String>]`: Container name associated with the backed up item.
  - `[FabricName <String>]`: Fabric name associated with the backed up item.
  - `[Id <String>]`: Resource identity path
  - `[JobName <String>]`: Name of the job whose details are to be fetched.
  - `[OperationId <String>]`: Operation ID which represents the operation whose result needs to be fetched.
  - `[PolicyName <String>]`: Backup policy information to be fetched.
  - `[ProtectedItemName <String>]`: Backed up item name whose details are to be fetched.
  - `[RecoveryPointId <String>]`: RecoveryPointID represents the backed up data to be fetched.
  - `[ResourceGroupName <String>]`: The name of the resource group where the recovery services vault is present.
  - `[SubscriptionId <String>]`: The subscription Id.
  - `[VaultName <String>]`: The name of the recovery services vault.

PARAMETER <IProtectionPolicyResource>: Base class for backup policy. Workload-specific backup policies are derived from this class.
  - `BackupManagementType <String>`: This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
  - `[ETag <String>]`: Optional ETag.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[ProtectedItemsCount <Int32?>]`: Number of items associated with this policy.

## RELATED LINKS

