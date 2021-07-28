# How to enable CORS on your Web API

_Security restrictions on your browser’s security policy prevent your web browser from making AJAX requests to a server in another domain. This is also known as same-origin policy. In other words, built-in browser security prevents a web page of one domain from executing AJAX calls on another domain._

_Here’s where CORS (Cross-Origin Resource Sharing) comes to the rescue. CORS is a W3C standard that allows you to get away from the same origin policy adopted by the browsers to restrict access from one domain to resources belonging to another domain. You can enable CORS for your Web API using the respective Web API package (depending on the version of Web API in use) or OWIN middleware._

---

---

# Enable CORS support in ASP.NET Web API

ASP.NET Web API provides excellent support for CORS. To provide support for CORS in ASP.NET Web API 2, you need to use the ** Microsoft.AspNet.WebApi.Cors ** NuGet package. To install this package, you can execute the following command from the NuGet package manager console.

---

---

### Support for CORS can be enabled at three levels. These include the following:

1. Action level
2. Controller level
3. Global level

---

## Enable CORS at the Global level

To enable CORS at the Global level, you would need to take advantage of the EnableCors method of the HttpConfiguration class as shown in the code snippet given below.

```
public static void Register(HttpConfiguration config)
{
    string origin = "http://localhost:50164/IDGWebClient/";
    EnableCorsAttribute cors = new EnableCorsAttribute(origin, "*", "GET,POST");
    config.EnableCors(cors);
    // Specify the Web API configuration and services here
    // Specify the Web API routes here
    }
```

Refer to the code snippet given above. Note how the request origin has been specified. The \* parameter implies all request headers. So, GET and POST requests from the specified domain would be accepted, all other requests would be rejected.

---

## Enable CORS at the Controller level

You can also enable CORS support at the controller level. To do this, specify the [EnableCors] attribute to your Web API controller as shown below.

```
  [EnableCors(origins: "http://localhost:50164/", headers: "*", methods: "*")]
    public class AuthorsController : ApiController
    {
        //Write your Web API controller methods here
    }
```

---

---

## Enable CORS at the Action level

Similarly, you can also enable CORS at the action level using the [EnableCORS] attribute. Here is an example that illustrates how this is done.

```
public class AuthorsController : ApiController
    {
        [EnableCors(origins: "http://localhost:50164/", headers: "*", methods: "*")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Joydip Kanjilal", "Steve Smith" };
        }
    }
```

---

## Disable CORS for a specific action

Now, you might need to disable CORS for a specific action or a group of actions. This feature might be handy when you have already enabled CORS at the global level and you now want to disable it for one of more actions due to security reasons. The following code snippet illustrates how you can achieve this using the [DisableCors] attribute.

```
[DisableCors()]
public IEnumerable<string> Get()
   {
      return new string[] { "Joydip Kanjilal", "Steve Smith" };
   }
```

---

---

If you are using ASP.NET Core, you should add the Microsoft.AspNetCore.Cors package via NuGet to your project and then write the following statement in the Startup.cs file to set up CORS support.

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddCors();
}
```

You can enable CORS using CORS middleware — you can take advantage of the UseCors extension method in this regard. Alternatively, you can enable CORS at the controller or the action levels using the EnableCors attribute much the same way we did earlier in this article. Similarly, for disabling CORS, you can use the [DisableCors] attribute
