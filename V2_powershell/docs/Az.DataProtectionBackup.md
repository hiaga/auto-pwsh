---
Module Name: Az.DataProtectionBackup
Module Guid: b8df0575-08ba-43b9-8c6f-44a278792f08
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/az.dataprotectionbackup
Help Version: 1.0.0.0
Locale: en-US
---

# Az.DataProtectionBackup Module
## Description
Microsoft Azure PowerShell: DataProtectionBackup cmdlets

## Az.DataProtectionBackup Cmdlets
### [Backup-AzDataProtectionBackupInstanceAdhoc](Backup-AzDataProtectionBackupInstanceAdhoc.md)
Trigger adhoc backup

### [Export-AzDataProtectionBackupAzureBackupJob](Export-AzDataProtectionBackupAzureBackupJob.md)
Triggers export of jobs and returns an OperationID to track.

### [Get-AzDataProtectionBackupAzureBackupJobExportJobOperationResult](Get-AzDataProtectionBackupAzureBackupJobExportJobOperationResult.md)
Gets the operation result of operation triggered by Export Jobs API.
If the operation is successful, then it also contains URL of a Blob and a SAS key to access the same.
The blob contains exported jobs in JSON serialized format.

### [Get-AzDataProtectionBackupDppOperationStatus](Get-AzDataProtectionBackupDppOperationStatus.md)
Gets the operation status for a resource.

### [Get-AzDataProtectionBackupGetOperationResult](Get-AzDataProtectionBackupGetOperationResult.md)
Gets the operation result for a resource

### [Get-AzDataProtectionBackupInstance](Get-AzDataProtectionBackupInstance.md)
Gets a backup instances belonging to a backup vault

### [Get-AzDataProtectionBackupJob](Get-AzDataProtectionBackupJob.md)
Gets a job with id in a backup vault

### [Get-AzDataProtectionBackupPolicy](Get-AzDataProtectionBackupPolicy.md)
Gets a backup policy belonging to a backup vault

### [Get-AzDataProtectionBackupRecoveryPoint](Get-AzDataProtectionBackupRecoveryPoint.md)
Gets a Recovery Point using recoveryPointId for a Datasource.

### [Get-AzDataProtectionBackupRecoveryPointAzureBackupRecoveryPoint](Get-AzDataProtectionBackupRecoveryPointAzureBackupRecoveryPoint.md)
Returns a list of Recovery Points for a DataSource in a vault.

### [Get-AzDataProtectionBackupResource](Get-AzDataProtectionBackupResource.md)


### [Get-AzDataProtectionBackupResourceOperationGatekeeper](Get-AzDataProtectionBackupResourceOperationGatekeeper.md)
Returns a ResourceOperationGateKeeper belonging to a resource group.

### [Get-AzDataProtectionBackupResourceOperationGatekeeperResource](Get-AzDataProtectionBackupResourceOperationGatekeeperResource.md)
Returns ResourceOperationGateKeepers collection belonging to a subscription.

### [Get-AzDataProtectionBackupVault](Get-AzDataProtectionBackupVault.md)
Returns a resource belonging to a resource group.

### [Get-AzDataProtectionBackupVaultResource](Get-AzDataProtectionBackupVaultResource.md)
Returns resource collection belonging to a subscription.

### [Remove-AzDataProtectionBackupInstance](Remove-AzDataProtectionBackupInstance.md)


### [Remove-AzDataProtectionBackupPolicy](Remove-AzDataProtectionBackupPolicy.md)
Deletes a backup policy belonging to a backup vault

### [Remove-AzDataProtectionBackupResourceOperationGatekeeper](Remove-AzDataProtectionBackupResourceOperationGatekeeper.md)
Deletes a ResourceOperationGateKeeper resource from the resource group.

### [Remove-AzDataProtectionBackupVault](Remove-AzDataProtectionBackupVault.md)
Deletes a BackupVault resource from the resource group.

### [Set-AzDataProtectionBackupInstance](Set-AzDataProtectionBackupInstance.md)


### [Set-AzDataProtectionBackupPolicy](Set-AzDataProtectionBackupPolicy.md)
Creates or Updates a backup policy belonging to a backup vault

### [Set-AzDataProtectionBackupResourceOperationGatekeeper](Set-AzDataProtectionBackupResourceOperationGatekeeper.md)
Creates or updates a ResourceOperationGatekeeper resource belonging to a resource group.

### [Set-AzDataProtectionBackupVault](Set-AzDataProtectionBackupVault.md)
Creates or updates a BackupVault resource belonging to a resource group.

### [Start-AzDataProtectionBackupInstanceRehydrate](Start-AzDataProtectionBackupInstanceRehydrate.md)
rehydrate recovery point for restore for a BackupInstance

### [Start-AzDataProtectionBackupInstanceRestore](Start-AzDataProtectionBackupInstanceRestore.md)
Triggers restore for a BackupInstance

### [Test-AzDataProtectionBackupInstance](Test-AzDataProtectionBackupInstance.md)
Validate whether adhoc backup will be successful or not

### [Test-AzDataProtectionBackupInstanceRestore](Test-AzDataProtectionBackupInstanceRestore.md)
Validates if Restore can be triggered for a DataSource

### [Test-AzDataProtectionBackupVaultNameAvailability](Test-AzDataProtectionBackupVaultNameAvailability.md)
API to check for resource name availability

### [Update-AzDataProtectionBackupResourceOperationGatekeeper](Update-AzDataProtectionBackupResourceOperationGatekeeper.md)
Updates a ResourceOperationGatekeeper resource belonging to a resource group.
For example, updating tags for a resource.

### [Update-AzDataProtectionBackupVault](Update-AzDataProtectionBackupVault.md)
Updates a BackupVault resource belonging to a resource group.
For example, updating tags for a resource.

