using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ohb.Core
{

	class ObservableObject : INotifyPropertyChanged

	{
public event PropertyChangedEventHandler PropertyChanged;

protected void OnPropertyChanged([CallerMemberName] string name = null)
		
		{
            if (PropertyChanged != null)
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		} 


	}

}

