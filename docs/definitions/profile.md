# Profile

Practitioner profile for a board

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Profile ID |
| fid | string (len: 9, format: digits) | Yes | FID of practitioner |
| submitDateUTC | string (date/time) | Yes | Date the profile was submitted, in UTC |
| application | [Application](application.md) | Yes | Application information |
| identity | [Identification](identification.md) | Yes | Identity |
| names | [Names](names.md) | Yes | Names |
| addresses | [Addresses](mailing-addresses.md) | Yes | Mailing addresses |
| emailAddresses | [EmailAddresses](email-addresses.md) | Yes | Email addresses |
| phones | [Phones](phones.md) | Yes | Phone numbers |
| medicalEducation | [MedicalEducationTraining](medicaleducationtraining.md) | Yes | Medical education |
| postGraduateTraining | [PostGraduateTraining](postgraduatetraining.md) | No | Postgraduate training |
| exams | [Exam](exam.md)[] | No | Exams |
| licenses | [License](license.md)[] | No | Licenses |
| activities | [Activity](activity.md)[] | No | Chronology of activity |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
