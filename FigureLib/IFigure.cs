using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib
{
    /// <summary>
    /// интерфейс фигуры
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// возвращает площать фигуры
        /// </summary>
        /// <returns></returns>
        double GetSquare();
    }
}
