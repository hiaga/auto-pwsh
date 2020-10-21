---
external help file:
Module Name: Az.RecoveryServicesBackup
online version: https://docs.microsoft.com/en-us/powershell/module/az.recoveryservicesbackup/update-azrecoveryservicesbackupresourcevaultconfig
schema: 2.0.0
---

# Update-AzRecoveryServicesBackupResourceVaultConfig

## SYNOPSIS
Updates vault security config.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzRecoveryServicesBackupResourceVaultConfig -ResourceGroupName <String> -VaultName <String>
 [-SubscriptionId <String>] [-EnhancedSecurityState <EnhancedSecurityState>] [-ETag <String>]
 [-Location <String>] [-SoftDeleteFeatureState <SoftDeleteFeatureState>] [-StorageModelType <StorageType>]
 [-StorageType <StorageType>] [-StorageTypeState <StorageTypeState>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-AzRecoveryServicesBackupResourceVaultConfig -ResourceGroupName <String> -VaultName <String>
 -Parameter <IBackupResourceVaultConfigResource> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzRecoveryServicesBackupResourceVaultConfig -InputObject <IRecoveryServicesBackupIdentity>
 -Parameter <IBackupResourceVaultConfigResource> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzRecoveryServicesBackupResourceVaultConfig -InputObject <IRecoveryServicesBackupIdentity>
 [-EnhancedSecurityState <EnhancedSecurityState>] [-ETag <String>] [-Location <String>]
 [-SoftDeleteFeatureState <SoftDeleteFeatureState>] [-StorageModelType <StorageType>]
 [-StorageType <StorageType>] [-StorageTypeState <StorageTypeState>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates vault security config.

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

### -EnhancedSecurityState
Enabled or Disabled.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Support.EnhancedSecurityState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
Backup resource vault config details.
To construct, see NOTES section for PARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IBackupResourceVaultConfigResource
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group where the recovery services vault is present.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SoftDeleteFeatureState
Soft Delete feature state

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Support.SoftDeleteFeatureState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageModelType
Storage type.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Support.StorageType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageType
Storage type.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Support.StorageType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageTypeState
Locked or Unlocked.
Once a machine is registered against a resource, the storageTypeState is always Locked.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Support.StorageTypeState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription Id.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IBackupResourceVaultConfigResource

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IBackupResourceVaultConfigResource

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

PARAMETER <IBackupResourceVaultConfigResource>: Backup resource vault config details.
  - `[ETag <String>]`: Optional ETag.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[EnhancedSecurityState <EnhancedSecurityState?>]`: Enabled or Disabled.
  - `[SoftDeleteFeatureState <SoftDeleteFeatureState?>]`: Soft Delete feature state
  - `[StorageModelType <StorageType?>]`: Storage type.
  - `[StorageType <StorageType?>]`: Storage type.
  - `[StorageTypeState <StorageTypeState?>]`: Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked.

## RELATED LINKS

