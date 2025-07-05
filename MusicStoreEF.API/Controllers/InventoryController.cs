using MusicStoreEF.Service.Services;
using Microsoft.AspNetCore.Mvc;
using MusicStoreEF.API.DTO;
using MusicStoreEF.Service.Models;

namespace MusicStoreEF.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private readonly IInventoryService inventoryService;

    public InventoryController(IInventoryService inventoryService)
    {
        this.inventoryService = inventoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllInventoryRecords()
    {
        var records = await inventoryService.GetAllInventoryRecordsAsync();
        return Ok(records);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetInventoryRecordById(int id)
    {
        var record = await inventoryService.GetInventoryRecordByIdAsync(id);
        if (record == null)
        {
            return NotFound();
        }
        return Ok(record);
    }

    [HttpPost]
    public async Task<IActionResult> AddInventoryRecord([FromBody] InventoryRecordDto inventoryRecord)
    {
        if (inventoryRecord == null)
        {
            return BadRequest("Invalid inventory record.");
        }
        var record = new InventoryRecord
        {
            // Assuming InventoryRecord has properties that match InventoryRecordDto
            // Map properties from inventoryRecord to record here
            // Example: Id = inventoryRecord.Id, Name = inventoryRecord.Name, etc.
        };
        await inventoryService.AddInventoryRecordAsync(record);
        return CreatedAtAction(nameof(GetInventoryRecordById), new { id = inventoryRecord.Id }, inventoryRecord);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateInventoryRecord(int id, [FromBody] InventoryRecordDto inventoryRecord)
    {
        if (inventoryRecord == null || inventoryRecord.Id != id)
        {
            return BadRequest("Invalid inventory record.");
        }
        var existingRecord = await inventoryService.GetInventoryRecordByIdAsync(id);
        if (existingRecord == null)
        {
            return NotFound();
        }
        await inventoryService.UpdateInventoryRecordAsync(inventoryRecord);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInventoryRecord(int id)
    {
        var existingRecord = await inventoryService.GetInventoryRecordByIdAsync(id);
        if (existingRecord == null)
        {
            return NotFound();
        }
        await inventoryService.DeleteInventoryRecordAsync(id);
        return NoContent();
    }

}
