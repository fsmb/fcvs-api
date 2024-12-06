# Application

Application information

| Name | Type | Required | Description |
| - | - | - | - |
| boardName | string (len: 100) | Yes | Board name |
| sentDateUtc | string (date/time) | No | Datetime the profile was sent, in UTC |
| status | string (len: ) | Yes | Status of the profile (e.g. `Submitted`, `Complete`) |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
