using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.InterfacesRepositorios
{
    public interface IRepositorio<T>
    {
        void Add(T item); //Alta
        void Update(T item);  //Modificar
        void Delete(int id); //Eliminar
        IEnumerable<T> FindAll(); //Obtener todos
        T FindById(int? id); //Buscar por identificador

    }
}
