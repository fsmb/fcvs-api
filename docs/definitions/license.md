# License

License information

| Name | Type | Required | Description |
| - | - | - | - |
| licenseType | string (len: 100) | No | Type of license (e.g. `Active`, `Training`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| licensingEntity | [LicensingEntity](licensing-entity.md) | No | Entity issuing license |
| status | string (len: 100) | No | License status (e.g. `Active`, `Denied`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| practitionerType | [PractitionerType](practitioner-type.md) | No | Practitioner type |
| licenseNumber | string (20) | No | License number |
| issueDate | string (date) | No | Issue date |
| expirationDate | string (date) | No | Expiration date |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
