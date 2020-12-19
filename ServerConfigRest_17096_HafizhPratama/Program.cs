using ServiceRest_17096_HafizhPratama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigRest_17096_HafizhPratama
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost hostObjek = null;

			try
			{
				hostObjek = new ServiceHost(typeof(TI_UMY));
				hostObjek.Open();
				Console.WriteLine("Server ready..");
				Console.ReadLine();
				hostObjek.Close();
			}
			catch (Exception ex)
			{
				hostObjek = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
	}
}
