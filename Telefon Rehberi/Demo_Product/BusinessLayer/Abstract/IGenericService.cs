using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        // Business tarafımız kontrollerin yapıldığı kısım olacak
        // Ürün adı girerken 20 karakteri geçmesin gibi
        // Burada Entity'lerimiz için Business Katmanında Generic Servis yazmış olduk.
        void TInsert (T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> TGetList();
        T TGetById(int id);
        T TGetByName(string name);
    }
}
