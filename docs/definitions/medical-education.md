# MedicalEducation

Medical school education

| Name | Type | Required | Description |
| - | - | - | - |
| school | [School](school.md) | Yes | Medical school |
| beginDate | string (date) | Yes | Start date |
| endDate | string (date) | Yes | End date |
| degree | [Degree](degree.md) | No | Degree information |
| graduationDate | string (date) | No | Graduation date |
| unusualCircumstances | [UnusualCircumstances](unusual-circumstances.md) | Yes | Unusual circumstances |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
