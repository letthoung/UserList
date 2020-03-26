using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserListAPI.Models;

namespace UserListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserListController : ControllerBase
    {
        private readonly eHelpDeskContext _context;

        public UserListController(eHelpDeskContext context)
        {
            _context = context;
        }

        // GET: api/UserList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserList>>> GetUserList()
        {
            return await _context.UserList.ToListAsync();
        }

        //// GET: api/UserList/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<UserList>> GetUserList(int id)
        //{
        //    var userList = await _context.UserList.FindAsync(id);

        //    if (userList == null)
        //    {
        //        return NotFound();
        //    }

        //    return userList;
        //}

        //// PUT: api/UserList/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUserList(int id, UserList userList)
        //{
        //    if (id != userList.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(userList).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserListExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/UserList
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<UserList>> PostUserList(UserList userList)
        //{
        //    _context.UserList.Add(userList);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (UserListExists(userList.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetUserList", new { id = userList.Id }, userList);
        //}

        //// DELETE: api/UserList/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<UserList>> DeleteUserList(int id)
        //{
        //    var userList = await _context.UserList.FindAsync(id);
        //    if (userList == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.UserList.Remove(userList);
        //    await _context.SaveChangesAsync();

        //    return userList;
        //}

        //private bool UserListExists(int id)
        //{
        //    return _context.UserList.Any(e => e.Id == id);
        //}
    }
}
