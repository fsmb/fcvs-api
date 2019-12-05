# Practitioner Status

Status of an FCVS Profile

| Name | Type | Description |
| - | - | - |
| fid |  string (length: 9, format: digits) | Required. FID of practitioner. |
| name | [Name](#name) | Reguired. Name of practitioner. | 
| lastProfileId | long | The ID of the last profile. |
| lastProfileStatus | string | The status of the last profile. | 
| lastProfileSubmitDateUtc | string (date/time) | The date/time the last profile was submitted, in UTC. | 
| lastProfileSentDateUtc | string (date/time) | The date/time the last profile was sent, in UTC. |

## Name 
Name of a person. 

| Name | Type | Description |
| - | - | - |
| firstName | string | Required. First name. |
| middleName | string | Middle name. |
| lastName | string | Required. Last name. |
| suffix | string | Suffix. |