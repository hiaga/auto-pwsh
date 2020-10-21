---
external help file:
Module Name: Az.RecoveryServicesBackup
online version: https://docs.microsoft.com/en-us/powershell/module/az.recoveryservicesbackup/start-azrecoveryservicesbackuprestore
schema: 2.0.0
---

# Start-AzRecoveryServicesBackupRestore

## SYNOPSIS
Restores the specified backed up data.
This is an asynchronous operation.
To know the status of this API call, use\r\nGetProtectedItemOperationResult API.

## SYNTAX

### TriggerExpanded (Default)
```
Start-AzRecoveryServicesBackupRestore -ContainerName <String> -FabricName <String> -ProtectedItemName <String>
 -RecoveryPointId <String> -ResourceGroupName <String> -VaultName <String> [-SubscriptionId <String>]
 [-ETag <String>] [-Location <String>] [-ObjectType <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Trigger
```
Start-AzRecoveryServicesBackupRestore -ContainerName <String> -FabricName <String> -ProtectedItemName <String>
 -RecoveryPointId <String> -ResourceGroupName <String> -VaultName <String>
 -Parameter <IRestoreRequestResource> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### TriggerViaIdentity
```
Start-AzRecoveryServicesBackupRestore -InputObject <IRecoveryServicesBackupIdentity>
 -Parameter <IRestoreRequestResource> [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### TriggerViaIdentityExpanded
```
Start-AzRecoveryServicesBackupRestore -InputObject <IRecoveryServicesBackupIdentity> [-ETag <String>]
 [-Location <String>] [-ObjectType <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Restores the specified backed up data.
This is an asynchronous operation.
To know the status of this API call, use\r\nGetProtectedItemOperationResult API.

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

### -ContainerName
Container name associated with the backed up items.

```yaml
Type: System.String
Parameter Sets: Trigger, TriggerExpanded
Aliases:

Required: True
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
Parameter Sets: TriggerExpanded, TriggerViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FabricName
Fabric name associated with the backed up items.

```yaml
Type: System.String
Parameter Sets: Trigger, TriggerExpanded
Aliases:

Required: True
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
Parameter Sets: TriggerViaIdentity, TriggerViaIdentityExpanded
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
Parameter Sets: TriggerExpanded, TriggerViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ObjectType
This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.

```yaml
Type: System.String
Parameter Sets: TriggerExpanded, TriggerViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
Base class for restore request.
Workload-specific restore requests are derived from this class.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IRestoreRequestResource
Parameter Sets: Trigger, TriggerViaIdentity
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

### -ProtectedItemName
Backed up item to be restored.

```yaml
Type: System.String
Parameter Sets: Trigger, TriggerExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointId
Recovery point ID which represents the backed up data to be restored.

```yaml
Type: System.String
Parameter Sets: Trigger, TriggerExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group where the recovery services vault is present.

```yaml
Type: System.String
Parameter Sets: Trigger, TriggerExpanded
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
Parameter Sets: Trigger, TriggerExpanded
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
Parameter Sets: TriggerExpanded, TriggerViaIdentityExpanded
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
Parameter Sets: Trigger, TriggerExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IRestoreRequestResource

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity

## OUTPUTS

### System.Boolean

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

PARAMETER <IRestoreRequestResource>: Base class for restore request. Workload-specific restore requests are derived from this class.
  - `ObjectType <String>`: This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
  - `[ETag <String>]`: Optional ETag.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.

## RELATED LINKS

