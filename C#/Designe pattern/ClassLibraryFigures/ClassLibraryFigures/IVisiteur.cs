using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
    public interface IVisiteur<T>
    {
        T Visit(Cercle _c);
        T Visit(Rectangle _r);
        T Visit(Figures _f);
    }
}
