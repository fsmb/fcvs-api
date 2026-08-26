# Federation Credentials Verification Service API

This is the source for technical information for the Federation Credentials Verification Service (FCVS) [REST API](https://en.wikipedia.org/wiki/Representational_state_transfer). 
The FCVS API can be used by state medical boards (SMBs) to retrieve information about FCVS applications submitted to the board. 

To learn more about FSMB APIs, refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code, please contact [FSMB](mailto:fcvs@fsmb.org).


- URL
  - Demo: https://services-fcvs-demo.fsmb.org
  - Production: https://services-fcvs.fsmb.org
- Authentication URL `<baseUrl>/connect/token`
- [Postman Collection](https://www.getpostman.com/collections/b59f8de00ca54eb654b7)
- OpenAPI Specification: [JSON](https://services-fcvs-demo.fsmb.org/openapi/v1.json) [YAML](https://services-fcvs-demo.fsmb.org/openapi/v1.yaml)

[<img src="https://run.pstmn.io/button.svg" alt="Run In Postman" style="width: 128px; height: 32px;">](https://app.getpostman.com/run-collection/1384052-bbfef0d8-d867-446d-8ae8-08d42b035ebe?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D1384052-bbfef0d8-d867-446d-8ae8-08d42b035ebe%26entityType%3Dcollection%26workspaceId%3D58240218-129c-4c2c-a71a-139a2efabdb2#?env%5BFCVS%20(Demo)%5D=W3siZW5hYmxlZCI6dHJ1ZSwia2V5IjoiYmFzZVVybCIsInZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy1mY3ZzLWRlbW8uZnNtYi5vcmcifSx7ImVuYWJsZWQiOnRydWUsInR5cGUiOiJzZWNyZXQiLCJrZXkiOiJjbGllbnRJZCIsInZhbHVlIjoiRE9fTk9UX1NFVCJ9LHsiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6InNlY3JldCIsImtleSI6ImNsaWVudFNlY3JldCIsInZhbHVlIjoiRE9fTk9UX1NFVCJ9XQ==)

## Change Log

| Date | Release Notes |
| - | -|
| Aug 2026 | [Release Notes](relnotes/relnotes-202608.md) |
| Dec 2019 | Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| fcvs.read | Grants the ability to read FCVS information. |

## Resources

- [Practitioners](docs/practitioners-v1/readme.md)
