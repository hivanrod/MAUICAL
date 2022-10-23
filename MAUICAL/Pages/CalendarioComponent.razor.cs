using MAUICAL.Services;
using Microsoft.AspNetCore.Components;

namespace MAUICAL.Pages
{
    // TODO : 02/Ene/2022 2.19pm : Hacer las otras partes de CRUD de calendario

    public class CalendarioComponentBase : ComponentBase
    {
        [Inject]
        public CitasServices citasServices { get; set; }
        [Parameter]
        public DateTime fechahoy { get; set; } = DateTime.Now;
        public DateTime hoy = DateTime.Now;
        [Parameter]
        public Int16 dianumero { get; set; }
            
        //[Parameter]
      //  public string dianombre { get; set; } = fechahoy.ToShortTimeString();
        [Parameter]
        public Int16 semana { get; set; } = 0;
        [Parameter]
        public Int16 mes { get; set; } = 0;
        [Parameter]
        public Int16 ano { get; set; } = 0;

        //dianumero = 1; //(0Int16)(DateTime hoy). 

    }
}
