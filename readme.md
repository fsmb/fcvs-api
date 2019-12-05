# Federation Credentials Verification Service API

This is the source for technical information for the Federation of State Medical Boards' Federation Credentials Verification Service (FCVS) [REST API](https://en.wikipedia.org/wiki/Representational_state_transfer). 
The FCVS API can be used by state medical boards (SMBs) to retrieve information about FCVS applications submitted to the board. 

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API, begin using it in your application, or access the [Postman]( https://www.getpostman.com/) collection,  please contact [FSMB](mailto:fcvs@fsmb.org).


- URL
  - Demo: https://demo-services.fsmb.org/fcvs/
  - Production: https://services.fsmb.org/fcvs/
- [Postman Collection](https://www.getpostman.com/collections/b59f8de00ca54eb654b7)
- [OpenAPI Specification](https://demo-services.fsmb.org/fcvs/swagger/v1)

## Authentication 

The FCVS API uses [OAuth2](https://oauth.net/2/) credentialing authentication. A client id and client secret are necessary for authentication. Contact FSMB for access to a client id and client secret. 

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
