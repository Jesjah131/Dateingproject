using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebData;
using Web.Models;

namespace Web.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public void GetImg(int id)
        {
            DejtingEntities ent = new DejtingEntities();
            var image = ent.UserInfoes.Where(c => c.ID == id).SingleOrDefault().Img;
                                 
          Response.Buffer = true;

          Response.Clear();

          Response.ContentType = "image/jpg";

          Response.BinaryWrite(image);

          Response.End();
             
           
            
            
            
        }
    }

    
}