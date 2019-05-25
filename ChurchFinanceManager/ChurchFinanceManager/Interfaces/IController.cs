using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    interface IController<T> where T : class
    {
        List<T> ShowAll(params Param[] parameters);
        T Show(int id);
        void Add(params Param[] @params);
        T Update(int id, params Param[] @params);
        void Delete(int id);
    }
}
