# Joint.DB.Redis

| Branch  | Build status                                                                                                                   |
| ------- | ------------------------------------------------------------------------------------------------------------------------------ |
| master  | [![Build Status](https://travis-ci.org/flapek/Joint.DB.Redis.svg?branch=master)](https://travis-ci.org/flapek/Joint.DB.Redis)  |
| develop | [![Build Status](https://travis-ci.org/flapek/Joint.DB.Redis.svg?branch=develop)](https://travis-ci.org/flapek/Joint.DB.Redis) |

## Redis

Adds the [Redis](https://redis.io/) integration with .NET Core based on [IDistributedCache](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.caching.distributed.idistributedcache?view=dotnet-plat-ext-3.1) abstraction.

## Installation

```
dotnet add package Joint.DB.Redis
```

## Dependencies

- [Joint](https://www.nuget.org/packages/Joint/)
- [Microsoft.Extensions.Caching.StackExchangeRedis](https://www.nuget.org/packages/Microsoft.Extensions.Caching.StackExchangeRedis/)

## Usage

Extend `IJointBuilder` with `AddRedis()` that will register the required services.

```c#
public static IJointBuilder RegisterJoint(this IJointBuilder builder)
{
    builder.AddRedis();
    // Other services.

    return builder;
}
```

In order to use Redis integration, inject built-in `IMemoryCache` interface.

```c#
public class SomeService
{
    private readonly IMemoryCache _cache;

    public SomeService(IMemoryCache cache)
    {
        _cache = cache;
    }
}
```

## Options

- connectionString - connection string e.g. localhost.
- instance - optional prefix, that will be added by default to all the keys.

### appsettings.json

```json
"redis": {
  "connectionString": "localhost",
  "instance": "some-prefix:"
}
```

## Table of Contents

- [Joint](https://github.com/flapek/Joint)
- [Joint.Auth](https://github.com/flapek/Joint.Auth)
- [Joint.CQRS.Commands](https://github.com/flapek/Joint.CQRS.Commands)
- [Joint.CQRS.Events](https://github.com/flapek/Joint.CQRS.Events)
- [Joint.CQRS.Queries](https://github.com/flapek/Joint.CQRS.Queries)
- [Joint.DB.Mongo](https://github.com/flapek/Joint.DB.Mongo)
- [Joint.DB.Redis](https://github.com/flapek/Joint.DB.Redis)
- [Joint.Docs.Swagger](https://github.com/flapek/Joint.Docs.Swagger)
- [Joint.Exception](https://github.com/flapek/Joint.Exception)
- [Joint.Logging](https://github.com/flapek/Joint.Logging)
- [Joint.WebApi](https://github.com/flapek/Joint.WebApi)
