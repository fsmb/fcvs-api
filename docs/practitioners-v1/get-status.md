# Get Current

Get the status of the current FCVS Profile for a practitioner

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/status
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
| 200 OK | [Practitioner Status](/docs/definitions/practitioner-status.md) | Success |
| 404 Not Found | | Board code is invalid or Practitioner has no profile |

## Security

### Scopes

| Scope | Description |
| -|-|
|fcvs.read | Grants the ability to read FCVS information. |

## Examples

[Get the status](#get-the-status)
***

### Get the status

#### Sample Request

```http
GET {baseUrl}/v1/boards/{board}/practitioners/{fid}/status
```

#### Sample Response

Status code: 200

*Note: Output is elided.*

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
    "lastProfileStatus": "In Progress",
    "lastProfileSubmitDateUtc": "2019-09-23T13:24:23.343Z"
}
```

For more examples go to [samples](/samples/).
