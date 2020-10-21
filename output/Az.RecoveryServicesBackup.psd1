@{
  GUID = '6878554b-66f4-416c-ad6b-29df489c490d'
  RootModule = './Az.RecoveryServicesBackup.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: RecoveryServicesBackup cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.RecoveryServicesBackup.private.dll'
  FormatsToProcess = './Az.RecoveryServicesBackup.format.ps1xml'
  FunctionsToExport = 'Export-AzRecoveryServicesBackupJob', 'Get-AzRecoveryServicesBackupExportJobsOperationResult', 'Get-AzRecoveryServicesBackupJob', 'Get-AzRecoveryServicesBackupJobDetail', 'Get-AzRecoveryServicesBackupJobOperationResult', 'Get-AzRecoveryServicesBackupPolicy', 'Get-AzRecoveryServicesBackupProtectedItem', 'Get-AzRecoveryServicesBackupProtectedItemOperationResult', 'Get-AzRecoveryServicesBackupProtectionPolicy', 'Get-AzRecoveryServicesBackupProtectionPolicyOperationResult', 'Get-AzRecoveryServicesBackupRecoveryPoint', 'Get-AzRecoveryServicesBackupResourceVaultConfig', 'New-AzRecoveryServicesBackupProtectedItem', 'New-AzRecoveryServicesBackupProtectionPolicy', 'Remove-AzRecoveryServicesBackupProtectedItem', 'Set-AzRecoveryServicesBackupProtectedItem', 'Set-AzRecoveryServicesBackupProtectionPolicy', 'Start-AzRecoveryServicesBackupJobCancellation', 'Start-AzRecoveryServicesBackupRestore', 'Update-AzRecoveryServicesBackupResourceVaultConfig', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'RecoveryServicesBackup'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
