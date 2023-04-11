using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
	internal interface InterfaceConta
	{ 
		void Sacar ( double valor );

		void Depositar ( double valor );
	}
}
