---
external help file:
Module Name: Az.RecoveryServicesBackup
online version: https://docs.microsoft.com/en-us/powershell/module/az.recoveryservicesbackup/get-azrecoveryservicesbackupexportjobsoperationresult
schema: 2.0.0
---

# Get-AzRecoveryServicesBackupExportJobsOperationResult

## SYNOPSIS
Gets the operation result of operation triggered by Export Jobs API.
If the operation is successful, then it also\r\ncontains URL of a Blob and a SAS key to access the same.
The blob contains exported jobs in JSON serialized format.

## SYNTAX

### Get (Default)
```
Get-AzRecoveryServicesBackupExportJobsOperationResult -OperationId <String> -ResourceGroupName <String>
 -VaultName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzRecoveryServicesBackupExportJobsOperationResult -InputObject <IRecoveryServicesBackupIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets the operation result of operation triggered by Export Jobs API.
If the operation is successful, then it also\r\ncontains URL of a Blob and a SAS key to access the same.
The blob contains exported jobs in JSON serialized format.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OperationId
OperationID which represents the export job.

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: Get
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
Type: System.String[]
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -VaultName
The name of the recovery services vault.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryServicesBackupIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Api20190513.IOperationResultInfoBaseResource

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

## RELATED LINKS
