@{
  GUID = 'b8df0575-08ba-43b9-8c6f-44a278792f08'
  RootModule = './Az.DataProtectionBackup.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DataProtectionBackup cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DataProtectionBackup.private.dll'
  FormatsToProcess = './Az.DataProtectionBackup.format.ps1xml'
  FunctionsToExport = 'Backup-AzDataProtectionBackupInstanceAdhoc', 'Export-AzDataProtectionBackupAzureBackupJob', 'Get-AzDataProtectionBackupAzureBackupJobExportJobOperationResult', 'Get-AzDataProtectionBackupDppOperationStatus', 'Get-AzDataProtectionBackupGetOperationResult', 'Get-AzDataProtectionBackupInstance', 'Get-AzDataProtectionBackupJob', 'Get-AzDataProtectionBackupPolicy', 'Get-AzDataProtectionBackupRecoveryPoint', 'Get-AzDataProtectionBackupRecoveryPointAzureBackupRecoveryPoint', 'Get-AzDataProtectionBackupResource', 'Get-AzDataProtectionBackupResourceOperationGatekeeper', 'Get-AzDataProtectionBackupResourceOperationGatekeeperResource', 'Get-AzDataProtectionBackupVault', 'Get-AzDataProtectionBackupVaultResource', 'Remove-AzDataProtectionBackupInstance', 'Remove-AzDataProtectionBackupPolicy', 'Remove-AzDataProtectionBackupResourceOperationGatekeeper', 'Remove-AzDataProtectionBackupVault', 'Set-AzDataProtectionBackupInstance', 'Set-AzDataProtectionBackupPolicy', 'Set-AzDataProtectionBackupResourceOperationGatekeeper', 'Set-AzDataProtectionBackupVault', 'Start-AzDataProtectionBackupInstanceRehydrate', 'Start-AzDataProtectionBackupInstanceRestore', 'Test-AzDataProtectionBackupInstance', 'Test-AzDataProtectionBackupInstanceRestore', 'Test-AzDataProtectionBackupVaultNameAvailability', 'Update-AzDataProtectionBackupResourceOperationGatekeeper', 'Update-AzDataProtectionBackupVault', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DataProtectionBackup'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
