using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using WebAPI_Client.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebAPI_Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //action method to consume webapi service product/get
        public ActionResult DisplayProducts()
        {
            IEnumerable<MVCProductModel> productlist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44343/api/");
                var responsetalk = webclient.GetAsync("Product/getproducts");
                responsetalk.Wait();

                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    productlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    productlist = Enumerable.Empty<MVCProductModel>();
                }
                return View(productlist);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCProductModel mvcprd)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44343/api/");

                var posttalk = webclient.PostAsJsonAsync<MVCProductModel>("Product/PostProduct", mvcprd);
                posttalk.Wait();

                var dataresult = posttalk.Result;

                if (dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("DisplayProducts");
                }

                ModelState.AddModelError(String.Empty, "Product Insertion Failed..");
                return View(mvcprd);
            }
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            if (Id < 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProductModel product = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44343/api/");
                var edittalk = webclient.GetAsync("Product/GetProductById/" + Id).Result;

                if (edittalk.IsSuccessStatusCode)
                {
                    var resultdata = edittalk.Content.ReadAsStringAsync().Result;
                    product = JsonConvert.DeserializeObject<MVCProductModel>(resultdata);
                }
                else
                {
                    ModelState.AddModelError("", "Some Error Occured while Processing your Request..");
                }

                if (product == null)
                {
                    return HttpNotFound();
                }
                return View(product);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(MVCProductModel p)
        {
            if (ModelState.IsValid)
            {
                using (var webclient = new HttpClient())
                {
                    webclient.BaseAddress = new Uri("https://localhost:44343/api/");

                    var response = await webclient.PutAsJsonAsync("Product/Put", p);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("DisplayProducts");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error in updation..");
                    }
                }
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}