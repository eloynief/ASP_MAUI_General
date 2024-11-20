using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiGestionGeneralMAUI.ViewModels
{
    internal class PersonaVM
    {
        private List<ClsPersona> personas;

        //listado de departamentos
        private List<ClsDepartamento> departamentos;

        private ClsPersona personaSeleccionada;


        public event PropertyChangedEventHandler? PropertyChanged;


        public List<ClsDepartamento> Departamentos
        {
            get => departamentos;
            set => departamentos = BL.ClaseListadosBL.listadoDepartamentosBL();

        }


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
            get { return BL.ClaseListadosBL.listadoPersonasBL(); }
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
