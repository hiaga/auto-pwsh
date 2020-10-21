# My API 

This file contains the configuration for generating My API from the OpenAPI specification.

> see https://aka.ms/autorest

``` yaml
# it's the same options as command line options, just drop the double-dash!
require:
  - $(this-folder)/readme.azure.noprofile.md
input-file: C:\Source\azure-rest-api-specs\specification\recoveryservicesbackup\resource-manager\Microsoft.RecoveryServices\stable\2019-05-13\bms.json
output-folder: output
```

## Alternate settings

This section is only activated if the `--make-it-rain` switch is added to the command line

``` yaml $(make-it-rain)
namespace: MyCompany.Special.Rest
```