using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlightNewsAPI
{
    public class Model:INotifyPropertyChanged
    {
		private String api;

		public string API
		{
			get { return api; }
			set { api = value;
                OnPropertyChanged("API");
            }
		}

		private String description;

        

        public string Description
		{
			get { return description; }
			set { description = value;
                OnPropertyChanged("Description");
            }
		}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
