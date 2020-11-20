using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTemp
{
    public class Temperature
    {

        private float tempe;
        private float[] tempreratureDAlert;

        public float Tempe { get => tempe; set => tempe = value; }

        public delegate void DelTemp();
        public event DelTemp ChangementTemp;
        /// <summary>
        /// evenement qui se produit quand risque de gel 0
        /// evenement qui se produit quand a de la fievre 38
        /// </summary>


        public Temperature()
        {
            this.Tempe= 10f;
        }


        public void Monter()
        {
            Tempe++;
            if (Tempe == 38)
                ChangementTemp();
        }


        public void Diminuer()
        {
            Tempe--;
            if (Tempe == 0)
                ChangementTemp();
        }



    }
}
