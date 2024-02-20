using CorredoresF1App_MCLG.Model;
using MvvmGuia.VistaModelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CorredoresF1App_MCLG.ViewModel
{
	public class VMcorredor : BaseViewModel
	{
		#region VARIABLES
		string _Id;
		string _Nombre;
		string _Equipo;
		int _Numero;

		#endregion
		#region CONSTRUCTOR
		public VMcorredor(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		#region OBJETOS
		public string Id
		{
			get { return _Id; }
			set { SetValue(ref _Id, value); }
		}
		public string Nombre
		{
			get { return _Nombre; }
			set { SetValue(ref _Nombre, value); }
		}
		public string Equipo
		{
			get { return _Equipo; }
			set { SetValue(ref _Equipo, value); }
		}
		public int Numero
		{
			get { return _Numero; }
			set { SetValue(ref _Numero, value); }
		}
		#endregion
		#region PROCESOS
		public async Task Insertar()
		{
			Mcorredor mcorredor = new Mcorredor
			{
				Name = Nombre,
				Number = Numero,
				Team = Equipo
			};
			Uri RequestUri = new
				Uri("http://www.corredoresf1api.somee.com/api/drivers");
			var client = new HttpClient();
			var json = JsonConvert.SerializeObject(mcorredor);
			var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync(RequestUri, contentJson);

			if(response.StatusCode == HttpStatusCode.Created)
			{
				await DisplayAlert("Mensaje", "Resgistrado", "ok");
			}
			else
			{
				await DisplayAlert("Mensaje", "No resgistrado", "ok");
			}
		}
		public void ProcesoSimple()
		{

		}
		#endregion
		#region COMANDOS
		public ICommand InsertarCorredor => new Command(async () => await Insertar());
		public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
		#endregion
	}
}

