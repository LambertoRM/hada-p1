using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{   
    /// <summary>
    /// Esta clase contiene métodos para convertir de sedundos a minutos y viceversa
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Seconds2Minutes is a method in the HadaP1 class.
        /// </summary>
        /// <param name="s">seconds</param>
        /// <returns>Returns minutes.</returns>
        public static double Seconds2Minutes(double s)
        {
            if(s == 0)
            {
                return 0;
            }else
            {
                return s / 60;
            }
        }

        /// <summary>
        /// Minutes2Seconds is a method in the HadaP1 class.
        /// </summary>
        /// <param name="m">minutes</param>
        /// <returns>Returns seconds.</returns>
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
    }
}
