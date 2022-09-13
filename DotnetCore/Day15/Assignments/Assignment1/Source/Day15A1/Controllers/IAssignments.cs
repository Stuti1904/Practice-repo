using Day15A1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15A1.Controllers
{
    public interface IAssignments : IRepository<Assignment>
    {
        List<Assignment> GetAssignments();
        Assignment UpdateAssignment(int id, Assignment assignment);

    }

    public class Assignments : Repository<Assignment>, IAssignments
    {


        public Assignments(NewDBContext context) : base(context)
        {

        }
        public List<Assignment> GetAssignments()
        {
            var emp = base.GetAll();
            return emp;
        }

        public Assignment UpdateAssignment(int id, Assignment assignment)
        {
            var tempassign = base.GetOne(id);
            tempassign.AssignmentCategory = assignment.AssignmentCategory;
            base.update(tempassign);
            return tempassign;
        }

    }
}
