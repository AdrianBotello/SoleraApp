using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using AppProject.Models;
using MongoDB.Bson.IO;

namespace webapi.Controllers;

[ApiController]
[Route("/api")]
public class RESTController : ControllerBase
{

    private readonly ILogger<RESTController> _logger;

    public RESTController(ILogger<RESTController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("GetHello")]
    public string Get()
    {
        AppProject.Models.Group myGroup = new AppProject.Models.Group();
        myGroup.group_name = "Grupo 1";
        string myJson = myGroup.ToJson();
        return myJson;
    }
}