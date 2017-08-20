using Microsoft.AspNetCore.Mvc;

// ValuesController is the equivalent
// `ValuesController` of the Iris 8.3 mvc application.
[Route("api/[controller]")]
public class ValuesController : Controller
{
    // Get handles "GET" requests to "api/values/{id}".
    [HttpGet("{id}")]
    public string Get(int id) => "value";

    // Put handles "PUT" requests to "api/values/{id}".
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value) { }

    // Delete handles "DELETE" requests to "api/values/{id}".
    [HttpDelete("{id}")]
    public void Delete(int id) { }
}
