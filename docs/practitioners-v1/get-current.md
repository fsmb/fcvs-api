# Get Current

Get the current FCVS Profile for a practitioner.

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/profiles/current
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| fid | path | True | string | The FID of the practitioner. |

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Profile](/docs/definitions/profile.md) | Success. |
| 404 Not Found | | Board code is missing/invalid or Practitioner does not have an FCVS Profile. |

## Security

### Scopes

| Scope | Description |
| -|-|
|fcvs.read | Grants the ability to read FCVS information. |

## Examples

[Get current profile](#get-current-profile)
***

### Get current profile

#### Sample Request

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/profiles/current
```

#### Sample Response

Status code: 200

```json
{
    "id": 1234,
    "fid": "999999915",
    "submitDateUtc": "2019-09-23T13:24:23Z",
    "application": {
        "boardName": "Texas Medical Board",
        "status": "In Progress"
    },
    "identity": {
        "ssnLast4": "1111",
        "birthDate": "1978-08-08T00:00:00",
        "birthCity": "Houston",
        "birthStateOrProvince": {
            "code": "TX",
            "description": "Texas",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        },
        "other": []
    },
    "addresses": {
        "other": [
            {
                "addressType": "Business",
                "lines": [
                    "9665 Greenway Trail"
                ],
                "city": "Portland",
                "stateOrProvince": {
                    "code": "OR",
                    "description": "Oregon",
                    "countryCode": "US",
                    "countryDescription": "United States"
                },
                "postalCode": "89456"
            }
        ]
    },
    "emailAddresses": {
        "primary": {
            "email": "fsmbqa@fsmb.org"
        },
        "other": []
    },
    "phones": {
        "other": [
            {
                "phoneType": "Business",
                "phoneNumber": "8524567856"
            }
        ]
    },
    "medicalEducation": {
        "graduating": {
            "school": {
                "name": "Baylor College of Medicine",
                "cibisCode": "044010",
                "schoolType": {
                    "code": "MD",
                    "description": "Doctor of Medicine"
                },
                "city": "Houston",
                "stateOrProvince": {
                    "code": "TX",
                    "description": "Texas",
                    "countryCode": "US",
                    "countryDescription": "United States"
                }
            },
            "beginDate": "2010-08-08T00:00:00",
            "endDate": "2019-02-08T00:00:00",
            "degree": {
                "code": "MD",
                "description": "Doctor of Medicine"
            },
            "graduationDate": "2019-06-06T00:00:00",
            "unusualCircumstances": {
                "hasInterruptions": false,
                "hasProbation": false,
                "hasInvestigation": false,
                "hasBehavior": false,
                "hasRequirements": false
            }
        },
        "other": []
    },
    "postGraduateTraining": {
        "accreditedTraining": [
            {
                "accreditationType": "ACGME",
                "programCode": "1102500201",
                "program": {
                    "hospitalName": "Mercy Health Program",
                    "affiliatedInstitution": "Mercy Health",
                    "city": "Muskegon",
                    "stateOrProvince": {
                        "code": "MI",
                        "description": "Michigan",
                        "countryCode": "US",
                        "countryDescription": "United States"
                    }
                },
                "specialty": {
                    "description": "Emergency Medicine"
                },
                "programType": "Residency",
                "trainingStatus": "Completed",
                "beginDate": "2004-09-09T00:00:00",
                "endDate": "2006-07-24T00:00:00",
                "unusualCircumstances": {
                    "hasInterruptions": true,
                    "interruptionsDescription": "Leave of absence",
                    "interruptionStartMonth": 10,
                    "interruptionStartYear": 2005,
                    "interruptionEndMonth": 12,
                    "interruptionEndYear": 2005,
                    "hasProbation": false,
                    "hasInvestigation": false,
                    "hasBehavior": false,
                    "hasRequirements": false
                }
            }
        ],
        "otherTraining": []
    },
    "exams": [
        {
            "examType": "NBME Part I",
            "examDate": "2006-09-09T00:00:00",
            "numberOfAttempts": 1,
            "passFail": "Pass"
        }
    ],
    "licenses": [
        {
            "licenseType": "Administrative",
            "licensingEntity": {
                "code": "AL",
                "description": "Alabama"
            },
            "status": "Active",
            "licenseNumber": "TEST1111",
            "issueDate": "2010-07-01T00:00:00",
            "expirationDate": "2020-06-30T00:00:00"
        },
        {
            "licenseType": "Full",
            "licensingEntity": {
                "code": "AZ",
                "description": "Arizona"
            },
            "status": "General",
            "licenseNumber": "TEST3333",
            "issueDate": "2010-07-01T00:00:00",
            "expirationDate": "2020-06-30T00:00:00"
        },
        {
            "licenseType": "Full",
            "licensingEntity": {
                "code": "NH",
                "description": "New Hampshire"
            },
            "status": "Active",
            "licenseNumber": "TEST555",
            "issueDate": "2004-07-01T00:00:00",
            "expirationDate": "2020-06-30T00:00:00"
        },
        {
            "licenseType": "Teaching",
            "licensingEntity": {
                "code": "AK",
                "description": "Alaska"
            },
            "status": "Expired",
            "licenseNumber": "TEST2222",
            "issueDate": "2001-07-01T00:00:00",
            "expirationDate": "2012-06-30T00:00:00"
        }
    ],
    "activities": [
        {
            "type": "Work",
            "inProgress": true,
            "beginDate": "2019-03-01T00:00:00",
            "description": "Working Hospital",
            "addressLines": [
                "123 Jane Lane"
            ],
            "city": "Euless",
            "stateOrProvince": {
                "code": "TX",
                "description": "Texas",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "75412",
            "position": "Lead Physician",
            "department": "Surgery",
            "wasEmployed": true,
            "hadStaffPrivileges": true,
            "wasAffiliated": true,
            "percentageClinical": 100,
            "percentageAdministrative": 0
        }
    ]
}
```
