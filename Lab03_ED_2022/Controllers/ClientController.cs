using CsvHelper;
using Lab03_ED_2022.BST;
using Lab03_ED_2022.Helpers;
using Lab03_ED_2022.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO;

namespace Lab03_ED_2022.Controllers
{
    public class ClientController : Controller
    {
        
        // GET: ClientController
        public ActionResult Index()
        {
            return View(Data.Instance.miArbolEmail);
        }

        public ActionResult IndexBoth()
        {
            return View(Data.Instance.miArbolEmail);
        }

        public ActionResult Index2()
        { 
            return View(Data.Instance.miArbolId);
        }
        public ActionResult Index3()
        {
            return View(Data.Instance.miArbolSerial);
        }
       
        //busqueda por correo
        public ActionResult Create2()
        {
            //formulario para busquedas
            return View(new ClientModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2(IFormCollection collection)
        {
            try
            {
                string parametro = (collection["Email"]);

                return View(Data.Instance.miArbolEmail.Buscar(Comparison.Comparison.CompararEmail(parametro)));
            }
            catch
            {
                return View();
            }
        }


        //busqueda por id
        public ActionResult Create3()
        {
            //formulario para busquedas
            return View(new ClientModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create3(IFormCollection collection)
        {
            try
            {
                int parametro = (int.Parse(collection["Id"]));

                return View(Data.Instance.miArbolId.Buscar(Comparison.Comparison.CompararID(parametro)));
            }
            catch
            {
                return View();
            }
        }

        //busqueda por serial 
        public ActionResult Create4()
        {
            //formulario para busquedas
            return View(new ClientModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create4(IFormCollection collection)
        {
            try
            {
                string parametro = (collection["SerialNo"]);

                return View(Data.Instance.miArbolSerial.Buscar(Comparison.Comparison.CompararSerial(parametro)));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Index4()
        {
            return View(Data.Instance.miArbolAvlId);
        }
        public ActionResult Index5()
        {
            return View(Data.Instance.miArbolAvlEmail);
        }
        public ActionResult Index6()
        {
            return View(Data.Instance.miArbolAvlSerial);
        }
        public ActionResult CreateAvl()
        {
            return View(new ClientModel());
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAvl(IFormCollection collection)
        {
            try
            {
                ClientModel.SaveAVLMode(new ClientModel
                {
                    Id = int.Parse(collection["Id"]),
                    FullName = collection["FullName"],
                    CarColor = collection["CarColor"],
                    CarModel = collection["CarModel"],
                    Email = collection["Email"],
                    SerialNo = collection["SerialNo"],
                });
                return RedirectToAction(nameof(Index4));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateavlId()
        {
            return View(new ClientModel());
        }
        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateavlId(IFormCollection collection)
        {
            try
            {
                int parametro = (int.Parse(collection["Id"]));

                return View(Data.Instance.miArbolAvlId.Buscar(Comparison.Comparison.CompararID(parametro)));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateavlSerial()
        {
            return View(new ClientModel());
        }
        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateavlSerial(IFormCollection collection)
        {
            try
            {
                string parametro = (collection["SerialNo"]);

                return View(Data.Instance.miArbolAvlSerial.Buscar(Comparison.Comparison.CompararSerial(parametro)));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateavlEmail()
        {
            return View(new ClientModel());
        }
        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateavlEmail(IFormCollection collection)
        {
            try
            {
                string parametro = (collection["Email"]);

                return View(Data.Instance.miArbolAvlEmail.Buscar(Comparison.Comparison.CompararEmail(parametro)));
            }
            catch
            {
                return View();
            }
        }


        //menu busqueda
        public ActionResult Create5()
        {
            //formulario para busquedas
            return View(new ClientModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create5(IFormCollection collection)
        {
            try
            {


                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create7()
        {
            //formulario para busquedas
            return View(new ClientModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create7(IFormCollection collection)
        {
            try
            {


                return View();
            }
            catch
            {
                return View();
            }
        }

        //eliminacion 
        //public ActionResult Create6()
        //{
        //    //formulario para busquedas
        //    return View(new ClientModel());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create6(IFormCollection collection)
        //{
        //    try
        //    {
        //        int parametro = (int.Parse(collection["Id"]));

        //        return View(Data.miArbolEmail.BorrarNodo(Comparison.Comparison.CompararID(parametro), Comparison.Comparison.CompararID));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View(new ClientModel());
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ClientModel.Save(new ClientModel
                {
                    Id = int.Parse(collection["Id"]),
                    FullName = collection["FullName"],
                    CarColor = collection["CarColor"],
                    CarModel = collection["CarModel"],
                    Email = collection["Email"],
                    SerialNo = collection["SerialNo"],
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        //leer csv
        [HttpGet]
        public IActionResult Index(BST<ClientModel> clients = null)
        {
            clients = clients == null ? new BST<ClientModel>() : clients;
            return View(Data.Instance.miArbolEmail);
        }

        [HttpPost]
        public IActionResult Index(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            // Upload CSV 
            string fileName = $"{ hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            //

            var clients = this.GetClientList(file.FileName);
            return Index(clients);
        }

        private BST<ClientModel> GetClientList(string fileName)
        {
            BST<ClientModel> client = new BST<ClientModel>(); //modificado aqui tambien 

            // Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var clients = csv.GetRecord<ClientModel>(); //modificado aqui

                    Data.Instance.miArbolEmail.InsertarNodo(clients);
                    Data.Instance.miArbolId.InsertarNodo(clients);
                    Data.Instance.miArbolSerial.InsertarNodo(clients);



                    ////arbol avl

                    //Data.Instance.miArbolAvlEmail.insert(clients);
                    //Data.Instance.miArbolAvlId.insert(clients);
                    //Data.Instance.miArbolAvlSerial.insert(clients);
                }
            }
                return client;

        }
        
        //cargar csv solo para arbol avl
        //leer csv
        [HttpGet]
        public IActionResult Index4(BST<ClientModel> clients = null)
        {
            clients = clients == null ? new BST<ClientModel>() : clients;
            return View(Data.Instance.miArbolAvlEmail);
        }

        [HttpPost]
        public IActionResult Index4(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            // Upload CSV 
            string fileName = $"{ hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            //

            var clients = this.GetClientListAVL(file.FileName);
            return Index4(clients);
        }

        private BST<ClientModel> GetClientListAVL(string fileName)
        {
            BST<ClientModel> client = new BST<ClientModel>(); //modificado aqui tambien 

            // Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var clients = csv.GetRecord<ClientModel>(); //modificado aqui

                    //arbol avl

                    Data.Instance.miArbolAvlEmail.insert(clients);
                    Data.Instance.miArbolAvlId.insert(clients);
                    Data.Instance.miArbolAvlSerial.insert(clients);
                }
            }
            return client;

        }

        // GET: ClientController/Create
        public ActionResult CreateBoth()
        {
            return View(new ClientModel());
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBoth(IFormCollection collection)
        {
            try
            {
                ClientModel.SaveBoth(new ClientModel
                {
                    Id = int.Parse(collection["Id"]),
                    FullName = collection["FullName"],
                    CarColor = collection["CarColor"],
                    CarModel = collection["CarModel"],
                    Email = collection["Email"],
                    SerialNo = collection["SerialNo"],
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //crear en ambos 

        //leer csv
        [HttpGet]
        public IActionResult IndexBoth(BST<ClientModel> clients = null)
        {
            clients = clients == null ? new BST<ClientModel>() : clients;
            return View(Data.Instance.miArbolAvlEmail);
        }

        [HttpPost]
        public IActionResult IndexBoth(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            // Upload CSV 
            string fileName = $"{ hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            //

            var clients = this.GetClientListBoth(file.FileName);
            return IndexBoth(clients);
        }

        private BST<ClientModel> GetClientListBoth(string fileName)
        {
            BST<ClientModel> client = new BST<ClientModel>(); //modificado aqui tambien 

            // Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var clients = csv.GetRecord<ClientModel>(); //modificado aqui

                    //arbol avl

                    Data.Instance.miArbolAvlEmail.insert(clients);
                    Data.Instance.miArbolAvlId.insert(clients);
                    Data.Instance.miArbolAvlSerial.insert(clients);

                    //arbol bst 

                    Data.Instance.miArbolEmail.InsertarNodo(clients);
                    Data.Instance.miArbolId.InsertarNodo(clients);
                    Data.Instance.miArbolSerial.InsertarNodo(clients);
                }
            }
            return client;

        }
    }
}
