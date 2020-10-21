---
Module Name: Az.RecoveryServicesBackup
Module Guid: 6878554b-66f4-416c-ad6b-29df489c490d
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/az.recoveryservicesbackup
Help Version: 1.0.0.0
Locale: en-US
---

# Az.RecoveryServicesBackup Module
## Description
Microsoft Azure PowerShell: RecoveryServicesBackup cmdlets

## Az.RecoveryServicesBackup Cmdlets
### [Export-AzRecoveryServicesBackupJob](Export-AzRecoveryServicesBackupJob.md)
Triggers export of jobs specified by filters and returns an OperationID to track.

### [Get-AzRecoveryServicesBackupExportJobsOperationResult](Get-AzRecoveryServicesBackupExportJobsOperationResult.md)
Gets the operation result of operation triggered by Export Jobs API.
If the operation is successful, then it also\r\ncontains URL of a Blob and a SAS key to access the same.
The blob contains exported jobs in JSON serialized format.

### [Get-AzRecoveryServicesBackupJob](Get-AzRecoveryServicesBackupJob.md)
Provides a pageable list of jobs.

### [Get-AzRecoveryServicesBackupJobDetail](Get-AzRecoveryServicesBackupJobDetail.md)
Gets extended information associated with the job.

### [Get-AzRecoveryServicesBackupJobOperationResult](Get-AzRecoveryServicesBackupJobOperationResult.md)
Fetches the result of any operation.

### [Get-AzRecoveryServicesBackupPolicy](Get-AzRecoveryServicesBackupPolicy.md)
Lists of backup policies associated with Recovery Services Vault.
API provides pagination parameters to fetch\r\nscoped results.

### [Get-AzRecoveryServicesBackupProtectedItem](Get-AzRecoveryServicesBackupProtectedItem.md)
Provides the details of the backed up item.
This is an asynchronous operation.
To know the status of the operation,\r\ncall the GetItemOperationResult API.

### [Get-AzRecoveryServicesBackupProtectedItemOperationResult](Get-AzRecoveryServicesBackupProtectedItemOperationResult.md)
Fetches the result of any operation on the backup item.

### [Get-AzRecoveryServicesBackupProtectionPolicy](Get-AzRecoveryServicesBackupProtectionPolicy.md)
Provides the details of the backup policies associated to Recovery Services Vault.
This is an asynchronous\r\noperation.
Status of the operation can be fetched using GetPolicyOperationResult API.

### [Get-AzRecoveryServicesBackupProtectionPolicyOperationResult](Get-AzRecoveryServicesBackupProtectionPolicyOperationResult.md)
Provides the result of an operation.

### [Get-AzRecoveryServicesBackupRecoveryPoint](Get-AzRecoveryServicesBackupRecoveryPoint.md)
Provides the information of the backed up data identified using RecoveryPointID.
This is an asynchronous operation.\r\nTo know the status of the operation, call the GetProtectedItemOperationResult API.

### [Get-AzRecoveryServicesBackupResourceVaultConfig](Get-AzRecoveryServicesBackupResourceVaultConfig.md)
Fetches resource vault config.

### [New-AzRecoveryServicesBackupProtectedItem](New-AzRecoveryServicesBackupProtectedItem.md)
Enables backup of an item or to modifies the backup policy information of an already backed up item.
This is an\r\nasynchronous operation.
To know the status of the operation, call the GetItemOperationResult API.

### [New-AzRecoveryServicesBackupProtectionPolicy](New-AzRecoveryServicesBackupProtectionPolicy.md)
Creates or modifies a backup policy.
This is an asynchronous operation.
Status of the operation can be fetched\r\nusing GetPolicyOperationResult API.

### [Remove-AzRecoveryServicesBackupProtectedItem](Remove-AzRecoveryServicesBackupProtectedItem.md)
Used to disable backup of an item within a container.
This is an asynchronous operation.
To know the status of the\r\nrequest, call the GetItemOperationResult API.

### [Set-AzRecoveryServicesBackupProtectedItem](Set-AzRecoveryServicesBackupProtectedItem.md)
Enables backup of an item or to modifies the backup policy information of an already backed up item.
This is an\r\nasynchronous operation.
To know the status of the operation, call the GetItemOperationResult API.

### [Set-AzRecoveryServicesBackupProtectionPolicy](Set-AzRecoveryServicesBackupProtectionPolicy.md)
Creates or modifies a backup policy.
This is an asynchronous operation.
Status of the operation can be fetched\r\nusing GetPolicyOperationResult API.

### [Start-AzRecoveryServicesBackupJobCancellation](Start-AzRecoveryServicesBackupJobCancellation.md)
Cancels a job.
This is an asynchronous operation.
To know the status of the cancellation, call\r\nGetCancelOperationResult API.

### [Start-AzRecoveryServicesBackupRestore](Start-AzRecoveryServicesBackupRestore.md)
Restores the specified backed up data.
This is an asynchronous operation.
To know the status of this API call, use\r\nGetProtectedItemOperationResult API.

### [Update-AzRecoveryServicesBackupResourceVaultConfig](Update-AzRecoveryServicesBackupResourceVaultConfig.md)
Updates vault security config.

