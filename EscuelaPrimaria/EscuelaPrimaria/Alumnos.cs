using System;
using Gtk;
using MySql.Data.MySqlClient;
using Pango;

namespace EscuelaPrimaria
{
	public partial class Alumnos : Gtk.Window
	{
		private MainWindow padre;
		public Alumnos (MainWindow padre, string id) : 
			base (Gtk.WindowType.Toplevel)
		{
			this.padre = padre;
			this.Build ();
			this.Cargar (id);
			this.Materias(id);
			this.Cursos (id);
			this.Pagos (id);
			this.Grado (id);
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			MainWindow win = new MainWindow ();
			win.Visible = true;
		}

		protected MySqlConnection myConnection;
		protected void abrirConexion ()
		{
			string connectionString =
				"Server=localhost;" +
				"Database=SistemaEscolar;" +
				"User ID=root;" +
				"Password=;" +
				"Pooling=false;";
			this.myConnection = new MySqlConnection (connectionString);
			this.myConnection.Open ();
		}

		protected void cerrarConexion ()
		{
			this.myConnection.Close (); 
			this.myConnection = null;
		}

		private int ejecutarComando (string sql)
		{
			MySqlCommand myCommand = new MySqlCommand (sql, this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery ();
			myCommand.Dispose ();
			myCommand = null;
			return afectadas;
		}

		public void Cargar (string id)
		{
			this.abrirConexion ();
			MySqlCommand myCommand = new MySqlCommand ("SELECT * FROM `Estudiante` WHERE (`id`='" + id + "')", 
				                         myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader ();	
			while (myReader.Read ()) {
				string codigo = myReader ["codigo"].ToString ();
				string nombre = myReader ["nombre"].ToString ();
				string apellidoP = myReader ["apellidoP"].ToString ();
				string apellidoM = myReader ["apellidoM"].ToString ();
				string calle = myReader ["calle"].ToString ();
				string numero = myReader ["numero"].ToString ();
				string numeroInt = myReader ["numeroInt"].ToString ();
				string ciudad = myReader ["ciudad"].ToString ();
				string colonia = myReader ["colonia"].ToString ();
				string telefono = myReader ["telefono"].ToString ();
				string avisarA = myReader ["avisarA"].ToString ();
				string telEm = myReader ["telEm"].ToString ();
				codTxt.Text = codigo.ToString ();
				nomTxt.Text = nombre.ToString ();
				paternoTxt.Text = apellidoP.ToString ();
				maternoTxt.Text = apellidoM.ToString ();
				calleTxt.Text = calle.ToString ();
				numExtTxt.Text = numero.ToString ();
				numIntTex.Text = numeroInt.ToString ();
				ciudadText.Text = ciudad.ToString ();
				colTxt.Text = colonia.ToString ();
				telTxt.Text = telefono.ToString ();
				aviTxt.Text = avisarA.ToString ();
				telEmTxt.Text = telEm.ToString ();
				this.Title = "Bienvenido " + nombre.ToString ()
				+ " " + apellidoP.ToString () + " " + apellidoM.ToString ();
				labelNombre.Text = "Bienvenido " + nombre.ToString ()
				+ " " + apellidoP.ToString () + " " + apellidoM.ToString ();
				labelNombre.ModifyFont (FontDescription.FromString ("Arial Bold 12"));
			}

			myReader.Close ();
			myReader = null;
			myCommand.Dispose ();
			myCommand = null;
			this.cerrarConexion ();
		}

		public void Grado (string id)
		{
			this.abrirConexion ();
			MySqlCommand myCommand = new MySqlCommand ("SELECT * FROM `Grado` WHERE (`id_Maestro`='" + id + "_Estudiante')", 
				myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader ();	
			while (myReader.Read ()) {
				string numGrado = myReader ["numGrado"].ToString ();
				string aula = myReader ["aula"].ToString ();
				string edificio = myReader ["edificio"].ToString ();
				gradoText.Text = "Grado: " + numGrado.ToString ()
				                 + " Aula: " + aula.ToString () + " Edificio: " + edificio.ToString ();
				gradoText.ModifyFont (FontDescription.FromString ("Arial Bold 10"));
			}

			myReader.Close ();
			myReader = null;
			myCommand.Dispose ();
			myCommand = null;
			this.cerrarConexion ();
		}

		private void Materias(string id){
			ListStore TipoDeListado;
			TipoDeListado = new ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
			nodeMateria.Model = TipoDeListado;

			this.abrirConexion();
			MySqlCommand myCommand = new MySqlCommand(
				"SELECT * FROM `Materia` WHERE (`id_Estudiante`='" + id + "_Estudiante')", myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();	
			while (myReader.Read()){
				string codigo = myReader["codigo"].ToString();
				string nombre = myReader["nombre"].ToString();
				string area = myReader["area"].ToString();
				string horas = myReader["horas"].ToString();
				string calificacion = myReader["calificacion"].ToString();
				string faltas = myReader["faltas"].ToString();
				TipoDeListado.AppendValues(codigo, nombre, area, horas, calificacion, faltas);
			}

			myReader.Close();
			myReader = null;
			myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();

			nodeMateria.AppendColumn("Código", new CellRendererText(), "text", 0);
			nodeMateria.AppendColumn("Nombre", new CellRendererText(), "text", 1); 
			nodeMateria.AppendColumn("Area", new CellRendererText(), "text", 2);
			nodeMateria.AppendColumn("Horas", new CellRendererText(), "text", 3); 
			nodeMateria.AppendColumn("Calificacion", new CellRendererText(), "text", 4);
			nodeMateria.AppendColumn("Faltas", new CellRendererText(), "text", 5);
			nodeMateria.EnableGridLines = TreeViewGridLines.Horizontal;
		}
		private void Cursos(string id){
			ListStore TipoDeListado;
			TipoDeListado = new ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
			nodeCursos.Model = TipoDeListado;

			this.abrirConexion();
			MySqlCommand myCommand = new MySqlCommand(
				"SELECT * FROM `Cursos` WHERE (`id_Estudiante`='" + id + "_Estudiante')", myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();	
			while (myReader.Read()){
				string codigo = myReader["codigo"].ToString();
				string nombre = myReader["nombre"].ToString();
				string area = myReader["area"].ToString();
				string horas = myReader["horas"].ToString();
				string acreditacion = myReader["acreditacion"].ToString();
				string faltas = myReader["faltas"].ToString();
				TipoDeListado.AppendValues(nombre, codigo, horas, area, acreditacion, faltas);
			}

			myReader.Close();
			myReader = null;
			myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();

			nodeCursos.AppendColumn("Código", new CellRendererText(), "text", 0);
			nodeCursos.AppendColumn("Nombre", new CellRendererText(), "text", 1); 
			nodeCursos.AppendColumn("Area", new CellRendererText(), "text", 2);
			nodeCursos.AppendColumn("Horas", new CellRendererText(), "text", 3); 
			nodeCursos.AppendColumn("Acreditacion", new CellRendererText(), "text", 4);
			nodeCursos.AppendColumn("Faltas", new CellRendererText(), "text", 5);
			nodeCursos.EnableGridLines = TreeViewGridLines.Horizontal;
		}
		private void Pagos(string id){
			ListStore TipoDeListado;
			TipoDeListado = new ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
			nodePagos.Model = TipoDeListado;

			this.abrirConexion();
			MySqlCommand myCommand = new MySqlCommand(
				"SELECT * FROM `Pagos` WHERE (`id_Estudiante`='" + id + "_Estudiante')", myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();	
			while (myReader.Read()){
				string codigo = myReader["codigo"].ToString();
				string fecha = myReader["fecha"].ToString();
				string tipopago = myReader["tipopago"].ToString();
				string importe = myReader["importe"].ToString();
				string observaciones = myReader["observaciones"].ToString();
				TipoDeListado.AppendValues(codigo, fecha, tipopago, importe, observaciones);
			}

			myReader.Close();
			myReader = null;
			myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();

			nodePagos.AppendColumn("Código", new CellRendererText(), "text", 0);
			nodePagos.AppendColumn("Fecha", new CellRendererText(), "text", 1);
			nodePagos.AppendColumn("Tipo de pago", new CellRendererText(), "text", 2); 
			nodePagos.AppendColumn("Importe", new CellRendererText(), "text", 3);
			nodePagos.AppendColumn("Observaciones", new CellRendererText(), "text", 4); 
			nodePagos.EnableGridLines = TreeViewGridLines.Horizontal;
		}
	}
}

