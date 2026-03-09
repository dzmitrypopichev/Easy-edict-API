using System;
using System.Collections.Generic;
using EasyEdictWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyEdictWebApi.Controllers;

[ApiController]
[Route("api")]
public class EntitiesController : ControllerBase
{
    [HttpGet("entities")]
    public IActionResult GetEntities()
    {
        try
        {
            var entities = new List<EntityModel>
            {
                new EntityModel
                {
                    Id = 1,
                    Name = "Entity One",
                    Description = "This is the first entity with detailed information",
                    Type = "Type A",
                    Status = "Active",
                    CreatedDate = DateTime.Now.AddDays(-30),
                    UpdatedDate = DateTime.Now.AddDays(-5),
                    Tags = new List<string> { "important", "featured", "priority" },
                    Metadata = new Dictionary<string, object>
                    {
                        { "priority", "high" },
                        { "category", "primary" },
                        { "score", 95 }
                    }
                },
                new EntityModel
                {
                    Id = 2,
                    Name = "Entity Two",
                    Description = "Second entity with comprehensive details and attributes",
                    Type = "Type B",
                    Status = "Active",
                    CreatedDate = DateTime.Now.AddDays(-25),
                    UpdatedDate = DateTime.Now.AddDays(-3),
                    Tags = new List<string> { "secondary", "review" },
                    Metadata = new Dictionary<string, object>
                    {
                        { "priority", "medium" },
                        { "category", "secondary" },
                        { "score", 87 }
                    }
                },
                new EntityModel
                {
                    Id = 3,
                    Name = "Entity Three",
                    Description = "Third entity containing special characteristics",
                    Type = "Type A",
                    Status = "Pending",
                    CreatedDate = DateTime.Now.AddDays(-15),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Tags = new List<string> { "new", "pending-review" },
                    Metadata = new Dictionary<string, object>
                    {
                        { "priority", "low" },
                        { "category", "tertiary" },
                        { "score", 72 }
                    }
                },
                new EntityModel
                {
                    Id = 4,
                    Name = "Entity Four",
                    Description = "Fourth entity with extended information and properties",
                    Type = "Type C",
                    Status = "Active",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    UpdatedDate = DateTime.Now,
                    Tags = new List<string> { "featured", "trending", "top" },
                    Metadata = new Dictionary<string, object>
                    {
                        { "priority", "critical" },
                        { "category", "premium" },
                        { "score", 98 }
                    }
                },
                new EntityModel
                {
                    Id = 5,
                    Name = "Entity Five",
                    Description = "Fifth entity demonstrating various data points",
                    Type = "Type B",
                    Status = "Inactive",
                    CreatedDate = DateTime.Now.AddDays(-50),
                    UpdatedDate = DateTime.Now.AddDays(-20),
                    Tags = new List<string> { "archived", "legacy" },
                    Metadata = new Dictionary<string, object>
                    {
                        { "priority", "low" },
                        { "category", "archived" },
                        { "score", 45 }
                    }
                }
            };

            return Ok(new
            {
                success = true,
                count = entities.Count,
                data = entities,
                timestamp = DateTime.UtcNow
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    [HttpGet("entities/{id:int}")]
    public IActionResult GetEntityById(int id)
    {
        try
        {
            var entity = new EntityModel
            {
                Id = id,
                Name = $"Entity {id}",
                Description = $"Detailed information about entity {id}",
                Type = "Type A",
                Status = "Active",
                CreatedDate = DateTime.Now.AddDays(-30),
                UpdatedDate = DateTime.Now,
                Tags = new List<string> { "sample", "detail" },
                Metadata = new Dictionary<string, object>
                {
                    { "priority", "high" },
                    { "views", 1523 },
                    { "likes", 342 }
                }
            };

            return Ok(new
            {
                success = true,
                data = entity,
                timestamp = DateTime.UtcNow
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok(new
        {
            message = "Easy Edict API is running successfully!",
            version = "1.0.0",
            timestamp = DateTime.UtcNow
        });
    }
}
