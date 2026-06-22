# Federation Credentials Verification Service API

This is the source for technical information for the Federation Credentials Verification Service (FCVS) [REST API](https://en.wikipedia.org/wiki/Representational_state_transfer). 
The FCVS API can be used by state medical boards (SMBs) to retrieve information about FCVS applications submitted to the board. 

To learn more about FSMB APIs, refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code, please contact [FSMB](mailto:fcvs@fsmb.org).

This API currently uses a custom error response instead of the standard [FSMB error response](https://github.com/fsmb/api-docs/docs/errors.md). The format of an error response is given here.

```json
{
   "code": "Error code",
   "message": "Descriptive message",
   "target": "Optional target of the error",
   "logId": "The ID of the log entry associated with the error, if any",
   "innerError": { },
   "data": { }
}
```

If the error was caused by a lower level error, then `innerError` contains the error detail of the child error. Some errors may return additional data in the `data` property. The `code` field identifies the underlying error that occurred while the `message` field provides a developer friendly message.

- URL
  - Demo: https://services-fcvs-demo.fsmb.org
  - Production: https://services-fcvs.fsmb.org
- [Postman Collection](https://www.getpostman.com/collections/b59f8de00ca54eb654b7)
- [OpenAPI Specification](https://services-fcvs.fsmb.org/swagger/v1)

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/b59f8de00ca54eb654b7)
## Change Log

| Version | Date | Release Notes |
| - | - | -|
| 1.0 | 5 Dec 2019 | Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| fcvs.read | Grants the ability to read FCVS information. |

## Resources

- [Practitioners](docs/practitioners-v1/readme.md)
