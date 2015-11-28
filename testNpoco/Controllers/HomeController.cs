using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NPoco;
namespace testNpoco.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			var bUser = new NPoco.BLL.User ();
			var mUser = new NPoco.Model.User ();
			mUser.Email = "test@exmaple.com";
			mUser.NickName = "npoco";
			mUser.UserName = "npoco";

		    mUser = bUser.Add (mUser);

			var userList = bUser.GetList (10);

			bUser.Delete (mUser.Id);
			 
			return View ();
		}
	}
}

