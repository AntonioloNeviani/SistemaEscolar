
// This file has been generated by the GUI designer. Do not modify.
namespace EscuelaPrimaria
{
	public partial class Grado
	{
		private global::Gtk.Fixed fixed5;
		private global::Gtk.Image image1;
		private global::Gtk.Image image2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView nodeview1;
		private global::Gtk.Image image6;
		private global::Gtk.Label idLabel;
		private global::Gtk.Entry idTxt;
		private global::Gtk.Label label9;
		private global::Gtk.Label label4;
		private global::Gtk.Entry codTxt;
		private global::Gtk.Entry nomTxt;
		private global::Gtk.Label label10;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView nodeview2;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Entry idTxt2;
		private global::Gtk.Label label5;
		private global::Gtk.Entry codTxt2;
		private global::Gtk.Button cargerAlumno;
		private global::Gtk.Button cargarMaestro;
		private global::Gtk.Label label14;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TreeView nodeGrado;
		private global::Gtk.Entry aulaTxt;
		private global::Gtk.Label label11;
		private global::Gtk.Entry edificioTxt;
		private global::Gtk.Label label12;
		private global::Gtk.Entry gradoTxt;
		private global::Gtk.Label label8;
		private global::Gtk.Button actualizar;
		private global::Gtk.Button agregar;
		private global::Gtk.Button eliminar;
		private global::Gtk.Button cargar;
		private global::Gtk.Button cancelar;
		private global::Gtk.Entry nomTxt2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget EscuelaPrimaria.Grado
			this.Name = "EscuelaPrimaria.Grado";
			this.Title = global::Mono.Unix.Catalog.GetString ("Grado");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			// Container child EscuelaPrimaria.Grado.Gtk.Container+ContainerChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("EscuelaPrimaria.Imagenes.FondoGrado.png");
			this.fixed5.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.image1]));
			w1.X = 3;
			w1.Y = 3;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.image2 = new global::Gtk.Image ();
			this.image2.Name = "image2";
			this.image2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("EscuelaPrimaria.Imagenes.GradoGrupo.png");
			this.fixed5.Add (this.image2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.image2]));
			w2.X = 7;
			w2.Y = 4;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.TreeView ();
			this.nodeview1.WidthRequest = 251;
			this.nodeview1.HeightRequest = 126;
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.GtkScrolledWindow.Add (this.nodeview1);
			this.fixed5.Add (this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.GtkScrolledWindow]));
			w4.X = 13;
			w4.Y = 101;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.image6 = new global::Gtk.Image ();
			this.image6.Name = "image6";
			this.image6.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("EscuelaPrimaria.Imagenes.EscuelaPrimaria3.png");
			this.fixed5.Add (this.image6);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.image6]));
			w5.X = 554;
			w5.Y = 4;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.idLabel = new global::Gtk.Label ();
			this.idLabel.Name = "idLabel";
			this.idLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("ID:");
			this.fixed5.Add (this.idLabel);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.idLabel]));
			w6.X = 316;
			w6.Y = 115;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.idTxt = new global::Gtk.Entry ();
			this.idTxt.WidthRequest = 35;
			this.idTxt.CanFocus = true;
			this.idTxt.Name = "idTxt";
			this.idTxt.IsEditable = false;
			this.idTxt.InvisibleChar = '●';
			this.fixed5.Add (this.idTxt);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.idTxt]));
			w7.X = 336;
			w7.Y = 112;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Código Estudiante:");
			this.fixed5.Add (this.label9);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label9]));
			w8.X = 376;
			w8.Y = 115;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Datos Del Estudiante");
			this.fixed5.Add (this.label4);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label4]));
			w9.X = 425;
			w9.Y = 84;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.codTxt = new global::Gtk.Entry ();
			this.codTxt.WidthRequest = 154;
			this.codTxt.CanFocus = true;
			this.codTxt.Name = "codTxt";
			this.codTxt.IsEditable = false;
			this.codTxt.InvisibleChar = '●';
			this.fixed5.Add (this.codTxt);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.codTxt]));
			w10.X = 488;
			w10.Y = 110;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.nomTxt = new global::Gtk.Entry ();
			this.nomTxt.WidthRequest = 192;
			this.nomTxt.CanFocus = true;
			this.nomTxt.Name = "nomTxt";
			this.nomTxt.IsEditable = false;
			this.nomTxt.InvisibleChar = '●';
			this.fixed5.Add (this.nomTxt);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.nomTxt]));
			w11.X = 451;
			w11.Y = 146;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre del Estudiante:");
			this.fixed5.Add (this.label10);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label10]));
			w12.X = 313;
			w12.Y = 150;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Maestro de asignatura");
			this.fixed5.Add (this.label2);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label2]));
			w13.X = 417;
			w13.Y = 185;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("ID:");
			this.fixed5.Add (this.label3);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label3]));
			w14.X = 317;
			w14.Y = 217;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.nodeview2 = new global::Gtk.TreeView ();
			this.nodeview2.WidthRequest = 251;
			this.nodeview2.HeightRequest = 126;
			this.nodeview2.CanFocus = true;
			this.nodeview2.Name = "nodeview2";
			this.GtkScrolledWindow1.Add (this.nodeview2);
			this.fixed5.Add (this.GtkScrolledWindow1);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.GtkScrolledWindow1]));
			w16.X = 14;
			w16.Y = 272;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre del Maestro:");
			this.fixed5.Add (this.label6);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label6]));
			w17.X = 307;
			w17.Y = 254;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Especifique el Nueva Grado");
			this.fixed5.Add (this.label7);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label7]));
			w18.X = 375;
			w18.Y = 291;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.idTxt2 = new global::Gtk.Entry ();
			this.idTxt2.WidthRequest = 35;
			this.idTxt2.CanFocus = true;
			this.idTxt2.Name = "idTxt2";
			this.idTxt2.IsEditable = false;
			this.idTxt2.InvisibleChar = '●';
			this.fixed5.Add (this.idTxt2);
			global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.idTxt2]));
			w19.X = 337;
			w19.Y = 213;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Código Maestro:");
			this.fixed5.Add (this.label5);
			global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label5]));
			w20.X = 380;
			w20.Y = 217;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.codTxt2 = new global::Gtk.Entry ();
			this.codTxt2.WidthRequest = 166;
			this.codTxt2.CanFocus = true;
			this.codTxt2.Name = "codTxt2";
			this.codTxt2.IsEditable = false;
			this.codTxt2.InvisibleChar = '●';
			this.fixed5.Add (this.codTxt2);
			global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.codTxt2]));
			w21.X = 478;
			w21.Y = 211;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.cargerAlumno = new global::Gtk.Button ();
			this.cargerAlumno.CanFocus = true;
			this.cargerAlumno.Name = "cargerAlumno";
			this.cargerAlumno.UseUnderline = true;
			this.cargerAlumno.Label = global::Mono.Unix.Catalog.GetString ("Cargar Estudiante");
			this.fixed5.Add (this.cargerAlumno);
			global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.cargerAlumno]));
			w22.X = 80;
			w22.Y = 234;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.cargarMaestro = new global::Gtk.Button ();
			this.cargarMaestro.CanFocus = true;
			this.cargarMaestro.Name = "cargarMaestro";
			this.cargarMaestro.UseUnderline = true;
			this.cargarMaestro.Label = global::Mono.Unix.Catalog.GetString ("Cargar Maestro");
			this.fixed5.Add (this.cargarMaestro);
			global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.cargarMaestro]));
			w23.X = 86;
			w23.Y = 405;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Grado del Alumno");
			this.fixed5.Add (this.label14);
			global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label14]));
			w24.X = 700;
			w24.Y = 157;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.nodeGrado = new global::Gtk.TreeView ();
			this.nodeGrado.WidthRequest = 138;
			this.nodeGrado.HeightRequest = 177;
			this.nodeGrado.CanFocus = true;
			this.nodeGrado.Name = "nodeGrado";
			this.GtkScrolledWindow2.Add (this.nodeGrado);
			this.fixed5.Add (this.GtkScrolledWindow2);
			global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.GtkScrolledWindow2]));
			w26.X = 682;
			w26.Y = 189;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.aulaTxt = new global::Gtk.Entry ();
			this.aulaTxt.WidthRequest = 50;
			this.aulaTxt.CanFocus = true;
			this.aulaTxt.Name = "aulaTxt";
			this.aulaTxt.IsEditable = true;
			this.aulaTxt.InvisibleChar = '●';
			this.fixed5.Add (this.aulaTxt);
			global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.aulaTxt]));
			w27.X = 472;
			w27.Y = 323;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Edificio:");
			this.fixed5.Add (this.label11);
			global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label11]));
			w28.X = 527;
			w28.Y = 327;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.edificioTxt = new global::Gtk.Entry ();
			this.edificioTxt.WidthRequest = 75;
			this.edificioTxt.CanFocus = true;
			this.edificioTxt.Name = "edificioTxt";
			this.edificioTxt.IsEditable = true;
			this.edificioTxt.InvisibleChar = '●';
			this.fixed5.Add (this.edificioTxt);
			global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.edificioTxt]));
			w29.X = 576;
			w29.Y = 322;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Aula:");
			this.fixed5.Add (this.label12);
			global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label12]));
			w30.X = 439;
			w30.Y = 327;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.gradoTxt = new global::Gtk.Entry ();
			this.gradoTxt.WidthRequest = 50;
			this.gradoTxt.CanFocus = true;
			this.gradoTxt.Name = "gradoTxt";
			this.gradoTxt.IsEditable = true;
			this.gradoTxt.InvisibleChar = '●';
			this.fixed5.Add (this.gradoTxt);
			global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.gradoTxt]));
			w31.X = 386;
			w31.Y = 321;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero Grado:");
			this.fixed5.Add (this.label8);
			global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.label8]));
			w32.X = 296;
			w32.Y = 325;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.actualizar = new global::Gtk.Button ();
			this.actualizar.CanFocus = true;
			this.actualizar.Name = "actualizar";
			this.actualizar.UseUnderline = true;
			this.actualizar.Label = global::Mono.Unix.Catalog.GetString ("Actualizar Grado");
			this.fixed5.Add (this.actualizar);
			global::Gtk.Fixed.FixedChild w33 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.actualizar]));
			w33.X = 501;
			w33.Y = 371;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.agregar = new global::Gtk.Button ();
			this.agregar.CanFocus = true;
			this.agregar.Name = "agregar";
			this.agregar.UseUnderline = true;
			this.agregar.Label = global::Mono.Unix.Catalog.GetString ("Agregar Nueva Grado");
			this.fixed5.Add (this.agregar);
			global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.agregar]));
			w34.X = 353;
			w34.Y = 372;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.eliminar = new global::Gtk.Button ();
			this.eliminar.CanFocus = true;
			this.eliminar.Name = "eliminar";
			this.eliminar.UseUnderline = true;
			this.eliminar.Label = global::Mono.Unix.Catalog.GetString ("Eliminar");
			this.fixed5.Add (this.eliminar);
			global::Gtk.Fixed.FixedChild w35 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.eliminar]));
			w35.X = 749;
			w35.Y = 382;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.cargar = new global::Gtk.Button ();
			this.cargar.CanFocus = true;
			this.cargar.Name = "cargar";
			this.cargar.UseUnderline = true;
			this.cargar.Label = global::Mono.Unix.Catalog.GetString ("Cargar");
			this.fixed5.Add (this.cargar);
			global::Gtk.Fixed.FixedChild w36 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.cargar]));
			w36.X = 693;
			w36.Y = 381;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.cancelar = new global::Gtk.Button ();
			this.cancelar.WidthRequest = 131;
			this.cancelar.CanFocus = true;
			this.cancelar.Name = "cancelar";
			this.cancelar.UseUnderline = true;
			this.cancelar.Label = global::Mono.Unix.Catalog.GetString ("Cancelar");
			this.fixed5.Add (this.cancelar);
			global::Gtk.Fixed.FixedChild w37 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.cancelar]));
			w37.X = 683;
			w37.Y = 449;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.nomTxt2 = new global::Gtk.Entry ();
			this.nomTxt2.WidthRequest = 212;
			this.nomTxt2.CanFocus = true;
			this.nomTxt2.Name = "nomTxt2";
			this.nomTxt2.IsEditable = false;
			this.nomTxt2.InvisibleChar = '●';
			this.fixed5.Add (this.nomTxt2);
			global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.nomTxt2]));
			w38.X = 433;
			w38.Y = 246;
			this.Add (this.fixed5);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 870;
			this.DefaultHeight = 544;
			this.Show ();
			this.cargerAlumno.Clicked += new global::System.EventHandler (this.OnCargerAlumnoClicked);
			this.cargarMaestro.Clicked += new global::System.EventHandler (this.OnCargarMaestroClicked);
			this.actualizar.Clicked += new global::System.EventHandler (this.OnActualizarClicked);
			this.agregar.Clicked += new global::System.EventHandler (this.OnAgregarClicked);
			this.eliminar.Clicked += new global::System.EventHandler (this.OnEliminarClicked);
			this.cargar.Clicked += new global::System.EventHandler (this.OnCargarClicked);
			this.cancelar.Clicked += new global::System.EventHandler (this.OnCancelarClicked);
		}
	}
}
