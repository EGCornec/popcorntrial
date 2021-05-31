using PopcornMVC2.Data;
using PopcornMVC2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopcornMVC2.Business
{
    public class Producto_busi
    {
        /// <param name="model"></param>
        public void Agregar(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Create(model);

        }

        public List<Producto> Listar()
        {
            var db = new BaseDataService<Producto>();
            var lista = db.Get();
            return lista;
        }

        public Producto Get(int id)
        {
            var db = new BaseDataService<Producto>();
            return db.GetById(id);
        }


        public void Eliminar(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Delete(model);
        }
        public void Update(Producto model)
        {
            var db = new BaseDataService<Producto>();
            db.Update(model);
        }
    }
}