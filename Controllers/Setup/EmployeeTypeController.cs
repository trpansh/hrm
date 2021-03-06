using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;
using Frapid.DataAccess.Models;

namespace MixERP.HRM.Controllers.Setup
{
    public class EmployeeTypeController : DashboardController
    {
        [Route("dashboard/hrm/setup/employee-types")]
        [MenuPolicy]
        [ScrudFactory]
        [AccessPolicy("hrm", "employee_types", AccessTypeEnum.Read)]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/EmployeeTypes/Index.cshtml", this.Tenant));
        }
    }
}