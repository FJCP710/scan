using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace scan.Models
{
    public class ListViewModel
    {
        private MedicinasModel _selectedMedicinas { get; set; }
        public MedicinasModel SelectedMedicinas
        {
            get { return _selectedMedicinas; }
            set
            {
                if( _selectedMedicinas != value)
                {
                    _selectedMedicinas = value;
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            Page page = new Page();
            var respuesta = page.DisplayAlert("Info","¿Quiere ver el prospecto?","Aceptar","Cancelar").Result;

            if(respuesta == true)
            {

            }
        }

    }
}
