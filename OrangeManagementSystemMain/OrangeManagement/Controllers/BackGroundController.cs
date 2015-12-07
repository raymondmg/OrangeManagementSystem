using System.Data;
using System.Linq;
using System.Web.Mvc;
using OrangeManagement.Models;

namespace OrangeManagement.Controllers
{
    /// <summary>
    /// 后台管理控制器
    /// </summary>
    public class BackGroundController : Controller
    {
        readonly DbHelper _db = new DbHelper();

        //新建校区
        [HttpPost]
        public ActionResult CreateNewCampus(CampusModel model)
        {

            if (!ModelState.IsValid) return View("CampusManagement");

            var newCampus = new CampusModel
            {
                CampusAddress = model.CampusAddress,
                CampusDescribe = model.CampusDescribe,
                CampusName = model.CampusName,
                CampusNumber = model.CampusNumber
            };

            _db.CampusModule.Add(newCampus);
            _db.SaveChanges();
            return View("CampusManagement");
        }

        //编辑校区信息
        [HttpPost]
        public ActionResult EditCampus(CampusModel model)
        {
            if (!ModelState.IsValid) return View("CampusManagement");

            var nowEditModel = _db.CampusModule.FirstOrDefault(it => it.CampusId == model.CampusId);
            
             if (nowEditModel != null)
             {
                 nowEditModel.CampusAddress = model.CampusAddress;
                 nowEditModel.CampusDescribe = model.CampusDescribe;
                 nowEditModel.CampusName = model.CampusName;
                 nowEditModel.CampusNumber = model.CampusNumber;
            };
     
            _db.SaveChanges();
            return View("CampusManagement");
        }
        
        
        //删除校区信息
        [HttpPost]
        public ActionResult DeleteCampus(System.Int32 deleteId)
        {
            _db.Entry(_db.CampusModule.FirstOrDefault(it => it.CampusId == deleteId)).State = EntityState.Deleted;
            _db.SaveChanges();
            return View("CampusManagement");
        }
        /// <summary>
        /// 登陆界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 校区管理
        /// </summary>
        /// <returns></returns>
        public ActionResult CampusManagement()
        {
            return View();
        }

        /// <summary>
        /// 校区管理首页
        /// </summary>
        /// <returns></returns>
        public ActionResult CampusInfo()
        {
            return View();
        }
   
        /// <summary>
        /// 后台管理首页
        /// </summary>
        /// <returns></returns>
        public ActionResult BackGroundHome()
        {
            return View();
        }

    }
}
