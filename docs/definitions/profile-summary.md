# Profile Summary

Summary information about a profile

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Profile ID |
| fid | string (len: 9, format: digits) | Yes | FID of practitioner |
| sentDate | string (date/time) | No | Date/time the profile was sent to the board |
| submitDate | string (date/time) | Yes | Date/time the profile was subm|
| status | string (len: 50) | Yes | Status of the profile |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
