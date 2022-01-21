using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Rekenmachine.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public struct Calculation
        {
            public int A { get; set; }
            public int B { get; set; }
            public int Result { get; set; }
        }
        private int a;
        private int b;
        private int answer;

        public CalculatorViewModel()
        {
            AddCommand = new RelayCommand(o => Add());
        }
        public int Answer
        {
            get { return answer; }
            set { 
                answer = value;
                OnPropertyChanged();
            }
        }
        public int B
        {
            get { return b; }
            set { 
                b = value;
                OnPropertyChanged();
            }
        }
        public int A
        {
            get { return a; }
            set { 
                a = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Calculation> History { get; } = new ObservableCollection<Calculation>();
        public ICommand AddCommand { get; }

        private void Add()
        {
            Answer = A + B;
            History.Add(new Calculation { A = A, B = B, Result = Answer });
        }

        private void OnPropertyChanged([CallerMemberName]string property="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
