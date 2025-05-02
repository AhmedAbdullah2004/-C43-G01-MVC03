using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Presentation.Controllers
{
    {
            if (!id.HasValue) return BadRequest();
            var department = _departmentService.GetDepartmentById(id.Value);
            if (department is null) return NotFound();
            return View(department);
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();

        {
        }


        #endregion
    }
}
