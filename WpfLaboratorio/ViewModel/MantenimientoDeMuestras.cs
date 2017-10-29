using Interfaces.Dto;
using Interfaces.Interfaces;
using RegistrarMuestras;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfLaboratorio.ViewModel
{
    public class MantenimientoDeMuestras : INotifyPropertyChanged
    {
        private MuestrasDto _muestrasDto = new MuestrasDto();
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<MuestrasDto> MuestrasResgistradas { get; set; }
        private IRegistraMuestra _registrarMuestras = new RegistraMuestra();

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public MuestrasDto muestraDto
        {
            get { return _muestrasDto; }
            set
            {
                this._muestrasDto = value;
                this.OnPropertyChanged("muestraDto");
            }
        }


        public void CargarMuestra()
        {
            this.MuestrasResgistradas = new ObservableCollection<MuestrasDto>();
            _registrarMuestras.ListarMuestras().ForEach(x => this.MuestrasResgistradas.Add(x));
        }

        public void RegistrarMuestra()
        {
            MuestrasDto nuevaMuestra = this._registrarMuestras.RegistrarMuestra(this.muestraDto);
            this.MuestrasResgistradas.Add(nuevaMuestra);
            this.muestraDto = new MuestrasDto();
        }

        public void ActualizarMuestra()
        {
            this._registrarMuestras.ActualizarMuestra(this.muestraDto);
            this.muestraDto = new MuestrasDto();
            
        }

        public void EliminarMuestra()
        {
            this._registrarMuestras.EliminarMuestra(this.muestraDto);
            this.muestraDto = new MuestrasDto();
        }
    }
}
