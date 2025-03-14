# Get Status

Get the status of the current FCVS Profile for a practitioner.

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/status
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | API URL |
| board | path | True | string | Board code or `me` |
| fid | path | True | string | FID of the practitioner |

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Practitioner Status](/docs/definitions/practitioner-status.md) | Success |
| 404 Not Found | | Board code is missing/invalid or Practitioner does not have an FCVS Profile |

## Security

### Scopes

| Scope | Description |
| -|-|
| fcvs.read | Grants the ability to read FCVS information. |

## Examples

[Get profile status](#get-profile-status)
***

### Get profile status

#### Sample Request

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/status
```

#### Sample Response

Status code: 200

```json
{
    "fid": "999999915",
    "name": {
        "firstName": "Philip",
        "middleName": "James",
        "lastName": "Testman",
        "suffix": ""
    },
    "lastProfileId": 428909,
    "lastProfileStatus": "Submitted",
    "lastProfileSubmitDateUtc": "2019-09-23T13:24:23.343Z"
}
```
