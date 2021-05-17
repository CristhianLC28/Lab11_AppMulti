using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class OperationsViewModel : ViewModelBase
    {
        #region Propiedades
        int valor1;

        public int Valor1
        {
            get { return valor1; }
            set
            {
                if(valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }

        }
        int valor2;

        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }

        }

        int suma;

        public int ResultSuma
        {
            get { return suma; }
            set
            {
                if(suma !=value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resta;

        public int ResultResta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }

        int multi;

        public int ResultMulti
        {
            get { return multi; }
            set
            {
                if (multi != value)
                {
                    multi = value;
                    OnPropertyChanged();
                }
            }
        }

        int divi;

        public int ResultDivi
        {
            get { return divi; }
            set
            {
                if (divi != value)
                {
                    divi = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Comandos

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multi { protected set; get; }
        public ICommand Divi { protected set; get; }
        #endregion

        #region Construstor
        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = valor1 + valor2;
            });

            Restar = new Command(() =>
            {
                ResultResta = valor1 - valor2;
            });

            Multi = new Command(() =>
            {
                ResultMulti = valor1 * valor2;
            });

            Divi = new Command(() =>
            {
                ResultDivi = valor1 / valor2;
            });
        }

        #endregion
    }
}
