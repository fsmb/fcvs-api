# Profile

An FCVS Profile for a Practitioner.

| Name | Type | Description |
| - | - | - |
| id | integer | Required. Application ID. |
| fid | string (length: 9, format: digits) | Required. FID of practitioner. |
| submitDateUTC | string (date/time) | Date/time of submission, in UTC. |
| application | [Application](#application) | Required. Application information. |
| identity | [Identification](#identification) | Required. Identity information. |
| names | [Names](#names) | Required. Names |
| addresses | [Addresses](#addresses) | Required. Mailing addresses. |
| emailAddresses | [EmailAddresses](#emailaddresses) | Required. Email addresses. |
| phones | [Phones](#phones) | Required. Phone numbers. |
| medicalEducation | [MedicalEducationTraining](#medicaleducationtraining) | Required. Medical education. |
| postGraduateTraining | [PostGraduateTraining](#postgraduatetraining) | Postgraduate training. |                
| exams | [Exam](#exam)[] | Exams. |
| licenses | [License](#license)[] | Licenses. |
| activities | [Activity](#activity)[] | Chronology of activity. |


## AccreditedTraining

Accredited training information.

| Name | Type | Description |
| - | - | - |
| accreditationType | string | Required. The type of accreditation (e.g. `ACMGE`, `AOA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| programCode | string | Required. Program code. |
| program | [Program](#program) | Required. Program. |
| specialty | [Specialty](#specialty) | Required. Specialty. |
| programType | string | Required. Program type. |
| trainingStatus | string | Required. Training status (e.g. `Active`, `Completed`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| unusualCircumstances | [UnusualCircumstances](#unusualcircumstances) | Unusual circumstances. |
        
## Activity

Activity information.

| Name | Type | Description |
| - | - | - |
| type | string | Required. Type of activity. |
| inProgress | boolean | Required. Is in progress? |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | End date. |
| description | string | Required. Description. |
| addressLines | string[] | Required. Address lines. |
| city | string | Required. City. |
| stateOrProvince | [Region](#region) | Required. State/province. |
| postalCode | string | Postal code. |
| position | string | Position. |
| department | string | Department. |
| wasEmployed | boolean | Required. Was employee? |
| hadStaffPrivileges | boolean | Required. Had staff privileges? |
| wasAffiliated | boolean | Required. Was affiliated? |
| percentageClinical | integer | % clinical. |
| percentageAdminstrative | integer | % administrative. |

## Address

Mailing address.

| Name | Type | Description |
| - | - | - |
| addressType | string | Required. Type of address (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| lines | string[] | Address lines. |
| city | string | Required. City. |
| stateOrProvince | [Region](#region) | Required. State/province.|
| postalCode | string | Required. Postal code. |

## Addresses

List of mailing addresses.

| Name | Type | Description |
| - | - | - |
| other | [Address](#address)[] | Addresses. |

## Application

Application information.

| Name | Type | Description |
| - | - | - |
| boardName | string | Required. Board name. |
| sentDateUtc | string(date/time) | Date/Time the profile was sent, in UTC. |
| status | string | Required. Status of the profile (e.g. Submitted, Complete. |

## Degree

Degree information.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Code (e.g. `BM`, `MD`, `DMCH`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |

## Ecfmg

ECFMG information.

| Name | Type | Description |
| - | - | - |
| ecfmgNumber | string (format: digits) | Required. ECFMG number. |
| issueDate | string (date) | Issue date. |

## EmailAddress

Email address.

| Name | Type | Description |
| - | - | - |
| email | string | Required. Email address. |

## EmailAddresses

List of email addresses.

| Name | Type | Description |
| - | - | - |
| primary | [EmailAddress](#emailaddress) | Required. Primary email address. |
| other | [EmailAddress](#emailaddress)[] | Other email addresses. |

## Exam

Exam. 

| Name | Type | Description |
| - | - | - |
| examType | string | Required. Type of exam. |
| stateBoardDetail | [StateBoard](#stateBoard) | State board code and description (for state exams). |
| examDate | string (date) | Required. Exam date. |
| numberOfAttempts | integer | Reqiured. Number of attempts. |
| passFail | string | Required. Pass/fail status (e.g. `Pass`, `Fail`, `Unknown`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |

## FifthPathway

Fifth Pathway information.

| Name | Type | Description |
| - | - | - |
| school | [FifthPathwaySchool](#fifthpathwayschool) | Required. School. |
| startDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| certificateDate | string (date) | Required. Certification date. |

## FifthPathwaySchool

Fifth Pathway school information.

| Name | Type | Description |
| - | - | - |
| name | string | Required. School name. |
| affiliatedInstitution | string | Required. Affiliated institution. |
| city | string | City. |
| stateOrProvince | [Region](#region) | State/province. |

## Identification

Identity information.

| Name | Type | Description |
| - | - | - |
| ssnLast4 | string (length: 4, format: digits) | Last 4 of the SSN. |
| npi | string (length: 10, format: digits) | NPI. |
| usmleId | string (length: 8, format: digits)| USMLE ID. |
| birthDate | string (date) | Required. Date of birth. |
| birthCity | string | Required. Date of birth. |
| birthStateOrProvince | [Region](#region) | State/province of birth. |
| gender | string | Required. Gender. |

## License

License information.

| Name | Type | Description |
| - | - | - |
| licenseType | string | Type of license (e.g. `TEMP`, `FULL`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| licensingEntity | [LicenseEntity](#licenseentity) | Entity issuing license. |
| status | string | License status (e.g. `Active`, `Denied`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| practitionerType | [PractitionerType](#practitionertype) | Practitioner type. |
| licenseNumber | string | License number. |
| issueDate | string (date) | Issue date. |
| expirationDate | string (date) | Expiration date. |

## LicenseEntity

Entity issuing license.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Entity code. Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |

        
## MedicalEducation

Medical school education.

| Name | Type | Description |
| - | - | - |
| school | [School](#school) | Medical school. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| degree | [Degree](#degree) | Degree information. |
| graduationDate | string (date) | Graduation date. |
| unusualCircumstances | [UnusualCircumstances](#unusualCircumstances) | Unusual circumstances.

## MedicalEducationTraining

List of medical education.

| Name | Type | Description |
| - | - | - |
| graduating | [MedicalEducation](#medicaleducation) | Required. Graduating school. |
| other | [MedicalEducation](#medicaleducation)[] | Other medical schools. |
| ecfmg | [Ecfmg](#ecfmg) | ECFMG information. |
| fifthPathway | [FifthPathway](#fifthpathway) | 5th Pathway information. |

## Name

Name of a person.

| Name | Type | Description |
| - | - | - |
| firstName | string | Required. First name. |
| middleName | string | Middle name. |
| lastName | string | Required. Last name. |
| suffix | string | Suffix. |

## Names

List of names.

| Name | Type | Description |
| - | - | - |
| legalName | [Name](#name) | Required. Legal name. |
| other | [Name](#name)[] | Other names. |

## OtherTraining

Non-accredited postgraduate training.

| Name | Type | Description |
| - | - | - |
| program | [Program](#program) | Required. Program. |
| specialty | [Specialty](#specialty) | Required. Specialty. |
| programType | string | Required. Program type (e.g. `Internship`, `Fellowship`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| trainingStatus | string | Required. Training status (e.g. `Active`, `Completed`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| beginDate | string (date) | Required. Start date. |
| endDate | string (date) | Required. End date. |
| unusualCircumstances | [UnusualCircumstances](#unusualcircumstances) | Unusual circumstances. |

## Phone

Phone number.

| Name | Type | Description |
| - | - | - |
| phoneType | string | Required. Type of home (e.g. `Business`, `Home`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| phoneNumber | string | Required. Phone number. |
| extension | string | Phone extension. |

## Phones

List of phone numbers.

| Name | Type | Description |
| - | - | - |
| other | [Phone](#phone)[] | Phone numbers. |

## PostGraduateTraining

List of post graduate training.

| Name | Type | Description |
| - | - | - |
| accreditedTraining | [AccreditedTraining](#accreditedtraining)[] | Accredited training. |
| otherTraining | [OtherTraining](#otherTraining)[] | Non-accredited training. |

## PractitionerType

Practitioner type.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Code. Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |

## Program

Postgraduate training program.

| Name | Type | Description |
| - | - | - |
| hospitalName | string | Required. Hospital name. |
| affiliatedInstitution | string | Affiliated institution. |
| city | string | Required. City. |
| stateOrProvince | [Region](#region) | Required. State/province. |

## Region

Geographic region.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Region code (e.g. `TX`, `MD`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |
| countryCode | string | ISO country code (e.g. `US`, `CA`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| countryDescription | string | Country description. |

## School

Medical school.

| Name | Type | Description |
| - | - | - |
| name | string | Required. School name. |
| cibisCode | string | CIBIS code. |
| schoolType | [SchoolType](#schooltype) | Required. Type of school. |
| city | string | City. |
| stateOrProvince | [Region](#region) | State/province. |

## SchoolType

Type of medical school.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Code (e.g. `MD`, `DO`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |

## Specialty

Training specialty.

| Name | Type | Description |
| - | - | - |
| description | string | Required. Description. |

## StateBoard

State Board information.

| Name | Type | Description |
| - | - | - |
| code | string | Required. State Board Code (e.g. `TX`, `MD`). |
| description | string | Required. Description. |

## StateProvince

State/province information.

| Name | Type | Description |
| - | - | - |
| code | string | Required. Code (e.g. `TX`, `MD`). Refer to [codes](https://github.com/fsmb/api-docs/tree/master/docs/codes) for more information. |
| description | string | Required. Description. |

## UnusualCircumstances

Unusual circumstances.

| Name | Type | Description |
| - | - | - |
| hasInterruptions | boolean | Required. Has an interruption? |
| interruptionsDescription | string | Interruption description. |
| interruptionStartMonth | integer | Interruption start month. |
| interruptionStartYear | integer | Interruption start year. |
| interruptionEndMonth | integer | Interruption end month. |
| interruptionEndYear | integer | Interruption end year. |
| hasProbation | boolean | Required. Has a probation? |
| probationDescription | string | Probation description. |
| hasInvestigation | boolean | Required. Has an investigation? |
| investigationDescription | string | Investigation description. |
| hasBehavior | boolean | Required. Has negative behavior? |
| behaviorDescription | string | Behavior description. |
| hasRequirements | boolean | Required. Has special requirements? |
| requirementsDescription | string | Special requirements description. |

