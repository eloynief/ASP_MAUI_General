using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionGeneral_MAUI.Models.ViewModels
{
    internal class PersonaVM
    {

        private List<ClsPersona> personas;


        private ClsPersona personaSeleccionada;
        

        public event PropertyChangedEventHandler? PropertyChanged;

        public ClsPersona PersonaSeleccionada
        {
            get => personaSeleccionada;
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ClsPersona> Personas
        {
            get {  return BL.ClaseListadosBL.listadoPersonasBL(); } 
        }

        public PersonaVM() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
