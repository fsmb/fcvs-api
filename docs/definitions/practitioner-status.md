# Practitioner Status

Status of a practitioner

| Name | Type | Required | Description |
| - | - | - | - |
| fid |  string (len: 9, format: digits) | Yes | FID of practitioner |
| name | [Name](name.md) | Yes | Name of practitioner |
| lastProfileId | long | Yes | ID of the last profile |
| lastProfileStatus | string | No | Status of the last profile |
| lastProfileSubmitDateUtc | string (date/time) | Yes | Date/time the last profile was submitted, in UTC |
| lastProfileSentDateUtc | string (date/time) | No | Date/time the last profile was sent, in UTC, if any |
