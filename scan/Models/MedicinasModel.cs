using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;

namespace scan.Models
{
    public class MedicinasModel
    {
        [PrimaryKey]
        public string id { get; set; }
        public string nombre { get; set; }
        public string prospecto { get; set; }
        public ObservableCollection<MedicinasModel> Medicinas { get; }
        
        public MedicinasModel()
        {
            Medicinas = new ObservableCollection<MedicinasModel>()
            {
                new MedicinasModel(){id = "8470007111863", nombre = "Almax", prospecto = "https://www.vademecum.es/medicamento-almax_prospecto-147"},
                new MedicinasModel(){id = "01084700099433561019013172205312178WAEDDA8S", nombre = "Zamene", prospecto = "https://www.vademecum.es/medicamento-zamene_prospecto-4344"},
                new MedicinasModel(){id = "010847000698682021NW6XZ6ECGFVPP41721103110N535", nombre = "Paracetamol ABAMED", prospecto = "https://www.vademecum.es/medicamento-paracetamol+abamed_prospecto-42201"},
                new MedicinasModel(){id = "01084700075534891722111210BR395221HG7A4MH27", nombre = "Naproxeno Sódico Cinfa", prospecto = "https://www.vademecum.es/medicamento-naproxeno+sodico+cinfa_prospecto-27621"},
                new MedicinasModel(){id = "0108470008404889212009999616213610103794617231031", nombre = "Tryptizol", prospecto = "https://www.vademecum.es/medicamento-tryptizol_4074"},
                new MedicinasModel(){id = "8470007183952", nombre = "Biodramina Cafeína", prospecto = "https://www.vademecum.es/medicamento-biodramina+cafeina_prospecto-18364"},
                new MedicinasModel(){id = "0108470006614082215RYYYV8DG71722013110E202182", nombre = "Fortecortín 4mg", prospecto = "https://www.vademecum.es/medicamento-fortecortin_prospecto-32689"},
                new MedicinasModel(){id = "01084700065670671721093010TR8N215F4VKC1KAB", nombre = "Ventolín 100", prospecto = "https://www.vademecum.es/medicamento-ventolin_prospecto-4211"},
                new MedicinasModel(){id = "8470007290612", nombre = "Nolotil 0,4", prospecto = "https://www.vademecum.es/medicamento-nolotil_prospecto-2811"},
                new MedicinasModel(){id = "010847000989137421911996304452261723113010KK832", nombre = "Sirdalud 2", prospecto = "https://www.vademecum.es/medicamento-sirdalud_prospecto-5250"}
            };
        }

    }
    
}
