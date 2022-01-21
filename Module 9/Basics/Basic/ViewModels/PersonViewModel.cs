using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private int age;
        private string color;

        public string FavoriteColor
        {
            get { return color; }
            set { color = value; }
        }


        public int Age
        {
            get { return age; }
            set { 
                age = value;
                Changed();
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { 
                lastName = value;
                Changed();
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set { 
                firstName = value;
                Changed();
            }
        }

        private void Changed([CallerMemberName]string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
